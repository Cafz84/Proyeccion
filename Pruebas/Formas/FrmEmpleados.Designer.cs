namespace Proyeccion.Principal
{
    partial class FrmEmpleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmpleados));
            this.TcEmpleados = new System.Windows.Forms.TabControl();
            this.TpIndex = new System.Windows.Forms.TabPage();
            this.DgvEmpleados = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.TpDireccion = new System.Windows.Forms.TabPage();
            this.cbCiudad = new System.Windows.Forms.ComboBox();
            this.CbEstado = new System.Windows.Forms.ComboBox();
            this.CbPais = new System.Windows.Forms.ComboBox();
            this.TxtNoInt = new System.Windows.Forms.TextBox();
            this.LblNoInt = new System.Windows.Forms.Label();
            this.LblCiudad = new System.Windows.Forms.Label();
            this.TxtCP = new System.Windows.Forms.TextBox();
            this.LblCP = new System.Windows.Forms.Label();
            this.TxtNoExt = new System.Windows.Forms.TextBox();
            this.LblNoExt = new System.Windows.Forms.Label();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.LblDireccion = new System.Windows.Forms.Label();
            this.TxtColonia = new System.Windows.Forms.TextBox();
            this.LblColonia = new System.Windows.Forms.Label();
            this.LblEstado = new System.Windows.Forms.Label();
            this.LblPais = new System.Windows.Forms.Label();
            this.TpGestion = new System.Windows.Forms.TabPage();
            this.LblMotivoRC = new System.Windows.Forms.Label();
            this.CbMotivoRC = new System.Windows.Forms.ComboBox();
            this.DtpFechaRC = new System.Windows.Forms.DateTimePicker();
            this.LblFechaRC = new System.Windows.Forms.Label();
            this.DtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.LblFechaInicio = new System.Windows.Forms.Label();
            this.TpPersonal = new System.Windows.Forms.TabPage();
            this.LblCURP = new System.Windows.Forms.Label();
            this.TxtCURP = new System.Windows.Forms.TextBox();
            this.LblNHijos = new System.Windows.Forms.Label();
            this.CbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.TxtNHijos = new System.Windows.Forms.TextBox();
            this.LblEstdoCivil = new System.Windows.Forms.Label();
            this.DtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.LblFechaNacimiento = new System.Windows.Forms.Label();
            this.LblSexo = new System.Windows.Forms.Label();
            this.CbSexo = new System.Windows.Forms.ComboBox();
            this.TpFinanciera = new System.Windows.Forms.TabPage();
            this.GbTipoPago = new System.Windows.Forms.GroupBox();
            this.RbVariable = new System.Windows.Forms.RadioButton();
            this.RbFijo = new System.Windows.Forms.RadioButton();
            this.CbUSueldoLimite = new System.Windows.Forms.ComboBox();
            this.CbUSueldoBase = new System.Windows.Forms.ComboBox();
            this.CbUSalario = new System.Windows.Forms.ComboBox();
            this.TxtSueldoLimite = new System.Windows.Forms.TextBox();
            this.LblSueldoLimite = new System.Windows.Forms.Label();
            this.TxtSueldoBase = new System.Windows.Forms.TextBox();
            this.LblSueldoBase = new System.Windows.Forms.Label();
            this.TxtSalario = new System.Windows.Forms.TextBox();
            this.LblSalario = new System.Windows.Forms.Label();
            this.LblTituloUsuario = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.PictureBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblIdEmpleado = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblApellido = new System.Windows.Forms.Label();
            this.LblArea = new System.Windows.Forms.Label();
            this.LblTelCasa = new System.Windows.Forms.Label();
            this.LblTelMovil = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblEmpId = new System.Windows.Forms.Label();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtTelCasa = new System.Windows.Forms.TextBox();
            this.TxtTelMovil = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtNombre2 = new System.Windows.Forms.TextBox();
            this.LblNombre2 = new System.Windows.Forms.Label();
            this.ChkActivo = new System.Windows.Forms.CheckBox();
            this.LblDpto = new System.Windows.Forms.Label();
            this.LblPuesto = new System.Windows.Forms.Label();
            this.CbArea = new System.Windows.Forms.ComboBox();
            this.CbDepto = new System.Windows.Forms.ComboBox();
            this.CbPuesto = new System.Windows.Forms.ComboBox();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.TcEmpleados.SuspendLayout();
            this.TpIndex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmpleados)).BeginInit();
            this.TpDireccion.SuspendLayout();
            this.TpGestion.SuspendLayout();
            this.TpPersonal.SuspendLayout();
            this.TpFinanciera.SuspendLayout();
            this.GbTipoPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // TcEmpleados
            // 
            this.TcEmpleados.Controls.Add(this.TpIndex);
            this.TcEmpleados.Controls.Add(this.TpDireccion);
            this.TcEmpleados.Controls.Add(this.TpGestion);
            this.TcEmpleados.Controls.Add(this.TpPersonal);
            this.TcEmpleados.Controls.Add(this.TpFinanciera);
            this.TcEmpleados.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TcEmpleados.Location = new System.Drawing.Point(12, 247);
            this.TcEmpleados.Name = "TcEmpleados";
            this.TcEmpleados.SelectedIndex = 0;
            this.TcEmpleados.Size = new System.Drawing.Size(1056, 406);
            this.TcEmpleados.TabIndex = 0;
            // 
            // TpIndex
            // 
            this.TpIndex.Controls.Add(this.DgvEmpleados);
            this.TpIndex.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TpIndex.Location = new System.Drawing.Point(4, 26);
            this.TpIndex.Name = "TpIndex";
            this.TpIndex.Padding = new System.Windows.Forms.Padding(3);
            this.TpIndex.Size = new System.Drawing.Size(1048, 376);
            this.TpIndex.TabIndex = 0;
            this.TpIndex.Text = "Index";
            this.TpIndex.UseVisualStyleBackColor = true;
            // 
            // DgvEmpleados
            // 
            this.DgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar});
            this.DgvEmpleados.Location = new System.Drawing.Point(0, 0);
            this.DgvEmpleados.Name = "DgvEmpleados";
            this.DgvEmpleados.Size = new System.Drawing.Size(1048, 376);
            this.DgvEmpleados.TabIndex = 0;
            this.DgvEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEmpleados_CellContentClick);
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = ((System.Drawing.Image)(resources.GetObject("Editar.Image")));
            this.Editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Editar.Name = "Editar";
            this.Editar.Width = 55;
            // 
            // TpDireccion
            // 
            this.TpDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.TpDireccion.Controls.Add(this.cbCiudad);
            this.TpDireccion.Controls.Add(this.CbEstado);
            this.TpDireccion.Controls.Add(this.CbPais);
            this.TpDireccion.Controls.Add(this.TxtNoInt);
            this.TpDireccion.Controls.Add(this.LblNoInt);
            this.TpDireccion.Controls.Add(this.LblCiudad);
            this.TpDireccion.Controls.Add(this.TxtCP);
            this.TpDireccion.Controls.Add(this.LblCP);
            this.TpDireccion.Controls.Add(this.TxtNoExt);
            this.TpDireccion.Controls.Add(this.LblNoExt);
            this.TpDireccion.Controls.Add(this.TxtDireccion);
            this.TpDireccion.Controls.Add(this.LblDireccion);
            this.TpDireccion.Controls.Add(this.TxtColonia);
            this.TpDireccion.Controls.Add(this.LblColonia);
            this.TpDireccion.Controls.Add(this.LblEstado);
            this.TpDireccion.Controls.Add(this.LblPais);
            this.TpDireccion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TpDireccion.Location = new System.Drawing.Point(4, 26);
            this.TpDireccion.Name = "TpDireccion";
            this.TpDireccion.Padding = new System.Windows.Forms.Padding(3);
            this.TpDireccion.Size = new System.Drawing.Size(1048, 376);
            this.TpDireccion.TabIndex = 1;
            this.TpDireccion.Text = "Dirección";
            // 
            // cbCiudad
            // 
            this.cbCiudad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.cbCiudad.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.cbCiudad.FormattingEnabled = true;
            this.cbCiudad.Location = new System.Drawing.Point(103, 79);
            this.cbCiudad.Name = "cbCiudad";
            this.cbCiudad.Size = new System.Drawing.Size(307, 29);
            this.cbCiudad.TabIndex = 47;
            this.cbCiudad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbCiudad_KeyPress);
            // 
            // CbEstado
            // 
            this.CbEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.CbEstado.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.CbEstado.FormattingEnabled = true;
            this.CbEstado.Location = new System.Drawing.Point(103, 44);
            this.CbEstado.Name = "CbEstado";
            this.CbEstado.Size = new System.Drawing.Size(307, 29);
            this.CbEstado.TabIndex = 46;
            this.CbEstado.SelectedIndexChanged += new System.EventHandler(this.CbEstado_SelectedIndexChanged);
            this.CbEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CbEstado_KeyPress);
            // 
            // CbPais
            // 
            this.CbPais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.CbPais.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.CbPais.FormattingEnabled = true;
            this.CbPais.Location = new System.Drawing.Point(103, 9);
            this.CbPais.Name = "CbPais";
            this.CbPais.Size = new System.Drawing.Size(307, 29);
            this.CbPais.TabIndex = 45;
            this.CbPais.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CbPais_KeyPress);
            // 
            // TxtNoInt
            // 
            this.TxtNoInt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.TxtNoInt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNoInt.Location = new System.Drawing.Point(299, 189);
            this.TxtNoInt.Name = "TxtNoInt";
            this.TxtNoInt.Size = new System.Drawing.Size(111, 31);
            this.TxtNoInt.TabIndex = 43;
            // 
            // LblNoInt
            // 
            this.LblNoInt.AutoSize = true;
            this.LblNoInt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNoInt.ForeColor = System.Drawing.Color.White;
            this.LblNoInt.Location = new System.Drawing.Point(220, 192);
            this.LblNoInt.Name = "LblNoInt";
            this.LblNoInt.Size = new System.Drawing.Size(80, 22);
            this.LblNoInt.TabIndex = 44;
            this.LblNoInt.Text = "No. Int.:";
            // 
            // LblCiudad
            // 
            this.LblCiudad.AutoSize = true;
            this.LblCiudad.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCiudad.ForeColor = System.Drawing.Color.White;
            this.LblCiudad.Location = new System.Drawing.Point(18, 81);
            this.LblCiudad.Name = "LblCiudad";
            this.LblCiudad.Size = new System.Drawing.Size(84, 22);
            this.LblCiudad.TabIndex = 40;
            this.LblCiudad.Text = "Ciudad:";
            // 
            // TxtCP
            // 
            this.TxtCP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.TxtCP.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCP.Location = new System.Drawing.Point(103, 226);
            this.TxtCP.Name = "TxtCP";
            this.TxtCP.Size = new System.Drawing.Size(307, 31);
            this.TxtCP.TabIndex = 37;
            this.TxtCP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCP_KeyPress);
            // 
            // LblCP
            // 
            this.LblCP.AutoSize = true;
            this.LblCP.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCP.ForeColor = System.Drawing.Color.White;
            this.LblCP.Location = new System.Drawing.Point(52, 229);
            this.LblCP.Name = "LblCP";
            this.LblCP.Size = new System.Drawing.Size(51, 22);
            this.LblCP.TabIndex = 38;
            this.LblCP.Text = "C.P.:";
            // 
            // TxtNoExt
            // 
            this.TxtNoExt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.TxtNoExt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNoExt.Location = new System.Drawing.Point(103, 189);
            this.TxtNoExt.Name = "TxtNoExt";
            this.TxtNoExt.Size = new System.Drawing.Size(111, 31);
            this.TxtNoExt.TabIndex = 35;
            // 
            // LblNoExt
            // 
            this.LblNoExt.AutoSize = true;
            this.LblNoExt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNoExt.ForeColor = System.Drawing.Color.White;
            this.LblNoExt.Location = new System.Drawing.Point(21, 192);
            this.LblNoExt.Name = "LblNoExt";
            this.LblNoExt.Size = new System.Drawing.Size(82, 22);
            this.LblNoExt.TabIndex = 36;
            this.LblNoExt.Text = "No. Ext.:";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.TxtDireccion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDireccion.Location = new System.Drawing.Point(103, 152);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(307, 31);
            this.TxtDireccion.TabIndex = 33;
            // 
            // LblDireccion
            // 
            this.LblDireccion.AutoSize = true;
            this.LblDireccion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDireccion.ForeColor = System.Drawing.Color.White;
            this.LblDireccion.Location = new System.Drawing.Point(2, 156);
            this.LblDireccion.Name = "LblDireccion";
            this.LblDireccion.Size = new System.Drawing.Size(101, 22);
            this.LblDireccion.TabIndex = 34;
            this.LblDireccion.Text = "Dirección:";
            // 
            // TxtColonia
            // 
            this.TxtColonia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.TxtColonia.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtColonia.Location = new System.Drawing.Point(103, 115);
            this.TxtColonia.Name = "TxtColonia";
            this.TxtColonia.Size = new System.Drawing.Size(307, 31);
            this.TxtColonia.TabIndex = 31;
            // 
            // LblColonia
            // 
            this.LblColonia.AutoSize = true;
            this.LblColonia.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblColonia.ForeColor = System.Drawing.Color.White;
            this.LblColonia.Location = new System.Drawing.Point(18, 118);
            this.LblColonia.Name = "LblColonia";
            this.LblColonia.Size = new System.Drawing.Size(85, 22);
            this.LblColonia.TabIndex = 32;
            this.LblColonia.Text = "Colonia:";
            // 
            // LblEstado
            // 
            this.LblEstado.AutoSize = true;
            this.LblEstado.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEstado.ForeColor = System.Drawing.Color.White;
            this.LblEstado.Location = new System.Drawing.Point(26, 46);
            this.LblEstado.Name = "LblEstado";
            this.LblEstado.Size = new System.Drawing.Size(77, 22);
            this.LblEstado.TabIndex = 30;
            this.LblEstado.Text = "Estado:";
            // 
            // LblPais
            // 
            this.LblPais.AutoSize = true;
            this.LblPais.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPais.ForeColor = System.Drawing.Color.White;
            this.LblPais.Location = new System.Drawing.Point(54, 9);
            this.LblPais.Name = "LblPais";
            this.LblPais.Size = new System.Drawing.Size(49, 22);
            this.LblPais.TabIndex = 28;
            this.LblPais.Text = "Pais:";
            // 
            // TpGestion
            // 
            this.TpGestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.TpGestion.Controls.Add(this.LblMotivoRC);
            this.TpGestion.Controls.Add(this.CbMotivoRC);
            this.TpGestion.Controls.Add(this.DtpFechaRC);
            this.TpGestion.Controls.Add(this.LblFechaRC);
            this.TpGestion.Controls.Add(this.DtpFechaInicio);
            this.TpGestion.Controls.Add(this.LblFechaInicio);
            this.TpGestion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TpGestion.Location = new System.Drawing.Point(4, 26);
            this.TpGestion.Name = "TpGestion";
            this.TpGestion.Size = new System.Drawing.Size(1048, 376);
            this.TpGestion.TabIndex = 2;
            this.TpGestion.Text = "Gestión";
            // 
            // LblMotivoRC
            // 
            this.LblMotivoRC.AutoSize = true;
            this.LblMotivoRC.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMotivoRC.ForeColor = System.Drawing.Color.White;
            this.LblMotivoRC.Location = new System.Drawing.Point(12, 90);
            this.LblMotivoRC.Name = "LblMotivoRC";
            this.LblMotivoRC.Size = new System.Drawing.Size(309, 22);
            this.LblMotivoRC.TabIndex = 81;
            this.LblMotivoRC.Text = "Motivo de recesión del contrato:";
            // 
            // CbMotivoRC
            // 
            this.CbMotivoRC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.CbMotivoRC.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.CbMotivoRC.FormattingEnabled = true;
            this.CbMotivoRC.Location = new System.Drawing.Point(323, 88);
            this.CbMotivoRC.Name = "CbMotivoRC";
            this.CbMotivoRC.Size = new System.Drawing.Size(180, 29);
            this.CbMotivoRC.TabIndex = 80;
            this.CbMotivoRC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CbMotivoRC_KeyPress);
            // 
            // DtpFechaRC
            // 
            this.DtpFechaRC.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaRC.Location = new System.Drawing.Point(321, 54);
            this.DtpFechaRC.Name = "DtpFechaRC";
            this.DtpFechaRC.Size = new System.Drawing.Size(89, 23);
            this.DtpFechaRC.TabIndex = 48;
            // 
            // LblFechaRC
            // 
            this.LblFechaRC.AutoSize = true;
            this.LblFechaRC.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaRC.ForeColor = System.Drawing.Color.White;
            this.LblFechaRC.Location = new System.Drawing.Point(12, 55);
            this.LblFechaRC.Name = "LblFechaRC";
            this.LblFechaRC.Size = new System.Drawing.Size(303, 22);
            this.LblFechaRC.TabIndex = 47;
            this.LblFechaRC.Text = "Fecha de recesión del contrato:";
            // 
            // DtpFechaInicio
            // 
            this.DtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaInicio.Location = new System.Drawing.Point(321, 16);
            this.DtpFechaInicio.Name = "DtpFechaInicio";
            this.DtpFechaInicio.Size = new System.Drawing.Size(89, 23);
            this.DtpFechaInicio.TabIndex = 46;
            this.DtpFechaInicio.ValueChanged += new System.EventHandler(this.DtpFechaInicio_ValueChanged);
            // 
            // LblFechaInicio
            // 
            this.LblFechaInicio.AutoSize = true;
            this.LblFechaInicio.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaInicio.ForeColor = System.Drawing.Color.White;
            this.LblFechaInicio.Location = new System.Drawing.Point(12, 16);
            this.LblFechaInicio.Name = "LblFechaInicio";
            this.LblFechaInicio.Size = new System.Drawing.Size(155, 22);
            this.LblFechaInicio.TabIndex = 45;
            this.LblFechaInicio.Text = "Fecha de Inicio:";
            // 
            // TpPersonal
            // 
            this.TpPersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.TpPersonal.Controls.Add(this.LblCURP);
            this.TpPersonal.Controls.Add(this.TxtCURP);
            this.TpPersonal.Controls.Add(this.LblNHijos);
            this.TpPersonal.Controls.Add(this.CbEstadoCivil);
            this.TpPersonal.Controls.Add(this.TxtNHijos);
            this.TpPersonal.Controls.Add(this.LblEstdoCivil);
            this.TpPersonal.Controls.Add(this.DtpFechaNacimiento);
            this.TpPersonal.Controls.Add(this.LblFechaNacimiento);
            this.TpPersonal.Controls.Add(this.LblSexo);
            this.TpPersonal.Controls.Add(this.CbSexo);
            this.TpPersonal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TpPersonal.Location = new System.Drawing.Point(4, 26);
            this.TpPersonal.Name = "TpPersonal";
            this.TpPersonal.Size = new System.Drawing.Size(1048, 376);
            this.TpPersonal.TabIndex = 3;
            this.TpPersonal.Text = "Personal";
            // 
            // LblCURP
            // 
            this.LblCURP.AutoSize = true;
            this.LblCURP.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCURP.ForeColor = System.Drawing.Color.White;
            this.LblCURP.Location = new System.Drawing.Point(12, 171);
            this.LblCURP.Name = "LblCURP";
            this.LblCURP.Size = new System.Drawing.Size(65, 22);
            this.LblCURP.TabIndex = 90;
            this.LblCURP.Text = "CURP:";
            // 
            // TxtCURP
            // 
            this.TxtCURP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.TxtCURP.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCURP.Location = new System.Drawing.Point(83, 168);
            this.TxtCURP.MaxLength = 50;
            this.TxtCURP.Name = "TxtCURP";
            this.TxtCURP.Size = new System.Drawing.Size(327, 31);
            this.TxtCURP.TabIndex = 89;
            // 
            // LblNHijos
            // 
            this.LblNHijos.AutoSize = true;
            this.LblNHijos.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNHijos.ForeColor = System.Drawing.Color.White;
            this.LblNHijos.Location = new System.Drawing.Point(12, 134);
            this.LblNHijos.Name = "LblNHijos";
            this.LblNHijos.Size = new System.Drawing.Size(176, 22);
            this.LblNHijos.TabIndex = 88;
            this.LblNHijos.Text = "Cantidad de hijos:";
            // 
            // CbEstadoCivil
            // 
            this.CbEstadoCivil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.CbEstadoCivil.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.CbEstadoCivil.FormattingEnabled = true;
            this.CbEstadoCivil.Items.AddRange(new object[] {
            "Soltero/a",
            "Casado/a",
            "Divorciado/a",
            "Viudo/a"});
            this.CbEstadoCivil.Location = new System.Drawing.Point(134, 90);
            this.CbEstadoCivil.Name = "CbEstadoCivil";
            this.CbEstadoCivil.Size = new System.Drawing.Size(276, 29);
            this.CbEstadoCivil.TabIndex = 87;
            this.CbEstadoCivil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CbEstadoCivil_KeyPress);
            // 
            // TxtNHijos
            // 
            this.TxtNHijos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.TxtNHijos.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNHijos.Location = new System.Drawing.Point(188, 131);
            this.TxtNHijos.MaxLength = 50;
            this.TxtNHijos.Name = "TxtNHijos";
            this.TxtNHijos.Size = new System.Drawing.Size(222, 31);
            this.TxtNHijos.TabIndex = 80;
            this.TxtNHijos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNHijos_KeyPress);
            // 
            // LblEstdoCivil
            // 
            this.LblEstdoCivil.AutoSize = true;
            this.LblEstdoCivil.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEstdoCivil.ForeColor = System.Drawing.Color.White;
            this.LblEstdoCivil.Location = new System.Drawing.Point(12, 92);
            this.LblEstdoCivil.Name = "LblEstdoCivil";
            this.LblEstdoCivil.Size = new System.Drawing.Size(116, 22);
            this.LblEstdoCivil.TabIndex = 86;
            this.LblEstdoCivil.Text = "Estado civil:";
            // 
            // DtpFechaNacimiento
            // 
            this.DtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaNacimiento.Location = new System.Drawing.Point(313, 52);
            this.DtpFechaNacimiento.Name = "DtpFechaNacimiento";
            this.DtpFechaNacimiento.Size = new System.Drawing.Size(97, 23);
            this.DtpFechaNacimiento.TabIndex = 85;
            this.DtpFechaNacimiento.ValueChanged += new System.EventHandler(this.DtpFechaNacimiento_ValueChanged);
            // 
            // LblFechaNacimiento
            // 
            this.LblFechaNacimiento.AutoSize = true;
            this.LblFechaNacimiento.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaNacimiento.ForeColor = System.Drawing.Color.White;
            this.LblFechaNacimiento.Location = new System.Drawing.Point(12, 52);
            this.LblFechaNacimiento.Name = "LblFechaNacimiento";
            this.LblFechaNacimiento.Size = new System.Drawing.Size(213, 22);
            this.LblFechaNacimiento.TabIndex = 84;
            this.LblFechaNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // LblSexo
            // 
            this.LblSexo.AutoSize = true;
            this.LblSexo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSexo.ForeColor = System.Drawing.Color.White;
            this.LblSexo.Location = new System.Drawing.Point(12, 13);
            this.LblSexo.Name = "LblSexo";
            this.LblSexo.Size = new System.Drawing.Size(57, 22);
            this.LblSexo.TabIndex = 83;
            this.LblSexo.Text = "Sexo:";
            // 
            // CbSexo
            // 
            this.CbSexo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.CbSexo.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.CbSexo.FormattingEnabled = true;
            this.CbSexo.Items.AddRange(new object[] {
            "Femenino",
            "Masculino"});
            this.CbSexo.Location = new System.Drawing.Point(188, 11);
            this.CbSexo.Name = "CbSexo";
            this.CbSexo.Size = new System.Drawing.Size(222, 29);
            this.CbSexo.TabIndex = 82;
            this.CbSexo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CbSexo_KeyPress);
            // 
            // TpFinanciera
            // 
            this.TpFinanciera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.TpFinanciera.Controls.Add(this.GbTipoPago);
            this.TpFinanciera.Controls.Add(this.CbUSueldoLimite);
            this.TpFinanciera.Controls.Add(this.CbUSueldoBase);
            this.TpFinanciera.Controls.Add(this.CbUSalario);
            this.TpFinanciera.Controls.Add(this.TxtSueldoLimite);
            this.TpFinanciera.Controls.Add(this.LblSueldoLimite);
            this.TpFinanciera.Controls.Add(this.TxtSueldoBase);
            this.TpFinanciera.Controls.Add(this.LblSueldoBase);
            this.TpFinanciera.Controls.Add(this.TxtSalario);
            this.TpFinanciera.Controls.Add(this.LblSalario);
            this.TpFinanciera.Location = new System.Drawing.Point(4, 26);
            this.TpFinanciera.Name = "TpFinanciera";
            this.TpFinanciera.Padding = new System.Windows.Forms.Padding(3);
            this.TpFinanciera.Size = new System.Drawing.Size(1048, 376);
            this.TpFinanciera.TabIndex = 6;
            this.TpFinanciera.Text = "Financiera";
            // 
            // GbTipoPago
            // 
            this.GbTipoPago.Controls.Add(this.RbVariable);
            this.GbTipoPago.Controls.Add(this.RbFijo);
            this.GbTipoPago.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbTipoPago.ForeColor = System.Drawing.Color.White;
            this.GbTipoPago.Location = new System.Drawing.Point(487, 18);
            this.GbTipoPago.Name = "GbTipoPago";
            this.GbTipoPago.Size = new System.Drawing.Size(161, 103);
            this.GbTipoPago.TabIndex = 83;
            this.GbTipoPago.TabStop = false;
            this.GbTipoPago.Text = "Tipo de Pago";
            // 
            // RbVariable
            // 
            this.RbVariable.AutoSize = true;
            this.RbVariable.Location = new System.Drawing.Point(14, 62);
            this.RbVariable.Name = "RbVariable";
            this.RbVariable.Size = new System.Drawing.Size(106, 26);
            this.RbVariable.TabIndex = 1;
            this.RbVariable.Text = "Variable";
            this.RbVariable.UseVisualStyleBackColor = true;
            // 
            // RbFijo
            // 
            this.RbFijo.AutoSize = true;
            this.RbFijo.Checked = true;
            this.RbFijo.Location = new System.Drawing.Point(14, 30);
            this.RbFijo.Name = "RbFijo";
            this.RbFijo.Size = new System.Drawing.Size(55, 26);
            this.RbFijo.TabIndex = 0;
            this.RbFijo.TabStop = true;
            this.RbFijo.Text = "Fijo";
            this.RbFijo.UseVisualStyleBackColor = true;
            // 
            // CbUSueldoLimite
            // 
            this.CbUSueldoLimite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.CbUSueldoLimite.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.CbUSueldoLimite.FormattingEnabled = true;
            this.CbUSueldoLimite.Items.AddRange(new object[] {
            "Hora",
            "Día",
            "Semana",
            "Mes",
            "Ejercicio",
            "Quincenal",
            "Bisemanal"});
            this.CbUSueldoLimite.Location = new System.Drawing.Point(285, 92);
            this.CbUSueldoLimite.Name = "CbUSueldoLimite";
            this.CbUSueldoLimite.Size = new System.Drawing.Size(179, 29);
            this.CbUSueldoLimite.TabIndex = 82;
            this.CbUSueldoLimite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CbUSueldoLimite_KeyPress);
            // 
            // CbUSueldoBase
            // 
            this.CbUSueldoBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.CbUSueldoBase.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.CbUSueldoBase.FormattingEnabled = true;
            this.CbUSueldoBase.Items.AddRange(new object[] {
            "Hora",
            "Día",
            "Semana",
            "Mes",
            "Ejercicio",
            "Quincenal",
            "Bisemanal"});
            this.CbUSueldoBase.Location = new System.Drawing.Point(285, 55);
            this.CbUSueldoBase.Name = "CbUSueldoBase";
            this.CbUSueldoBase.Size = new System.Drawing.Size(179, 29);
            this.CbUSueldoBase.TabIndex = 81;
            this.CbUSueldoBase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CbUSueldoBase_KeyPress);
            // 
            // CbUSalario
            // 
            this.CbUSalario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.CbUSalario.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.CbUSalario.FormattingEnabled = true;
            this.CbUSalario.Items.AddRange(new object[] {
            "Hora",
            "Día",
            "Semana",
            "Mes",
            "Ejercicio",
            "Quincenal",
            "Bisemanal"});
            this.CbUSalario.Location = new System.Drawing.Point(285, 17);
            this.CbUSalario.Name = "CbUSalario";
            this.CbUSalario.Size = new System.Drawing.Size(179, 29);
            this.CbUSalario.TabIndex = 80;
            this.CbUSalario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CbUSalario_KeyPress);
            // 
            // TxtSueldoLimite
            // 
            this.TxtSueldoLimite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.TxtSueldoLimite.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSueldoLimite.Location = new System.Drawing.Point(143, 91);
            this.TxtSueldoLimite.MaxLength = 50;
            this.TxtSueldoLimite.Name = "TxtSueldoLimite";
            this.TxtSueldoLimite.Size = new System.Drawing.Size(136, 31);
            this.TxtSueldoLimite.TabIndex = 31;
            this.TxtSueldoLimite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSueldoLimite_KeyPress);
            // 
            // LblSueldoLimite
            // 
            this.LblSueldoLimite.AutoSize = true;
            this.LblSueldoLimite.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSueldoLimite.ForeColor = System.Drawing.Color.White;
            this.LblSueldoLimite.Location = new System.Drawing.Point(14, 94);
            this.LblSueldoLimite.Name = "LblSueldoLimite";
            this.LblSueldoLimite.Size = new System.Drawing.Size(132, 22);
            this.LblSueldoLimite.TabIndex = 32;
            this.LblSueldoLimite.Text = "Sueldo Limite:";
            // 
            // TxtSueldoBase
            // 
            this.TxtSueldoBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.TxtSueldoBase.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSueldoBase.Location = new System.Drawing.Point(143, 54);
            this.TxtSueldoBase.MaxLength = 50;
            this.TxtSueldoBase.Name = "TxtSueldoBase";
            this.TxtSueldoBase.Size = new System.Drawing.Size(136, 31);
            this.TxtSueldoBase.TabIndex = 29;
            this.TxtSueldoBase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSueldoBase_KeyPress);
            // 
            // LblSueldoBase
            // 
            this.LblSueldoBase.AutoSize = true;
            this.LblSueldoBase.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSueldoBase.ForeColor = System.Drawing.Color.White;
            this.LblSueldoBase.Location = new System.Drawing.Point(14, 57);
            this.LblSueldoBase.Name = "LblSueldoBase";
            this.LblSueldoBase.Size = new System.Drawing.Size(126, 22);
            this.LblSueldoBase.TabIndex = 30;
            this.LblSueldoBase.Text = "Sueldo base:";
            // 
            // TxtSalario
            // 
            this.TxtSalario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.TxtSalario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSalario.Location = new System.Drawing.Point(143, 17);
            this.TxtSalario.MaxLength = 50;
            this.TxtSalario.Name = "TxtSalario";
            this.TxtSalario.Size = new System.Drawing.Size(136, 31);
            this.TxtSalario.TabIndex = 27;
            this.TxtSalario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSalario_KeyPress);
            // 
            // LblSalario
            // 
            this.LblSalario.AutoSize = true;
            this.LblSalario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSalario.ForeColor = System.Drawing.Color.White;
            this.LblSalario.Location = new System.Drawing.Point(14, 20);
            this.LblSalario.Name = "LblSalario";
            this.LblSalario.Size = new System.Drawing.Size(74, 22);
            this.LblSalario.TabIndex = 28;
            this.LblSalario.Text = "Salario:";
            // 
            // LblTituloUsuario
            // 
            this.LblTituloUsuario.AutoSize = true;
            this.LblTituloUsuario.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloUsuario.ForeColor = System.Drawing.Color.White;
            this.LblTituloUsuario.Location = new System.Drawing.Point(421, 3);
            this.LblTituloUsuario.Name = "LblTituloUsuario";
            this.LblTituloUsuario.Size = new System.Drawing.Size(190, 39);
            this.LblTituloUsuario.TabIndex = 1;
            this.LblTituloUsuario.Text = "Empleados";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.Image")));
            this.BtnCerrar.Location = new System.Drawing.Point(1056, 3);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(21, 24);
            this.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnCerrar.TabIndex = 20;
            this.BtnCerrar.TabStop = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // TxtNombre
            // 
            this.TxtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.TxtNombre.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(119, 56);
            this.TxtNombre.MaxLength = 50;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(307, 31);
            this.TxtNombre.TabIndex = 1;
            // 
            // LblIdEmpleado
            // 
            this.LblIdEmpleado.AutoSize = true;
            this.LblIdEmpleado.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIdEmpleado.ForeColor = System.Drawing.Color.White;
            this.LblIdEmpleado.Location = new System.Drawing.Point(18, 30);
            this.LblIdEmpleado.Name = "LblIdEmpleado";
            this.LblIdEmpleado.Size = new System.Drawing.Size(33, 22);
            this.LblIdEmpleado.TabIndex = 25;
            this.LblIdEmpleado.Text = "Id:";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.ForeColor = System.Drawing.Color.White;
            this.LblNombre.Location = new System.Drawing.Point(18, 60);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(105, 22);
            this.LblNombre.TabIndex = 26;
            this.LblNombre.Text = "1er Nomb:";
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApellido.ForeColor = System.Drawing.Color.White;
            this.LblApellido.Location = new System.Drawing.Point(14, 98);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(110, 22);
            this.LblApellido.TabIndex = 27;
            this.LblApellido.Text = "Apellido(s):";
            // 
            // LblArea
            // 
            this.LblArea.AutoSize = true;
            this.LblArea.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblArea.ForeColor = System.Drawing.Color.White;
            this.LblArea.Location = new System.Drawing.Point(62, 134);
            this.LblArea.Name = "LblArea";
            this.LblArea.Size = new System.Drawing.Size(61, 22);
            this.LblArea.TabIndex = 28;
            this.LblArea.Text = "Area:";
            // 
            // LblTelCasa
            // 
            this.LblTelCasa.AutoSize = true;
            this.LblTelCasa.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTelCasa.ForeColor = System.Drawing.Color.White;
            this.LblTelCasa.Location = new System.Drawing.Point(28, 171);
            this.LblTelCasa.Name = "LblTelCasa";
            this.LblTelCasa.Size = new System.Drawing.Size(96, 22);
            this.LblTelCasa.TabIndex = 29;
            this.LblTelCasa.Text = "Tel. Casa:";
            // 
            // LblTelMovil
            // 
            this.LblTelMovil.AutoSize = true;
            this.LblTelMovil.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTelMovil.ForeColor = System.Drawing.Color.White;
            this.LblTelMovil.Location = new System.Drawing.Point(447, 174);
            this.LblTelMovil.Name = "LblTelMovil";
            this.LblTelMovil.Size = new System.Drawing.Size(96, 22);
            this.LblTelMovil.TabIndex = 30;
            this.LblTelMovil.Text = "Tel. Móvil:";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.ForeColor = System.Drawing.Color.White;
            this.LblEmail.Location = new System.Drawing.Point(63, 209);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(61, 22);
            this.LblEmail.TabIndex = 31;
            this.LblEmail.Text = "Email:";
            // 
            // LblEmpId
            // 
            this.LblEmpId.AutoSize = true;
            this.LblEmpId.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmpId.ForeColor = System.Drawing.Color.Black;
            this.LblEmpId.Location = new System.Drawing.Point(48, 30);
            this.LblEmpId.Name = "LblEmpId";
            this.LblEmpId.Size = new System.Drawing.Size(0, 22);
            this.LblEmpId.TabIndex = 38;
            // 
            // TxtApellido
            // 
            this.TxtApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.TxtApellido.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApellido.Location = new System.Drawing.Point(119, 94);
            this.TxtApellido.MaxLength = 50;
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(622, 31);
            this.TxtApellido.TabIndex = 3;
            // 
            // TxtTelCasa
            // 
            this.TxtTelCasa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.TxtTelCasa.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelCasa.Location = new System.Drawing.Point(119, 168);
            this.TxtTelCasa.MaxLength = 20;
            this.TxtTelCasa.Name = "TxtTelCasa";
            this.TxtTelCasa.Size = new System.Drawing.Size(307, 31);
            this.TxtTelCasa.TabIndex = 8;
            // 
            // TxtTelMovil
            // 
            this.TxtTelMovil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.TxtTelMovil.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelMovil.Location = new System.Drawing.Point(540, 168);
            this.TxtTelMovil.MaxLength = 20;
            this.TxtTelMovil.Name = "TxtTelMovil";
            this.TxtTelMovil.Size = new System.Drawing.Size(298, 31);
            this.TxtTelMovil.TabIndex = 9;
            // 
            // TxtEmail
            // 
            this.TxtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.TxtEmail.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.Location = new System.Drawing.Point(119, 205);
            this.TxtEmail.MaxLength = 100;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(719, 31);
            this.TxtEmail.TabIndex = 10;
            // 
            // TxtNombre2
            // 
            this.TxtNombre2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.TxtNombre2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre2.Location = new System.Drawing.Point(540, 57);
            this.TxtNombre2.MaxLength = 50;
            this.TxtNombre2.Name = "TxtNombre2";
            this.TxtNombre2.Size = new System.Drawing.Size(298, 31);
            this.TxtNombre2.TabIndex = 2;
            // 
            // LblNombre2
            // 
            this.LblNombre2.AutoSize = true;
            this.LblNombre2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre2.ForeColor = System.Drawing.Color.White;
            this.LblNombre2.Location = new System.Drawing.Point(432, 60);
            this.LblNombre2.Name = "LblNombre2";
            this.LblNombre2.Size = new System.Drawing.Size(112, 22);
            this.LblNombre2.TabIndex = 39;
            this.LblNombre2.Text = "2do Nomb:";
            // 
            // ChkActivo
            // 
            this.ChkActivo.AutoSize = true;
            this.ChkActivo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkActivo.ForeColor = System.Drawing.Color.White;
            this.ChkActivo.Location = new System.Drawing.Point(747, 98);
            this.ChkActivo.Name = "ChkActivo";
            this.ChkActivo.Size = new System.Drawing.Size(91, 26);
            this.ChkActivo.TabIndex = 4;
            this.ChkActivo.Text = "Activo";
            this.ChkActivo.UseVisualStyleBackColor = true;
            // 
            // LblDpto
            // 
            this.LblDpto.AutoSize = true;
            this.LblDpto.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDpto.ForeColor = System.Drawing.Color.White;
            this.LblDpto.Location = new System.Drawing.Point(325, 134);
            this.LblDpto.Name = "LblDpto";
            this.LblDpto.Size = new System.Drawing.Size(61, 22);
            this.LblDpto.TabIndex = 42;
            this.LblDpto.Text = "Dpto:";
            // 
            // LblPuesto
            // 
            this.LblPuesto.AutoSize = true;
            this.LblPuesto.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPuesto.ForeColor = System.Drawing.Color.White;
            this.LblPuesto.Location = new System.Drawing.Point(588, 134);
            this.LblPuesto.Name = "LblPuesto";
            this.LblPuesto.Size = new System.Drawing.Size(76, 22);
            this.LblPuesto.TabIndex = 44;
            this.LblPuesto.Text = "Puesto:";
            // 
            // CbArea
            // 
            this.CbArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.CbArea.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.CbArea.FormattingEnabled = true;
            this.CbArea.Location = new System.Drawing.Point(119, 131);
            this.CbArea.Name = "CbArea";
            this.CbArea.Size = new System.Drawing.Size(208, 29);
            this.CbArea.TabIndex = 5;
            this.CbArea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CbArea_KeyPress);
            // 
            // CbDepto
            // 
            this.CbDepto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.CbDepto.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.CbDepto.FormattingEnabled = true;
            this.CbDepto.Location = new System.Drawing.Point(382, 131);
            this.CbDepto.Name = "CbDepto";
            this.CbDepto.Size = new System.Drawing.Size(208, 29);
            this.CbDepto.TabIndex = 6;
            this.CbDepto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CbDepto_KeyPress);
            // 
            // CbPuesto
            // 
            this.CbPuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.CbPuesto.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.CbPuesto.FormattingEnabled = true;
            this.CbPuesto.Location = new System.Drawing.Point(658, 131);
            this.CbPuesto.Name = "CbPuesto";
            this.CbPuesto.Size = new System.Drawing.Size(180, 29);
            this.CbPuesto.TabIndex = 7;
            this.CbPuesto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CbPuesto_KeyPress);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.BurlyWood;
            this.BtnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLimpiar.Enabled = false;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.ForeColor = System.Drawing.Color.White;
            this.BtnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("BtnLimpiar.Image")));
            this.BtnLimpiar.Location = new System.Drawing.Point(844, 33);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(214, 51);
            this.BtnLimpiar.TabIndex = 76;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.DarkGreen;
            this.BtnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.White;
            this.BtnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("BtnAgregar.Image")));
            this.BtnAgregar.Location = new System.Drawing.Point(844, 87);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(214, 51);
            this.BtnAgregar.TabIndex = 77;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.BackColor = System.Drawing.Color.Goldenrod;
            this.BtnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnActualizar.Enabled = false;
            this.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActualizar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizar.ForeColor = System.Drawing.Color.White;
            this.BtnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnActualizar.Image")));
            this.BtnActualizar.Location = new System.Drawing.Point(844, 141);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(214, 51);
            this.BtnActualizar.TabIndex = 74;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnActualizar.UseVisualStyleBackColor = false;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.DarkRed;
            this.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminar.Enabled = false;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminar.Image")));
            this.BtnEliminar.Location = new System.Drawing.Point(844, 195);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(214, 51);
            this.BtnEliminar.TabIndex = 79;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // FrmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1080, 665);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.CbPuesto);
            this.Controls.Add(this.CbDepto);
            this.Controls.Add(this.CbArea);
            this.Controls.Add(this.LblPuesto);
            this.Controls.Add(this.LblDpto);
            this.Controls.Add(this.ChkActivo);
            this.Controls.Add(this.TxtNombre2);
            this.Controls.Add(this.LblNombre2);
            this.Controls.Add(this.LblEmpId);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtTelMovil);
            this.Controls.Add(this.TxtTelCasa);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.LblTelMovil);
            this.Controls.Add(this.LblTelCasa);
            this.Controls.Add(this.LblArea);
            this.Controls.Add(this.LblApellido);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.LblIdEmpleado);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.LblTituloUsuario);
            this.Controls.Add(this.TcEmpleados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEmpleados";
            this.Text = "FrmEmpleados";
            this.TcEmpleados.ResumeLayout(false);
            this.TpIndex.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmpleados)).EndInit();
            this.TpDireccion.ResumeLayout(false);
            this.TpDireccion.PerformLayout();
            this.TpGestion.ResumeLayout(false);
            this.TpGestion.PerformLayout();
            this.TpPersonal.ResumeLayout(false);
            this.TpPersonal.PerformLayout();
            this.TpFinanciera.ResumeLayout(false);
            this.TpFinanciera.PerformLayout();
            this.GbTipoPago.ResumeLayout(false);
            this.GbTipoPago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TcEmpleados;
        private System.Windows.Forms.TabPage TpIndex;
        private System.Windows.Forms.TabPage TpDireccion;
        private System.Windows.Forms.Label LblTituloUsuario;
        private System.Windows.Forms.PictureBox BtnCerrar;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LblIdEmpleado;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.Label LblArea;
        private System.Windows.Forms.Label LblTelCasa;
        private System.Windows.Forms.Label LblTelMovil;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblEmpId;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtTelCasa;
        private System.Windows.Forms.TextBox TxtTelMovil;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtNombre2;
        private System.Windows.Forms.Label LblNombre2;
        private System.Windows.Forms.CheckBox ChkActivo;
        private System.Windows.Forms.Label LblDpto;
        private System.Windows.Forms.Label LblPuesto;
        private System.Windows.Forms.TabPage TpGestion;
        private System.Windows.Forms.TabPage TpPersonal;
        private System.Windows.Forms.DataGridView DgvEmpleados;
        private System.Windows.Forms.ComboBox CbArea;
        private System.Windows.Forms.ComboBox CbDepto;
        private System.Windows.Forms.ComboBox CbPuesto;
        private System.Windows.Forms.Label LblCiudad;
        private System.Windows.Forms.TextBox TxtCP;
        private System.Windows.Forms.Label LblCP;
        private System.Windows.Forms.TextBox TxtNoExt;
        private System.Windows.Forms.Label LblNoExt;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.Label LblDireccion;
        private System.Windows.Forms.TextBox TxtColonia;
        private System.Windows.Forms.Label LblColonia;
        private System.Windows.Forms.Label LblEstado;
        private System.Windows.Forms.Label LblPais;
        private System.Windows.Forms.TabPage TpFinanciera;
        private System.Windows.Forms.TextBox TxtNoInt;
        private System.Windows.Forms.Label LblNoInt;
        private System.Windows.Forms.ComboBox CbEstado;
        private System.Windows.Forms.ComboBox CbPais;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.ComboBox cbCiudad;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.DateTimePicker DtpFechaRC;
        private System.Windows.Forms.Label LblFechaRC;
        private System.Windows.Forms.DateTimePicker DtpFechaInicio;
        private System.Windows.Forms.Label LblFechaInicio;
        private System.Windows.Forms.Label LblMotivoRC;
        private System.Windows.Forms.ComboBox CbMotivoRC;
        private System.Windows.Forms.Label LblSexo;
        private System.Windows.Forms.ComboBox CbSexo;
        private System.Windows.Forms.Label LblNHijos;
        private System.Windows.Forms.ComboBox CbEstadoCivil;
        private System.Windows.Forms.TextBox TxtNHijos;
        private System.Windows.Forms.Label LblEstdoCivil;
        private System.Windows.Forms.DateTimePicker DtpFechaNacimiento;
        private System.Windows.Forms.Label LblFechaNacimiento;
        private System.Windows.Forms.Label LblCURP;
        private System.Windows.Forms.TextBox TxtCURP;
        private System.Windows.Forms.GroupBox GbTipoPago;
        private System.Windows.Forms.RadioButton RbVariable;
        private System.Windows.Forms.RadioButton RbFijo;
        private System.Windows.Forms.ComboBox CbUSueldoLimite;
        private System.Windows.Forms.ComboBox CbUSueldoBase;
        private System.Windows.Forms.ComboBox CbUSalario;
        private System.Windows.Forms.TextBox TxtSueldoLimite;
        private System.Windows.Forms.Label LblSueldoLimite;
        private System.Windows.Forms.TextBox TxtSueldoBase;
        private System.Windows.Forms.Label LblSueldoBase;
        private System.Windows.Forms.TextBox TxtSalario;
        private System.Windows.Forms.Label LblSalario;
    }
}