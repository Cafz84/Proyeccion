using Entidades.Usuario;
using LogicaNegocio.Usuario;
using Pruebas.Utilidades;
using System;
using System.Windows.Forms;

namespace Pruebas.Formas
{
    public partial class FrmEscaneo : Form
    {
        #region Variables Privadas
        private ClsEscaneo ObjEscaneo = null;
        private ClsTipoEscaneo ObjTipoEscaneo = null;
        private readonly ClsEscaneoLn ObjEscaneoLn = new ClsEscaneoLn();
        private readonly ClsTipoEscaneoLn ObjTipoEscaneoLn = new ClsTipoEscaneoLn();
        private readonly ClsUtilidades ObjUtilidades = new ClsUtilidades();

        private FrmEscaneo intance;
        #endregion

        #region Constructores
        public FrmEscaneo()
        {
            InitializeComponent();
            CargarListaEscaneo();
            CargarListaTipoEscaneo();
        }
        #endregion

        #region Metodos Privados
        private void CargarListaEscaneo()
        {
            ObjEscaneo = new ClsEscaneo();
            ObjEscaneoLn.Index(ref ObjEscaneo);
            if (ObjEscaneo.MsjError == null)
            {
                DgvEscaneo.DataSource = ObjEscaneo.DtResultados;
                ObjUtilidades.FormatoDgvEmpleado(ref DgvEscaneo);
            }
            else
            {
                MessageBox.Show(ObjEscaneo.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Metodos Publicos
        public void CargarListaTipoEscaneo()
        {
            ObjTipoEscaneo = new ClsTipoEscaneo();
            ObjTipoEscaneoLn.CargarCbTipoEscaneo(ref ObjTipoEscaneo);
            if (ObjTipoEscaneo.MsjError == null)
            {
                CbTipoEscaneo.DisplayMember = "Nombre";
                CbTipoEscaneo.ValueMember = "TipoId";
                CbTipoEscaneo.DataSource = ObjTipoEscaneo.DtResultados;
            }
            else
            {
                MessageBox.Show(ObjTipoEscaneo.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Accion con Botones
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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

        private void BtnAbrirEmbarque_Click(object sender, EventArgs e)
        {
            ObjEscaneo = new ClsEscaneo();
            ObjEscaneoLn.ReadEmbarqueMax(ref ObjEscaneo);
            if (ObjEscaneo.MsjError == null)
            {
                LblNEmbarque.Text = ObjEscaneo.NEmbarque.ToString();
            }
            else
            {
                MessageBox.Show(ObjEscaneo.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            BtnAbrirEmbarque.Enabled = false;
            BtnActualizarEmbarque.Enabled = false;
            BtnCerrarEmbarque.Enabled = true;

            TxtPrograma.Enabled = true;
            CbTipoEscaneo.Enabled = true;
            TxtEscaneo.Enabled = true;
            DgvEscaneo.Enabled = true;
        }

        private void BtnActualizarEmbarque_Click(object sender, EventArgs e)
        {

        }

        private void BtnCerrarEmbarque_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
