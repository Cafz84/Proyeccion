using Entidades.Usuario;
using LogicaNegocio.Usuario;
using Proyeccion.Principal;
using Pruebas.Utilidades;
using System;
using System.Windows.Forms;

namespace Pruebas.Formas
{
    public partial class FrmCiudad : Form
    {
        #region Variables Privadas
        private ClsPais ObjPais = null;
        private ClsEstado ObjEstado = null;
        private ClsCiudad ObjCiudad = null;
        private readonly ClsPaisLn ObjPaisLn = new ClsPaisLn();
        private readonly ClsEstadoLn ObjEstadoLn = new ClsEstadoLn();
        private readonly ClsUtilidades ObjUtilidades = new ClsUtilidades();
        private readonly ClsCiudadLn ObjCiudadLn = new ClsCiudadLn();

        private FrmEmpleados FrmEmpleadosHandler;
        #endregion

        #region Variables Publicas
        public string nomEstado;
        #endregion

        #region Metodos Constructores
        public FrmCiudad()
        {
            InitializeComponent();
        }

        public FrmCiudad(FrmEmpleados frmEmpleados, string NameEstado)
        {
            InitializeComponent();
            nomEstado = NameEstado;
            CargarListaCiudad();
            FrmEmpleadosHandler = frmEmpleados;
        }
        #endregion

        #region Metodos Privados
        private void CargarListaCiudad()
        {
            ObjCiudad = new ClsCiudad()
            {
                Estado = nomEstado
            };
            ObjCiudadLn.Index(ref ObjCiudad);
            if (ObjCiudad.MsjError == null)
            {
                DgvCiudad.DataSource = ObjCiudad.DtResultados;
                ObjUtilidades.FormatoDataGridView(ref DgvCiudad);
            }
            else
            {
                MessageBox.Show(ObjPais.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Accion con Botones
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {

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

        private void BtnCerrar_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
