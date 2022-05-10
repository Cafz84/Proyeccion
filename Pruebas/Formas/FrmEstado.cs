using Entidades.Usuario;
using LogicaNegocio.Usuario;
using Proyeccion.Principal;
using System;
using System.Windows.Forms;

namespace Pruebas.Formas
{
    public partial class FrmEstado : Form
    {
        #region Variables Privadas
        private ClsPais ObjPais = null;
        private ClsEstado ObjEstado = null;
        private readonly ClsPaisLn ObjPaisLn = new ClsPaisLn();
        private readonly ClsEstadoLn ObjEstadoLn = new ClsEstadoLn();

        private FrmEmpleados FrmEmpleadosHandler;
        #endregion

        #region Metodos Constructores
        public FrmEstado()
        {
            InitializeComponent();
            CargarListaEstado();
        }

        public FrmEstado(FrmEmpleados frmEmpleados)
        {
            InitializeComponent();
            CargarListaEstado();
            FrmEmpleadosHandler = frmEmpleados;
        }
        #endregion

        #region Metodos Privados
        private void CargarListaEstado()
        {
            ObjEstado = new ClsEstado();
            ObjEstadoLn.Index(ref ObjEstado);
            if (ObjEstado.MsjError == null)
            {
                DgvEstado.DataSource = ObjEstado.DtResultados;
            }
            else
            {
                MessageBox.Show(ObjPais.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Acciones con Botones
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmEmpleadosHandler.bEstado = false;
            FrmEmpleadosHandler.CargarListaEstado();
            FrmEmpleadosHandler.CambiarSelectedIndexEstado();
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
    }
}
