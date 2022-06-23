using Entidades.Usuario;
using LogicaNegocio.Usuario;
using Pruebas.Formas;
using Pruebas.Utilidades;
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
        private ClsCiudad ObjCiudad = null;
        private readonly ClsUtilidades ObjUtilidades = new ClsUtilidades();
        private readonly ClsEmpleadoLn ObjEmpleadoLn = new ClsEmpleadoLn();
        private readonly ClsAreaLn ObjAreaLn = new ClsAreaLn();
        private readonly ClsDepartamentoLn ObjDepartamentoLn = new ClsDepartamentoLn();
        private readonly ClsPuestoLn ObjPuestoLn = new ClsPuestoLn();
        private readonly ClsPaisLn ObjPaisLn = new ClsPaisLn();
        private readonly ClsEstadoLn ObjEstadoLn = new ClsEstadoLn();
        private readonly ClsCiudadLn ObjCiudadLn = new ClsCiudadLn();

        private readonly FrmEmpleados intance;
        #endregion

        #region Variables Publicas
        bool bEstado = false, bCiudad = false;
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
            this.cbCiudad.SelectedIndexChanged += new System.EventHandler(this.CbCiudad_SelectedIndexChanged);
            intance = this;
            DtpFechaInicio.Format = DateTimePickerFormat.Custom;
            DtpFechaInicio.CustomFormat = " ";
            DtpFechaNacimiento.Format = DateTimePickerFormat.Custom;
            DtpFechaNacimiento.CustomFormat = " ";
            DtpFechaRC.Format = DateTimePickerFormat.Custom;
            DtpFechaRC.CustomFormat = " ";
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
                ObjUtilidades.FormatoDgvEmpleado(ref DgvEmpleados);
            }
            else
            {
                MessageBox.Show(ObjEmpleado.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Metodos Publicos
        public void LimpiarCampos()
        {
            //Formulario Empleados
            LblEmpId.Text = string.Empty;
            TxtNombre.Text = string.Empty;
            TxtNombre2.Text = string.Empty;
            TxtApellido.Text = string.Empty;
            CbArea.SelectedIndex = -1;
            CbDepto.SelectedIndex = -1;
            CbPuesto.SelectedIndex = -1;
            TxtTelCasa.Text = string.Empty;
            TxtTelMovil.Text = string.Empty;
            TxtEmail.Text = string.Empty;
            ChkActivo.Checked = false;

            //TabControl Direccion
            CbPais.Text = string.Empty;
            CbEstado.Text = string.Empty;
            cbCiudad.Text = string.Empty;
            TxtColonia.Text = string.Empty;
            TxtDireccion.Text = string.Empty;
            TxtNoExt.Text = string.Empty;
            TxtNoInt.Text = string.Empty;
            TxtCP.Text = string.Empty;

            //TabControl Gestion
            DtpFechaInicio.Format = DateTimePickerFormat.Custom;
            DtpFechaInicio.CustomFormat = " ";
            DtpFechaRC.Format = DateTimePickerFormat.Custom;
            DtpFechaRC.CustomFormat = " ";
            CbMotivoRC.Text = string.Empty;

            //TabControl Personal
            DtpFechaNacimiento.Format = DateTimePickerFormat.Custom;
            DtpFechaNacimiento.CustomFormat = " ";
            CbSexo.Text = string.Empty;
            CbEstadoCivil.Text = string.Empty;
            TxtNHijos.Text = string.Empty;
            TxtCURP.Text = string.Empty;

            //TabControl Financiera
            TxtSalario.Text = string.Empty;
            TxtSueldoBase.Text = string.Empty;
            TxtSueldoLimite.Text = string.Empty;
            CbUSalario.Text = string.Empty;
            CbUSueldoBase.Text = string.Empty;
            CbUSueldoLimite.Text = string.Empty;

            //Activacion de botones
            BtnAgregar.Enabled = true;
            BtnEliminar.Enabled = false;
            BtnActualizar.Enabled = false;
        }
        
        public void CargarListaArea()
        {
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
            ObjEstado = new ClsEstado()
            {
                Country = CbPais.Text
            };
            ObjEstadoLn.CargarCbEstado(ref ObjEstado);
            if (ObjEstado.MsjError == null)
            {
                bEstado = false;

                CbEstado.DisplayMember = "Name";
                CbEstado.ValueMember = "Code";
                CbEstado.DataSource = ObjEstado.DtResultados;
            }
            else
            {
                MessageBox.Show(ObjEstado.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CargarListaCiudad()
        {
            ObjCiudad = new ClsCiudad()
            {
                Estado = CbEstado.Text
            };
            ObjCiudadLn.CargarCbCiudad(ref ObjCiudad);
            if (ObjCiudad.MsjError == null)
            {
                bCiudad = false;

                cbCiudad.DisplayMember = "Name";
                cbCiudad.ValueMember = "Code";
                cbCiudad.DataSource = ObjCiudad.DtResultados;
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
            CbPais.SelectedIndex = -1;
        }

        public void CambiarSelectedIndexEstado()
        {
            CbEstado.SelectedIndex = -1;
            bEstado = true;
        }

        public void CambiarSelectedIndexCiudad()
        {
            cbCiudad.SelectedIndex = -1;
            bCiudad = true;
        }

        public string NamePais()
        {
            string nombrePais = CbPais.Text;
            return nombrePais;
        }
        #endregion

        #region Acciones con los Botones
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (LblEmpId.Text == string.Empty)
            {
                if (TxtNombre.Text == string.Empty)
                {
                    MessageBox.Show("Se requiere ingresar un nombre de empleado");
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("¿Realmente quiere dar de alta el registro?", "Mensaje de sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.OK)
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
                            Active = 'Y',
                            HomeCountr = CbPais.SelectedValue.ToString(),
                            HomeState = CbEstado.SelectedValue.ToString(),
                            HomeCounty = cbCiudad.SelectedValue.ToString(),
                            HomeCity = cbCiudad.Text,
                            HomeBlock = TxtColonia.Text,
                            HomeStreet = TxtDireccion.Text,
                            StreetNoH = TxtNoExt.Text,
                            HomeBuild = TxtNoInt.Text,
                            HomeZip = TxtCP.Text,
                            Sex = CbSexo.Text[0],
                            NChildren = Convert.ToInt16(TxtNHijos.Text),
                            GovID = TxtCURP.Text,
                            Salary = Convert.ToDecimal(TxtSalario.Text),
                            SueldoBase = Convert.ToDecimal(TxtSueldoBase.Text),
                            SueldoLimite = Convert.ToDecimal(TxtSueldoLimite.Text)
                        };

                        if (DtpFechaInicio.Text == " ")
                        {
                            ObjEmpleado.StartDate = null;
                        }
                        else
                        {
                            ObjEmpleado.StartDate = DtpFechaInicio.Value;
                        }

                        if (DtpFechaRC.Text == " ")
                        {
                            ObjEmpleado.TermDate = null;
                        }
                        else
                        {
                            ObjEmpleado.TermDate = DtpFechaInicio.Value;
                        }

                        if (DtpFechaNacimiento.Text == " ")
                        {
                            ObjEmpleado.BirthDate = null;
                        }
                        else
                        {
                            ObjEmpleado.BirthDate = DtpFechaNacimiento.Value;
                        }

                        if (RbFijo.Checked)
                        {
                            ObjEmpleado.TipoPago = 'F';
                        }
                        else if (RbVariable.Checked)
                        {
                            ObjEmpleado.TipoPago = 'V';
                        }

                        switch (CbEstadoCivil.Text)
                        {
                            case "Soltero/a":
                                ObjEmpleado.MartStatus = 'S';
                                break;
                            case "Casado/a":
                                ObjEmpleado.MartStatus = 'M';
                                break;
                            case "Divorciado/a":
                                ObjEmpleado.MartStatus = 'D';
                                break;
                            case "Viudo/a":
                                ObjEmpleado.MartStatus = 'W';
                                break;
                        }

                        switch (CbUSalario.Text)
                        {
                            case "Hora":
                                ObjEmpleado.SalaryUnit = 'H';
                                break;
                            case "Día":
                                ObjEmpleado.SalaryUnit = 'D';
                                break;
                            case "Semana":
                                ObjEmpleado.SalaryUnit = 'S';
                                break;
                            case "Bisemanal":
                                ObjEmpleado.SalaryUnit = 'B';
                                break;
                            case "Quincenal":
                                ObjEmpleado.SalaryUnit = 'Q';
                                break;
                            case "Mes":
                                ObjEmpleado.SalaryUnit = 'M';
                                break;
                            case "Ejercicio":
                                ObjEmpleado.SalaryUnit = 'E';
                                break;
                        }

                        switch (CbUSueldoBase.Text)
                        {
                            case "Hora":
                                ObjEmpleado.USueldoBase = 'H';
                                break;
                            case "Día":
                                ObjEmpleado.USueldoBase = 'D';
                                break;
                            case "Semana":
                                ObjEmpleado.USueldoBase = 'S';
                                break;
                            case "Bisemanal":
                                ObjEmpleado.USueldoBase = 'B';
                                break;
                            case "Quincenal":
                                ObjEmpleado.USueldoBase = 'Q';
                                break;
                            case "Mes":
                                ObjEmpleado.USueldoBase = 'M';
                                break;
                            case "Ejercicio":
                                ObjEmpleado.USueldoBase = 'E';
                                break;
                        }

                        switch (CbUSueldoLimite.Text)
                        {
                            case "Hora":
                                ObjEmpleado.USueldoLimite = 'H';
                                break;
                            case "Día":
                                ObjEmpleado.USueldoLimite = 'D';
                                break;
                            case "Semana":
                                ObjEmpleado.USueldoLimite = 'S';
                                break;
                            case "Bisemanal":
                                ObjEmpleado.USueldoLimite = 'B';
                                break;
                            case "Quincenal":
                                ObjEmpleado.USueldoLimite = 'Q';
                                break;
                            case "Mes":
                                ObjEmpleado.USueldoLimite = 'M';
                                break;
                            case "Ejercicio":
                                ObjEmpleado.USueldoLimite = 'E';
                                break;
                        }

                        ObjEmpleadoLn.Create(ref ObjEmpleado);
                        if (ObjEmpleado.MsjError == null)
                        {
                            MessageBox.Show("Alta exitosa");
                            CargarListaEmpleados();

                            LimpiarCampos();
                        }
                        else
                        {
                            MessageBox.Show(ObjEmpleado.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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
                DialogResult respuesta = MessageBox.Show("¿En ralidad quiere modificar el registro?", "Mensaje de Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (respuesta == DialogResult.OK)
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
                        Email = TxtEmail.Text,
                        HomeCountr = CbPais.SelectedValue.ToString(),
                        HomeState = CbEstado.SelectedValue.ToString(),
                        HomeCounty = cbCiudad.SelectedValue.ToString(),
                        HomeCity = cbCiudad.Text,
                        HomeBlock = TxtColonia.Text,
                        HomeStreet = TxtDireccion.Text,
                        StreetNoH = TxtNoExt.Text,
                        HomeBuild = TxtNoInt.Text,
                        HomeZip = TxtCP.Text,
                        Sex = CbSexo.Text[0],
                        NChildren = Convert.ToInt16(TxtNHijos.Text),
                        GovID = TxtCURP.Text,
                        Salary = Convert.ToDecimal(TxtSalario.Text),
                        SueldoBase = Convert.ToDecimal(TxtSueldoBase.Text),
                        SueldoLimite = Convert.ToDecimal(TxtSueldoLimite.Text)
                    };

                    if (DtpFechaInicio.Text == " ")
                    {
                        ObjEmpleado.StartDate = null;
                    }
                    else
                    {
                        ObjEmpleado.StartDate = DtpFechaInicio.Value;
                    }

                    if (DtpFechaRC.Text == " ")
                    {
                        ObjEmpleado.TermDate = null;
                    }
                    else
                    {
                        ObjEmpleado.TermDate = DtpFechaInicio.Value;
                    }

                    if (DtpFechaNacimiento.Text == " ")
                    {
                        ObjEmpleado.BirthDate = null;
                    }
                    else
                    {
                        ObjEmpleado.BirthDate = DtpFechaNacimiento.Value;
                    }

                    if (ChkActivo.Checked)
                    {
                        ObjEmpleado.Active = 'Y';
                    }
                    else
                    {
                        ObjEmpleado.Active = 'N';
                    }

                    if (RbFijo.Checked)
                    {
                        ObjEmpleado.TipoPago = 'F';
                    }
                    else if (RbVariable.Checked)
                    {
                        ObjEmpleado.TipoPago = 'V';
                    }

                    switch (CbEstadoCivil.Text)
                    {
                        case "Soltero/a":
                            ObjEmpleado.MartStatus = 'S';
                            break;
                        case "Casado/a":
                            ObjEmpleado.MartStatus = 'M';
                            break;
                        case "Divorciado/a":
                            ObjEmpleado.MartStatus = 'D';
                            break;
                        case "Viudo/a":
                            ObjEmpleado.MartStatus = 'W';
                            break;
                    }

                    switch (CbUSalario.Text)
                    {
                        case "Hora":
                            ObjEmpleado.SalaryUnit = 'H';
                            break;
                        case "Día":
                            ObjEmpleado.SalaryUnit = 'D';
                            break;
                        case "Semana":
                            ObjEmpleado.SalaryUnit = 'S';
                            break;
                        case "Bisemanal":
                            ObjEmpleado.SalaryUnit = 'B';
                            break;
                        case "Quincenal":
                            ObjEmpleado.SalaryUnit = 'Q';
                            break;
                        case "Mes":
                            ObjEmpleado.SalaryUnit = 'M';
                            break;
                        case "Ejercicio":
                            ObjEmpleado.SalaryUnit = 'E';
                            break;
                    }

                    switch (CbUSueldoBase.Text)
                    {
                        case "Hora":
                            ObjEmpleado.USueldoBase = 'H';
                            break;
                        case "Día":
                            ObjEmpleado.USueldoBase = 'D';
                            break;
                        case "Semana":
                            ObjEmpleado.USueldoBase = 'S';
                            break;
                        case "Bisemanal":
                            ObjEmpleado.USueldoBase = 'B';
                            break;
                        case "Quincenal":
                            ObjEmpleado.USueldoBase = 'Q';
                            break;
                        case "Mes":
                            ObjEmpleado.USueldoBase = 'M';
                            break;
                        case "Ejercicio":
                            ObjEmpleado.USueldoBase = 'E';
                            break;
                    }

                    switch (CbUSueldoLimite.Text)
                    {
                        case "Hora":
                            ObjEmpleado.USueldoLimite = 'H';
                            break;
                        case "Día":
                            ObjEmpleado.USueldoLimite = 'D';
                            break;
                        case "Semana":
                            ObjEmpleado.USueldoLimite = 'S';
                            break;
                        case "Bisemanal":
                            ObjEmpleado.USueldoLimite = 'B';
                            break;
                        case "Quincenal":
                            ObjEmpleado.USueldoLimite = 'Q';
                            break;
                        case "Mes":
                            ObjEmpleado.USueldoLimite = 'M';
                            break;
                        case "Ejercicio":
                            ObjEmpleado.USueldoLimite = 'E';
                            break;
                    }

                    ObjEmpleadoLn.Update(ref ObjEmpleado);
                    if (ObjEmpleado.MsjError == null)
                    {
                        MessageBox.Show("El empleado fue actualizado correctamente");
                        CargarListaEmpleados();
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show(ObjEmpleado.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
                    DialogResult respuesta = MessageBox.Show("¿En ralidad quiere eliminar el registro?", "Mensaje de Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.OK)
                    {
                        ObjEmpleado = new ClsEmpleado()
                        {
                            EmpID = Convert.ToByte(LblEmpId.Text)
                        };

                        ObjEmpleadoLn.Delete(ref ObjEmpleado);
                        if (ObjEmpleado.MsjError == null)
                        {
                            MessageBox.Show("Baja exitosa");
                            CargarListaEmpleados();

                            LimpiarCampos();
                        }
                        else
                        {
                            MessageBox.Show(ObjEmpleado.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    DialogResult respuesta = MessageBox.Show("¿En ralidad quiere desactivar el registro?", "Mensaje de Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.OK)
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

                            BtnLimpiar.Enabled = false;
                            BtnActualizar.Enabled = false;
                            BtnAgregar.Enabled = true;
                            BtnEliminar.Enabled = false;

                            LimpiarCampos();
                        }
                        else
                        {
                            MessageBox.Show(ObjEmpleado.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
        #endregion

        #region Acciones con los ComboBox
        
        #region Eventos SelectedIndexChanged
        private void CbArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbArea.Text.Equals("Nueva Area"))
            {
                FrmArea fmArea = new FrmArea(this);
                fmArea.ShowDialog();
            }
        }

        private void CbDepto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbDepto.Text.Equals("Nuevo Departamento"))
            {
                FrmDepto fmDepto = new FrmDepto(this);
                fmDepto.ShowDialog();
            }
        }

        private void CbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bEstado == true)
            {
                if (CbEstado.Text.Equals("Nuevo Estado"))
                {
                    FrmEstado fmEstado = new FrmEstado(this, CbPais.Text);
                    fmEstado.ShowDialog();
                }
            }
            if (CbEstado.Text != "Nuevo Estado" || CbEstado.Text != string.Empty)
            {
                CargarListaCiudad();
                CambiarSelectedIndexCiudad();
            }
        }

        private void CbCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bCiudad == true)
            {
                if (cbCiudad.Text.Equals("Nueva Ciudad"))
                {
                    FrmCiudad fmCiudad = new FrmCiudad(this, CbEstado.Text);
                    fmCiudad.ShowDialog();
                }
            }
        }

        private void CbPuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbPuesto.Text.Equals("Nuevo Puesto"))
            {
                FrmPuesto fmPuesto = new FrmPuesto(this);
                fmPuesto.ShowDialog();
            }
        }

        private void CbPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbPais.Text.Equals("Nuevo Pais"))
            {
                FrmPais fmPais = new FrmPais(this);
                fmPais.ShowDialog();
            }
            CargarListaEstado();
            CambiarSelectedIndexEstado();
        }
        #endregion

        #region Eventos KeyPress
        private void CbArea_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void CbDepto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void CbPais_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled= true;
        }

        private void CbEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        
        private void CbPuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled= true;
        }

        private void cbCiudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void CbMotivoRC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void CbSexo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void CbEstadoCivil_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void CbUSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void CbUSueldoBase_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void CbUSueldoLimite_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        #endregion

        #endregion

        #region Acciones con DataGridView
        private void DgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LimpiarCampos();
            BtnActualizar.Enabled = true;
            BtnEliminar.Enabled = true;
            BtnLimpiar.Enabled = true;
            BtnAgregar.Enabled = false;
            try
            {
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
                    CbPais.SelectedValue = ObjEmpleado.HomeCountr;
                    CbEstado.SelectedValue = ObjEmpleado.HomeState;
                    cbCiudad.SelectedValue = ObjEmpleado.HomeCounty;
                    TxtColonia.Text = ObjEmpleado.HomeBlock;
                    TxtDireccion.Text = ObjEmpleado.HomeStreet;
                    TxtNoExt.Text = ObjEmpleado.StreetNoH;
                    TxtNoInt.Text = ObjEmpleado.HomeBuild;
                    TxtCP.Text = ObjEmpleado.HomeZip;
                    TxtNHijos.Text = Convert.ToString(ObjEmpleado.NChildren);
                    TxtCURP.Text = ObjEmpleado.GovID;
                    TxtSalario.Text = Convert.ToString(ObjEmpleado.Salary);
                    TxtSueldoBase.Text = Convert.ToString(ObjEmpleado.SueldoBase);
                    TxtSueldoLimite.Text = Convert.ToString(ObjEmpleado.SueldoLimite);
                    
                    if (ObjEmpleado.StartDate == null)
                    {
                        DtpFechaInicio.Format = DateTimePickerFormat.Custom;
                        DtpFechaInicio.CustomFormat = " ";
                    }
                    else
                    {
                        DtpFechaInicio.Format = DateTimePickerFormat.Custom;
                        DtpFechaInicio.CustomFormat = "dd/MM/yyyy";
                        DtpFechaInicio.Value = Convert.ToDateTime(ObjEmpleado.StartDate);
                    }

                    if (ObjEmpleado.TermDate == null)
                    {
                        DtpFechaRC.Format = DateTimePickerFormat.Custom;
                        DtpFechaRC.CustomFormat = " ";
                    }
                    else
                    {
                        DtpFechaRC.Format = DateTimePickerFormat.Custom;
                        DtpFechaRC.CustomFormat = "dd/MM/yyyy";
                        DtpFechaRC.Value = Convert.ToDateTime(ObjEmpleado.TermDate);
                    }

                    if (ObjEmpleado.BirthDate == null)
                    {
                        DtpFechaNacimiento.Format = DateTimePickerFormat.Custom;
                        DtpFechaNacimiento.CustomFormat = " ";
                    }
                    else
                    {
                        DtpFechaNacimiento.Format = DateTimePickerFormat.Custom;
                        DtpFechaNacimiento.CustomFormat = "dd/MM/yyyy";
                        DtpFechaNacimiento.Value = Convert.ToDateTime(ObjEmpleado.BirthDate);
                    }

                    if (ObjEmpleado.Active == 'Y')
                    {
                        ChkActivo.Checked = true;
                    }
                    else
                    {
                        ChkActivo.Checked = false;
                    }

                    if (ObjEmpleado.Sex == 'F')
                    {
                        CbSexo.Text = "Femenino";
                    }
                    else
                    {
                        CbSexo.Text = "Masculino";
                    }

                    if (ObjEmpleado.TipoPago == 'F')
                    {
                        RbFijo.Checked = true;
                    }
                    else if (ObjEmpleado.TipoPago == 'V')
                    {
                        RbVariable.Checked = true;
                    }

                    switch (ObjEmpleado.MartStatus)
                    {
                        case 'S':
                            CbEstadoCivil.Text = "Soltero/a";
                            break;
                        case 'M':
                            CbEstadoCivil.Text = "Casado/a";
                            break;
                        case 'D':
                            CbEstadoCivil.Text = "Divorciado/a";
                            break;
                        case 'W':
                            CbEstadoCivil.Text = "Viudo/a";
                            break;
                    }

                    switch (ObjEmpleado.SalaryUnit)
                    {
                        case 'H':
                            CbUSalario.Text = "Hora";
                            break;
                        case 'S':
                            CbUSalario.Text = "Semana";
                            break;
                        case 'B':
                            CbUSalario.Text = "Bisemanal";
                            break;
                        case 'Q':
                            CbUSalario.Text = "Quincenal";
                            break;
                        case 'M':
                            CbUSalario.Text = "Mes";
                            break;
                        case 'E':
                            CbUSalario.Text = "Ejercicio";
                            break;
                        case 'D':
                            CbUSalario.Text = "Día";
                            break;
                    }

                    switch (ObjEmpleado.USueldoBase)
                    {
                        case 'H':
                            CbUSueldoBase.Text = "Hora";
                            break;
                        case 'S':
                            CbUSueldoBase.Text = "Semana";
                            break;
                        case 'B':
                            CbUSueldoBase.Text = "Bisemanal";
                            break;
                        case 'Q':
                            CbUSueldoBase.Text = "Quincenal";
                            break;
                        case 'M':
                            CbUSueldoBase.Text = "Mes";
                            break;
                        case 'E':
                            CbUSueldoBase.Text = "Ejercicio";
                            break;
                        case 'D':
                            CbUSueldoBase.Text = "Día";
                            break;
                    }

                    switch (ObjEmpleado.USueldoLimite)
                    {
                        case 'H':
                            CbUSueldoLimite.Text = "Hora";
                            break;
                        case 'S':
                            CbUSueldoLimite.Text = "Semana";
                            break;
                        case 'B':
                            CbUSueldoLimite.Text = "Bisemanal";
                            break;
                        case 'Q':
                            CbUSueldoLimite.Text = "Quincenal";
                            break;
                        case 'M':
                            CbUSueldoLimite.Text = "Mes";
                            break;
                        case 'E':
                            CbUSueldoLimite.Text = "Ejercicio";
                            break;
                        case 'D':
                            CbUSueldoLimite.Text = "Día";
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion

        #region Acciones con TextBox
        private void TxtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para que solo acepte numeros y no texto
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            //Para que solo se pueda colocar un solo punto y no mas
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void TxtSueldoLimite_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para que solo acepte numeros y no texto
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            //Para que solo se pueda colocar un solo punto y no mas
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void TxtSueldoBase_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para que solo acepte numeros y no texto
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            //Para que solo se pueda colocar un solo punto y no mas
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void TxtNHijos_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para que solo acepte numeros y no texto
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void TxtCP_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para que solo acepte numeros y no texto
            e.Handled = !char.IsDigit(e.KeyChar);
        }
        #endregion

        #region Acciones con DateTimePicker
        private void DtpFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            DtpFechaInicio.Format = DateTimePickerFormat.Custom;
            DtpFechaInicio.CustomFormat = "dd/MM/yyyy";
        }

        private void DtpFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            DtpFechaNacimiento.Format = DateTimePickerFormat.Custom;
            DtpFechaNacimiento.CustomFormat = "dd/MM/yyyy";
        }
        #endregion
    }
}