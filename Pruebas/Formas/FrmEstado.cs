using Entidades.Usuario;
using LogicaNegocio.Usuario;
using Proyeccion.Principal;
using Pruebas.Utilidades;
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
        private readonly ClsUtilidades ObjUtilidades = new ClsUtilidades();

        private FrmEmpleados FrmEmpleadosHandler;
        #endregion

        #region Variables Publicas
        public string nomPais;
        #endregion

        #region Metodos Constructores
        public FrmEstado()
        {
            InitializeComponent();
            CargarListaEstado();
        }

        public FrmEstado(FrmEmpleados frmEmpleados, string namePais)
        {
            InitializeComponent();
            nomPais = namePais;
            CargarListaEstado();
            FrmEmpleadosHandler = frmEmpleados;
        }
        #endregion

        #region Metodos Privados
        private void CargarListaEstado()
        {
            ObjEstado = new ClsEstado()
            {
                NamePais = nomPais
            };
            ObjEstadoLn.Index(ref ObjEstado);
            if (ObjEstado.MsjError == null)
            {
                DgvEstado.DataSource = ObjEstado.DtResultados;
                ObjUtilidades.FormatoDataGridView(ref DgvEstado);
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
