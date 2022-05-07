using Entidades.Usuario;
using LogicaNegocio.Usuario;
using Proyeccion.Principal;
using System;
using System.Windows.Forms;

namespace Pruebas.Formas
{
    public partial class FrmPais : Form
    {
        #region Variables Privadas
        private ClsPais ObjPais = null;
        private ClsEstado ObjEstado = null;
        private readonly ClsPaisLn ObjPaisLn = new ClsPaisLn();
        private readonly ClsEstadoLn ObjEstadoLn = new ClsEstadoLn();

        private FrmEmpleados FrmEmpleadosHandler;
        #endregion

        #region Metodos Constructores
        public FrmPais()
        {
            InitializeComponent();
            CargarListaPais();
        }

        public FrmPais(FrmEmpleados frmEmpleados)
        {
            InitializeComponent();
            CargarListaPais();
            FrmEmpleadosHandler = frmEmpleados;
        }
        #endregion

        #region Metodos Privados
        private void CargarListaPais()
        {
            ObjPais = new ClsPais();
            ObjPaisLn.Index(ref ObjPais);
            if (ObjPais.MsjError == null)
            {
                DgvPais.DataSource = ObjPais.DtResultados;
            }
            else
            {
                MessageBox.Show(ObjPais.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Acciones con DataGridView
        private void DgvPais_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DgvPais.Columns[e.ColumnIndex].Name == "Editar")
                {
                    ObjPais = new ClsPais()
                    {
                        Code = DgvPais.Rows[e.RowIndex].Cells["Code"].Value.ToString(),
                        Name = DgvPais.Rows[e.RowIndex].Cells["Name"].Value.ToString(),
                    };

                    TxtCode.Text = ObjPais.Code.ToString();

                    ObjPaisLn.Read(ref ObjPais);
                    TxtNombre.Text = ObjPais.Name;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion

        #region Acciones con Botones
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmEmpleadosHandler.bArea = false;
            FrmEmpleadosHandler.CargarListaPais();
            FrmEmpleadosHandler.CambiarSelectedIndexPais();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtCode.Text = "";
            TxtNombre.Text = "";
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (TxtCode.Text == "")
            {
                ObjPais = new ClsPais()
                {
                    Code = TxtCode.Text,
                    Name = TxtNombre.Text,
                };

                ObjPaisLn.Create(ref ObjPais);
                if (ObjPais.MsjError == null)
                {
                    MessageBox.Show("Alta exitosa");
                    CargarListaPais();
                    TxtCode.Text = "";
                    TxtNombre.Text = "";
                }
                else
                {
                    MessageBox.Show(ObjPais.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se puede generar alta si se selecciono para editar favor de limpiar primero");
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (TxtCode.Text == "")
            {
                MessageBox.Show("Selecciona un dato para actualizar");
            }
            else
            {
                ObjPais = new ClsPais()
                {
                    Code = TxtCode.Text,
                    Name = TxtNombre.Text,
                };

                ObjPaisLn.Update(ref ObjPais);
                if (ObjPais.MsjError == null)
                {
                    MessageBox.Show("El Pais fue actualizado correctamente");
                    CargarListaPais();
                }
                else
                {
                    MessageBox.Show(ObjPais.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (TxtCode.Text == "")
            {
                MessageBox.Show("Debes seleccionar un dato para eliminar");
            }
            else
            {
                ObjEstado = new ClsEstado()
                {
                    Country = TxtCode.Text
                };
                ObjEstadoLn.ReadCountry(ref ObjEstado);

                if (ObjEstado.DtResultados.Rows.Count < 1)
                {
                    ObjPais = new ClsPais()
                    {
                        Code = TxtCode.Text
                    };

                    ObjPaisLn.Delete(ref ObjPais);
                    if (ObjPais.MsjError == null)
                    {
                        MessageBox.Show("Baja exitosa");
                        CargarListaPais();
                        TxtCode.Text = "";
                        TxtNombre.Text = "";
                    }
                    else
                    {
                        MessageBox.Show(ObjPais.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No se puede dar de baja ya que el pais esta ligado con estados");
                }
            }
        }
        #endregion
    }
}
