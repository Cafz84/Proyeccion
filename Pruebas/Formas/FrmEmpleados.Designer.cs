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
            this.TpGestion = new System.Windows.Forms.TabPage();
            this.TpPersonal = new System.Windows.Forms.TabPage();
            this.TpFinanciar = new System.Windows.Forms.TabPage();
            this.TpComentarios = new System.Windows.Forms.TabPage();
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
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // TpEmpleados
            // 
            this.TpEmpleados.Controls.Add(this.TpIndex);
            this.TpEmpleados.Controls.Add(this.TpDireccion);
            this.TpEmpleados.Controls.Add(this.TpGestion);
            this.TpEmpleados.Controls.Add(this.TpPersonal);
            this.TpEmpleados.Controls.Add(this.TpFinanciar);
            this.TpEmpleados.Controls.Add(this.TpComentarios);
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
            this.TpDireccion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TpDireccion.Location = new System.Drawing.Point(4, 26);
            this.TpDireccion.Name = "TpDireccion";
            this.TpDireccion.Padding = new System.Windows.Forms.Padding(3);
            this.TpDireccion.Size = new System.Drawing.Size(1048, 376);
            this.TpDireccion.TabIndex = 1;
            this.TpDireccion.Text = "Dirección";
            this.TpDireccion.UseVisualStyleBackColor = true;
            // 
            // TpGestion
            // 
            this.TpGestion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TpGestion.Location = new System.Drawing.Point(4, 26);
            this.TpGestion.Name = "TpGestion";
            this.TpGestion.Size = new System.Drawing.Size(1048, 376);
            this.TpGestion.TabIndex = 2;
            this.TpGestion.Text = "Gestión";
            this.TpGestion.UseVisualStyleBackColor = true;
            // 
            // TpPersonal
            // 
            this.TpPersonal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TpPersonal.Location = new System.Drawing.Point(4, 26);
            this.TpPersonal.Name = "TpPersonal";
            this.TpPersonal.Size = new System.Drawing.Size(1048, 376);
            this.TpPersonal.TabIndex = 3;
            this.TpPersonal.Text = "Personal";
            this.TpPersonal.UseVisualStyleBackColor = true;
            // 
            // TpFinanciar
            // 
            this.TpFinanciar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TpFinanciar.Location = new System.Drawing.Point(4, 26);
            this.TpFinanciar.Name = "TpFinanciar";
            this.TpFinanciar.Size = new System.Drawing.Size(1048, 376);
            this.TpFinanciar.TabIndex = 4;
            this.TpFinanciar.Text = "Financiar";
            this.TpFinanciar.UseVisualStyleBackColor = true;
            // 
            // TpComentarios
            // 
            this.TpComentarios.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TpComentarios.Location = new System.Drawing.Point(4, 26);
            this.TpComentarios.Name = "TpComentarios";
            this.TpComentarios.Size = new System.Drawing.Size(1048, 376);
            this.TpComentarios.TabIndex = 5;
            this.TpComentarios.Text = "Comentarios";
            this.TpComentarios.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.TabPage TpFinanciar;
        private System.Windows.Forms.TabPage TpComentarios;
        private System.Windows.Forms.DataGridView DgvEmpleados;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.ComboBox CbArea;
        private System.Windows.Forms.ComboBox CbDepto;
        private System.Windows.Forms.ComboBox CbPuesto;
        private FontAwesome.Sharp.IconButton BtnLimpiar;
    }
}