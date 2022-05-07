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
            this.TpEmpleados = new System.Windows.Forms.TabControl();
            this.TpIndex = new System.Windows.Forms.TabPage();
            this.DgvEmpleados = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.TpDireccion = new System.Windows.Forms.TabPage();
            this.CbEstado = new System.Windows.Forms.ComboBox();
            this.CbPais = new System.Windows.Forms.ComboBox();
            this.TxtNoInt = new System.Windows.Forms.TextBox();
            this.LblNoInt = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
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
            this.TpPersonal = new System.Windows.Forms.TabPage();
            this.TpComentarios = new System.Windows.Forms.TabPage();
            this.TpFinanciera = new System.Windows.Forms.TabPage();
            this.LblTituloUsuario = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.PictureBox();
            this.BtnEliminar = new FontAwesome.Sharp.IconButton();
            this.BtnActualizar = new FontAwesome.Sharp.IconButton();
            this.BtnAgregar = new FontAwesome.Sharp.IconButton();
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
            this.BtnLimpiar = new FontAwesome.Sharp.IconButton();
            this.TpEmpleados.SuspendLayout();
            this.TpIndex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmpleados)).BeginInit();
            this.TpDireccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // TpEmpleados
            // 
            this.TpEmpleados.Controls.Add(this.TpIndex);
            this.TpEmpleados.Controls.Add(this.TpDireccion);
            this.TpEmpleados.Controls.Add(this.TpGestion);
            this.TpEmpleados.Controls.Add(this.TpPersonal);
            this.TpEmpleados.Controls.Add(this.TpComentarios);
            this.TpEmpleados.Controls.Add(this.TpFinanciera);
            this.TpEmpleados.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TpEmpleados.Location = new System.Drawing.Point(12, 247);
            this.TpEmpleados.Name = "TpEmpleados";
            this.TpEmpleados.SelectedIndex = 0;
            this.TpEmpleados.Size = new System.Drawing.Size(1056, 406);
            this.TpEmpleados.TabIndex = 0;
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
            this.TpDireccion.Controls.Add(this.CbEstado);
            this.TpDireccion.Controls.Add(this.CbPais);
            this.TpDireccion.Controls.Add(this.TxtNoInt);
            this.TpDireccion.Controls.Add(this.LblNoInt);
            this.TpDireccion.Controls.Add(this.textBox8);
            this.TpDireccion.Controls.Add(this.label8);
            this.TpDireccion.Controls.Add(this.textBox7);
            this.TpDireccion.Controls.Add(this.label7);
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
            // 
            // TxtNoInt
            // 
            this.TxtNoInt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.TxtNoInt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNoInt.Location = new System.Drawing.Point(299, 154);
            this.TxtNoInt.Name = "TxtNoInt";
            this.TxtNoInt.Size = new System.Drawing.Size(111, 31);
            this.TxtNoInt.TabIndex = 43;
            // 
            // LblNoInt
            // 
            this.LblNoInt.AutoSize = true;
            this.LblNoInt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNoInt.ForeColor = System.Drawing.Color.White;
            this.LblNoInt.Location = new System.Drawing.Point(220, 157);
            this.LblNoInt.Name = "LblNoInt";
            this.LblNoInt.Size = new System.Drawing.Size(80, 22);
            this.LblNoInt.TabIndex = 44;
            this.LblNoInt.Text = "No. Int.:";
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.textBox8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(103, 265);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(307, 31);
            this.textBox8.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(2, 269);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 22);
            this.label8.TabIndex = 42;
            this.label8.Text = "1er Nomb:";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.textBox7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(103, 228);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(307, 31);
            this.textBox7.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(2, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 22);
            this.label7.TabIndex = 40;
            this.label7.Text = "1er Nomb:";
            // 
            // TxtCP
            // 
            this.TxtCP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.TxtCP.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCP.Location = new System.Drawing.Point(103, 191);
            this.TxtCP.Name = "TxtCP";
            this.TxtCP.Size = new System.Drawing.Size(307, 31);
            this.TxtCP.TabIndex = 37;
            // 
            // LblCP
            // 
            this.LblCP.AutoSize = true;
            this.LblCP.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCP.ForeColor = System.Drawing.Color.White;
            this.LblCP.Location = new System.Drawing.Point(52, 194);
            this.LblCP.Name = "LblCP";
            this.LblCP.Size = new System.Drawing.Size(51, 22);
            this.LblCP.TabIndex = 38;
            this.LblCP.Text = "C.P.:";
            // 
            // TxtNoExt
            // 
            this.TxtNoExt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.TxtNoExt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNoExt.Location = new System.Drawing.Point(103, 154);
            this.TxtNoExt.Name = "TxtNoExt";
            this.TxtNoExt.Size = new System.Drawing.Size(111, 31);
            this.TxtNoExt.TabIndex = 35;
            // 
            // LblNoExt
            // 
            this.LblNoExt.AutoSize = true;
            this.LblNoExt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNoExt.ForeColor = System.Drawing.Color.White;
            this.LblNoExt.Location = new System.Drawing.Point(21, 157);
            this.LblNoExt.Name = "LblNoExt";
            this.LblNoExt.Size = new System.Drawing.Size(82, 22);
            this.LblNoExt.TabIndex = 36;
            this.LblNoExt.Text = "No. Ext.:";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.TxtDireccion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDireccion.Location = new System.Drawing.Point(103, 117);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(307, 31);
            this.TxtDireccion.TabIndex = 33;
            // 
            // LblDireccion
            // 
            this.LblDireccion.AutoSize = true;
            this.LblDireccion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDireccion.ForeColor = System.Drawing.Color.White;
            this.LblDireccion.Location = new System.Drawing.Point(2, 121);
            this.LblDireccion.Name = "LblDireccion";
            this.LblDireccion.Size = new System.Drawing.Size(101, 22);
            this.LblDireccion.TabIndex = 34;
            this.LblDireccion.Text = "Dirección:";
            // 
            // TxtColonia
            // 
            this.TxtColonia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.TxtColonia.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtColonia.Location = new System.Drawing.Point(103, 80);
            this.TxtColonia.Name = "TxtColonia";
            this.TxtColonia.Size = new System.Drawing.Size(307, 31);
            this.TxtColonia.TabIndex = 31;
            // 
            // LblColonia
            // 
            this.LblColonia.AutoSize = true;
            this.LblColonia.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblColonia.ForeColor = System.Drawing.Color.White;
            this.LblColonia.Location = new System.Drawing.Point(18, 83);
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
            this.TpGestion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TpGestion.Location = new System.Drawing.Point(4, 26);
            this.TpGestion.Name = "TpGestion";
            this.TpGestion.Size = new System.Drawing.Size(1048, 376);
            this.TpGestion.TabIndex = 2;
            this.TpGestion.Text = "Gestión";
            // 
            // TpPersonal
            // 
            this.TpPersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.TpPersonal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TpPersonal.Location = new System.Drawing.Point(4, 26);
            this.TpPersonal.Name = "TpPersonal";
            this.TpPersonal.Size = new System.Drawing.Size(1048, 376);
            this.TpPersonal.TabIndex = 3;
            this.TpPersonal.Text = "Personal";
            // 
            // TpComentarios
            // 
            this.TpComentarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.TpComentarios.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TpComentarios.Location = new System.Drawing.Point(4, 26);
            this.TpComentarios.Name = "TpComentarios";
            this.TpComentarios.Size = new System.Drawing.Size(1048, 376);
            this.TpComentarios.TabIndex = 5;
            this.TpComentarios.Text = "Comentarios";
            // 
            // TpFinanciera
            // 
            this.TpFinanciera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.TpFinanciera.Location = new System.Drawing.Point(4, 26);
            this.TpFinanciera.Name = "TpFinanciera";
            this.TpFinanciera.Padding = new System.Windows.Forms.Padding(3);
            this.TpFinanciera.Size = new System.Drawing.Size(1048, 376);
            this.TpFinanciera.TabIndex = 6;
            this.TpFinanciera.Text = "Financiera";
            // 
            // LblTituloUsuario
            // 
            this.LblTituloUsuario.AutoSize = true;
            this.LblTituloUsuario.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloUsuario.ForeColor = System.Drawing.Color.White;
            this.LblTituloUsuario.Location = new System.Drawing.Point(421, 9);
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
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.DarkRed;
            this.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.IconChar = FontAwesome.Sharp.IconChar.UserTimes;
            this.BtnEliminar.IconColor = System.Drawing.Color.White;
            this.BtnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEliminar.IconSize = 40;
            this.BtnEliminar.Location = new System.Drawing.Point(844, 195);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(214, 51);
            this.BtnEliminar.TabIndex = 13;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.BackColor = System.Drawing.Color.Goldenrod;
            this.BtnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActualizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizar.ForeColor = System.Drawing.Color.White;
            this.BtnActualizar.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.BtnActualizar.IconColor = System.Drawing.Color.White;
            this.BtnActualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnActualizar.IconSize = 40;
            this.BtnActualizar.Location = new System.Drawing.Point(844, 141);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(214, 51);
            this.BtnActualizar.TabIndex = 12;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnActualizar.UseVisualStyleBackColor = false;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.DarkGreen;
            this.BtnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.White;
            this.BtnAgregar.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.BtnAgregar.IconColor = System.Drawing.Color.White;
            this.BtnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAgregar.IconSize = 40;
            this.BtnAgregar.Location = new System.Drawing.Point(844, 87);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(214, 51);
            this.BtnAgregar.TabIndex = 11;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // TxtNombre
            // 
            this.TxtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.TxtNombre.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(119, 56);
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
            this.LblTelMovil.Location = new System.Drawing.Point(450, 174);
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
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(622, 31);
            this.TxtApellido.TabIndex = 3;
            // 
            // TxtTelCasa
            // 
            this.TxtTelCasa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.TxtTelCasa.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelCasa.Location = new System.Drawing.Point(119, 168);
            this.TxtTelCasa.Name = "TxtTelCasa";
            this.TxtTelCasa.Size = new System.Drawing.Size(307, 31);
            this.TxtTelCasa.TabIndex = 8;
            // 
            // TxtTelMovil
            // 
            this.TxtTelMovil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.TxtTelMovil.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelMovil.Location = new System.Drawing.Point(540, 168);
            this.TxtTelMovil.Name = "TxtTelMovil";
            this.TxtTelMovil.Size = new System.Drawing.Size(298, 31);
            this.TxtTelMovil.TabIndex = 9;
            // 
            // TxtEmail
            // 
            this.TxtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.TxtEmail.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.Location = new System.Drawing.Point(119, 205);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(719, 31);
            this.TxtEmail.TabIndex = 10;
            // 
            // TxtNombre2
            // 
            this.TxtNombre2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.TxtNombre2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre2.Location = new System.Drawing.Point(540, 57);
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
            this.CbArea.DataSourceChanged += new System.EventHandler(this.CbArea_DataSourceChanged);
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
            this.CbDepto.DataSourceChanged += new System.EventHandler(this.CbDepto_DataSourceChanged);
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
            this.CbPuesto.DataSourceChanged += new System.EventHandler(this.CbPuesto_DataSourceChanged);
            this.CbPuesto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CbPuesto_KeyPress);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.BurlyWood;
            this.BtnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.ForeColor = System.Drawing.Color.White;
            this.BtnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.BtnLimpiar.IconColor = System.Drawing.Color.White;
            this.BtnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnLimpiar.IconSize = 40;
            this.BtnLimpiar.Location = new System.Drawing.Point(844, 33);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(214, 51);
            this.BtnLimpiar.TabIndex = 45;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // FrmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1080, 665);
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
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.LblTituloUsuario);
            this.Controls.Add(this.TpEmpleados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEmpleados";
            this.Text = "FrmEmpleados";
            this.TpEmpleados.ResumeLayout(false);
            this.TpIndex.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmpleados)).EndInit();
            this.TpDireccion.ResumeLayout(false);
            this.TpDireccion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TpEmpleados;
        private System.Windows.Forms.TabPage TpIndex;
        private System.Windows.Forms.TabPage TpDireccion;
        private System.Windows.Forms.Label LblTituloUsuario;
        private System.Windows.Forms.PictureBox BtnCerrar;
        private FontAwesome.Sharp.IconButton BtnEliminar;
        private FontAwesome.Sharp.IconButton BtnActualizar;
        private FontAwesome.Sharp.IconButton BtnAgregar;
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
        private System.Windows.Forms.TabPage TpComentarios;
        private System.Windows.Forms.DataGridView DgvEmpleados;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.ComboBox CbArea;
        private System.Windows.Forms.ComboBox CbDepto;
        private System.Windows.Forms.ComboBox CbPuesto;
        private FontAwesome.Sharp.IconButton BtnLimpiar;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
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
    }
}