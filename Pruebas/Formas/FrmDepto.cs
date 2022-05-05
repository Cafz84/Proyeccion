using Entidades.Usuario;
using LogicaNegocio.Usuario;
using System;
using System.Windows.Forms;

namespace Proyeccion.Principal
{
    public partial class FrmDepto : Form
    {
        #region Variables Privadas
        private ClsDepartamento ObjDepartamento = null;
        private readonly ClsDepartamentoLn ObjDepartamentoLn = new ClsDepartamentoLn();

        private FrmEmpleados FrmEmpleadosHandler;
        #endregion

        #region Contructores
        public FrmDepto()
        {
            InitializeComponent();
            CargarListaDepto();
        }

        public FrmDepto(FrmEmpleados frmEmpleados)
        {
            InitializeComponent();
            CargarListaDepto();
            FrmEmpleadosHandler = frmEmpleados;
        }
        #endregion

        #region Metodos Privados
        private void CargarListaDepto()
        {
            ObjDepartamento = new ClsDepartamento();
            ObjDepartamentoLn.Index(ref ObjDepartamento);
            if (ObjDepartamento.MsjError == null)
            {
                DgvDepto.DataSource = ObjDepartamento.DtResultados;
            }
            else
            {
                MessageBox.Show(ObjDepartamento.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Accion con DataGridView
        private void DgvDepto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DgvDepto.Columns[e.ColumnIndex].Name == "Editar")
                {
                    ObjDepartamento = new ClsDepartamento()
                    {
                        DeptoId = Convert.ToByte(DgvDepto.Rows[e.RowIndex].Cells["DeptoId"].Value.ToString())
                    };

                    LblDeptoId.Text = ObjDepartamento.DeptoId.ToString();

                    ObjDepartamentoLn.Read(ref ObjDepartamento);
                    TxtNombre.Text = ObjDepartamento.Name;
                    TxtDescripcion.Text = ObjDepartamento.Remarks;
                    ChkActivo.Checked = ObjDepartamento.Activo;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion

        #region Accion con Botones
        private void BtnCerrar_Click(object sender, System.EventArgs e)
        {
            this.Close();
            FrmEmpleadosHandler.bDepartamento = false;
            FrmEmpleadosHandler.CargarListaDepto();
            FrmEmpleadosHandler.CambiarSelectedIndexDpto();
        }

        private void BtnLimpiar_Click(object sender, System.EventArgs e)
        {
            LblDeptoId.Text = "";
            TxtDescripcion.Text = "";
            TxtNombre.Text = "";
            ChkActivo.Checked = false;
        }

        private void BtnAgregar_Click(object sender, System.EventArgs e)
        {
            if (LblDeptoId.Text == "")
            {
                ObjDepartamento = new ClsDepartamento()
                {
                    Name = TxtNombre.Text,
                    Remarks = TxtDescripcion.Text,
                    Activo = true
                };

                ObjDepartamentoLn.Create(ref ObjDepartamento);
                if (ObjDepartamento.MsjError == null)
                {
                    MessageBox.Show("Alta exitosa");
                    CargarListaDepto();
                    LblDeptoId.Text = "";
                    TxtDescripcion.Text = "";
                    TxtNombre.Text = "";
                    ChkActivo.Checked = false;
                }
                else
                {
                    MessageBox.Show(ObjDepartamento.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se puede generar alta si se selecciono para editar favor de limpiar primero");
            }
        }

        private void BtnActualizar_Click(object sender, System.EventArgs e)
        {
            if (LblDeptoId.Text == "")
            {
                MessageBox.Show("Selecciona un dato para actualizar");
            }
            else
            {
                ObjDepartamento = new ClsDepartamento()
                {
                    DeptoId = Convert.ToByte(LblDeptoId.Text),
                    Name = TxtNombre.Text,
                    Remarks = TxtDescripcion.Text,
                    Activo = ChkActivo.Checked
                };

                ObjDepartamentoLn.Update(ref ObjDepartamento);
                if (ObjDepartamento.MsjError == null)
                {
                    MessageBox.Show("La Area fue actualizada correctamente");
                    CargarListaDepto();
                }
                else
                {
                    MessageBox.Show(ObjDepartamento.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (LblDeptoId.Text == "")
            {
                MessageBox.Show("Debes seleccionar un dato para eliminar");
            }
            else
            {
                if (ChkActivo.Checked == false)
                {
                    ObjDepartamento = new ClsDepartamento()
                    {
                        DeptoId = Convert.ToByte(LblDeptoId.Text)
                    };

                    ObjDepartamentoLn.Delete(ref ObjDepartamento);
                    if (ObjDepartamento.MsjError == null)
                    {
                        MessageBox.Show("Baja exitosa");
                        CargarListaDepto();
                        LblDeptoId.Text = "";
                        TxtDescripcion.Text = "";
                        TxtNombre.Text = "";
                        ChkActivo.Checked = false;
                    }
                    else
                    {
                        MessageBox.Show(ObjDepartamento.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    ObjDepartamento = new ClsDepartamento()
                    {
                        DeptoId = Convert.ToByte(LblDeptoId.Text),
                        Activo = false
                    };

                    ObjDepartamentoLn.UpdateActivo(ref ObjDepartamento);
                    if (ObjDepartamento.MsjError == null)
                    {
                        MessageBox.Show("El Departamento fue desactivado");
                        CargarListaDepto();
                        LblDeptoId.Text = "";
                        TxtDescripcion.Text = "";
                        TxtNombre.Text = "";
                        ChkActivo.Checked = false;
                    }
                    else
                    {
                        MessageBox.Show(ObjDepartamento.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        #endregion

    }
}
