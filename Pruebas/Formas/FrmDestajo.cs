using Entidades.Usuario;
using LogicaNegocio.Usuario;
using Pruebas.Utilidades;
using System;
using System.Windows.Forms;

namespace Pruebas.Formas
{
    public partial class FrmDestajo : Form
    {
        #region Variables Privadas
        private ClsDestajo ObjDestajo = null;
        private ClsEmpleado ObjEmpleado = null;
        private ClsFraccEstilo ObjFraccEstilo = null;
        private ClsTablasSAP ObjTablasSAP = null;
        private readonly ClsDestajoLn ObjDestajoLn = new ClsDestajoLn();
        private readonly ClsEmpleadoLn ObjEmpleadoLn = new ClsEmpleadoLn();
        private readonly ClsFraccEstiloLn ObjFraccEstiloLn = new ClsFraccEstiloLn();
        private readonly ClsTablasSAPLn ObjTabasSAPLn = new ClsTablasSAPLn();
        private readonly ClsUtilidades ObjUtilidades = new ClsUtilidades();
        #endregion

        #region Metodo Constructor
        public FrmDestajo()
        {
            InitializeComponent();
            CargarListaDestajo();
            CargarListaEmpleado();
            
            //Se llena Combo con el No. de semanas del año
            for (int i = 0; i < 52; i++)
            {
                CbSemana.Items.Add(i + 1);
            }
        }
        #endregion

        #region Metodos Privados
        private void CargarListaDestajo()
        {
            ObjDestajo = new ClsDestajo();
            ObjDestajoLn.Index(ref ObjDestajo);
            if (ObjDestajo.MsjError == null)
            {
                DgvDestajo.DataSource = ObjDestajo.DtResultados;
                ObjUtilidades.FormatoDgvEmpleado(ref DgvDestajo);
            }
            else
            {
                MessageBox.Show(ObjDestajo.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarListaEmpleado()
        {
            ObjEmpleado = new ClsEmpleado();
            ObjEmpleadoLn.IndexActivoVariable(ref ObjEmpleado);
            if (ObjEmpleado.MsjError == null)
            {
                DgvEmpleado.DataSource = ObjEmpleado.DtResultados;
                ObjUtilidades.FormatoDgvPEC(ref DgvEmpleado);
            }
            else
            {
                MessageBox.Show(ObjEmpleado.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Limpiar()
        {
            CbSemana.SelectedIndex = -1;
            LblEmpId.Text = string.Empty;
            LblFraccId.Text = string.Empty;
            LblTrabajador.Text = string.Empty;
            TxtPrograma.Text = string.Empty;
            LblColor.Text = string.Empty;
            LblEstilo.Text = string.Empty;
            LblPP.Text = string.Empty;
            LblPagado.Text = string.Empty;
            LblRestante.Text = string.Empty;
            LblFraccion.Text = string.Empty;
            TxtCantidad.Text = string.Empty;
            DgvFraccion.DataSource = null;
            DgvFraccion.Rows.Clear();

            BtnLimpiar.Enabled = true;
            BtnAgregar.Enabled = true;
            BtnActualizar.Enabled = false;
            BtnEliminar.Enabled = false;
        }
        #endregion

        #region Accion con Botones
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Acciones con DataGridView
        private void DgvEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvEmpleado.Columns[e.ColumnIndex].Name == "SelT")
            {
                LblEmpId.Text = DgvEmpleado.Rows[e.RowIndex].Cells["empID"].Value.ToString();
                LblNombre.Text = DgvEmpleado.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
            }
        }

        private void DgvFraccion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvFraccion.Columns[e.ColumnIndex].Name == "SelF")
            {
                LblFraccId.Text = DgvFraccion.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                LblFraccion.Text = DgvFraccion.Rows[e.RowIndex].Cells["Fraccion"].Value.ToString();
                LblCXE.Text = DgvFraccion.Rows[e.RowIndex].Cells["Cantidad"].Value.ToString();

                ObjDestajo = new ClsDestajo()
                {
                    Programa = TxtPrograma.Text,
                    UFraccId = Convert.ToInt16(LblFraccId.Text)
                };

                ObjDestajoLn.ReadPagados(ref ObjDestajo);
                if (ObjDestajo.MsjError == null)
                {
                    LblPagado.Text = ObjDestajo.Pagado.ToString();
                }
                else
                {
                    MessageBox.Show(ObjDestajo.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                LblRestante.Text = (Convert.ToSingle(LblPP.Text) - Convert.ToSingle(LblPagado.Text)).ToString();
            }
        }
        #endregion

        #region Acciones con TextBox
        private void TxtPrograma_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ObjTablasSAP = new ClsTablasSAP()
                {
                    Programa = TxtPrograma.Text
                };

                ObjTabasSAPLn.ReadPedidoCantidad(ref ObjTablasSAP);
                if (ObjTablasSAP.MsjError == null)
                {
                    LblEstilo.Text = ObjTablasSAP.Estilo;
                    LblColor.Text = ObjTablasSAP.Color;
                    LblPP.Text = ObjTablasSAP.CantPedido.ToString();
                }
                else
                {
                    MessageBox.Show(ObjTablasSAP.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //Revisar si ya se pago algo de la Fraccion y que no este vacia la captura de la Fracción
                if (LblFraccId.Text != string.Empty)
                {
                    ObjDestajo = new ClsDestajo()
                    {
                        Programa = TxtPrograma.Text,
                        UFraccId = Convert.ToInt16(LblFraccId.Text)
                    };

                    ObjDestajoLn.ReadPagados(ref ObjDestajo);
                    if (ObjDestajo.MsjError == null)
                    {
                        LblPagado.Text = ObjDestajo.Pagado.ToString();
                    }
                    else
                    {
                        MessageBox.Show(ObjDestajo.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                //Se carga la lista de fracciones
                ObjFraccEstilo = new ClsFraccEstilo()
                {
                    U_ModDesc = LblEstilo.Text
                };
                ObjFraccEstiloLn.ReadEstilo(ref ObjFraccEstilo);
                if (ObjFraccEstilo.MsjError == null)
                {
                    DgvFraccion.DataSource = ObjFraccEstilo.DtResultados;
                    ObjUtilidades.FormatoDgvPEC(ref DgvFraccion);
                }
                else
                {
                    MessageBox.Show(ObjFraccEstilo.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion
    }
}
