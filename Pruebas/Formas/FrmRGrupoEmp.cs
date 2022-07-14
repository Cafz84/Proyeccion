using Entidades.Usuario;
using LogicaNegocio.Usuario;
using Pruebas.Utilidades;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Pruebas.Formas
{
    public partial class FrmRGrupoEmp : Form
    {
        #region Variables Privadas
        private ClsRGrupoEmpleado ObjRGrupoEmpleado = null;
        private ClsGrupo ObjGrupo = null;
        private ClsEmpleado ObjEmpleado = null;
        private readonly ClsRGrupoEmpleadoLn ObjRGrupoEmpleadoLn = new ClsRGrupoEmpleadoLn();
        private readonly ClsGrupoLn ObjGrupoLn = new ClsGrupoLn();
        private readonly ClsEmpleadoLn ObjEmpleadoLn = new ClsEmpleadoLn();
        private readonly ClsUtilidades ObjUtilidades = new ClsUtilidades();

        private readonly FrmDestajo FrmDestajoHandler;
        private int idGrupo, idEmp, cidGrupo, cidEmp;
        #endregion

        #region Metodo Constructor
        public FrmRGrupoEmp()
        {
            InitializeComponent();
        }

        public FrmRGrupoEmp(FrmDestajo frmDestajoHandler)
        {
            InitializeComponent();
            CargarListaRGE();
            CargarListaGrupo();
            CargarListaEmpleados();
            FrmDestajoHandler = frmDestajoHandler;
            idGrupo = 0;
            idEmp = 0;
            cidGrupo = 0;
            cidEmp = 0;
        }
        #endregion

        #region Metodos Privados
        private void Limpiar()
        {
            LblGrupo.Text = string.Empty;
            LblEmpleado.Text = string.Empty;
            TxtPorcentaje.Text = string.Empty;
            TxtBEmpleado.Text = string.Empty;
            TxtBGrupo.Text = string.Empty;
            TxtBRGrupo.Text = string.Empty;
            idGrupo = 0;
            idEmp = 0;
            cidEmp = 0;
            cidGrupo = 0;

            BtnAgregar.Enabled = true;
            BtnActualizar.Enabled = false;
            BtnEliminar.Enabled = false;
        }

        private void CargarListaRGE()
        {
            ObjRGrupoEmpleado = new ClsRGrupoEmpleado()
            {
                Grupo = TxtBGrupo.Text
            };

            ObjRGrupoEmpleadoLn.Index(ref ObjRGrupoEmpleado);
            if (ObjRGrupoEmpleado.MsjError == null)
            {
                DgvRelacion.DataSource = ObjRGrupoEmpleado.DtResultados;
                ObjUtilidades.FormatoDgvPEC(ref DgvRelacion);

                DgvRelacion.Columns["Eid"].Visible = false;
                DgvRelacion.Columns["Gid"].Visible = false;
                DgvRelacion.Columns["Editar"].Width = 25;
                DgvRelacion.Columns["Grupo"].Width = 100;
                DgvRelacion.Columns["Porcentaje"].Width = 75;
            }
        }

        private void CargarListaGrupo()
        {
            ObjGrupo = new ClsGrupo()
            {
                Grupo = TxtBRGrupo.Text
            };

            ObjGrupoLn.CargarIndexGrupo(ref ObjGrupo);
            if (ObjGrupo.MsjError == null)
            {
                DgvGrupo.DataSource = ObjGrupo.DtResultados;
                ObjUtilidades.FormatoDgvPEC(ref DgvGrupo);

                DgvGrupo.Columns["Id"].Visible = false;
                DgvGrupo.Columns["SelG"].Width = 25;
                DgvGrupo.Columns["Grupo"].Width = 75;
            }
        }

        private void CargarListaEmpleados()
        {
            ObjEmpleado = new ClsEmpleado()
            {
                Nombre = TxtBEmpleado.Text
            };

            ObjEmpleadoLn.IndexRelacion(ref ObjEmpleado);
            if (ObjEmpleado.MsjError == null)
            {
                DgvEmpleado.DataSource = ObjEmpleado.DtResultados;
                ObjUtilidades.FormatoDgvPEC(ref DgvEmpleado);

                DgvEmpleado.Columns["ID"].Visible = false;
                DgvEmpleado.Columns["SelE"].Width = 25;
                DgvEmpleado.Columns["Empleado"].Width = 250;
            }
        }
        #endregion

        #region Accion con Botones
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmDestajoHandler.CargarListaGrupo();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (cidGrupo != 0)
            {
                if (cidEmp != 0)
                {
                    DialogResult respuesta = MessageBox.Show("¿Quieres agregar la relación?", "Mensaje de sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.OK)
                    {
                        ObjRGrupoEmpleado = new ClsRGrupoEmpleado()
                        {
                            U_GrupoId = cidGrupo,
                            U_EmpId = cidEmp
                        };

                        if (TxtPorcentaje.Text == string.Empty)
                        {
                            ObjRGrupoEmpleado.Porcentaje = 0;
                        }
                        else
                        {
                            ObjRGrupoEmpleado.Porcentaje = Convert.ToSingle(TxtPorcentaje.Text);
                        }

                        ObjRGrupoEmpleadoLn.Create(ref ObjRGrupoEmpleado);
                        if (ObjRGrupoEmpleado.MsjError == null)
                        {
                            MessageBox.Show("Alta exitosa");
                            CargarListaRGE();
                            CargarListaGrupo();
                            Limpiar();
                        }
                        else
                        {
                            MessageBox.Show(ObjRGrupoEmpleado.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No se puede generar la relación si no se a seleccionado un Empleado");
                }
            }
            else
            {
                MessageBox.Show("No se puede generar la relación si no se a seleccionado un Grupo");
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Realmente quieres actualizar el registo?", "Mensaje de sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                ObjRGrupoEmpleado = new ClsRGrupoEmpleado()
                {
                    U_GrupoId = idGrupo,
                    U_EmpId = idEmp,
                    C_GrupoId = cidGrupo,
                    C_EmpId = cidEmp
                };

                if (TxtPorcentaje.Text == string.Empty)
                {
                    ObjRGrupoEmpleado.Porcentaje = 0;
                }
                else
                {
                    ObjRGrupoEmpleado.Porcentaje = Convert.ToSingle(TxtPorcentaje.Text);
                }

                ObjRGrupoEmpleadoLn.Update(ref ObjRGrupoEmpleado);
                if (ObjRGrupoEmpleado.MsjError == null)
                {
                    MessageBox.Show("La Relación fue actualizada correctamente");
                    CargarListaRGE();
                    CargarListaGrupo();
                    Limpiar();
                }
                else
                {
                    MessageBox.Show(ObjRGrupoEmpleado.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (cidGrupo != 0)
            {
                if (cidEmp != 0)
                {
                    DialogResult result = MessageBox.Show("¿Quieres eliminar la relación?", "Mensaje de sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        ObjRGrupoEmpleado = new ClsRGrupoEmpleado()
                        {
                            U_EmpId = idEmp,
                            U_GrupoId = idGrupo
                        };

                        ObjRGrupoEmpleadoLn.Delete(ref ObjRGrupoEmpleado);
                        if (ObjRGrupoEmpleado.MsjError == null)
                        {
                            MessageBox.Show("Baja exitosa");
                            CargarListaRGE();
                            CargarListaGrupo();
                            Limpiar();
                        }
                        else
                        {
                            MessageBox.Show(ObjRGrupoEmpleado.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No se puede eliminar ya que se cambio el Empleado original");
                }
            }
            else
            {
                MessageBox.Show("No se puede eliminar ya que se cambio el Grupo original");
            }
            
        }
        #endregion

        #region Accion con DataGridView
        private void DgvRelacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvRelacion.Columns[e.ColumnIndex].Name == "Editar")
            {
                LblGrupo.Text = DgvRelacion.Rows[e.RowIndex].Cells["Grupo"].Value.ToString();
                LblEmpleado.Text = DgvRelacion.Rows[e.RowIndex].Cells["Empleado"].Value.ToString();
                TxtPorcentaje.Text = DgvRelacion.Rows[e.RowIndex].Cells["Porcentaje"].Value.ToString();
                idGrupo = Convert.ToInt16(DgvRelacion.Rows[e.RowIndex].Cells["Gid"].Value.ToString());
                idEmp = Convert.ToInt16(DgvRelacion.Rows[e.RowIndex].Cells["Eid"].Value.ToString());
                cidGrupo = Convert.ToInt16(DgvRelacion.Rows[e.RowIndex].Cells["Gid"].Value.ToString());
                cidEmp = Convert.ToInt16(DgvRelacion.Rows[e.RowIndex].Cells["Eid"].Value.ToString());

                BtnAgregar.Enabled = false;
                BtnActualizar.Enabled = true;
                BtnEliminar.Enabled = true;
            }
        }

        private void DgvGrupo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvGrupo.Columns[e.ColumnIndex].Name == "SelG")
            {
                LblGrupo.Text = DgvGrupo.Rows[e.RowIndex].Cells["Grupo"].Value.ToString();
                cidGrupo = Convert.ToInt16(DgvGrupo.Rows[e.RowIndex].Cells["Id"].Value.ToString());
            }
        }

        private void DgvEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvEmpleado.Columns[e.ColumnIndex].Name == "SelE")
            {
                LblEmpleado.Text = DgvEmpleado.Rows[e.RowIndex].Cells["Empleado"].Value.ToString();
                cidEmp = Convert.ToInt16(DgvEmpleado.Rows[e.RowIndex].Cells["ID"].Value.ToString());
            }
        }
        #endregion

        #region Accion con TextBox
        private void TxtBGrupo_TextChanged(object sender, EventArgs e)
        {
            CargarListaRGE();
        }

        private void TxtBEmpleado_TextChanged(object sender, EventArgs e)
        {
            CargarListaEmpleados();
        }

        private void TxtBRGrupo_TextChanged(object sender, EventArgs e)
        {
            CargarListaGrupo();
        }
        #endregion

        #region Mover la ventana
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void FrmRGrupoEmp_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void LblTituloRelacionar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
    }
}
