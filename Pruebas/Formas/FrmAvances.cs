using Entidades.Usuario;
using LogicaNegocio.Usuario;
using System;
using System.Windows.Forms;

namespace Pruebas.Formas
{
    public partial class FrmAvances : Form
    {
        #region Variables privadas
        private ClsAvance ObjAvance = null;
        private ClsLoteo ObjLoteo = null;
        private ClsAvances ObjAvances = null;
        private ClsRUsuarioAvance ObjRUsuarioAvance = null;
        readonly private ClsAvanceLn ObjAvanceLn = new ClsAvanceLn();
        readonly private ClsLoteoLn ObjLoteoLn = new ClsLoteoLn();
        readonly private ClsAvancesLn ObjAvancesLn = new ClsAvancesLn();
        readonly private ClsRUsuarioAvanceLn ObjRUsuarioAvanceLn = new ClsRUsuarioAvanceLn();

        private int userId;
        #endregion

        #region Metodos Constructores
        public FrmAvances()
        {
            InitializeComponent();
        }

        public FrmAvances(int id)
        {
            InitializeComponent();
            userId = id;
            CargarDatos();
        }
        #endregion

        #region Metodos Privados
        private void Limpiar()
        {
            TxtCodigo.Clear();
            TxtCodigo.Focus();
            LblCorrecto.Visible = false;
            LblIncorrecto.Visible = false;
        }

        private void LimpiarCorrecto()
        {
            LblCorrecto.Visible = true;
            LblIncorrecto.Visible = false;
            TxtCodigo.Clear();
            TxtCodigo.Focus();
            CargarDatos();
        }

        private void LimpiarIncorrecto()
        {
            TxtCodigo.Clear();
            TxtCodigo.Focus();
            LblIncorrecto.Visible = true;
            LblCorrecto.Visible = false;
        }

        private void CargarDatos()
        {
            ObjAvances = new ClsAvances()
            {
                UCodigo = TxtBCodigo.Text,
                Usuario = TxtBUsuario.Text,
                Estilo = TxtBEstilo.Text,
                Color = TxtBColor.Text
            };
            if (TxtBArea.Text == string.Empty)
            {
                ObjAvances.Area = null;
            }
            else
            {
                ObjAvances.Area = Convert.ToChar(TxtBArea.Text);
            }

            ObjAvancesLn.Index(ref ObjAvances);
            if (ObjAvances.MsjError == null)
            {
                DgvAvances.DataSource = ObjAvances.DtResultados;
            }
        }

        private void CrearAvance(string cod, int userId, float avanceId, DateTime time)
        {
            ObjAvances = new ClsAvances()
            {
                UCodigo = cod,
                UUserId = userId,
                UAvanceId = avanceId,
                FAvance = DateTime.Now,
                Tiempo = (DateTime.Now - time).ToString(@"dd\d\ hh\h\ mm\m\ ")
            };
            ObjAvancesLn.Create(ref ObjAvances);
            if (ObjAvances.MsjError == null)
            {
                LimpiarCorrecto();
            }
            else
            {
                MessageBox.Show(ObjAvances.MsjError, "Mensaje de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Acción con Botones
        private void BtnCerrar_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void BtnLimpiar_Click(object sender, System.EventArgs e)
        {
            Limpiar();
        }
        #endregion

        #region Acción con TextBox
        private void TxtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                float ultimoAvance = 0f, siguienteAvance = 0f;
                int cantAvances = 0, cont = 0;
                string avance = string.Empty;

                //Lectura de información de el lote escaneado
                ObjLoteo = new ClsLoteo()
                {
                    CodLote = TxtCodigo.Text
                };
                ObjLoteoLn.Read(ref ObjLoteo);

                //Lectura de la lista de Avances que se pueden generar con el lote escaneado
                ObjAvance = new ClsAvance()
                {
                    Area = ObjLoteo.Area[0]
                };
                ObjAvanceLn.IndexArea(ref ObjAvance);

                //Lectura de la lista de avances que puede dar el usuario que escanea
                ObjRUsuarioAvance = new ClsRUsuarioAvance()
                {
                    UserId = userId,
                    Area = ObjLoteo.Area[0]
                };
                ObjRUsuarioAvanceLn.IndexId(ref ObjRUsuarioAvance);

                //Lectura en la base para saber si esta el avance generado en sistema
                ObjAvances = new ClsAvances()
                {
                    UCodigo = TxtCodigo.Text
                };
                ObjAvancesLn.ReadSeguir(ref ObjAvances);

                //Validar que el usuario este permitido para dar avances en sistema
                if (ObjRUsuarioAvance.DtResultados != null)
                {
                    if (ObjAvances.MsjError == null)
                    {
                        //Si el lote no tiene ningun avance en sistema
                        if (ObjAvances.DtResultados.Rows.Count == 0)
                        {
                            //Validar que sea un usuario permitido para dar el primer avance
                            if (Convert.ToSingle(ObjAvance.DtResultados.Rows[0]["Id"].ToString()) == Convert.ToSingle(ObjRUsuarioAvance.DtResultados.Rows[0]["AvanceId"].ToString()))
                            {
                                CrearAvance(TxtCodigo.Text, userId, Convert.ToSingle(ObjAvance.DtResultados.Rows[0]["Id"].ToString()),
                                    Convert.ToDateTime(ObjLoteo.FLote.ToString()));
                                LimpiarCorrecto();
                            }
                            else
                            {
                                LblIncorrecto.Text = "Tu no puedes generar el primer avance";
                                LimpiarIncorrecto();
                            }
                        }
                        //Si el lote ya tiene avances en sistema
                        else
                        {
                            //Se obtiene la cantidad de avances que puede dar el usuario
                            cantAvances = ObjRUsuarioAvance.DtResultados.Rows.Count;

                            //Obtener el ultimo avance para verificar si el que se esta dando es el que sigue
                            ultimoAvance = Convert.ToSingle(ObjAvances.DtResultados.Rows[ObjAvances.DtResultados.Rows.Count - 1]["UAvanceId"].ToString());

                            //Lectura de cuantos avances a generado el usuario por codigo
                            ObjAvances = new ClsAvances()
                            {
                                UUserId = userId,
                                UCodigo = TxtCodigo.Text
                            };
                            ObjAvancesLn.ReadUserCod(ref ObjAvances);

                            //Obtener cuantos avances a realizado el usuario por codigo
                            cont = ObjAvances.DtResultados.Rows.Count;

                            //Validar que el avance no se este generando de forma repetida
                            if (cantAvances == cont)
                            {
                                LblIncorrecto.Text = "No se puede repetir un avance. Favor de revisar";
                                LimpiarIncorrecto();
                            }

                            //Validar que el avance que se esta dando sea la continuidad del ultimo avance que se dio, sino para negar su avance
                            else if (ultimoAvance == Convert.ToSingle(ObjAvance.DtResultados.Rows[ObjAvance.DtResultados.Rows.Count - 1]["Id"].ToString()))
                            {
                                LblIncorrecto.Text = "Ya se generaron todos los avances";
                                LimpiarIncorrecto();
                            }

                            else
                            {
                                //Obtener cual es el avance que sigue
                                for (int i = 0; i < ObjAvance.DtResultados.Rows.Count - 1; i++)
                                {
                                    if (ultimoAvance == Convert.ToSingle(ObjAvance.DtResultados.Rows[i]["Id"].ToString()))
                                    {
                                        siguienteAvance = Convert.ToSingle(ObjAvance.DtResultados.Rows[i + 1]["Id"].ToString());
                                        avance = ObjAvance.DtResultados.Rows[i + 1]["Avance"].ToString();
                                        break;
                                    }
                                }

                                //Lectura en la base para saber si esta el avance generado en sistema ya que se pierde esta tabla al generar otro objeto de la misma
                                //para obtener los avances por usuario
                                ObjAvances = new ClsAvances()
                                {
                                    UCodigo = TxtCodigo.Text
                                };
                                ObjAvancesLn.ReadSeguir(ref ObjAvances);

                                //Validar si es la persona indicada para dar el avance correspondiente
                                for (int j = 0; j < ObjAvance.DtResultados.Rows.Count - 1; j++)
                                {
                                    if (siguienteAvance == Convert.ToSingle(ObjRUsuarioAvance.DtResultados.Rows[j]["AvanceId"].ToString()))
                                    {
                                        CrearAvance(TxtCodigo.Text, userId, siguienteAvance,
                                            Convert.ToDateTime(ObjAvances.DtResultados.Rows[ObjAvances.DtResultados.Rows.Count - 1]["FAvance"].ToString()));
                                        LimpiarCorrecto();
                                        break;
                                    }
                                    else
                                    {
                                        LblIncorrecto.Text = "Falta dar el avance de " + avance;
                                        LimpiarIncorrecto();
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show(ObjAvances.MsjError, "Mensaje de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    LblIncorrecto.Text = "No estas registrado para dar avances";
                    LimpiarIncorrecto();
                }
            }
        }
        #endregion
    }
}
