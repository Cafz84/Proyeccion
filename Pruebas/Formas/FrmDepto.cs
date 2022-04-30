using Entidades.Usuario;
using LogicaNegocio.Usuario;
using System.Windows.Forms;

namespace Proyeccion.Principal
{
    public partial class FrmDepto : Form
    {
        private ClsDepartamento ObjDepartamento = null;
        private readonly ClsDepartamentoLn ObjAreaLn = new ClsDepartamentoLn();

        private FrmEmpleados FrmEmpleadosHandler;

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

        private void CargarListaDepto()
        {
            ObjDepartamento = new ClsDepartamento();
            ObjAreaLn.Index(ref ObjDepartamento);
            if (ObjDepartamento.MsjError == null)
            {
                DgvDepto.DataSource = ObjDepartamento.DtResultados;
            }
            else
            {
                MessageBox.Show(ObjDepartamento.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
