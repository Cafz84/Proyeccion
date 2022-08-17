namespace Proyeccion.Principal
{
    partial class FrmUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsers));
            this.LblTituloUsuario = new System.Windows.Forms.Label();
            this.LblId = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblApellido = new System.Windows.Forms.Label();
            this.LblPuesto = new System.Windows.Forms.Label();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.Contraseña = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtPuesto = new System.Windows.Forms.TextBox();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtContrasena = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.LblUserId = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.PictureBox();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.TcDestajo = new System.Windows.Forms.TabControl();
            this.TpIndex = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtBNombre = new System.Windows.Forms.TextBox();
            this.DgvUsers = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.TpPermisos = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ChkLoteo = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ChkUsuarios = new System.Windows.Forms.CheckBox();
            this.GbIngenieria = new System.Windows.Forms.GroupBox();
            this.ChkRevDestajo = new System.Windows.Forms.CheckBox();
            this.ChkFraccEstilo = new System.Windows.Forms.CheckBox();
            this.ChkCapDestajo = new System.Windows.Forms.CheckBox();
            this.ChkFracciones = new System.Windows.Forms.CheckBox();
            this.GbRH = new System.Windows.Forms.GroupBox();
            this.ChkEmpleados = new System.Windows.Forms.CheckBox();
            this.GbEmbarque = new System.Windows.Forms.GroupBox();
            this.ChkEscaneo = new System.Windows.Forms.CheckBox();
            this.GbProduccion = new System.Windows.Forms.GroupBox();
            this.ChkAvances = new System.Windows.Forms.CheckBox();
            this.ChkUAvances = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            this.TcDestajo.SuspendLayout();
            this.TpIndex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsers)).BeginInit();
            this.TpPermisos.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.GbIngenieria.SuspendLayout();
            this.GbRH.SuspendLayout();
            this.GbEmbarque.SuspendLayout();
            this.GbProduccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblTituloUsuario
            // 
            this.LblTituloUsuario.AutoSize = true;
            this.LblTituloUsuario.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloUsuario.ForeColor = System.Drawing.Color.White;
            this.LblTituloUsuario.Location = new System.Drawing.Point(459, 0);
            this.LblTituloUsuario.Name = "LblTituloUsuario";
            this.LblTituloUsuario.Size = new System.Drawing.Size(141, 39);
            this.LblTituloUsuario.TabIndex = 0;
            this.LblTituloUsuario.Text = "Usuarios";
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblId.ForeColor = System.Drawing.Color.White;
            this.LblId.Location = new System.Drawing.Point(26, 56);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(33, 22);
            this.LblId.TabIndex = 1;
            this.LblId.Text = "Id:";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.ForeColor = System.Drawing.Color.White;
            this.LblNombre.Location = new System.Drawing.Point(125, 56);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(110, 22);
            this.LblNombre.TabIndex = 2;
            this.LblNombre.Text = "Nombre(s):";
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApellido.ForeColor = System.Drawing.Color.White;
            this.LblApellido.Location = new System.Drawing.Point(125, 94);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(110, 22);
            this.LblApellido.TabIndex = 3;
            this.LblApellido.Text = "Apellido(s):";
            // 
            // LblPuesto
            // 
            this.LblPuesto.AutoSize = true;
            this.LblPuesto.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPuesto.ForeColor = System.Drawing.Color.White;
            this.LblPuesto.Location = new System.Drawing.Point(159, 131);
            this.LblPuesto.Name = "LblPuesto";
            this.LblPuesto.Size = new System.Drawing.Size(76, 22);
            this.LblPuesto.TabIndex = 4;
            this.LblPuesto.Text = "Puesto:";
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.ForeColor = System.Drawing.Color.White;
            this.LblUsuario.Location = new System.Drawing.Point(155, 168);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(80, 22);
            this.LblUsuario.TabIndex = 5;
            this.LblUsuario.Text = "Usuario:";
            // 
            // Contraseña
            // 
            this.Contraseña.AutoSize = true;
            this.Contraseña.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contraseña.ForeColor = System.Drawing.Color.White;
            this.Contraseña.Location = new System.Drawing.Point(451, 168);
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.Size = new System.Drawing.Size(124, 22);
            this.Contraseña.TabIndex = 6;
            this.Contraseña.Text = "Contraseña:";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.ForeColor = System.Drawing.Color.White;
            this.LblEmail.Location = new System.Drawing.Point(174, 205);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(61, 22);
            this.LblEmail.TabIndex = 7;
            this.LblEmail.Text = "Email:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.TxtNombre.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(232, 53);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(578, 31);
            this.TxtNombre.TabIndex = 8;
            // 
            // TxtApellido
            // 
            this.TxtApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.TxtApellido.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApellido.Location = new System.Drawing.Point(232, 91);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(578, 31);
            this.TxtApellido.TabIndex = 9;
            // 
            // TxtPuesto
            // 
            this.TxtPuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.TxtPuesto.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPuesto.Location = new System.Drawing.Point(232, 128);
            this.TxtPuesto.Name = "TxtPuesto";
            this.TxtPuesto.Size = new System.Drawing.Size(578, 31);
            this.TxtPuesto.TabIndex = 10;
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.TxtUsuario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuario.Location = new System.Drawing.Point(232, 165);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(213, 31);
            this.TxtUsuario.TabIndex = 11;
            // 
            // TxtContrasena
            // 
            this.TxtContrasena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.TxtContrasena.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContrasena.Location = new System.Drawing.Point(572, 165);
            this.TxtContrasena.Name = "TxtContrasena";
            this.TxtContrasena.Size = new System.Drawing.Size(238, 31);
            this.TxtContrasena.TabIndex = 12;
            // 
            // TxtEmail
            // 
            this.TxtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.TxtEmail.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.Location = new System.Drawing.Point(232, 202);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(578, 31);
            this.TxtEmail.TabIndex = 13;
            // 
            // LblUserId
            // 
            this.LblUserId.AutoSize = true;
            this.LblUserId.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserId.ForeColor = System.Drawing.Color.Black;
            this.LblUserId.Location = new System.Drawing.Point(56, 56);
            this.LblUserId.Name = "LblUserId";
            this.LblUserId.Size = new System.Drawing.Size(0, 22);
            this.LblUserId.TabIndex = 15;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.Image")));
            this.BtnCerrar.Location = new System.Drawing.Point(1052, 4);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(23, 23);
            this.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnCerrar.TabIndex = 19;
            this.BtnCerrar.TabStop = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.DarkRed;
            this.BtnEliminar.Enabled = false;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminar.Image")));
            this.BtnEliminar.Location = new System.Drawing.Point(827, 189);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(214, 51);
            this.BtnEliminar.TabIndex = 83;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.BackColor = System.Drawing.Color.Goldenrod;
            this.BtnActualizar.Enabled = false;
            this.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActualizar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizar.ForeColor = System.Drawing.Color.White;
            this.BtnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnActualizar.Image")));
            this.BtnActualizar.Location = new System.Drawing.Point(827, 135);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(214, 51);
            this.BtnActualizar.TabIndex = 80;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnActualizar.UseVisualStyleBackColor = false;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.DarkGreen;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.White;
            this.BtnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("BtnAgregar.Image")));
            this.BtnAgregar.Location = new System.Drawing.Point(827, 81);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(214, 51);
            this.BtnAgregar.TabIndex = 82;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.BurlyWood;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.ForeColor = System.Drawing.Color.White;
            this.BtnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("BtnLimpiar.Image")));
            this.BtnLimpiar.Location = new System.Drawing.Point(827, 27);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(214, 51);
            this.BtnLimpiar.TabIndex = 81;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // TcDestajo
            // 
            this.TcDestajo.Controls.Add(this.TpIndex);
            this.TcDestajo.Controls.Add(this.TpPermisos);
            this.TcDestajo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TcDestajo.Location = new System.Drawing.Point(3, 240);
            this.TcDestajo.Name = "TcDestajo";
            this.TcDestajo.SelectedIndex = 0;
            this.TcDestajo.Size = new System.Drawing.Size(1073, 422);
            this.TcDestajo.TabIndex = 84;
            // 
            // TpIndex
            // 
            this.TpIndex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.TpIndex.Controls.Add(this.pictureBox1);
            this.TpIndex.Controls.Add(this.TxtBNombre);
            this.TpIndex.Controls.Add(this.DgvUsers);
            this.TpIndex.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TpIndex.Location = new System.Drawing.Point(4, 26);
            this.TpIndex.Name = "TpIndex";
            this.TpIndex.Padding = new System.Windows.Forms.Padding(3);
            this.TpIndex.Size = new System.Drawing.Size(1065, 392);
            this.TpIndex.TabIndex = 0;
            this.TpIndex.Text = "Index";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pruebas.Properties.Resources.xmag_search_find_export_locate_32x32;
            this.pictureBox1.Location = new System.Drawing.Point(5, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 128;
            this.pictureBox1.TabStop = false;
            // 
            // TxtBNombre
            // 
            this.TxtBNombre.BackColor = System.Drawing.Color.LightGray;
            this.TxtBNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBNombre.Location = new System.Drawing.Point(41, 3);
            this.TxtBNombre.MaxLength = 50;
            this.TxtBNombre.Name = "TxtBNombre";
            this.TxtBNombre.Size = new System.Drawing.Size(234, 27);
            this.TxtBNombre.TabIndex = 130;
            this.TxtBNombre.TextChanged += new System.EventHandler(this.TxtBNombre_TextChanged);
            // 
            // DgvUsers
            // 
            this.DgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar});
            this.DgvUsers.Location = new System.Drawing.Point(0, 32);
            this.DgvUsers.Name = "DgvUsers";
            this.DgvUsers.Size = new System.Drawing.Size(1065, 360);
            this.DgvUsers.TabIndex = 0;
            this.DgvUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvUsers_CellContentClick);
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Edit";
            this.Editar.Image = ((System.Drawing.Image)(resources.GetObject("Editar.Image")));
            this.Editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Editar.Name = "Editar";
            this.Editar.Width = 55;
            // 
            // TpPermisos
            // 
            this.TpPermisos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.TpPermisos.Controls.Add(this.groupBox2);
            this.TpPermisos.Controls.Add(this.groupBox1);
            this.TpPermisos.Controls.Add(this.GbIngenieria);
            this.TpPermisos.Controls.Add(this.GbRH);
            this.TpPermisos.Controls.Add(this.GbEmbarque);
            this.TpPermisos.Controls.Add(this.GbProduccion);
            this.TpPermisos.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TpPermisos.ForeColor = System.Drawing.Color.Transparent;
            this.TpPermisos.Location = new System.Drawing.Point(4, 26);
            this.TpPermisos.Name = "TpPermisos";
            this.TpPermisos.Padding = new System.Windows.Forms.Padding(3);
            this.TpPermisos.Size = new System.Drawing.Size(1065, 392);
            this.TpPermisos.TabIndex = 1;
            this.TpPermisos.Text = "Permisos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ChkLoteo);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox2.Location = new System.Drawing.Point(8, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(125, 53);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Planeación";
            // 
            // ChkLoteo
            // 
            this.ChkLoteo.AutoSize = true;
            this.ChkLoteo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkLoteo.ForeColor = System.Drawing.Color.White;
            this.ChkLoteo.Location = new System.Drawing.Point(17, 22);
            this.ChkLoteo.Name = "ChkLoteo";
            this.ChkLoteo.Size = new System.Drawing.Size(64, 21);
            this.ChkLoteo.TabIndex = 5;
            this.ChkLoteo.Text = "Loteo";
            this.ChkLoteo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ChkUsuarios);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(8, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(125, 53);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Administrador";
            // 
            // ChkUsuarios
            // 
            this.ChkUsuarios.AutoSize = true;
            this.ChkUsuarios.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkUsuarios.ForeColor = System.Drawing.Color.White;
            this.ChkUsuarios.Location = new System.Drawing.Point(17, 22);
            this.ChkUsuarios.Name = "ChkUsuarios";
            this.ChkUsuarios.Size = new System.Drawing.Size(78, 21);
            this.ChkUsuarios.TabIndex = 5;
            this.ChkUsuarios.Text = "Usuarios";
            this.ChkUsuarios.UseVisualStyleBackColor = true;
            // 
            // GbIngenieria
            // 
            this.GbIngenieria.Controls.Add(this.ChkRevDestajo);
            this.GbIngenieria.Controls.Add(this.ChkFraccEstilo);
            this.GbIngenieria.Controls.Add(this.ChkCapDestajo);
            this.GbIngenieria.Controls.Add(this.ChkFracciones);
            this.GbIngenieria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.GbIngenieria.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GbIngenieria.Location = new System.Drawing.Point(152, 9);
            this.GbIngenieria.Name = "GbIngenieria";
            this.GbIngenieria.Size = new System.Drawing.Size(156, 132);
            this.GbIngenieria.TabIndex = 9;
            this.GbIngenieria.TabStop = false;
            this.GbIngenieria.Text = "Ingenieria";
            // 
            // ChkRevDestajo
            // 
            this.ChkRevDestajo.AutoSize = true;
            this.ChkRevDestajo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkRevDestajo.ForeColor = System.Drawing.Color.White;
            this.ChkRevDestajo.Location = new System.Drawing.Point(17, 103);
            this.ChkRevDestajo.Name = "ChkRevDestajo";
            this.ChkRevDestajo.Size = new System.Drawing.Size(132, 21);
            this.ChkRevDestajo.TabIndex = 8;
            this.ChkRevDestajo.Text = "Revisión Destajo";
            this.ChkRevDestajo.UseVisualStyleBackColor = true;
            // 
            // ChkFraccEstilo
            // 
            this.ChkFraccEstilo.AutoSize = true;
            this.ChkFraccEstilo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkFraccEstilo.ForeColor = System.Drawing.Color.White;
            this.ChkFraccEstilo.Location = new System.Drawing.Point(17, 76);
            this.ChkFraccEstilo.Name = "ChkFraccEstilo";
            this.ChkFraccEstilo.Size = new System.Drawing.Size(112, 21);
            this.ChkFraccEstilo.TabIndex = 7;
            this.ChkFraccEstilo.Text = "Fracc. x Estilo";
            this.ChkFraccEstilo.UseVisualStyleBackColor = true;
            // 
            // ChkCapDestajo
            // 
            this.ChkCapDestajo.AutoSize = true;
            this.ChkCapDestajo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkCapDestajo.ForeColor = System.Drawing.Color.White;
            this.ChkCapDestajo.Location = new System.Drawing.Point(17, 49);
            this.ChkCapDestajo.Name = "ChkCapDestajo";
            this.ChkCapDestajo.Size = new System.Drawing.Size(135, 21);
            this.ChkCapDestajo.TabIndex = 6;
            this.ChkCapDestajo.Text = "Captura Destajo";
            this.ChkCapDestajo.UseVisualStyleBackColor = true;
            // 
            // ChkFracciones
            // 
            this.ChkFracciones.AutoSize = true;
            this.ChkFracciones.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkFracciones.ForeColor = System.Drawing.Color.White;
            this.ChkFracciones.Location = new System.Drawing.Point(17, 22);
            this.ChkFracciones.Name = "ChkFracciones";
            this.ChkFracciones.Size = new System.Drawing.Size(95, 21);
            this.ChkFracciones.TabIndex = 5;
            this.ChkFracciones.Text = "Fracciones";
            this.ChkFracciones.UseVisualStyleBackColor = true;
            // 
            // GbRH
            // 
            this.GbRH.Controls.Add(this.ChkEmpleados);
            this.GbRH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.GbRH.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GbRH.Location = new System.Drawing.Point(8, 127);
            this.GbRH.Name = "GbRH";
            this.GbRH.Size = new System.Drawing.Size(125, 53);
            this.GbRH.TabIndex = 8;
            this.GbRH.TabStop = false;
            this.GbRH.Text = "R.H.";
            // 
            // ChkEmpleados
            // 
            this.ChkEmpleados.AutoSize = true;
            this.ChkEmpleados.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkEmpleados.ForeColor = System.Drawing.Color.White;
            this.ChkEmpleados.Location = new System.Drawing.Point(17, 22);
            this.ChkEmpleados.Name = "ChkEmpleados";
            this.ChkEmpleados.Size = new System.Drawing.Size(99, 21);
            this.ChkEmpleados.TabIndex = 5;
            this.ChkEmpleados.Text = "Empleados";
            this.ChkEmpleados.UseVisualStyleBackColor = true;
            // 
            // GbEmbarque
            // 
            this.GbEmbarque.Controls.Add(this.ChkEscaneo);
            this.GbEmbarque.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.GbEmbarque.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GbEmbarque.Location = new System.Drawing.Point(8, 68);
            this.GbEmbarque.Name = "GbEmbarque";
            this.GbEmbarque.Size = new System.Drawing.Size(125, 53);
            this.GbEmbarque.TabIndex = 7;
            this.GbEmbarque.TabStop = false;
            this.GbEmbarque.Text = "Embarque";
            // 
            // ChkEscaneo
            // 
            this.ChkEscaneo.AutoSize = true;
            this.ChkEscaneo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkEscaneo.ForeColor = System.Drawing.Color.White;
            this.ChkEscaneo.Location = new System.Drawing.Point(17, 22);
            this.ChkEscaneo.Name = "ChkEscaneo";
            this.ChkEscaneo.Size = new System.Drawing.Size(81, 21);
            this.ChkEscaneo.TabIndex = 5;
            this.ChkEscaneo.Text = "Escaneo";
            this.ChkEscaneo.UseVisualStyleBackColor = true;
            // 
            // GbProduccion
            // 
            this.GbProduccion.Controls.Add(this.ChkUAvances);
            this.GbProduccion.Controls.Add(this.ChkAvances);
            this.GbProduccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.GbProduccion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GbProduccion.Location = new System.Drawing.Point(152, 154);
            this.GbProduccion.Name = "GbProduccion";
            this.GbProduccion.Size = new System.Drawing.Size(157, 85);
            this.GbProduccion.TabIndex = 6;
            this.GbProduccion.TabStop = false;
            this.GbProduccion.Text = "Producción";
            // 
            // ChkAvances
            // 
            this.ChkAvances.AutoSize = true;
            this.ChkAvances.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkAvances.ForeColor = System.Drawing.Color.White;
            this.ChkAvances.Location = new System.Drawing.Point(17, 22);
            this.ChkAvances.Name = "ChkAvances";
            this.ChkAvances.Size = new System.Drawing.Size(82, 21);
            this.ChkAvances.TabIndex = 5;
            this.ChkAvances.Text = "Avances";
            this.ChkAvances.UseVisualStyleBackColor = true;
            // 
            // ChkUAvances
            // 
            this.ChkUAvances.AutoSize = true;
            this.ChkUAvances.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkUAvances.ForeColor = System.Drawing.Color.White;
            this.ChkUAvances.Location = new System.Drawing.Point(17, 49);
            this.ChkUAvances.Name = "ChkUAvances";
            this.ChkUAvances.Size = new System.Drawing.Size(132, 21);
            this.ChkUAvances.TabIndex = 6;
            this.ChkUAvances.Text = "Usuario Avances";
            this.ChkUAvances.UseVisualStyleBackColor = true;
            // 
            // FrmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1080, 665);
            this.Controls.Add(this.TcDestajo);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.LblUserId);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtContrasena);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.TxtPuesto);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.Contraseña);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.LblPuesto);
            this.Controls.Add(this.LblApellido);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.LblId);
            this.Controls.Add(this.LblTituloUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUsers";
            this.Text = "FrmUsers";
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            this.TcDestajo.ResumeLayout(false);
            this.TpIndex.ResumeLayout(false);
            this.TpIndex.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsers)).EndInit();
            this.TpPermisos.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GbIngenieria.ResumeLayout(false);
            this.GbIngenieria.PerformLayout();
            this.GbRH.ResumeLayout(false);
            this.GbRH.PerformLayout();
            this.GbEmbarque.ResumeLayout(false);
            this.GbEmbarque.PerformLayout();
            this.GbProduccion.ResumeLayout(false);
            this.GbProduccion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTituloUsuario;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.Label LblPuesto;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Label Contraseña;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtPuesto;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtContrasena;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label LblUserId;
        private System.Windows.Forms.PictureBox BtnCerrar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.TabControl TcDestajo;
        private System.Windows.Forms.TabPage TpIndex;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TxtBNombre;
        private System.Windows.Forms.DataGridView DgvUsers;
        private System.Windows.Forms.TabPage TpPermisos;
        private System.Windows.Forms.GroupBox GbProduccion;
        private System.Windows.Forms.CheckBox ChkAvances;
        private System.Windows.Forms.GroupBox GbEmbarque;
        private System.Windows.Forms.CheckBox ChkEscaneo;
        private System.Windows.Forms.GroupBox GbRH;
        private System.Windows.Forms.CheckBox ChkEmpleados;
        private System.Windows.Forms.GroupBox GbIngenieria;
        private System.Windows.Forms.CheckBox ChkFracciones;
        private System.Windows.Forms.CheckBox ChkRevDestajo;
        private System.Windows.Forms.CheckBox ChkFraccEstilo;
        private System.Windows.Forms.CheckBox ChkCapDestajo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ChkUsuarios;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox ChkLoteo;
        private System.Windows.Forms.CheckBox ChkUAvances;
    }
}