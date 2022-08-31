using Entidades.Usuario;
using LogicaNegocio.Usuario;
using System;
using System.Windows.Forms;

namespace Pruebas.Formas
{
    public partial class FrmAvances : Form
    {
        #region Variables privadas
        private ClsAvance ObjAvance = null;
        private ClsLoteo ObjLoteo = null;
        private ClsAvances ObjAvances = null;
        readonly private ClsAvanceLn ObjAvanceLn = new ClsAvanceLn();
        readonly private ClsLoteoLn ObjLoteoLn = new ClsLoteoLn();
        readonly private ClsAvancesLn ObjAvancesLn = new ClsAvancesLn();

        private int userId;
        #endregion

        #region Metodos Constructores
        public FrmAvances()
        {
            InitializeComponent();
        }

        public FrmAvances(int id)
        {
            InitializeComponent();
            userId = id;
            CargarDatos();
        }
        #endregion

        #region Metodos Privados
        private void Limpiar()
        {
            TxtCodigo.Clear();
            LblCorrecto.Visible = false;
            LblIncorrecto.Visible = false;
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
                DgvAvances.DataSource = ObjAvances.DtResultados;
            }
        }
        #endregion

        #region Acción con Botones
        private void BtnCerrar_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void BtnLimpiar_Click(object sender, System.EventArgs e)
        {
            Limpiar();
        }
        #endregion

        #region Acción con TextBox
        private void TxtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

            }
        }
        #endregion
    }
}
