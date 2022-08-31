using Entidades.Usuario;
using LogicaNegocio.Usuario;
using System;
using System.Windows.Forms;

namespace Pruebas.Formas
{
    public partial class FrmRevDestajo : Form
    {
        #region Variables Privadas
        private ClsDestajo ObjDestajo = null;
        private ClsAportacion ObjAportacion = null;
        private ClsDeduccion ObjDeduccion = null;
        private readonly ClsDestajoLn ObjDestajoLn = new ClsDestajoLn();
        private readonly ClsAportacionLn ObjAportacionLn = new ClsAportacionLn();
        private readonly ClsDeduccionLn ObjDeduccionLn = new ClsDeduccionLn();

        private int empId;
        private readonly FrmRevDestajo instancia;
        #endregion

        #region Metodos Constructores
        public FrmRevDestajo()
        {
            InitializeComponent();
            CargarListaRevision();
            CargarListaRevisionGpo();
            CargarListaAportacion();
            CargarListaDeduccion();
            instancia = this;
        }
        #endregion

        #region Metodos Privados
        private void CargarListaRevision()
        {
            ObjDestajo = new ClsDestajo()
            {
                Nombre = TxtBRNombre.Text
            };
            if (TxtBRSemana.Text == string.Empty)
            {
                ObjDestajo.Semana = 0;
            }
            else
            {
                ObjDestajo.Semana = Convert.ToByte(TxtBRSemana.Text);
            }
            
            ObjDestajoLn.IndexRD(ref ObjDestajo);
            if (ObjDestajo.MsjError == null)
            {
                DgvDestajo.DataSource = ObjDestajo.DtResultados;
                DgvDestajo.Columns["SelRE"].Width = 30;
                DgvDestajo.Columns["Sem"].Width = 35;
                DgvDestajo.Columns["Nombre"].Width = 250;
                DgvDestajo.Columns["UEmpId"].Visible = false;
            }
            else
            {
                MessageBox.Show(ObjDestajo.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarListaRevisionGpo()
        {
            ObjDestajo = new ClsDestajo()
            {
                Nombre = TxtBRGrupo.Text
            };
            if (TxtBRSemana.Text == string.Empty)
            {
                ObjDestajo.Semana = 0;
            }
            else
            {
                ObjDestajo.Semana = Convert.ToByte(TxtBRSemana.Text);
            }

            ObjDestajoLn.IndexRG(ref ObjDestajo);
            if (ObjDestajo.MsjError == null)
            {
                DgvDestajoGpo.DataSource = ObjDestajo.DtResultados;
                DgvDestajoGpo.Columns["SelRG"].Width = 30;
                DgvDestajoGpo.Columns["Sem"].Width = 35;
                DgvDestajoGpo.Columns["Grupo"].Width = 65;
                DgvDestajoGpo.Columns["Pago"].Width = 60;
                DgvDestajoGpo.Columns["UEmpId"].Visible = false;
            }
            else
            {
                MessageBox.Show(ObjDestajo.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Limpiar()
        {
            LblSemana.Text = string.Empty;
            LblNombre.Text = string.Empty;
            LblSueldoBase.Text = "0";
            LblSueldoLimite.Text = "0";
            LblDestajo.Text = "0";
            LblAportaciones.Text = "0";
            LblDeducciones.Text = "0";
            TxtAjusteSueldo.Text = "0";
            LblTotalPago.Text = "0";

        }
        #endregion

        #region Metodos Publicos
        public void CargarListaAportacion()
        {
            ObjAportacion = new ClsAportacion()
            {
                Aportacion = TxtBAportacion.Text
            };

            ObjAportacionLn.IndexRA(ref ObjAportacion);
            if (ObjAportacion.MsjError == null)
            {
                DgvA.DataSource = ObjAportacion.DtResultados;
                DgvA.Columns["IdAportacion"].Visible = false;
                DgvA.Columns["Activo"].Visible = false;
            }
        }

        public void CargarListaDeduccion()
        {
            ObjDeduccion = new ClsDeduccion()
            {
                Deduccion = TxtBDeduccion.Text
            };

            ObjDeduccionLn.IndexRD(ref ObjDeduccion);
            if (ObjDeduccion.MsjError == null)
            {
                DgvD.DataSource = ObjDeduccion.DtResultados;
                DgvD.Columns["IdDeduccion"].Visible = false;
                DgvD.Columns["Activo"].Visible = false;
            }
        }
        #endregion

        #region Acciones con TextBox
        private void TxtBRSemana_TextChanged(object sender, System.EventArgs e)
        {
            CargarListaRevision();
            CargarListaRevisionGpo();
        }

        private void TxtBRNombre_TextChanged(object sender, System.EventArgs e)
        {
            CargarListaRevision();
        }

        private void TxtBRGrupo_TextChanged(object sender, EventArgs e)
        {
            CargarListaRevisionGpo();
        }

        private void TxtAjusteSueldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Si el texto ya contiene un signo negativo, debemos asegurarnos de que el usuario no esté intentando introducir un carácter al principio
            //Si ya hay un signo negativo y el signo negativo no está seleccionado, la pulsación de la tecla no es válida.
            //Esto permite al usuario resaltar parte del texto y reemplazarlo con un signo negativo.
            if ((TxtAjusteSueldo.Text.IndexOf("-") > -1) && TxtAjusteSueldo.SelectionStart == 0 && !TxtAjusteSueldo.SelectedText.Contains("-"))
            {
                e.Handled = true;
            }

            //No aceptara caracteres al menos que sean los siguientes
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }

            //Solo permitir un punto decimal
            if ((e.KeyChar == '.') && (TxtAjusteSueldo.Text.IndexOf(".") > -1))
            {
                e.Handled = true;
            }

            //El signo negativo unicamente puede estar al principio
            if (e.KeyChar == '-')
            {
                //Si el cursor no está al principio del texto, la pulsación de tecla no es válida
                if (TxtAjusteSueldo.SelectionStart > 0)
                {
                    e.Handled = true;
                }

                //Si ya hay un signo negativo y el signo negativo no está seleccionado, la pulsación de la tecla no es válida
                //Esto permite al usuario resaltar parte del texto y reemplazarlo con un signo negativo.
                if (TxtAjusteSueldo.Text.IndexOf("-") > -1 && !TxtAjusteSueldo.SelectedText.Contains("-"))
                {
                    e.Handled = true;
                }
            }
        }
        #endregion

        #region Acciones con DataGridView
        private void DgvDestajo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvDestajo.Columns[e.ColumnIndex].Name == "SelRE")
            {
                empId = Convert.ToByte(DgvDestajo.Rows[e.RowIndex].Cells["UEmpId"].Value.ToString());
                LblNombre.Text = DgvDestajo.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                LblSueldoBase.Text = DgvDestajo.Rows[e.RowIndex].Cells["SBase"].Value.ToString();
                LblSueldoLimite.Text = DgvDestajo.Rows[e.RowIndex].Cells["SLimite"].Value.ToString();
                LblDestajo.Text = DgvDestajo.Rows[e.RowIndex].Cells["Pago"].Value.ToString();
                LblSemana.Text = DgvDestajo.Rows[e.RowIndex].Cells["Sem"].Value.ToString();

                LblTotalPago.Text = Convert.ToString(Convert.ToSingle(LblDestajo.Text) + Convert.ToSingle(LblAportaciones.Text)
                    - Convert.ToSingle(LblDeducciones.Text) + Convert.ToSingle(TxtAjusteSueldo.Text));

                BtnGuardar.Enabled = false;
                BtnActualizar.Enabled = true;
                BtnAutorizar.Enabled = true;
            }
        }

        private void DgvDestajoGpo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        #endregion

        #region Acción con Botones
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void BtnAutorizar_Click(object sender, EventArgs e)
        {

        }

        private void BtnGuardarAF_Click(object sender, EventArgs e)
        {

        }

        private void BtnEliminarAF_Click(object sender, EventArgs e)
        {

        }

        private void BtnGuardarAV_Click(object sender, EventArgs e)
        {

        }

        private void BtnEliminarAV_Click(object sender, EventArgs e)
        {

        }

        private void BtnAF_Click(object sender, EventArgs e)
        {

        }

        private void BtnAV_Click(object sender, EventArgs e)
        {

        }

        private void BtnAAportacion_Click(object sender, EventArgs e)
        {
            FrmAportaciones frmAportaciones = new FrmAportaciones(this);
            frmAportaciones.ShowDialog();
        }

        private void BtnGuardarDF_Click(object sender, EventArgs e)
        {

        }

        private void BtnEliminarDF_Click(object sender, EventArgs e)
        {

        }

        private void BtnGuardarDV_Click(object sender, EventArgs e)
        {

        }

        private void BtnEliminarDV_Click(object sender, EventArgs e)
        {

        }

        private void BtnDF_Click(object sender, EventArgs e)
        {

        }

        private void BtnDV_Click(object sender, EventArgs e)
        {

        }

        private void BtnADeduccion_Click(object sender, EventArgs e)
        {
            FrmDeducciones frmDeducciones = new FrmDeducciones(this);
            frmDeducciones.ShowDialog();
        }
        #endregion
    }
}
