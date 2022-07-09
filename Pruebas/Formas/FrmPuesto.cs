using Entidades.Usuario;
using LogicaNegocio.Usuario;
using Proyeccion.Principal;
using Pruebas.Utilidades;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Pruebas.Formas
{
    public partial class FrmPuesto : Form
    {
        #region Variables Privadas
        private ClsPuesto ObjPuesto = null;
        private readonly ClsPuestoLn ObjPuestoLn = new ClsPuestoLn();
        private readonly ClsUtilidades ObjUtilidades = new ClsUtilidades();

        private FrmEmpleados FrmEmpleadosHandler;
        #endregion

        #region Contructores
        public FrmPuesto()
        {
            InitializeComponent();
            CargarListaPuesto();
        }

        public FrmPuesto(FrmEmpleados frmEmpleados)
        {
            InitializeComponent();
            CargarListaPuesto();
            FrmEmpleadosHandler = frmEmpleados;
        }
        #endregion

        #region Metodos Privados
        private void CargarListaPuesto()
        {
            ObjPuesto = new ClsPuesto()
            {
                Puesto = TxtBPuesto.Text
            };

            ObjPuestoLn.Index(ref ObjPuesto);
            if (ObjPuesto.MsjError == null)
            {
                DgvPuesto.DataSource = ObjPuesto.DtResultados;
                ObjUtilidades.FormatoDataGridView(ref DgvPuesto);
            }
            else
            {
                MessageBox.Show(ObjPuesto.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Limpiar()
        {
            LblPuestoId.Text = string.Empty;
            TxtNombre.Text = string.Empty;
            TxtDescripcion.Text = string.Empty;
            ChkActivo.Checked = false;
            TxtBPuesto.Text = string.Empty;
            TxtNombre.Focus();

            BtnAgregar.Enabled = true;
            BtnActualizar.Enabled = false;
            BtnEliminar.Enabled = false;
        }

        private bool Repetido()
        {
            ObjPuesto = new ClsPuesto()
            {
                Puesto = TxtNombre.Text
            };

            ObjPuestoLn.ReadRepetido(ref ObjPuesto);
            if (ObjPuesto.DtResultados.Rows.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region Accion con los Botones
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (LblPuestoId.Text == string.Empty)
            {
                if (Repetido())
                {
                    DialogResult result = MessageBox.Show("¿Quieres dar de alta el registro?", "Mensaje de sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        ObjPuesto = new ClsPuesto()
                        {
                            Puesto = TxtNombre.Text,
                            Descripcion = TxtDescripcion.Text,
                            Activo = true
                        };

                        ObjPuestoLn.Create(ref ObjPuesto);
                        if (ObjPuesto.MsjError == null)
                        {
                            MessageBox.Show("Alta exitosa");
                            CargarListaPuesto();
                            Limpiar();
                        }
                        else
                        {
                            MessageBox.Show(ObjPuesto.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("El Puesto ya exixte", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se puede generar alta si se selecciono para editar.\nFavor de limpiar primero", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (LblPuestoId.Text == string.Empty)
            {
                MessageBox.Show("Selecciona un dato para actualizar");
            }
            else
            {
                if (Repetido())
                {
                    DialogResult result = MessageBox.Show("¿Quieres actualizar el registro?", "Mensaje de sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        ObjPuesto = new ClsPuesto()
                        {
                            PuestoId = Convert.ToByte(LblPuestoId.Text),
                            Puesto = TxtNombre.Text,
                            Descripcion = TxtDescripcion.Text,
                            Activo = ChkActivo.Checked
                        };

                        ObjPuestoLn.Update(ref ObjPuesto);
                        if (ObjPuesto.MsjError == null)
                        {
                            MessageBox.Show("El Puesto fue actualizado correctamente");
                            CargarListaPuesto();
                            Limpiar();
                        }
                        else
                        {
                            MessageBox.Show(ObjPuesto.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("El Puesto ya exixte", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (LblPuestoId.Text == string.Empty)
            {
                MessageBox.Show("Debes seleccionar un dato para eliminar");
            }
            else
            {
                if (ChkActivo.Checked == false)
                {
                    DialogResult result = MessageBox.Show("¿Realmente quieres eliminar el registro?", "Mensaje de Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        ObjPuesto = new ClsPuesto()
                        {
                            PuestoId = Convert.ToByte(LblPuestoId.Text)
                        };

                        ObjPuestoLn.Delete(ref ObjPuesto);
                        if (ObjPuesto.MsjError == null)
                        {
                            MessageBox.Show("Baja exitosa");
                            CargarListaPuesto();
                            Limpiar();
                        }
                        else
                        {
                            MessageBox.Show(ObjPuesto.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("El registro se desactivara primero \n ¿Quieres continuar?", "Mensaje de Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        ObjPuesto = new ClsPuesto()
                        {
                            PuestoId = Convert.ToByte(LblPuestoId.Text),
                            Activo = false
                        };

                        ObjPuestoLn.UpdateActivo(ref ObjPuesto);
                        if (ObjPuesto.MsjError == null)
                        {
                            MessageBox.Show("La Area fue desactivada");
                            CargarListaPuesto();
                            Limpiar();
                        }
                        else
                        {
                            MessageBox.Show(ObjPuesto.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmEmpleadosHandler.CargarListaPuesto();
            FrmEmpleadosHandler.CambiarSelectedIndexPuesto();
        }
        #endregion

        #region Accion con DataGridView
        private void DgvPuesto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DgvPuesto.Columns[e.ColumnIndex].Name == "Editar")
                {
                    ObjPuesto = new ClsPuesto()
                    {
                        PuestoId = Convert.ToByte(DgvPuesto.Rows[e.RowIndex].Cells["PuestoId"].Value.ToString())
                    };

                    LblPuestoId.Text = ObjPuesto.PuestoId.ToString();

                    ObjPuestoLn.Read(ref ObjPuesto);
                    TxtNombre.Text = ObjPuesto.Puesto;
                    TxtDescripcion.Text = ObjPuesto.Descripcion;
                    ChkActivo.Checked = ObjPuesto.Activo;

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

        #region Accion con TextBox
        private void TxtBPuesto_TextChanged(object sender, EventArgs e)
        {
            CargarListaPuesto();
        }
        #endregion

        #region Mover la ventana
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void FrmPuesto_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void LblTituloPuesto_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
    }
}
