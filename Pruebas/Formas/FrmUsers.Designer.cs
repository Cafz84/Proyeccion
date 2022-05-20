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
            this.DgvUsers = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.LblUserId = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.PictureBox();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTituloUsuario
            // 
            this.LblTituloUsuario.AutoSize = true;
            this.LblTituloUsuario.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloUsuario.ForeColor = System.Drawing.Color.White;
            this.LblTituloUsuario.Location = new System.Drawing.Point(459, 9);
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
            this.LblId.Location = new System.Drawing.Point(26, 65);
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
            this.LblNombre.Location = new System.Drawing.Point(125, 65);
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
            this.LblApellido.Location = new System.Drawing.Point(125, 103);
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
            this.LblPuesto.Location = new System.Drawing.Point(159, 140);
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
            this.LblUsuario.Location = new System.Drawing.Point(155, 177);
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
            this.Contraseña.Location = new System.Drawing.Point(451, 177);
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
            this.LblEmail.Location = new System.Drawing.Point(174, 214);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(61, 22);
            this.LblEmail.TabIndex = 7;
            this.LblEmail.Text = "Email:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.TxtNombre.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(232, 62);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(578, 31);
            this.TxtNombre.TabIndex = 8;
            // 
            // TxtApellido
            // 
            this.TxtApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.TxtApellido.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApellido.Location = new System.Drawing.Point(232, 100);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(578, 31);
            this.TxtApellido.TabIndex = 9;
            // 
            // TxtPuesto
            // 
            this.TxtPuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.TxtPuesto.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPuesto.Location = new System.Drawing.Point(232, 137);
            this.TxtPuesto.Name = "TxtPuesto";
            this.TxtPuesto.Size = new System.Drawing.Size(578, 31);
            this.TxtPuesto.TabIndex = 10;
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.TxtUsuario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuario.Location = new System.Drawing.Point(232, 174);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(213, 31);
            this.TxtUsuario.TabIndex = 11;
            // 
            // TxtContrasena
            // 
            this.TxtContrasena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.TxtContrasena.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContrasena.Location = new System.Drawing.Point(572, 174);
            this.TxtContrasena.Name = "TxtContrasena";
            this.TxtContrasena.Size = new System.Drawing.Size(238, 31);
            this.TxtContrasena.TabIndex = 12;
            // 
            // TxtEmail
            // 
            this.TxtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.TxtEmail.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.Location = new System.Drawing.Point(232, 211);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(578, 31);
            this.TxtEmail.TabIndex = 13;
            // 
            // DgvUsers
            // 
            this.DgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar});
            this.DgvUsers.Location = new System.Drawing.Point(12, 257);
            this.DgvUsers.Name = "DgvUsers";
            this.DgvUsers.Size = new System.Drawing.Size(1056, 396);
            this.DgvUsers.TabIndex = 14;
            this.DgvUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvUsers_CellContentClick);
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = ((System.Drawing.Image)(resources.GetObject("Editar.Image")));
            this.Editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Width = 40;
            // 
            // LblUserId
            // 
            this.LblUserId.AutoSize = true;
            this.LblUserId.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserId.ForeColor = System.Drawing.Color.Black;
            this.LblUserId.Location = new System.Drawing.Point(56, 65);
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
            this.BtnEliminar.Location = new System.Drawing.Point(827, 198);
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
            this.BtnActualizar.Location = new System.Drawing.Point(827, 144);
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
            this.BtnAgregar.Location = new System.Drawing.Point(827, 90);
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
            this.BtnLimpiar.Enabled = false;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.ForeColor = System.Drawing.Color.White;
            this.BtnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("BtnLimpiar.Image")));
            this.BtnLimpiar.Location = new System.Drawing.Point(827, 36);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(214, 51);
            this.BtnLimpiar.TabIndex = 81;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            // 
            // FrmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1080, 665);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.LblUserId);
            this.Controls.Add(this.DgvUsers);
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
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
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
        private System.Windows.Forms.DataGridView DgvUsers;
        private System.Windows.Forms.Label LblUserId;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.PictureBox BtnCerrar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnLimpiar;
    }
}