using Entidades.Usuario;
using LogicaNegocio.Usuario;
using Pruebas.Utilidades;
using System;
using System.Windows.Forms;

namespace Pruebas.Formas
{
    public partial class FrmFraccEstilo : Form
    {
        #region Variables Privadas
        private ClsFraccEstilo ObjFraccEstilo = null;
        private ClsTablasSAP ObjTablasSAP = null;
        private ClsFraccion ObjFraccion = null;
        private readonly ClsFraccEstiloLn ObjFraccEstiloLn = new ClsFraccEstiloLn();
        private readonly ClsTablasSAPLn ObjTablasSAPLn = new ClsTablasSAPLn();
        private readonly ClsFraccionLn ObjFraccionLn = new ClsFraccionLn();
        private readonly ClsUtilidades ObjUtilidades = new ClsUtilidades();
        #endregion

        #region Metodo constructor
        public FrmFraccEstilo()
        {
            InitializeComponent();
            CargarListaFraccEstilo();
            CargarListaEstilo();
            CargarListaFraccion();
        }
        #endregion

        #region Metodos Privados
        private void Limpiar()
        {
            LblIdEstilo.Text = string.Empty;
            LblCodEstilo.Text = string.Empty;
            LblNomEstilo.Text = string.Empty;
            LblIdFraccion.Text = string.Empty;
            LblCodFraccion.Text = string.Empty;
            LblNomFraccion.Text = string.Empty;

            BtnLimpiar.Enabled = false;
            BtnActualizar.Enabled = true;
            BtnActualizar.Enabled = false;
            BtnEliminar.Enabled = false;
        }

        private void LimpiarAgregar()
        {
            LblIdFraccion.Text = string.Empty;
            LblCodFraccion.Text = string.Empty;
            LblNomFraccion.Text = string.Empty;

            BtnLimpiar.Enabled = false;
            BtnActualizar.Enabled = true;
            BtnActualizar.Enabled = false;
            BtnEliminar.Enabled = false;
        }

        private void CargarListaFraccEstilo()
        {
            ObjFraccEstilo = new ClsFraccEstilo();
            ObjFraccEstiloLn.Index(ref ObjFraccEstilo);
            if (ObjFraccEstilo.MsjError == null)
            {
                DgvFraccEstilo.DataSource = ObjFraccEstilo.DtResultados;
                ObjUtilidades.FormatoDgvPEC(ref DgvFraccEstilo);
                DgvFraccEstilo.Columns["EditFE"].Width = 20;
                DgvFraccEstilo.Columns["Estilo"].Width = 30;
                DgvFraccEstilo.Columns["U_IdEstilo"].Visible = false;
                DgvFraccEstilo.Columns["U_IdFraccion"].Visible = false;
                DgvFraccEstilo.Columns["U_ModCode"].Visible = false;
                DgvFraccEstilo.Columns["U_CodigoFraccion"].Visible = false;
            }
            else
            {
                MessageBox.Show(ObjFraccEstilo.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarListaEstilo()
        {
            ObjTablasSAP = new ClsTablasSAP();
            ObjTablasSAPLn.IndexModel(ref ObjTablasSAP);
            if (ObjTablasSAP.MsjError == null)
            {
                DgvEstilo.DataSource = ObjTablasSAP.DtResultados;
                ObjUtilidades.FormatoDgvPEC(ref DgvEstilo);
                DgvEstilo.Columns["SelE"].Width = 25;
                DgvEstilo.Columns["Codigo"].Width = 50;
                DgvEstilo.Columns["Code"].Visible = false;
            }
            else
            {
                MessageBox.Show(ObjTablasSAP.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarListaFraccion()
        {
            ObjFraccion = new ClsFraccion();
            ObjFraccionLn.Index(ref ObjFraccion);
            if (ObjFraccion.MsjError == null)
            {
                DgvFraccion.DataSource = ObjFraccion.DtResultados;
                ObjUtilidades.FormatoDgvPEC(ref DgvFraccion);
                DgvFraccion.Columns["SelF"].Width = 7;
                DgvFraccion.Columns["Codigo"].Width = 10;
                DgvFraccion.Columns["FraccionId"].Visible = false;
                DgvFraccion.Columns["Descripcion"].Visible = false;
                DgvFraccion.Columns["Activo"].Visible = false;
                DgvFraccion.Columns["Tiempo"].Visible = false;
                DgvFraccion.Columns["Costo"].Visible = false;
            }
            else
            {
                MessageBox.Show(ObjFraccion.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Acciones con Botones
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
            if (LblCodEstilo.Text.Equals(string.Empty))
            {
                MessageBox.Show("Favor de ingresar un Estilo para relacionar", "Mensaje de sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (LblCodFraccion.Text.Equals(string.Empty))
            {
                MessageBox.Show("Favor de ingresar una Fraccion para relacionar", "Mensaje de sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("¿Quieres relacionar la Fraccion al Estilo?", "Mensaje de sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.OK)
                {
                    ObjFraccEstilo = new ClsFraccEstilo()
                    {
                        U_IdEstilo = LblIdEstilo.Text,
                        U_IdFraccion = Convert.ToInt16(LblIdFraccion.Text),
                        U_ModCode = LblCodEstilo.Text,
                        U_ModDesc = LblNomEstilo.Text,
                        U_CodigoFraccion = LblCodFraccion.Text,
                        U_NameFraccion = LblNomFraccion.Text
                    };

                    ObjFraccEstiloLn.Create(ref ObjFraccEstilo);
                    if (ObjFraccEstilo.MsjError == null)
                    {
                        CargarListaFraccEstilo();
                        LimpiarAgregar();
                    }
                    else
                    {
                        MessageBox.Show(ObjFraccEstilo.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (LblCodEstilo.Text.Equals(string.Empty))
            {
                MessageBox.Show("Favor de ingresar un Estilo para actulizar", "Mensaje de sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (LblCodFraccion.Text.Equals(string.Empty))
            {
                MessageBox.Show("Favor de ingresar una Fraccion para actualizar", "Mensaje de sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("¿Quieres actualizar el registro?", "Mensaje de sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.OK)
                {
                    ObjFraccEstilo = new ClsFraccEstilo()
                    {
                        U_IdEstilo = LblIdEstilo.Text,
                        U_IdFraccion = Convert.ToInt16(LblIdFraccion.Text),
                        U_ModCode = LblCodEstilo.Text,
                        U_ModDesc = LblNomEstilo.Text,
                        U_CodigoFraccion = LblCodFraccion.Text,
                        U_NameFraccion = LblNomFraccion.Text
                    };

                    ObjFraccEstiloLn.Update(ref ObjFraccEstilo);
                    if (ObjFraccEstilo.MsjError == null)
                    {
                        CargarListaFraccEstilo();
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show(ObjFraccEstilo.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Quiere eliminar el registro?", "Mensaje de sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                ObjFraccEstilo = new ClsFraccEstilo()
                {
                    U_IdEstilo = LblCodEstilo.Text,
                    U_IdFraccion = Convert.ToInt32(LblCodEstilo.Text),
                };

                ObjFraccEstiloLn.Delete(ref ObjFraccEstilo);
                if (ObjFraccEstilo.MsjError == null)
                {
                    MessageBox.Show("Registro eliminado");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show(ObjFraccEstilo.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        #region Acciones con DataGridView
        private void DgvEstilo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {   
            if (DgvEstilo.Columns[e.ColumnIndex].Name == "SelE")
            {
                LblIdEstilo.Text = DgvEstilo.Rows[e.RowIndex].Cells["Code"].Value.ToString();
                LblCodEstilo.Text = DgvEstilo.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();
                LblNomEstilo.Text = DgvEstilo.Rows[e.RowIndex].Cells["Estilo"].Value.ToString();
            }
        }

        private void DgvFraccion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvFraccion.Columns[e.ColumnIndex].Name == "SelF")
            {
                LblIdFraccion.Text = DgvFraccion.Rows[e.RowIndex].Cells["FraccionId"].Value.ToString();
                LblCodFraccion.Text = DgvFraccion.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();
                LblNomFraccion.Text = DgvFraccion.Rows[e.RowIndex].Cells["Fraccion"].Value.ToString();
            }
        }
        #endregion
    }
}
