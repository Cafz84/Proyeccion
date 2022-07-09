using Entidades.Usuario;
using LogicaNegocio.Usuario;
using Pruebas.Utilidades;
using System;
using System.Windows.Forms;

namespace Pruebas.Formas
{
    public partial class FrmFracciones : Form
    {
        #region Variables Privadas
        private ClsFraccion ObjFraccion = null;
        public readonly ClsFraccionLn ObjFraccionLn = new ClsFraccionLn();
        public readonly ClsUtilidades ObjUtilidades = new ClsUtilidades();
        #endregion

        #region Metodo Constructor
        public FrmFracciones()
        {
            InitializeComponent();
            CargarListaFracciones();
        }
        #endregion

        #region Metodos Privados
        private void Limpiar()
        {
            LblFraccionId.Text = string.Empty;
            TxtCodFraccion.Text = string.Empty;
            ChkActivo.Checked = false;
            TxtNombre.Text = string.Empty;
            TxtDescripcion.Text = string.Empty;
            TxtBCodFraccion.Text = string.Empty;
            TxtBFraccion.Text = string.Empty;

            BtnAgregar.Enabled = true;
            BtnActualizar.Enabled = false;
            BtnEliminar.Enabled = false;
            TxtCodFraccion.Focus();
        }

        private void CargarListaFracciones()
        {
            ObjFraccion = new ClsFraccion()
            {
                Name = TxtBFraccion.Text,
                Codigo = TxtBCodFraccion.Text
            };

            ObjFraccionLn.Index(ref ObjFraccion);
            if (ObjFraccion.MsjError == null)
            {
                DgvFracciones.DataSource = ObjFraccion.DtResultados;
                ObjUtilidades.FormatoDgvPEC(ref DgvFracciones);
                DgvFracciones.Columns["FraccionId"].Visible = false;
                DgvFracciones.Columns["Editar"].Width = 30;
                DgvFracciones.Columns["Codigo"].Width = 55;
                DgvFracciones.Columns["Fraccion"].Width = 300;
            }
            else
            {
                MessageBox.Show(ObjFraccion.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Accion con Botones
        private void BtnCerrar_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void BtnLimpiar_Click(object sender, System.EventArgs e)
        {
            Limpiar();
        }

        private void BtnAgregar_Click(object sender, System.EventArgs e)
        {
            if (LblFraccionId.Text == string.Empty)
            {
                if (TxtNombre.Text == string.Empty)
                {
                    MessageBox.Show("Se requiere ingresar un nombre de Fracción");
                    TxtNombre.Focus();
                }
                else if (TxtCodFraccion.Text == string.Empty)
                {
                    MessageBox.Show("Se requiere ingresar un codigo de Fracción");
                    TxtCodFraccion.Focus();
                }
                else
                {
                    ObjFraccion = new ClsFraccion()
                    {
                        Codigo = TxtCodFraccion.Text.ToUpper(),
                        Name = TxtNombre.Text.ToUpper()
                    };
                    ObjFraccionLn.ReadRepetido(ref ObjFraccion);

                    if(ObjFraccion.DtResultados.Rows.Count != 0)
                    {
                        MessageBox.Show("No se puede agregar la Fracción ya existe");
                    }
                    else
                    {
                        DialogResult respuesta = MessageBox.Show("¿En ralidad quiere agregar el registro?", "Mensaje de Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (respuesta == DialogResult.OK)
                        {
                            ObjFraccion = new ClsFraccion()
                            {
                                Codigo = TxtCodFraccion.Text.ToUpper(),
                                Name = TxtNombre.Text.ToUpper(),
                                Descripcion = TxtDescripcion.Text,
                                Activo = true
                            };

                            ObjFraccionLn.Create(ref ObjFraccion);
                            if (ObjFraccion.MsjError == null)
                            {
                                MessageBox.Show("Alta exitosa");
                                CargarListaFracciones();

                                Limpiar();
                            }
                            else
                            {
                                MessageBox.Show(ObjFraccion.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No se puede generar alta si se selecciono para editar favor de limpiar primero");
            }
        }

        private void BtnActualizar_Click(object sender, System.EventArgs e)
        {
            if (LblFraccionId.Text == string.Empty)
            {
                MessageBox.Show("Selecciona un dato para actualizar");
            }
            else
            {
                ObjFraccion = new ClsFraccion()
                {
                    Codigo = TxtCodFraccion.Text.ToUpper(),
                    Name = TxtNombre.Text.ToUpper()
                };
                ObjFraccionLn.ReadRepetido(ref ObjFraccion);

                if (ObjFraccion.DtResultados.Rows.Count != 0)
                {
                    MessageBox.Show("No se puede duplicar la Fracción");
                }
                else
                {
                    DialogResult respuesta = MessageBox.Show("¿En ralidad quiere modificar el registro?", "Mensaje de Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.OK)
                    {
                        ObjFraccion = new ClsFraccion()
                        {
                            FraccionId = Convert.ToInt16(LblFraccionId.Text),
                            Codigo = TxtCodFraccion.Text.ToUpper(),
                            Name = TxtNombre.Text.ToUpper(),
                            Descripcion = TxtDescripcion.Text
                        };
                        if (ChkActivo.Checked)
                        {
                            ObjFraccion.Activo = true;
                        }
                        else
                        {
                            ObjFraccion.Activo = false;
                        }

                        ObjFraccionLn.Update(ref ObjFraccion);
                        if (ObjFraccion.MsjError == null)
                        {
                            MessageBox.Show("El empleado fue actualizado correctamente");
                            CargarListaFracciones();

                            Limpiar();
                        }
                        else
                        {
                            MessageBox.Show(ObjFraccion.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void BtnEliminar_Click(object sender, System.EventArgs e)
        {
            if (LblFraccionId.Text == string.Empty)
            {
                MessageBox.Show("Debes seleccionar una fracción para eliminar");
            }
            else
            {
                if (ChkActivo.Checked == false)
                {
                    DialogResult respuesta = MessageBox.Show("¿En ralidad quiere eliminar el registro?", "Mensaje de Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.OK)
                    {
                        ObjFraccion = new ClsFraccion()
                        {
                            FraccionId = Convert.ToByte(LblFraccionId.Text)
                        };

                        ObjFraccionLn.Delete(ref ObjFraccion);
                        if (ObjFraccion.MsjError == null)
                        {
                            MessageBox.Show("Baja exitosa");
                            CargarListaFracciones();

                            Limpiar();
                        }
                        else
                        {
                            MessageBox.Show(ObjFraccion.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    DialogResult respuesta = MessageBox.Show("¿En ralidad quiere desactivar el registro?", "Mensaje de Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.OK)
                    {
                        ObjFraccion = new ClsFraccion()
                        {
                            FraccionId = Convert.ToByte(LblFraccionId.Text),
                            Activo = false
                        };

                        ObjFraccionLn.UpdateActivo(ref ObjFraccion);
                        if (ObjFraccion.MsjError == null)
                        {
                            MessageBox.Show("La fracción fue desactivada");
                            CargarListaFracciones();

                            Limpiar();
                        }
                        else
                        {
                            MessageBox.Show(ObjFraccion.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
        #endregion

        #region Acciones con DataGredView
        private void DgvFracciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnActualizar.Enabled = true;
            BtnEliminar.Enabled = true;
            BtnLimpiar.Enabled = true;
            BtnAgregar.Enabled = false;
            try
            {
                if (DgvFracciones.Columns[e.ColumnIndex].Name == "Editar")
                {
                    ObjFraccion = new ClsFraccion()
                    {
                        FraccionId = Convert.ToByte(DgvFracciones.Rows[e.RowIndex].Cells["FraccionId"].Value.ToString())
                    };

                    LblFraccionId.Text = ObjFraccion.FraccionId.ToString();

                    ObjFraccionLn.Read(ref ObjFraccion);
                    TxtCodFraccion.Text = ObjFraccion.Codigo;
                    TxtNombre.Text = ObjFraccion.Name;
                    TxtDescripcion.Text = ObjFraccion.Descripcion;
                    if (ObjFraccion.Activo == true)
                    {
                        ChkActivo.Checked = true;
                    }
                    else
                    {
                        ChkActivo.Checked = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion

        #region Acciones con TextBox
        private void TxtBFraccion_TextChanged(object sender, EventArgs e)
        {
            CargarListaFracciones();
        }

        private void TxtBCodFraccion_TextChanged(object sender, EventArgs e)
        {
            CargarListaFracciones();
        }
        #endregion
    }
}
