using Entidades.Usuario;
using LogicaNegocio.Usuario;
using Pruebas.Utilidades;
using System;
using System.Windows.Forms;

namespace Pruebas.Formas
{
    public partial class FrmEscaneo : Form
    {
        #region Variables Privadas
        private ClsEscaneo ObjEscaneo = null;
        private ClsTipoEscaneo ObjTipoEscaneo = null;
        private ClsReadDatosEscaneo ObjReadDatosEscaneo = null;
        private readonly ClsEscaneoLn ObjEscaneoLn = new ClsEscaneoLn();
        private readonly ClsTipoEscaneoLn ObjTipoEscaneoLn = new ClsTipoEscaneoLn();
        private readonly ClsUtilidades ObjUtilidades = new ClsUtilidades();
        private readonly ClsReadDatosEscaneoLn ObjReadDatosEscaneoLn = new ClsReadDatosEscaneoLn();

        private readonly FrmEscaneo intance;
        private int nCaja, linea;
        #endregion

        #region Constructores
        public FrmEscaneo()
        {
            InitializeComponent();
            CargarListaEscaneo();
            intance = this;
        }
        #endregion

        #region Metodos Privados
        private void CargarListaEscaneo()
        {
            ObjEscaneo = new ClsEscaneo();
            ObjEscaneoLn.Index(ref ObjEscaneo);
            if (ObjEscaneo.MsjError == null)
            {
                DgvEscaneo.DataSource = ObjEscaneo.DtResultados;
                ObjUtilidades.FormatoDgvEmpleado(ref DgvEscaneo);
            }
            else
            {
                MessageBox.Show(ObjEscaneo.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Metodos Publicos
        public void CargarListaTipoEscaneo()
        {
            ObjTipoEscaneo = new ClsTipoEscaneo();
            ObjTipoEscaneoLn.CargarCbTipoEscaneo(ref ObjTipoEscaneo);
            if (ObjTipoEscaneo.MsjError == null)
            {
                CbTipoEscaneo.DisplayMember = "Nombre";
                CbTipoEscaneo.ValueMember = "TipoId";
                CbTipoEscaneo.DataSource = ObjTipoEscaneo.DtResultados;
                CbTipoEscaneo.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show(ObjTipoEscaneo.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Accion con Botones
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void BtnAbrirEmbarque_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Quieres abrir un embarque?", "Mensaje de sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resultado == DialogResult.OK)
            {
                ObjEscaneo = new ClsEscaneo();
                ObjEscaneoLn.ReadEmbarqueMax(ref ObjEscaneo);
                if (ObjEscaneo.MsjError == null)
                {
                    LblNEmbarque.Text = ObjEscaneo.NEmbarque.ToString();
                }
                else
                {
                    MessageBox.Show(ObjEscaneo.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                CargarListaTipoEscaneo();

                BtnAbrirEmbarque.Enabled = false;
                BtnActualizarEmbarque.Enabled = false;
                BtnCerrarEmbarque.Enabled = true;

                LblNCaja.Text = "1";
                LblNEscaneoXCaja.Text = "1";
                TxtPrograma.Enabled = true;
                CbTipoEscaneo.Enabled = true;
                TxtEscaneo.Enabled = true;
                DgvEscaneo.Enabled = true;
            }
        }

        private void BtnActualizarEmbarque_Click(object sender, EventArgs e)
        {

        }

        private void BtnCerrarEmbarque_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Acciones con ComboBox
        private void CbTipoEscaneo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbTipoEscaneo.Text.Equals("Nuevo Tipo"))
            {
                FrmTipoEscaneo fmTipoEscaneo = new FrmTipoEscaneo(this);
                fmTipoEscaneo.ShowDialog();
            }
        }

        #endregion

        #region Acciones con TextBox
        private void TxtEscaneo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (TxtPrograma.Text == string.Empty)
                {
                    MessageBox.Show("No puede estar vacio el programa", "Mensaje de sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtEscaneo.Text = string.Empty;
                    TxtPrograma.Focus();
                }
                else if (CbTipoEscaneo.Text == string.Empty)
                {
                    MessageBox.Show("No puede estar vacio el tipo de escaneo", "Mensaje de sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtEscaneo.Text = string.Empty;
                    CbTipoEscaneo.Focus();
                }
                else
                {
                    //Se llama el porcedimiento para extraer la información del escaneo
                    ObjReadDatosEscaneo = new ClsReadDatosEscaneo()
                    {
                        OrdenProduccion = TxtPrograma.Text,
                        Codigo = TxtEscaneo.Text
                    };
                    ObjReadDatosEscaneoLn.ReadDatosEscaneo(ref ObjReadDatosEscaneo);

                    if (ObjReadDatosEscaneo.MsjError == null)
                    {
                        ObjEscaneo = new ClsEscaneo()
                        {
                            Programa = Convert.ToInt32(ObjReadDatosEscaneo.OrdenProduccion),
                            Escaneo = ObjReadDatosEscaneo.Codigo,
                            Area = CbTipoEscaneo.Text,
                            Cantidad = Convert.ToDouble(ObjReadDatosEscaneo.Cantidad),
                            NCajaEmbarque = Convert.ToInt32(LblNCaja.Text),
                            PO = ObjReadDatosEscaneo.PO,
                            ItemCode = ObjReadDatosEscaneo.Codigo,
                            Cod_Modelo = ObjReadDatosEscaneo.U_Argns_Mod,
                            Modelo = ObjReadDatosEscaneo.Estilo,
                            Cod_Color = ObjReadDatosEscaneo.U_Argns_Col,
                            Punto = ObjReadDatosEscaneo.USA,
                            FechaAlta = DateTime.Now,
                            Error = ObjReadDatosEscaneo.MsjError,
                            NEscaneoXCaja = Convert.ToInt32(LblNEscaneoXCaja.Text),
                            NEmbarque = Convert.ToInt32(LblNEmbarque.Text)
                        };
                        if (RbNormal.Checked == true)
                        {
                            ObjEscaneo.Selecc = "Normal";
                        }
                        else if (RbComplemento.Checked == true) {
                            ObjEscaneo.Selecc = "Complemento";
                        }
                        else if (RbBGrade.Checked == true)
                        {
                            ObjEscaneo.Selecc = "B-Grade";
                        }

                        ObjEscaneoLn.Create(ref ObjEscaneo);
                        if (ObjEscaneo.MsjError == null)
                        {
                            TxtEscaneo.Text = string.Empty;
                            TxtEscaneo.Focus();
                        }
                        else
                        {
                            MessageBox.Show(ObjEscaneo.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show(ObjReadDatosEscaneo.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        #endregion
    }
}
