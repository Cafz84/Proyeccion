using Entidades.Usuario;
using LogicaNegocio.Usuario;
using Pruebas.Utilidades;
using System;
using System.Windows.Forms;

namespace Pruebas.Formas
{
    public partial class FrmRevDestajo : Form
    {
        #region Variables Privadas
        private ClsDestajo ObjDestajo = null;
        private readonly ClsDestajoLn ObjDestajoLn = new ClsDestajoLn();
        private readonly ClsUtilidades ObjUtilidades = new ClsUtilidades();

        private int empId;
        #endregion

        #region Metodos Constructores
        public FrmRevDestajo()
        {
            InitializeComponent();
            CargarListaRevision();
            CargarListaRevisionGpo();
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
                ObjUtilidades.FormatoDgvPEC(ref DgvDestajo);
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
                ObjUtilidades.FormatoDgvPEC(ref DgvDestajoGpo);
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
            }
        }
        #endregion

        
    }
}
