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

        private string idEst;
        private int idFracc;
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
            TxtBEstiloFE.Text = string.Empty;
            TxtBFraccionFE.Text = string.Empty;
            TxtBEstilo.Text = string.Empty;
            TxtBCodEstilo.Text = string.Empty;
            TxtBCodFraccion.Text = string.Empty;
            TxtBFraccion.Text = string.Empty;
            TxtCantidad.Text = "1";
            TxtCosto.Text = "0";
            TxtTiempo.Text = "0";
            TxtCostoMuestra.Text = "0";


            BtnAgregar.Enabled = true;
            BtnActualizar.Enabled = false;
            BtnEliminar.Enabled = false;
        }

        private void LimpiarAgregar()
        {
            LblIdFraccion.Text = string.Empty;
            LblCodFraccion.Text = string.Empty;
            LblNomFraccion.Text = string.Empty;
            TxtCantidad.Text = "1";
            TxtCosto.Text = "0";
            TxtTiempo.Text = "0";
            TxtCostoMuestra.Text = "0";

            BtnActualizar.Enabled = true;
            BtnActualizar.Enabled = false;
            BtnEliminar.Enabled = false;
        }

        private void CargarListaFraccEstilo()
        {
            ObjFraccEstilo = new ClsFraccEstilo()
            {
                U_ModDesc = TxtBEstiloFE.Text,
                U_NameFraccion = TxtBFraccionFE.Text
            };
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
                DgvFraccEstilo.Columns["Cantidad"].Visible = false;
                DgvFraccEstilo.Columns["Tiempo"].Visible = false;
                DgvFraccEstilo.Columns["Costo"].Visible = false;
                DgvFraccEstilo.Columns["CostoMuestra"].Visible = false;
            }
            else
            {
                MessageBox.Show(ObjFraccEstilo.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarListaEstilo()
        {
            ObjTablasSAP = new ClsTablasSAP()
            {
                U_ModCode = TxtBCodEstilo.Text,
                U_ModDesc = TxtBEstilo.Text
            };
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
            ObjFraccion = new ClsFraccion()
            {
                Name = TxtBFraccion.Text,
                Codigo = TxtBCodFraccion.Text
            };
            
            ObjFraccionLn.Index(ref ObjFraccion);
            if (ObjFraccion.MsjError == null)
            {
                DgvFraccion.DataSource = ObjFraccion.DtResultados;
                ObjUtilidades.FormatoDgvPEC(ref DgvFraccion);
                DgvFraccion.Columns["SelF"].Width = 7;
                DgvFraccion.Columns["Codigo"].Width = 30;
                DgvFraccion.Columns["FraccionId"].Visible = false;
                DgvFraccion.Columns["Descripcion"].Visible = false;
                DgvFraccion.Columns["Activo"].Visible = false;
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
                        U_NameFraccion = LblNomFraccion.Text,
                        Cantidad =Convert.ToInt16(TxtCantidad.Text),
                        Tiempo = Convert.ToDouble(TxtTiempo.Text),
                        Costo = Convert.ToDouble(TxtCosto.Text),
                        CostoMuestra = Convert.ToDouble(TxtCostoMuestra.Text)
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
                        IdEstilo = idEst,
                        IdFraccion = idFracc,
                        U_IdEstilo = LblIdEstilo.Text,
                        U_IdFraccion = Convert.ToInt16(LblIdFraccion.Text),
                        U_ModCode = LblCodEstilo.Text,
                        U_ModDesc = LblNomEstilo.Text,
                        U_CodigoFraccion = LblCodFraccion.Text,
                        U_NameFraccion = LblNomFraccion.Text,
                        Cantidad = Convert.ToInt16(TxtCantidad.Text),
                        Tiempo = Convert.ToDouble(TxtTiempo.Text),
                        Costo = Convert.ToDouble(TxtCosto.Text),
                        CostoMuestra = Convert.ToDouble(TxtCostoMuestra.Text)
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

        private void DgvFraccEstilo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvFraccEstilo.Columns[e.ColumnIndex].Name == "EditFE")
            {
                LblIdEstilo.Text = DgvFraccEstilo.Rows[e.RowIndex].Cells["U_IdEstilo"].Value.ToString();
                LblCodEstilo.Text = DgvFraccEstilo.Rows[e.RowIndex].Cells["U_ModCode"].Value.ToString();
                LblNomEstilo.Text = DgvFraccEstilo.Rows[e.RowIndex].Cells["Estilo"].Value.ToString();
                LblIdFraccion.Text = DgvFraccEstilo.Rows[e.RowIndex].Cells["U_IdFraccion"].Value.ToString();
                LblCodFraccion.Text = DgvFraccEstilo.Rows[e.RowIndex].Cells["U_CodigoFraccion"].Value.ToString();
                LblNomFraccion.Text = DgvFraccEstilo.Rows[e.RowIndex].Cells["Fraccion"].Value.ToString();
                TxtCantidad.Text = DgvFraccEstilo.Rows[e.RowIndex].Cells["Cantidad"].Value.ToString();
                TxtTiempo.Text = DgvFraccEstilo.Rows[e.RowIndex].Cells["Tiempo"].Value.ToString();
                TxtCosto.Text = DgvFraccEstilo.Rows[e.RowIndex].Cells["Costo"].Value.ToString();
                TxtCostoMuestra.Text = DgvFraccEstilo.Rows[e.RowIndex].Cells["CostoMuestra"].Value.ToString();
                idEst = LblIdEstilo.Text;
                idFracc = Convert.ToByte(LblIdFraccion.Text);

                BtnLimpiar.Enabled = true;
                BtnAgregar.Enabled = false;
                BtnActualizar.Enabled = true;
                BtnEliminar.Enabled = true;
            }
        }
        #endregion

        #region Acciones con TextBox
        private void TxtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para que solo acepte numeros y no texto
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void TxtTiempo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para que solo acepte numeros y no texto
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            //Para que solo se pueda colocar un solo punto y no mas
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void TxtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para que solo acepte numeros y no texto
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            //Para que solo se pueda colocar un solo punto y no mas
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void TxtCostoMuestra_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para que solo acepte numeros y no texto
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            //Para que solo se pueda colocar un solo punto y no mas
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void TxtBEstiloFE_TextChanged(object sender, EventArgs e)
        {
            CargarListaFraccEstilo();
        }

        private void TxtBFraccionFE_TextChanged(object sender, EventArgs e)
        {
            CargarListaFraccEstilo();
        }

        private void TxtBEstilo_TextChanged(object sender, EventArgs e)
        {
            CargarListaEstilo();
        }

        private void TxtBFraccion_TextChanged(object sender, EventArgs e)
        {
            CargarListaFraccion();
        }

        private void TxtBCodEstilo_TextChanged(object sender, EventArgs e)
        {
            CargarListaEstilo();
        }

        private void TxtBCodFraccion_TextChanged(object sender, EventArgs e)
        {
            CargarListaFraccion();
        }
        #endregion
    }
}
