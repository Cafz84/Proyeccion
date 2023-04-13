using Entidades.Usuario;
using LogicaNegocio.Usuario;
using System;
using System.Windows.Forms;

namespace Pruebas.Formas
{
    public partial class FrmReportesAvances : Form
    {
        #region Variables Privadas
        private ClsAvances ObjAvances = null;
        private readonly ClsAvancesLn ObjAvancesLn = new ClsAvancesLn();
        #endregion

        #region Metodo Constructor
        public FrmReportesAvances()
        {
            InitializeComponent();
            CargarDatos();
        }
        #endregion

        #region Metodos Privados
        private void LimpiarGeneral()
        {
            TxtBArea.Clear();
            TxtBCodigo.Clear();
            TxtBColor.Clear();
            TxtBEstilo.Clear();
            TxtBUsuario.Clear();
            TxtBCodigo.Focus();
        }

        private void CargarDatos()
        {
            ObjAvances = new ClsAvances()
            {
                UCodigo = TxtBCodigo.Text,
                Usuario = TxtBUsuario.Text,
                Estilo = TxtBEstilo.Text,
                Color = TxtBColor.Text
            };
            if (TxtBArea.Text == string.Empty)
            {
                ObjAvances.Area = null;
            }
            else
            {
                ObjAvances.Area = Convert.ToChar(TxtBArea.Text);
            }

            ObjAvancesLn.Index(ref ObjAvances);
            if (ObjAvances.MsjError == null)
            {
                DgvGeneral.DataSource = ObjAvances.DtResultados;
                DgvGeneral.Columns["Codigo"].Width = 76;
                DgvGeneral.Columns["Estilo"].Width = 127;
                DgvGeneral.Columns["Color"].Width = 157;
                DgvGeneral.Columns["Usuario"].Width = 85;
                DgvGeneral.Columns["Avance"].Width = 110;
                DgvGeneral.Columns["FEmbarque"].Width = 140;
                DgvGeneral.Columns["FAvance"].Width = 140;
                DgvGeneral.Columns["Area"].Width = 40;
            }
        }

        private void BuscarInfo(string codigo, string usuario, string estilo, string color, string area)
        {
            ObjAvances = new ClsAvances()
            {
                UCodigo = codigo,
                Usuario = usuario,
                Estilo = estilo,
                Color = color
            };
            if (area == string.Empty)
            {
                ObjAvances.Area = null;
            }
            else
            {
                ObjAvances.Area = Convert.ToChar(area);
            }

            ObjAvancesLn.Index(ref ObjAvances);
            if (ObjAvances.MsjError == null)
            {
                DgvGeneral.DataSource = ObjAvances.DtResultados;
            }
        }
        #endregion

        #region Acción con TextBox
        private void TxtBCodigo_TextChanged(object sender, EventArgs e)
        {
            BuscarInfo(TxtBCodigo.Text, TxtBUsuario.Text, TxtBEstilo.Text, TxtBColor.Text, TxtBArea.Text);
        }

        private void TxtBEstilo_TextChanged(object sender, EventArgs e)
        {
            BuscarInfo(TxtBCodigo.Text, TxtBUsuario.Text, TxtBEstilo.Text, TxtBColor.Text, TxtBArea.Text);
        }

        private void TxtBColor_TextChanged(object sender, EventArgs e)
        {
            BuscarInfo(TxtBCodigo.Text, TxtBUsuario.Text, TxtBEstilo.Text, TxtBColor.Text, TxtBArea.Text);
        }

        private void TxtBUsuario_TextChanged(object sender, EventArgs e)
        {
            BuscarInfo(TxtBCodigo.Text, TxtBUsuario.Text, TxtBEstilo.Text, TxtBColor.Text, TxtBArea.Text);
        }

        private void TxtBArea_TextChanged(object sender, EventArgs e)
        {
            BuscarInfo(TxtBCodigo.Text, TxtBUsuario.Text, TxtBEstilo.Text, TxtBColor.Text, TxtBArea.Text);
        }
        #endregion

        #region Acción con botones
        private void BtnLimpiarGeneral_Click(object sender, EventArgs e)
        {
            LimpiarGeneral();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
