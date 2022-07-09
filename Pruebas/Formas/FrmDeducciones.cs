using Entidades.Usuario;
using LogicaNegocio.Usuario;
using Pruebas.Utilidades;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Pruebas.Formas
{
    public partial class FrmDeducciones : Form
    {
        #region Variables Privadas
        private ClsDeduccion ObjDeduccion = null;
        private readonly ClsDeduccionLn ObjDeduccionLn = new ClsDeduccionLn();
        private readonly ClsUtilidades ObjUtilidades = new ClsUtilidades();

        private FrmRevDestajo FrmRevDestajoHandler;
        #endregion

        #region Metodos Constructores
        public FrmDeducciones()
        {
            InitializeComponent();
        }

        public FrmDeducciones(FrmRevDestajo frmRevDestajo)
        {
            InitializeComponent();
            CargarListaDeducciones();
            FrmRevDestajoHandler = frmRevDestajo;
        }
        #endregion

        #region Metodos Privados
        private void CargarListaDeducciones()
        {
            ObjDeduccion = new ClsDeduccion()
            {
                Deduccion = TxtBDeduccion.Text
            };

            ObjDeduccionLn.Index(ref ObjDeduccion);
            if (ObjDeduccion.MsjError == null)
            {
                DgvDeduccion.DataSource = ObjDeduccion.DtResultados;
                ObjUtilidades.FormatoDgvPEC(ref DgvDeduccion);
                DgvDeduccion.Columns["IdDeduccion"].Visible = false;
            }
            else
            {
                MessageBox.Show(ObjDeduccion.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Limpiar()
        {
            LblDeduccionId.Text = string.Empty;
            TxtNombre.Text = string.Empty;
            TxtDescripcion.Text = string.Empty;
            ChkActivo.Checked = false;
            TxtBDeduccion.Text = string.Empty;
            TxtNombre.Focus();

            BtnAgregar.Enabled = true;
            BtnActualizar.Enabled = false;
            BtnEliminar.Enabled = false;
        }

        private bool Repetido()
        {
            ObjDeduccion = new ClsDeduccion()
            {
                Deduccion = TxtNombre.Text.ToUpper()
            };

            ObjDeduccionLn.ReadRepetido(ref ObjDeduccion);
            if (ObjDeduccion.DtResultados.Rows.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region Acciones con los Botones
        private void BtnCerrar_Click(object sender, System.EventArgs e)
        {
            this.Close();
            //FrmRevDestajoHandler.CargarListaDeducciones();
        }

        private void BtnLimpiar_Click(object sender, System.EventArgs e)
        {
            Limpiar();
        }

        private void BtnAgregar_Click(object sender, System.EventArgs e)
        {
            if (LblDeduccionId.Text == string.Empty)
            {
                if (TxtNombre.Text == string.Empty)
                {
                    MessageBox.Show("No se puede generar alta si no se escribe un Nombre", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtNombre.Focus();
                }
                else
                {
                    if (Repetido())
                    {
                        DialogResult result = MessageBox.Show("¿Realmente quieres dar de alta el registro?", "Mensaje de sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (result == DialogResult.OK)
                        {
                            ObjDeduccion = new ClsDeduccion()
                            {
                                Deduccion = TxtNombre.Text.ToUpper(),
                                Descripcion = TxtDescripcion.Text,
                                Activo = true
                            };

                            ObjDeduccionLn.Create(ref ObjDeduccion);
                            if (ObjDeduccion.MsjError == null)
                            {
                                MessageBox.Show("Alta exitosa");
                                CargarListaDeducciones();
                                Limpiar();
                            }
                            else
                            {
                                MessageBox.Show(ObjDeduccion.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ya existe el registro", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("No se puede generar alta si se selecciono para editar.\nFavor de limpiar primero", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnActualizar_Click(object sender, System.EventArgs e)
        {
            if (LblDeduccionId.Text == string.Empty)
            {
                MessageBox.Show("Selecciona un dato para actualizar", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Repetido())
                {
                    DialogResult result = MessageBox.Show("¿Quieres actualizar el registro?", "Mensaje de Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        ObjDeduccion = new ClsDeduccion()
                        {
                            IdDeduccion = Convert.ToByte(LblDeduccionId.Text),
                            Deduccion = TxtNombre.Text.ToUpper(),
                            Descripcion = TxtDescripcion.Text,
                            Activo = ChkActivo.Checked
                        };

                        ObjDeduccionLn.Update(ref ObjDeduccion);
                        if (ObjDeduccion.MsjError == null)
                        {
                            MessageBox.Show("La Aportación fue actualizada correctamente");
                            CargarListaDeducciones();

                            Limpiar();
                        }
                        else
                        {
                            MessageBox.Show(ObjDeduccion.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ya existe el registro", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnEliminar_Click(object sender, System.EventArgs e)
        {
            if (LblDeduccionId.Text == string.Empty)
            {
                MessageBox.Show("Debes seleccionar un dato para eliminar", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (ChkActivo.Checked == false)
                {
                    DialogResult result = MessageBox.Show("¿Realmente quieres eliminar el registro?", "Mensaje de Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        ObjDeduccion = new ClsDeduccion()
                        {
                            IdDeduccion = Convert.ToByte(LblDeduccionId.Text)
                        };

                        ObjDeduccionLn.Delete(ref ObjDeduccion);
                        if (ObjDeduccion.MsjError == null)
                        {
                            MessageBox.Show("Baja exitosa");
                            CargarListaDeducciones();
                            Limpiar();
                        }
                        else
                        {
                            MessageBox.Show(ObjDeduccion.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("El registro se desactivara primero \n ¿Quieres continuar?", "Mensaje de sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        ObjDeduccion = new ClsDeduccion()
                        {
                            IdDeduccion = Convert.ToByte(LblDeduccionId.Text),
                            Activo = false
                        };

                        ObjDeduccionLn.UpdateActivo(ref ObjDeduccion);
                        if (ObjDeduccion.MsjError == null)
                        {
                            MessageBox.Show("La Aportación fue desactivada");
                            CargarListaDeducciones();
                            Limpiar();
                        }
                        else
                        {
                            MessageBox.Show(ObjDeduccion.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
        #endregion

        #region Acción con TextBox
        private void TxtBDeduccion_TextChanged(object sender, EventArgs e)
        {
            CargarListaDeducciones();
        }
        #endregion

        #region Acción con DataGridView
        private void DgvDeduccion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DgvDeduccion.Columns[e.ColumnIndex].Name == "Editar")
                {
                    ObjDeduccion = new ClsDeduccion()
                    {
                        IdDeduccion = Convert.ToByte(DgvDeduccion.Rows[e.RowIndex].Cells["IdDeduccion"].Value.ToString())
                    };

                    LblDeduccionId.Text = ObjDeduccion.IdDeduccion.ToString();

                    ObjDeduccionLn.Read(ref ObjDeduccion);
                    TxtNombre.Text = ObjDeduccion.Deduccion;
                    TxtDescripcion.Text = ObjDeduccion.Descripcion;
                    ChkActivo.Checked = ObjDeduccion.Activo;

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

        #region Mover la ventana
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void LblTituloDeduccion_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FrmDeducciones_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
    }
}
