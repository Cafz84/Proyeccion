using Entidades.Usuario;
using LogicaNegocio.Usuario;
using Proyeccion.Principal;
using Pruebas.Utilidades;
using System;
using System.Windows.Forms;

namespace Pruebas.Formas
{
    public partial class FrmTipoEscaneo : Form
    {
        #region Variables Privadas
        private ClsTipoEscaneo ObjTipoEscaneo = null;
        private readonly ClsUtilidades ObjUtilidades = new ClsUtilidades();
        private readonly ClsTipoEscaneoLn ObjTipoEscaneoLn = new ClsTipoEscaneoLn();

        private readonly FrmEscaneo FrmEscaneoHandler;
        #endregion

        #region Constructores
        public FrmTipoEscaneo()
        {
            InitializeComponent();
        }

        public FrmTipoEscaneo(FrmEscaneo frmEscaneo)
        {
            InitializeComponent();
            CargarListaTipoEscaneo();
            FrmEscaneoHandler = frmEscaneo;
        }
        #endregion

        #region Metodos Privados
        private void LimpiarDatos()
        {
            LblTipoId.Text = string.Empty;
            TxtNombre.Text = string.Empty;
            TxtDescripcion.Text = string.Empty;
            ChkActivo.Checked = false;

            BtnLimpiar.Enabled = false;
            BtnAgregar.Enabled = true;
            BtnActualizar.Enabled = false;
            BtnEliminar.Enabled = false;
        }
        private void CargarListaTipoEscaneo()
        {
            ObjTipoEscaneo = new ClsTipoEscaneo();
            ObjTipoEscaneoLn.Index(ref ObjTipoEscaneo);
            if (ObjTipoEscaneo.MsjError == null)
            {
                DgvTipoEscaneo.DataSource = ObjTipoEscaneo.DtResultados;
                ObjUtilidades.FormatoDataGridView(ref DgvTipoEscaneo);
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
            FrmEscaneoHandler.CargarListaTipoEscaneo();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (LblTipoId.Text == string.Empty)
            {
                DialogResult respuesta = MessageBox.Show("¿Realmente quiere agregar el registro?", "Mensaje de sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (respuesta == DialogResult.OK)
                {
                    ObjTipoEscaneo = new ClsTipoEscaneo()
                    {
                        Nombre = TxtNombre.Text,
                        Descripcion = TxtDescripcion.Text,
                        Activo = true
                    };

                    ObjTipoEscaneoLn.Create(ref ObjTipoEscaneo);
                    if (ObjTipoEscaneo.MsjError == null)
                    {
                        MessageBox.Show("Alta exitosa");
                        CargarListaTipoEscaneo();
                        LimpiarDatos();
                    }
                    else
                    {
                        MessageBox.Show(ObjTipoEscaneo.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (LblTipoId.Text == string.Empty)
            {
                MessageBox.Show("Selecciona un dato para actualizar");
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Realmente quieres actualizar el registo?", "Mensaje de sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    ObjTipoEscaneo = new ClsTipoEscaneo()
                    {
                        TipoId = Convert.ToByte(LblTipoId.Text),
                        Nombre = TxtNombre.Text,
                        Descripcion = TxtDescripcion.Text,
                        Activo = ChkActivo.Checked
                    };

                    ObjTipoEscaneoLn.Update(ref ObjTipoEscaneo);
                    if (ObjTipoEscaneo.MsjError == null)
                    {
                        MessageBox.Show("La Area fue actualizada correctamente");
                        CargarListaTipoEscaneo();
                        LimpiarDatos();
                    }
                    else
                    {
                        MessageBox.Show(ObjTipoEscaneo.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (LblTipoId.Text == string.Empty)
            {
                MessageBox.Show("Debes seleccionar un dato para eliminar");
            }
            else
            {
                if (ChkActivo.Checked == false)
                {
                    DialogResult result = MessageBox.Show("¿Realmente quiere eliminar el registro?", "Mensaje de sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        ObjTipoEscaneo = new ClsTipoEscaneo()
                        {
                            TipoId = Convert.ToByte(LblTipoId.Text)
                        };

                        ObjTipoEscaneoLn.Delete(ref ObjTipoEscaneo);
                        if (ObjTipoEscaneo.MsjError == null)
                        {
                            MessageBox.Show("Baja exitosa");
                            CargarListaTipoEscaneo();
                            LimpiarDatos();
                        }
                        else
                        {
                            MessageBox.Show(ObjTipoEscaneo.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("El registro se desactivara pirmero \n ¿Quieres continuar?", "Mensaje de sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        ObjTipoEscaneo = new ClsTipoEscaneo()
                        {
                            TipoId = Convert.ToByte(LblTipoId.Text),
                            Activo = false
                        };

                        ObjTipoEscaneoLn.UpdateActivo(ref ObjTipoEscaneo);
                        if (ObjTipoEscaneo.MsjError == null)
                        {
                            MessageBox.Show("La Area fue desactivada");
                            CargarListaTipoEscaneo();
                            LimpiarDatos();
                        }
                        else
                        {
                            MessageBox.Show(ObjTipoEscaneo.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
        #endregion

        #region Acciones con DataGridView
        private void DgvTipoEscaneo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DgvTipoEscaneo.Columns[e.ColumnIndex].Name == "Editar")
                {
                    ObjTipoEscaneo = new ClsTipoEscaneo()
                    {
                        TipoId = Convert.ToByte(DgvTipoEscaneo.Rows[e.RowIndex].Cells["TipoId"].Value.ToString())
                    };

                    LblTipoId.Text = ObjTipoEscaneo.TipoId.ToString();

                    ObjTipoEscaneoLn.Read(ref ObjTipoEscaneo);
                    TxtNombre.Text = ObjTipoEscaneo.Nombre;
                    TxtDescripcion.Text = ObjTipoEscaneo.Descripcion;
                    ChkActivo.Checked = ObjTipoEscaneo.Activo;

                    BtnActualizar.Enabled = true;
                    BtnLimpiar.Enabled = true;
                    BtnAgregar.Enabled = false;
                    BtnEliminar.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion
    }
}
