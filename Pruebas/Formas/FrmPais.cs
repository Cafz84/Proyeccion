using Entidades.Usuario;
using LogicaNegocio.Usuario;
using Proyeccion.Principal;
using Pruebas.Utilidades;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Pruebas.Formas
{
    public partial class FrmPais : Form
    {
        #region Variables Privadas
        private ClsPais ObjPais = null;
        private ClsEstado ObjEstado = null;
        private ClsUtilidades ObjUtilidades = new ClsUtilidades();
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
                ObjUtilidades.FormatoDataGridView(ref DgvPais);
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
                        Code = DgvPais.Rows[e.RowIndex].Cells["Codigo"].Value.ToString(),
                        Name = DgvPais.Rows[e.RowIndex].Cells["Nombre"].Value.ToString(),
                    };

                    TxtCode.Text = ObjPais.Code.ToString();

                    ObjPaisLn.Read(ref ObjPais);
                    TxtNombre.Text = ObjPais.Name;

                    BtnLimpiar.Enabled = true;
                    BtnAgregar.Enabled = false;
                    BtnActualizar.Enabled = true;
                    BtnEliminar.Enabled = true;
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
            FrmEmpleadosHandler.CargarListaPais();
            FrmEmpleadosHandler.CambiarSelectedIndexPais();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtCode.Text = string.Empty;
            TxtNombre.Text = string.Empty;

            BtnLimpiar.Enabled = false;
            BtnAgregar.Enabled = true;
            BtnActualizar.Enabled = false;
            BtnEliminar.Enabled = false;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (TxtCode.Text != string.Empty || TxtNombre.Text != string.Empty)
            {
                DialogResult result = MessageBox.Show("¿Realmente quiere agregar el registro?", "Mensaje de sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
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
                        TxtCode.Text = string.Empty;
                        TxtNombre.Text = string.Empty;

                        BtnLimpiar.Enabled = false;
                        BtnAgregar.Enabled = true;
                        BtnActualizar.Enabled = false;
                        BtnEliminar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show(ObjPais.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("No se puede generar alta si se selecciono para editar favor de limpiar primero");
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (TxtCode.Text == string.Empty || TxtNombre.Text == string.Empty)
            {
                MessageBox.Show("Selecciona un dato para actualizar");
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Realmente quiere actualizar el registro?", "Mensaje de sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
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

                        TxtCode.Text = string.Empty;
                        TxtNombre.Text = string.Empty;

                        BtnLimpiar.Enabled = false;
                        BtnAgregar.Enabled = true;
                        BtnActualizar.Enabled = false;
                        BtnEliminar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show(ObjPais.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (TxtCode.Text == string.Empty || TxtNombre.Text == string.Empty)
            {
                MessageBox.Show("Debes seleccionar un dato para eliminar");
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Realmente quiere eliminar el registro?", "Mensaje de sistema", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                if (result == DialogResult.OK)
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
                            TxtCode.Text = string.Empty;
                            TxtNombre.Text = string.Empty;

                            BtnLimpiar.Enabled = false;
                            BtnAgregar.Enabled = true;
                            BtnActualizar.Enabled = false;
                            BtnEliminar.Enabled = false;
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
        }
        #endregion

        #region Mover la ventana
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void FrmPais_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void LblTituloPais_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
    }
}
