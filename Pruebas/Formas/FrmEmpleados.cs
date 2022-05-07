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
        private ClsPais ObjPais = null;
        private ClsEstado ObjEstado = null;
        private readonly ClsEmpleadoLn ObjEmpleadoLn = new ClsEmpleadoLn();
        private readonly ClsAreaLn ObjAreaLn = new ClsAreaLn();
        private readonly ClsDepartamentoLn ObjDepartamentoLn = new ClsDepartamentoLn();
        private readonly ClsPuestoLn ObjPuestoLn = new ClsPuestoLn();
        private readonly ClsPaisLn ObjPaisLn = new ClsPaisLn();
        private readonly ClsEstadoLn ObjEstadoLn = new ClsEstadoLn();

        private FrmEmpleados intance;
        #endregion

        #region Variables Publicas
        public bool bArea, bPuesto, bDepartamento, bPais, bEstado;
        #endregion

        #region Metodo Constructor
        public FrmEmpleados()
        {
            InitializeComponent();
            CargarListaEmpleados();
            CargarListaArea();
            CargarListaDepto();
            CargarListaPuesto();
            CargarListaPais();
            CbArea.SelectedIndex = -1;
            CbDepto.SelectedIndex = -1;
            CbPuesto.SelectedIndex = -1;
            CbPais.SelectedIndex = -1;
            this.CbArea.SelectedIndexChanged += new System.EventHandler(this.CbArea_SelectedIndexChanged);
            this.CbPuesto.SelectedIndexChanged += new System.EventHandler(this.CbPuesto_SelectedIndexChanged);
            this.CbDepto.SelectedIndexChanged += new System.EventHandler(this.CbDepto_SelectedIndexChanged);
            this.CbPais.SelectedIndexChanged += new System.EventHandler(this.CbPais_SelectedIndexChanged);
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
        #endregion

        #region Metodos Publicos
        public void CargarListaArea()
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

        public void CargarListaDepto()
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

        public void CargarListaPuesto()
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

        public void CargarListaPais()
        {
            ObjPais = new ClsPais();
            ObjPaisLn.CargarCbPais(ref ObjPais);
            if (ObjPais.MsjError == null)
            {
                CbPais.DisplayMember = "Name";
                CbPais.ValueMember = "Code";
                CbPais.DataSource = ObjPais.DtResultados;
            }
            else
            {
                MessageBox.Show(ObjPais.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CargarListaEstado()
        {
            ObjEstado = new ClsEstado();
            ObjEstadoLn.CargarCbEstado(ref ObjEstado);
            if (ObjEstado.MsjError == null)
            {
                CbEstado.DisplayMember = "Name";
                CbEstado.ValueMember = "Code";
                CbEstado.DataSource = ObjEstado.DtResultados;
            }
            else
            {
                MessageBox.Show(ObjEstado.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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

        public void CambiarSelectedIndexPais()
        {
            CbPuesto.SelectedIndex = -1;
        }

        public void CambiarSelectedIndexEstado()
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
            if (LblEmpId.Text == "")
            {
                if (TxtNombre.Text == "")
                {
                    MessageBox.Show("Se requiere ingresar un nombre de empleado");
                }
                else
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
                        Email = TxtEmail.Text,
                        Active = 'Y'
                        
                    };

                    ObjEmpleadoLn.Create(ref ObjEmpleado);
                    if (ObjEmpleado.MsjError == null)
                    {
                        MessageBox.Show("Alta exitosa");
                        CargarListaEmpleados();
                    }
                    else
                    {
                        MessageBox.Show(ObjEmpleado.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("No se puede generar alta si se selecciono para editar favor de limpiar primero");
            }
            
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (LblEmpId.Text == "")
            {
                MessageBox.Show("Selecciona un dato para actualizar");
            }
            else
            {
                ObjEmpleado = new ClsEmpleado()
                {
                    EmpID = Convert.ToInt16(LblEmpId.Text),
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

                ObjEmpleadoLn.Update(ref ObjEmpleado);
                if (ObjEmpleado.MsjError == null)
                {
                    MessageBox.Show("El empleado fue actualizado correctamente");
                    CargarListaEmpleados();
                }
                else
                {
                    MessageBox.Show(ObjEmpleado.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (LblEmpId.Text == "")
            {
                MessageBox.Show("Debes seleccionar un empleado para eliminar");
            }
            else
            {
                if (ChkActivo.Checked == false)
                {
                    ObjEmpleado = new ClsEmpleado()
                    {
                        EmpID = Convert.ToByte(LblEmpId.Text)
                    };

                    ObjEmpleadoLn.Delete(ref ObjEmpleado);
                    if (ObjArea.MsjError == null)
                    {
                        MessageBox.Show("Baja exitosa");
                        CargarListaEmpleados();
                    }
                    else
                    {
                        MessageBox.Show(ObjArea.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    ObjEmpleado = new ClsEmpleado()
                    {
                        EmpID = Convert.ToByte(LblEmpId.Text),
                        Active = 'N'
                    };

                    ObjEmpleadoLn.UpdateActivo(ref ObjEmpleado);
                    if (ObjEmpleado.MsjError == null)
                    {
                        MessageBox.Show("El empleado fue desactivado");
                        CargarListaEmpleados();
                    }
                    else
                    {
                        MessageBox.Show(ObjEmpleado.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
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

        private void CbArea_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void CbDepto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void CbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bEstado == true)
            {
                bEstado = false;
            }
            else
            {
                if (CbEstado.Text.Equals("Nuevo Estado"))
                {
                    FrmPais fmPais = new FrmPais(this);
                    fmPais.ShowDialog();
                }
                else
                {
                    bEstado = true;
                }
            }
        }

        private void CbPuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled= true;
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

        private void CbPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bPais == true)
            {
                bPais = false;
            }
            else
            {
                if (CbPuesto.Text.Equals("Nuevo Pais"))
                {
                    FrmPais fmPais = new FrmPais(this);
                    fmPais.ShowDialog();
                }
                else
                {
                    bPais = true;
                }
            }
        }
        #endregion

        #region Acciones con DataGridView
        private void DgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                bArea = false;
                bDepartamento = false;
                bPuesto = false;
                if (DgvEmpleados.Columns[e.ColumnIndex].Name == "Editar")
                {
                    ObjEmpleado = new ClsEmpleado()
                    {
                        EmpID = Convert.ToByte(DgvEmpleados.Rows[e.RowIndex].Cells["ID"].Value.ToString())
                    };

                    LblEmpId.Text = ObjEmpleado.EmpID.ToString();

                    ObjEmpleadoLn.Read(ref ObjEmpleado);
                    TxtNombre.Text = ObjEmpleado.FirstName;
                    TxtNombre2.Text = ObjEmpleado.MiddleName;
                    TxtApellido.Text = ObjEmpleado.LastName;
                    CbArea.SelectedValue = ObjEmpleado.AreaId;
                    CbDepto.SelectedValue = ObjEmpleado.Dept;
                    CbPuesto.SelectedValue = ObjEmpleado.Position;
                    TxtTelCasa.Text = ObjEmpleado.HomeTel;
                    TxtTelMovil.Text = ObjEmpleado.Mobile;
                    TxtEmail.Text = ObjEmpleado.Email;
                    if (ObjEmpleado.Active == 'Y')
                    {
                        ChkActivo.Checked = true;
                    }
                    else
                    {
                        ChkActivo.Checked = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion
    }
}