using Entidades.Usuario;
using LogicaNegocio.Usuario;
using Pruebas.Formas;
using System;
using System.Windows.Forms;

namespace Proyeccion.Principal
{
    public partial class FrmEmpleados : Form
    {
        #region Variables Privadas
        private ClsEmpleado ObjEmpleado = null;
        private ClsArea ObjArea = null;
        private ClsDepartamento ObjDepartamento= null;
        private ClsPuesto ObjPuesto = null;
        private readonly ClsEmpleadoLn ObjEmpleadoLn = new ClsEmpleadoLn();
        private readonly ClsAreaLn ObjAreaLn = new ClsAreaLn();
        private readonly ClsDepartamentoLn ObjDepartamentoLn = new ClsDepartamentoLn();
        private readonly ClsPuestoLn ObjPuestoLn = new ClsPuestoLn();

        private FrmEmpleados intance;
        #endregion

        #region Variables Publicas
        public bool bArea, bPuesto, bDepartamento;
        #endregion

        #region Metodo Constructor
        public FrmEmpleados()
        {
            InitializeComponent();
            CargarListaEmpleados();
            CargarListaArea();
            CargarListaDepto();
            CargarListaPuesto();
            CbArea.SelectedIndex = -1;
            CbDepto.SelectedIndex = -1;
            CbPuesto.SelectedIndex = -1;
            this.CbArea.SelectedIndexChanged += new System.EventHandler(this.CbArea_SelectedIndexChanged);
            this.CbPuesto.SelectedIndexChanged += new System.EventHandler(this.CbPuesto_SelectedIndexChanged);
            this.CbDepto.SelectedIndexChanged += new System.EventHandler(this.CbDepto_SelectedIndexChanged);
            intance = this;
        }
        #endregion

        #region Metodos Privados
        private void CargarListaEmpleados()
        {
            ObjEmpleado = new ClsEmpleado();
            ObjEmpleadoLn.Index(ref ObjEmpleado);
            if (ObjEmpleado.MsjError == null)
            {
                DgvEmpleados.DataSource = ObjEmpleado.DtResultados;
            }
            else
            {
                MessageBox.Show(ObjEmpleado.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarListaArea()
        {
            bArea = false;
            ObjArea = new ClsArea();
            ObjAreaLn.CargarCbArea(ref ObjArea);
            if (ObjArea.MsjError == null)
            {
                CbArea.DisplayMember = "Area";
                CbArea.ValueMember = "AreaId";
                CbArea.DataSource = ObjArea.DtResultados;
            }
            else
            {
                MessageBox.Show(ObjArea.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarListaDepto()
        {
            ObjDepartamento = new ClsDepartamento();
            ObjDepartamentoLn.CargarCbDepto(ref ObjDepartamento);
            if (ObjDepartamento.MsjError == null)
            {
                CbDepto.DisplayMember = "Name";
                CbDepto.ValueMember = "DeptoId";
                CbDepto.DataSource = ObjDepartamento.DtResultados;
            }
            else
            {
                MessageBox.Show(ObjDepartamento.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarListaPuesto()
        {
            ObjPuesto = new ClsPuesto();
            ObjPuestoLn.CargarCbPuesto(ref ObjPuesto);
            if (ObjPuesto.MsjError == null)
            {
                CbPuesto.DisplayMember = "Puesto";
                CbPuesto.ValueMember = "PuestoId";
                CbPuesto.DataSource = ObjPuesto.DtResultados;
            }
            else
            {
                MessageBox.Show(ObjPuesto.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Metodos Publicos
        public void CambiarSelectedIndexArea()
        {
            CbArea.SelectedIndex = -1;
        }

        public void CambiarSelectedIndexDpto()
        {
            CbDepto.SelectedIndex = -1;
        }

        public void CambiarSelectedIndexPuesto()
        {
            CbPuesto.SelectedIndex = -1;
        }
        #endregion

        #region Acciones con los Botones
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LblEmpId.Text = "";
            TxtNombre.Text = "";
            TxtNombre2.Text = "";
            TxtApellido.Text = "";
            CbArea.SelectedIndex = -1;
            CbDepto.SelectedIndex = -1;
            CbPuesto.SelectedIndex = -1;
            TxtTelCasa.Text = "";
            TxtTelMovil.Text = "";
            TxtEmail.Text = "";
            ChkActivo.Checked = false;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            ObjEmpleado = new ClsEmpleado()
            {
                FirstName = TxtNombre.Text,
                MiddleName = TxtNombre2.Text,
                LastName = TxtApellido.Text,
                JobTitle = CbArea.Text,
                Dept = Convert.ToInt16(CbDepto.SelectedValue),
                Position = Convert.ToInt16(CbPuesto.SelectedValue),
                HomeTel = TxtTelCasa.Text,
                Mobile = TxtTelMovil.Text,
                Email = TxtEmail.Text
            };
            if (ChkActivo.Checked)
            {
                ObjEmpleado.Active = 'Y';
            }
            else
            {
                ObjEmpleado.Active = 'N';
            }
        }
        #endregion

        #region Acciones con los ComboBox
        private void CbArea_DataSourceChanged(object sender, EventArgs e)
        {
            CbArea.SelectedIndex = -1;
        }

        private void CbArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bArea == true)
            {
                bArea = false;
            }
            else
            {
                if (CbArea.Text.Equals("Nueva Area"))
                {
                    FrmArea fmArea = new FrmArea(this);
                    fmArea.ShowDialog();
                }
                else
                {
                    bArea = true;
                }
            }
        }

        private void CbDepto_DataSourceChanged(object sender, EventArgs e)
        {
            CbDepto.SelectedIndex = -1;
        }

        private void CbPuesto_DataSourceChanged(object sender, EventArgs e)
        {
            CbPuesto.SelectedIndex = -1;
        }

        private void CbDepto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bDepartamento == true)
            {
                bDepartamento = false;
            }
            else
            {
                if (CbDepto.Text.Equals("Nuevo Departamento"))
                {
                    FrmDepto fmDepto = new FrmDepto(this);
                    fmDepto.ShowDialog();
                }
                else
                {
                    bDepartamento = true;
                }
            }
        }

        private void CbPuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bPuesto == true)
            {
                bPuesto = false;
            }
            else
            {
                if (CbPuesto.Text.Equals("Nuevo Puesto"))
                {
                    FrmPuesto fmPuesto = new FrmPuesto(this);
                    fmPuesto.ShowDialog();
                }
                else
                {
                    bPuesto = true;
                }
            }
        }
        #endregion
    }
}