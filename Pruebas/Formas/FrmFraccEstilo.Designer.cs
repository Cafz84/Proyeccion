namespace Pruebas.Formas
{
    partial class FrmFraccEstilo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFraccEstilo));
            this.LblTituloFraccEstilo = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.PictureBox();
            this.DgvEstilo = new System.Windows.Forms.DataGridView();
            this.DgvFraccEstilo = new System.Windows.Forms.DataGridView();
            this.LblIdE = new System.Windows.Forms.Label();
            this.LblNomE = new System.Windows.Forms.Label();
            this.LblCodE = new System.Windows.Forms.Label();
            this.GbEstilo = new System.Windows.Forms.GroupBox();
            this.LblNomEstilo = new System.Windows.Forms.Label();
            this.LblCodEstilo = new System.Windows.Forms.Label();
            this.LblIdEstilo = new System.Windows.Forms.Label();
            this.GbFraccion = new System.Windows.Forms.GroupBox();
            this.LblNomFraccion = new System.Windows.Forms.Label();
            this.LblCodFraccion = new System.Windows.Forms.Label();
            this.LblIdFraccion = new System.Windows.Forms.Label();
            this.LblIdF = new System.Windows.Forms.Label();
            this.LblNomF = new System.Windows.Forms.Label();
            this.LblCodF = new System.Windows.Forms.Label();
            this.SelE = new System.Windows.Forms.DataGridViewImageColumn();
            this.DgvFraccion = new System.Windows.Forms.DataGridView();
            this.SelF = new System.Windows.Forms.DataGridViewImageColumn();
            this.EditFE = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEstilo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFraccEstilo)).BeginInit();
            this.GbEstilo.SuspendLayout();
            this.GbFraccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFraccion)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTituloFraccEstilo
            // 
            this.LblTituloFraccEstilo.AutoSize = true;
            this.LblTituloFraccEstilo.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloFraccEstilo.ForeColor = System.Drawing.Color.White;
            this.LblTituloFraccEstilo.Location = new System.Drawing.Point(262, 9);
            this.LblTituloFraccEstilo.Name = "LblTituloFraccEstilo";
            this.LblTituloFraccEstilo.Size = new System.Drawing.Size(332, 39);
            this.LblTituloFraccEstilo.TabIndex = 49;
            this.LblTituloFraccEstilo.Text = "Fracciones por Estilo";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.DarkRed;
            this.BtnEliminar.Enabled = false;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminar.Image")));
            this.BtnEliminar.Location = new System.Drawing.Point(854, 191);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(214, 51);
            this.BtnEliminar.TabIndex = 88;
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
            this.BtnActualizar.Location = new System.Drawing.Point(854, 137);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(214, 51);
            this.BtnActualizar.TabIndex = 85;
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
            this.BtnAgregar.Location = new System.Drawing.Point(854, 83);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(214, 51);
            this.BtnAgregar.TabIndex = 87;
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
            this.BtnLimpiar.Location = new System.Drawing.Point(854, 28);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(214, 51);
            this.BtnLimpiar.TabIndex = 86;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.Image")));
            this.BtnCerrar.Location = new System.Drawing.Point(1060, 0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(21, 24);
            this.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnCerrar.TabIndex = 84;
            this.BtnCerrar.TabStop = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // DgvEstilo
            // 
            this.DgvEstilo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEstilo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelE});
            this.DgvEstilo.Location = new System.Drawing.Point(340, 249);
            this.DgvEstilo.Name = "DgvEstilo";
            this.DgvEstilo.Size = new System.Drawing.Size(364, 411);
            this.DgvEstilo.TabIndex = 89;
            this.DgvEstilo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEstilo_CellContentClick);
            // 
            // DgvFraccEstilo
            // 
            this.DgvFraccEstilo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFraccEstilo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EditFE});
            this.DgvFraccEstilo.Location = new System.Drawing.Point(5, 249);
            this.DgvFraccEstilo.Name = "DgvFraccEstilo";
            this.DgvFraccEstilo.Size = new System.Drawing.Size(329, 411);
            this.DgvFraccEstilo.TabIndex = 91;
            // 
            // LblIdE
            // 
            this.LblIdE.AutoSize = true;
            this.LblIdE.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIdE.ForeColor = System.Drawing.Color.White;
            this.LblIdE.Location = new System.Drawing.Point(10, 27);
            this.LblIdE.Name = "LblIdE";
            this.LblIdE.Size = new System.Drawing.Size(33, 22);
            this.LblIdE.TabIndex = 92;
            this.LblIdE.Text = "Id:";
            // 
            // LblNomE
            // 
            this.LblNomE.AutoSize = true;
            this.LblNomE.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNomE.ForeColor = System.Drawing.Color.White;
            this.LblNomE.Location = new System.Drawing.Point(6, 61);
            this.LblNomE.Name = "LblNomE";
            this.LblNomE.Size = new System.Drawing.Size(89, 22);
            this.LblNomE.TabIndex = 93;
            this.LblNomE.Text = "Nombre:";
            // 
            // LblCodE
            // 
            this.LblCodE.AutoSize = true;
            this.LblCodE.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodE.ForeColor = System.Drawing.Color.White;
            this.LblCodE.Location = new System.Drawing.Point(345, 27);
            this.LblCodE.Name = "LblCodE";
            this.LblCodE.Size = new System.Drawing.Size(83, 22);
            this.LblCodE.TabIndex = 94;
            this.LblCodE.Text = "Código:";
            // 
            // GbEstilo
            // 
            this.GbEstilo.Controls.Add(this.LblNomEstilo);
            this.GbEstilo.Controls.Add(this.LblCodEstilo);
            this.GbEstilo.Controls.Add(this.LblIdEstilo);
            this.GbEstilo.Controls.Add(this.LblIdE);
            this.GbEstilo.Controls.Add(this.LblNomE);
            this.GbEstilo.Controls.Add(this.LblCodE);
            this.GbEstilo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbEstilo.ForeColor = System.Drawing.Color.White;
            this.GbEstilo.Location = new System.Drawing.Point(29, 51);
            this.GbEstilo.Name = "GbEstilo";
            this.GbEstilo.Size = new System.Drawing.Size(805, 94);
            this.GbEstilo.TabIndex = 95;
            this.GbEstilo.TabStop = false;
            this.GbEstilo.Text = "Datos Estilo";
            // 
            // LblNomEstilo
            // 
            this.LblNomEstilo.AutoSize = true;
            this.LblNomEstilo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNomEstilo.ForeColor = System.Drawing.Color.Black;
            this.LblNomEstilo.Location = new System.Drawing.Point(101, 61);
            this.LblNomEstilo.Name = "LblNomEstilo";
            this.LblNomEstilo.Size = new System.Drawing.Size(0, 22);
            this.LblNomEstilo.TabIndex = 99;
            // 
            // LblCodEstilo
            // 
            this.LblCodEstilo.AutoSize = true;
            this.LblCodEstilo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodEstilo.ForeColor = System.Drawing.Color.Black;
            this.LblCodEstilo.Location = new System.Drawing.Point(434, 27);
            this.LblCodEstilo.Name = "LblCodEstilo";
            this.LblCodEstilo.Size = new System.Drawing.Size(0, 22);
            this.LblCodEstilo.TabIndex = 96;
            // 
            // LblIdEstilo
            // 
            this.LblIdEstilo.AutoSize = true;
            this.LblIdEstilo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIdEstilo.ForeColor = System.Drawing.Color.Black;
            this.LblIdEstilo.Location = new System.Drawing.Point(49, 27);
            this.LblIdEstilo.Name = "LblIdEstilo";
            this.LblIdEstilo.Size = new System.Drawing.Size(0, 22);
            this.LblIdEstilo.TabIndex = 95;
            // 
            // GbFraccion
            // 
            this.GbFraccion.Controls.Add(this.LblNomFraccion);
            this.GbFraccion.Controls.Add(this.LblCodFraccion);
            this.GbFraccion.Controls.Add(this.LblIdFraccion);
            this.GbFraccion.Controls.Add(this.LblIdF);
            this.GbFraccion.Controls.Add(this.LblNomF);
            this.GbFraccion.Controls.Add(this.LblCodF);
            this.GbFraccion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbFraccion.ForeColor = System.Drawing.Color.White;
            this.GbFraccion.Location = new System.Drawing.Point(29, 148);
            this.GbFraccion.Name = "GbFraccion";
            this.GbFraccion.Size = new System.Drawing.Size(805, 94);
            this.GbFraccion.TabIndex = 96;
            this.GbFraccion.TabStop = false;
            this.GbFraccion.Text = "Datos Fracción";
            // 
            // LblNomFraccion
            // 
            this.LblNomFraccion.AutoSize = true;
            this.LblNomFraccion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNomFraccion.ForeColor = System.Drawing.Color.Black;
            this.LblNomFraccion.Location = new System.Drawing.Point(101, 61);
            this.LblNomFraccion.Name = "LblNomFraccion";
            this.LblNomFraccion.Size = new System.Drawing.Size(0, 22);
            this.LblNomFraccion.TabIndex = 98;
            // 
            // LblCodFraccion
            // 
            this.LblCodFraccion.AutoSize = true;
            this.LblCodFraccion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodFraccion.ForeColor = System.Drawing.Color.Black;
            this.LblCodFraccion.Location = new System.Drawing.Point(434, 27);
            this.LblCodFraccion.Name = "LblCodFraccion";
            this.LblCodFraccion.Size = new System.Drawing.Size(0, 22);
            this.LblCodFraccion.TabIndex = 97;
            // 
            // LblIdFraccion
            // 
            this.LblIdFraccion.AutoSize = true;
            this.LblIdFraccion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIdFraccion.ForeColor = System.Drawing.Color.Black;
            this.LblIdFraccion.Location = new System.Drawing.Point(49, 27);
            this.LblIdFraccion.Name = "LblIdFraccion";
            this.LblIdFraccion.Size = new System.Drawing.Size(0, 22);
            this.LblIdFraccion.TabIndex = 96;
            // 
            // LblIdF
            // 
            this.LblIdF.AutoSize = true;
            this.LblIdF.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIdF.ForeColor = System.Drawing.Color.White;
            this.LblIdF.Location = new System.Drawing.Point(10, 27);
            this.LblIdF.Name = "LblIdF";
            this.LblIdF.Size = new System.Drawing.Size(33, 22);
            this.LblIdF.TabIndex = 92;
            this.LblIdF.Text = "Id:";
            // 
            // LblNomF
            // 
            this.LblNomF.AutoSize = true;
            this.LblNomF.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNomF.ForeColor = System.Drawing.Color.White;
            this.LblNomF.Location = new System.Drawing.Point(6, 61);
            this.LblNomF.Name = "LblNomF";
            this.LblNomF.Size = new System.Drawing.Size(89, 22);
            this.LblNomF.TabIndex = 93;
            this.LblNomF.Text = "Nombre:";
            // 
            // LblCodF
            // 
            this.LblCodF.AutoSize = true;
            this.LblCodF.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodF.ForeColor = System.Drawing.Color.White;
            this.LblCodF.Location = new System.Drawing.Point(345, 27);
            this.LblCodF.Name = "LblCodF";
            this.LblCodF.Size = new System.Drawing.Size(83, 22);
            this.LblCodF.TabIndex = 94;
            this.LblCodF.Text = "Código:";
            // 
            // SelE
            // 
            this.SelE.HeaderText = "Sel";
            this.SelE.Image = ((System.Drawing.Image)(resources.GetObject("SelE.Image")));
            this.SelE.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.SelE.Name = "SelE";
            this.SelE.Width = 35;
            // 
            // DgvFraccion
            // 
            this.DgvFraccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFraccion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelF});
            this.DgvFraccion.Location = new System.Drawing.Point(710, 248);
            this.DgvFraccion.Name = "DgvFraccion";
            this.DgvFraccion.Size = new System.Drawing.Size(364, 411);
            this.DgvFraccion.TabIndex = 97;
            this.DgvFraccion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvFraccion_CellContentClick);
            // 
            // SelF
            // 
            this.SelF.HeaderText = "Sel";
            this.SelF.Image = ((System.Drawing.Image)(resources.GetObject("SelF.Image")));
            this.SelF.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.SelF.Name = "SelF";
            this.SelF.Width = 35;
            // 
            // EditFE
            // 
            this.EditFE.HeaderText = "Editar";
            this.EditFE.Image = ((System.Drawing.Image)(resources.GetObject("EditFE.Image")));
            this.EditFE.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.EditFE.Name = "EditFE";
            this.EditFE.Width = 40;
            // 
            // FrmFraccEstilo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1080, 665);
            this.Controls.Add(this.DgvFraccion);
            this.Controls.Add(this.GbFraccion);
            this.Controls.Add(this.GbEstilo);
            this.Controls.Add(this.DgvFraccEstilo);
            this.Controls.Add(this.DgvEstilo);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.LblTituloFraccEstilo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmFraccEstilo";
            this.Text = "FrmFraccEstilo";
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEstilo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFraccEstilo)).EndInit();
            this.GbEstilo.ResumeLayout(false);
            this.GbEstilo.PerformLayout();
            this.GbFraccion.ResumeLayout(false);
            this.GbFraccion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFraccion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTituloFraccEstilo;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.PictureBox BtnCerrar;
        private System.Windows.Forms.DataGridView DgvEstilo;
        private System.Windows.Forms.DataGridView DgvFraccEstilo;
        private System.Windows.Forms.Label LblIdE;
        private System.Windows.Forms.Label LblNomE;
        private System.Windows.Forms.Label LblCodE;
        private System.Windows.Forms.GroupBox GbEstilo;
        private System.Windows.Forms.GroupBox GbFraccion;
        private System.Windows.Forms.Label LblIdF;
        private System.Windows.Forms.Label LblNomF;
        private System.Windows.Forms.Label LblCodF;
        private System.Windows.Forms.Label LblNomEstilo;
        private System.Windows.Forms.Label LblCodEstilo;
        private System.Windows.Forms.Label LblIdEstilo;
        private System.Windows.Forms.Label LblNomFraccion;
        private System.Windows.Forms.Label LblCodFraccion;
        private System.Windows.Forms.Label LblIdFraccion;
        private System.Windows.Forms.DataGridViewImageColumn SelE;
        private System.Windows.Forms.DataGridView DgvFraccion;
        private System.Windows.Forms.DataGridViewImageColumn SelF;
        private System.Windows.Forms.DataGridViewImageColumn EditFE;
    }
}