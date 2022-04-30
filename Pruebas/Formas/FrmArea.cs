using Entidades.Usuario;
using LogicaNegocio.Usuario;
using System;
using System.Windows.Forms;

namespace Proyeccion.Principal
{
    public partial class FrmArea : Form
    {
        private ClsArea ObjArea = null;
        private readonly ClsAreaLn ObjAreaLn = new ClsAreaLn();

        private FrmEmpleados FrmEmpleadosHandler;

        public FrmArea()
        {
            InitializeComponent();
            CargarListaArea();
        }

        public FrmArea(FrmEmpleados frmEmpleados)
        {
            InitializeComponent();
            CargarListaArea();
            FrmEmpleadosHandler = frmEmpleados;
        }

        private void CargarListaArea()
        {
            ObjArea = new ClsArea();
            ObjAreaLn.Index(ref ObjArea);
            if (ObjArea.MsjError == null)
            {
                DgvArea.DataSource = ObjArea.DtResultados;
            }
            else
            {
                MessageBox.Show(ObjArea.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmEmpleadosHandler.bArea = false;
            FrmEmpleadosHandler.CambiarSelectedIndexArea();
        }
    }
}
