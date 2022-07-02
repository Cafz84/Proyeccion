using Entidades.Usuario;
using LogicaNegocio.Usuario;
using Pruebas.Utilidades;
using System.Windows.Forms;

namespace Pruebas.Formas
{
    public partial class FrmRevDestajo : Form
    {
        #region Variables Privadas
        private ClsDestajo ObjDestajo = null;
        private readonly ClsDestajoLn ObjDestajoLn = new ClsDestajoLn();
        private readonly ClsUtilidades ObjUtilidades = new ClsUtilidades();
        #endregion

        #region Metodos Constructores
        public FrmRevDestajo()
        {
            InitializeComponent();
            CargarListaDestajo();
        }
        #endregion

        #region Metodos Privados
        private void CargarListaDestajo()
        {
            ObjDestajo = new ClsDestajo();
            ObjDestajoLn.IndexRD(ref ObjDestajo);
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
        #endregion

        #region Acciones con TxtBox
        private void TxtBSemana_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void TxtBNombre_TextChanged(object sender, System.EventArgs e)
        {

        }
        #endregion
    }
}
