using Entidades.Usuario;
using LogicaNegocio.Usuario;
using Pruebas.Utilidades;
using System;
using System.Windows.Forms;

namespace Proyeccion.Principal
{
    public partial class FrmArea : Form
    {
        #region Variables Privadas
        private ClsArea ObjArea = null;
        private ClsUtilidades ObjUtilidades = new ClsUtilidades();
        private readonly ClsAreaLn ObjAreaLn = new ClsAreaLn();

        private FrmEmpleados FrmEmpleadosHandler;
        #endregion

        #region Constructores
        public FrmArea()
        {
            InitializeComponent();
            CargarListaArea();
        }

        public FrmArea(FrmEmpleados frmEmpleados)
        {
            InitializeComponent();
            CargarListaArea();
            FrmEmpleadosHandler = frmEmpleados;
        }
        #endregion

        #region Metodos Privados
        private void CargarListaArea()
        {
            ObjArea = new ClsArea();
            ObjAreaLn.Index(ref ObjArea);
            if (ObjArea.MsjError == null)
            {
                DgvArea.DataSource = ObjArea.DtResultados;
                ObjUtilidades.FormatoDataGridView(ref DgvArea);
            }
            else
            {
                MessageBox.Show(ObjArea.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Accion con DataGridView
        private void DgvArea_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DgvArea.Columns[e.ColumnIndex].Name == "Editar")
                {
                    ObjArea = new ClsArea()
                    {
                        AreaId = Convert.ToByte(DgvArea.Rows[e.RowIndex].Cells["AreaId"].Value.ToString())
                    };

                    LblAreaId.Text = ObjArea.AreaId.ToString();

                    ObjAreaLn.Read(ref ObjArea);
                    TxtNombre.Text = ObjArea.Area;
                    TxtDescripcion.Text = ObjArea.Descripcion;
                    ChkActivo.Checked = ObjArea.Activo;

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

        #region Accion con los Botones
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmEmpleadosHandler.bArea = false;
            FrmEmpleadosHandler.CargarListaArea();
            FrmEmpleadosHandler.CambiarSelectedIndexArea();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (LblAreaId.Text == "")
            {
                DialogResult respuesta = MessageBox.Show("¿Realmente quiere agregar el registro?", "Mensaje de sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (respuesta == DialogResult.OK)
                {
                    ObjArea = new ClsArea()
                    {
                        Area = TxtNombre.Text,
                        Descripcion = TxtDescripcion.Text,
                        Activo = true
                    };

                    ObjAreaLn.Create(ref ObjArea);
                    if (ObjArea.MsjError == null)
                    {
                        MessageBox.Show("Alta exitosa");
                        CargarListaArea();
                        LblAreaId.Text = "";
                        TxtNombre.Text = "";
                        TxtDescripcion.Text = "";
                        ChkActivo.Checked = false;
                    }
                    else
                    {
                        MessageBox.Show(ObjArea.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (LblAreaId.Text == "")
            {
                MessageBox.Show("Selecciona un dato para actualizar");
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Realmente quieres actualizar el registo?", "Mensaje de sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    ObjArea = new ClsArea()
                    {
                        AreaId = Convert.ToByte(LblAreaId.Text),
                        Area = TxtNombre.Text,
                        Descripcion = TxtDescripcion.Text,
                        Activo = ChkActivo.Checked
                    };

                    ObjAreaLn.Update(ref ObjArea);
                    if (ObjArea.MsjError == null)
                    {
                        MessageBox.Show("La Area fue actualizada correctamente");
                        CargarListaArea();
                    }
                    else
                    {
                        MessageBox.Show(ObjArea.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LblAreaId.Text = "";
            TxtNombre.Text = "";
            TxtDescripcion.Text = "";
            ChkActivo.Checked = false;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (LblAreaId.Text == "")
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
                        ObjArea = new ClsArea()
                        {
                            AreaId = Convert.ToByte(LblAreaId.Text)
                        };

                        ObjAreaLn.Delete(ref ObjArea);
                        if (ObjArea.MsjError == null)
                        {
                            MessageBox.Show("Baja exitosa");
                            CargarListaArea();
                            LblAreaId.Text = "";
                            TxtNombre.Text = "";
                            TxtDescripcion.Text = "";
                            ChkActivo.Checked = false;
                        }
                        else
                        {
                            MessageBox.Show(ObjArea.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("El registro se desactivara pirmero \n ¿Quieres continuar?", "Mensaje de sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        ObjArea = new ClsArea()
                        {
                            AreaId = Convert.ToByte(LblAreaId.Text),
                            Activo = false
                        };

                        ObjAreaLn.UpdateActivo(ref ObjArea);
                        if (ObjArea.MsjError == null)
                        {
                            MessageBox.Show("La Area fue desactivada");
                            CargarListaArea();
                            LblAreaId.Text = "";
                            TxtNombre.Text = "";
                            TxtDescripcion.Text = "";
                            ChkActivo.Checked = false;
                        }
                        else
                        {
                            MessageBox.Show(ObjArea.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
        #endregion
    }
}
