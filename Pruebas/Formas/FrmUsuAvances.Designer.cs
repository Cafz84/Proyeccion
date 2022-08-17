namespace Pruebas.Formas
{
    partial class FrmUsuAvances
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuAvances));
            this.BtnCerrar = new System.Windows.Forms.PictureBox();
            this.LblTituloUsuario = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TpIndex = new System.Windows.Forms.TabPage();
            this.TpRelacionar = new System.Windows.Forms.TabPage();
            this.TpAvance = new System.Windows.Forms.TabPage();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.DgvUsers = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtBNombre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.TpIndex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.Image")));
            this.BtnCerrar.Location = new System.Drawing.Point(1055, 2);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(23, 23);
            this.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnCerrar.TabIndex = 21;
            this.BtnCerrar.TabStop = false;
            // 
            // LblTituloUsuario
            // 
            this.LblTituloUsuario.AutoSize = true;
            this.LblTituloUsuario.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloUsuario.ForeColor = System.Drawing.Color.White;
            this.LblTituloUsuario.Location = new System.Drawing.Point(386, 2);
            this.LblTituloUsuario.Name = "LblTituloUsuario";
            this.LblTituloUsuario.Size = new System.Drawing.Size(276, 39);
            this.LblTituloUsuario.TabIndex = 22;
            this.LblTituloUsuario.Text = "Usuario Avances";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TpIndex);
            this.tabControl1.Controls.Add(this.TpRelacionar);
            this.tabControl1.Controls.Add(this.TpAvance);
            this.tabControl1.Location = new System.Drawing.Point(2, 246);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1076, 417);
            this.tabControl1.TabIndex = 23;
            // 
            // TpIndex
            // 
            this.TpIndex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.TpIndex.Controls.Add(this.pictureBox1);
            this.TpIndex.Controls.Add(this.TxtBNombre);
            this.TpIndex.Controls.Add(this.DgvUsers);
            this.TpIndex.Location = new System.Drawing.Point(4, 22);
            this.TpIndex.Name = "TpIndex";
            this.TpIndex.Padding = new System.Windows.Forms.Padding(3);
            this.TpIndex.Size = new System.Drawing.Size(1068, 391);
            this.TpIndex.TabIndex = 0;
            this.TpIndex.Text = "Index";
            // 
            // TpRelacionar
            // 
            this.TpRelacionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.TpRelacionar.Location = new System.Drawing.Point(4, 22);
            this.TpRelacionar.Name = "TpRelacionar";
            this.TpRelacionar.Padding = new System.Windows.Forms.Padding(3);
            this.TpRelacionar.Size = new System.Drawing.Size(1068, 391);
            this.TpRelacionar.TabIndex = 1;
            this.TpRelacionar.Text = "Relacionar";
            // 
            // TpAvance
            // 
            this.TpAvance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.TpAvance.Location = new System.Drawing.Point(4, 22);
            this.TpAvance.Name = "TpAvance";
            this.TpAvance.Size = new System.Drawing.Size(1068, 391);
            this.TpAvance.TabIndex = 2;
            this.TpAvance.Text = "Avance";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.DarkRed;
            this.BtnEliminar.Enabled = false;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminar.Image")));
            this.BtnEliminar.Location = new System.Drawing.Point(854, 207);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(214, 51);
            this.BtnEliminar.TabIndex = 87;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEliminar.UseVisualStyleBackColor = false;
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.BackColor = System.Drawing.Color.Goldenrod;
            this.BtnActualizar.Enabled = false;
            this.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActualizar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizar.ForeColor = System.Drawing.Color.White;
            this.BtnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnActualizar.Image")));
            this.BtnActualizar.Location = new System.Drawing.Point(854, 153);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(214, 51);
            this.BtnActualizar.TabIndex = 84;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnActualizar.UseVisualStyleBackColor = false;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.DarkGreen;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.White;
            this.BtnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("BtnAgregar.Image")));
            this.BtnAgregar.Location = new System.Drawing.Point(854, 99);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(214, 51);
            this.BtnAgregar.TabIndex = 86;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAgregar.UseVisualStyleBackColor = false;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.BurlyWood;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.ForeColor = System.Drawing.Color.White;
            this.BtnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("BtnLimpiar.Image")));
            this.BtnLimpiar.Location = new System.Drawing.Point(854, 45);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(214, 51);
            this.BtnLimpiar.TabIndex = 85;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            // 
            // DgvUsers
            // 
            this.DgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar});
            this.DgvUsers.Location = new System.Drawing.Point(0, 36);
            this.DgvUsers.Name = "DgvUsers";
            this.DgvUsers.RowHeadersVisible = false;
            this.DgvUsers.Size = new System.Drawing.Size(1068, 355);
            this.DgvUsers.TabIndex = 1;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Edit";
            this.Editar.Image = ((System.Drawing.Image)(resources.GetObject("Editar.Image")));
            this.Editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Editar.Name = "Editar";
            this.Editar.Width = 55;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pruebas.Properties.Resources.xmag_search_find_export_locate_32x32;
            this.pictureBox1.Location = new System.Drawing.Point(2, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 131;
            this.pictureBox1.TabStop = false;
            // 
            // TxtBNombre
            // 
            this.TxtBNombre.BackColor = System.Drawing.Color.LightGray;
            this.TxtBNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBNombre.Location = new System.Drawing.Point(38, 5);
            this.TxtBNombre.MaxLength = 50;
            this.TxtBNombre.Name = "TxtBNombre";
            this.TxtBNombre.Size = new System.Drawing.Size(234, 27);
            this.TxtBNombre.TabIndex = 132;
            // 
            // FrmUsuAvances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1080, 665);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.LblTituloUsuario);
            this.Controls.Add(this.BtnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUsuAvances";
            this.Text = "FrmUsuAvances";
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.TpIndex.ResumeLayout(false);
            this.TpIndex.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BtnCerrar;
        private System.Windows.Forms.Label LblTituloUsuario;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TpIndex;
        private System.Windows.Forms.TabPage TpRelacionar;
        private System.Windows.Forms.TabPage TpAvance;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.DataGridView DgvUsers;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TxtBNombre;
    }
}