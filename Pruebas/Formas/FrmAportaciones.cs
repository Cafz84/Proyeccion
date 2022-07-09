using Entidades.Usuario;
using LogicaNegocio.Usuario;
using Pruebas.Utilidades;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Pruebas.Formas
{
    public partial class FrmAportaciones : Form
    {
        #region Variables Privadas
        private ClsAportacion ObjAportacion = null;
        private readonly ClsAportacionLn ObjAportacionLn = new ClsAportacionLn();
        private readonly ClsUtilidades ObjUtilidades = new ClsUtilidades();

        private FrmRevDestajo FrmRevDestajoHandler;
        #endregion

        #region Metodos Constructores
        public FrmAportaciones()
        {
            InitializeComponent();
        }

        public FrmAportaciones(FrmRevDestajo frmRevDestajo)
        {
            InitializeComponent();
            CargarListaAportaciones();
            FrmRevDestajoHandler = frmRevDestajo;
        }
        #endregion

        #region Metodos Privados
        private void CargarListaAportaciones()
        {
            ObjAportacion = new ClsAportacion()
            {
                Aportacion = TxtBAportacion.Text
            };

            ObjAportacionLn.Index(ref ObjAportacion);
            if (ObjAportacion.MsjError == null)
            {
                DgvAportacion.DataSource = ObjAportacion.DtResultados;
                ObjUtilidades.FormatoDgvPEC(ref DgvAportacion);
                DgvAportacion.Columns["IdAportacion"].Visible = false;
            }
            else 
            {
                MessageBox.Show(ObjAportacion.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Limpiar()
        {
            LblAportacionId.Text = string.Empty;
            TxtNombre.Text = string.Empty;
            TxtDescripcion.Text = string.Empty;
            ChkActivo.Checked = false;
            TxtBAportacion.Text = string.Empty;
            TxtNombre.Focus();

            BtnAgregar.Enabled = true;
            BtnActualizar.Enabled = false;
            BtnEliminar.Enabled = false;
        }

        private bool Repetido()
        {
            ObjAportacion = new ClsAportacion()
            {
                Aportacion = TxtNombre.Text.ToUpper()
            };

            ObjAportacionLn.ReadRepetido(ref ObjAportacion);
            if (ObjAportacion.DtResultados.Rows.Count == 0)
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
            //FrmRevDestajoHandler.CargarListaAportaciones();
        }

        private void BtnLimpiar_Click(object sender, System.EventArgs e)
        {
            Limpiar();
        }

        private void BtnAgregar_Click(object sender, System.EventArgs e)
        {
            if (LblAportacionId.Text == string.Empty)
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
                            ObjAportacion = new ClsAportacion()
                            {
                                Aportacion = TxtNombre.Text.ToUpper(),
                                Descripcion = TxtDescripcion.Text,
                                Activo = true
                            };

                            ObjAportacionLn.Create(ref ObjAportacion);
                            if (ObjAportacion.MsjError == null)
                            {
                                MessageBox.Show("Alta exitosa");
                                CargarListaAportaciones();
                                Limpiar();
                            }
                            else
                            {
                                MessageBox.Show(ObjAportacion.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (LblAportacionId.Text == string.Empty)
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
                        ObjAportacion = new ClsAportacion()
                        {
                            IdAportacion = Convert.ToByte(LblAportacionId.Text),
                            Aportacion = TxtNombre.Text.ToUpper(),
                            Descripcion = TxtDescripcion.Text,
                            Activo = ChkActivo.Checked
                        };

                        ObjAportacionLn.Update(ref ObjAportacion);
                        if (ObjAportacion.MsjError == null)
                        {
                            MessageBox.Show("La Aportación fue actualizada correctamente");
                            CargarListaAportaciones();

                            Limpiar();
                        }
                        else
                        {
                            MessageBox.Show(ObjAportacion.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (LblAportacionId.Text == string.Empty)
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
                        ObjAportacion = new ClsAportacion()
                        {
                            IdAportacion = Convert.ToByte(LblAportacionId.Text)
                        };

                        ObjAportacionLn.Delete(ref ObjAportacion);
                        if (ObjAportacion.MsjError == null)
                        {
                            MessageBox.Show("Baja exitosa");
                            CargarListaAportaciones();
                            Limpiar();
                        }
                        else
                        {
                            MessageBox.Show(ObjAportacion.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("El registro se desactivara primero \n ¿Quieres continuar?", "Mensaje de sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        ObjAportacion = new ClsAportacion()
                        {
                            IdAportacion = Convert.ToByte(LblAportacionId.Text),
                            Activo = false
                        };

                        ObjAportacionLn.UpdateActivo(ref ObjAportacion);
                        if (ObjAportacion.MsjError == null)
                        {
                            MessageBox.Show("La Aportación fue desactivada");
                            CargarListaAportaciones();
                            Limpiar();
                        }
                        else
                        {
                            MessageBox.Show(ObjAportacion.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
        #endregion

        #region Acción con TextBox
        private void TxtBAportacion_TextChanged(object sender, EventArgs e)
        {
            CargarListaAportaciones();
        }
        #endregion

        #region Acción con DataGridView
        private void DgvAportacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DgvAportacion.Columns[e.ColumnIndex].Name == "Editar")
                {
                    ObjAportacion = new ClsAportacion()
                    {
                        IdAportacion = Convert.ToByte(DgvAportacion.Rows[e.RowIndex].Cells["IdAportacion"].Value.ToString())
                    };

                    LblAportacionId.Text = ObjAportacion.IdAportacion.ToString();

                    ObjAportacionLn.Read(ref ObjAportacion);
                    TxtNombre.Text = ObjAportacion.Aportacion;
                    TxtDescripcion.Text = ObjAportacion.Descripcion;
                    ChkActivo.Checked = ObjAportacion.Activo;

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

        private void LblTituloAportaciones_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FrmAportaciones_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
    }
}
