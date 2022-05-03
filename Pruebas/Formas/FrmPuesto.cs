using Entidades.Usuario;
using LogicaNegocio.Usuario;
using Proyeccion.Principal;
using System;
using System.Windows.Forms;

namespace Pruebas.Formas
{
    public partial class FrmPuesto : Form
    {
        #region Variables Privadas
        private ClsPuesto ObjPuesto = null;
        private readonly ClsPuestoLn ObjPuestoLn = new ClsPuestoLn();

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
            ObjPuesto = new ClsPuesto();
            ObjPuestoLn.Index(ref ObjPuesto);
            if (ObjPuesto.MsjError == null)
            {
                DgvPuesto.DataSource = ObjPuesto.DtResultados;
            }
            else
            {
                MessageBox.Show(ObjPuesto.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Accion con los Botones
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LblPuestoId.Text = "";
            TxtNombre.Text = "";
            TxtDescripcion.Text = "";
            ChkActivo.Checked = false;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (LblPuestoId.Text == "")
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
                }
                else
                {
                    MessageBox.Show(ObjPuesto.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se puede generar alta si se selecciono para editar favor de limpiar primero");
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (LblPuestoId.Text == "")
            {
                MessageBox.Show("Selecciona un dato para actualizar");
            }
            else
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
                    MessageBox.Show("La Area fue actualizada correctamente");
                    CargarListaPuesto();
                }
                else
                {
                    MessageBox.Show(ObjPuesto.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (LblPuestoId.Text == "")
            {
                MessageBox.Show("Debes seleccionar un dato para eliminar");
            }
            else
            {
                if (ChkActivo.Checked == false)
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
                    }
                    else
                    {
                        MessageBox.Show(ObjPuesto.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
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
                    }
                    else
                    {
                        MessageBox.Show(ObjPuesto.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmEmpleadosHandler.bPuesto = false;
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Selecciona un valor correcto");
            }
        }
        #endregion
    }
}
