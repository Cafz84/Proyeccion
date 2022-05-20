namespace Pruebas.Formas
{
    partial class FrmPuesto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPuesto));
            this.ChkActivo = new System.Windows.Forms.CheckBox();
            this.LblPuestoId = new System.Windows.Forms.Label();
            this.LblIdPuesto = new System.Windows.Forms.Label();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.DgvPuesto = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.BtnCerrar = new System.Windows.Forms.PictureBox();
            this.LblTituloPuesto = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPuesto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // ChkActivo
            // 
            this.ChkActivo.AutoSize = true;
            this.ChkActivo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkActivo.ForeColor = System.Drawing.Color.White;
            this.ChkActivo.Location = new System.Drawing.Point(128, 47);
            this.ChkActivo.Name = "ChkActivo";
            this.ChkActivo.Size = new System.Drawing.Size(91, 26);
            this.ChkActivo.TabIndex = 56;
            this.ChkActivo.Text = "Activo";
            this.ChkActivo.UseVisualStyleBackColor = true;
            // 
            // LblPuestoId
            // 
            this.LblPuestoId.AutoSize = true;
            this.LblPuestoId.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPuestoId.ForeColor = System.Drawing.Color.Black;
            this.LblPuestoId.Location = new System.Drawing.Point(42, 51);
            this.LblPuestoId.Name = "LblPuestoId";
            this.LblPuestoId.Size = new System.Drawing.Size(0, 22);
            this.LblPuestoId.TabIndex = 54;
            // 
            // LblIdPuesto
            // 
            this.LblIdPuesto.AutoSize = true;
            this.LblIdPuesto.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIdPuesto.ForeColor = System.Drawing.Color.White;
            this.LblIdPuesto.Location = new System.Drawing.Point(12, 51);
            this.LblIdPuesto.Name = "LblIdPuesto";
            this.LblIdPuesto.Size = new System.Drawing.Size(33, 22);
            this.LblIdPuesto.TabIndex = 53;
            this.LblIdPuesto.Text = "Id:";
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.TxtDescripcion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescripcion.Location = new System.Drawing.Point(128, 122);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(404, 31);
            this.TxtDescripcion.TabIndex = 2;
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescripcion.ForeColor = System.Drawing.Color.White;
            this.LblDescripcion.Location = new System.Drawing.Point(12, 126);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(121, 22);
            this.LblDescripcion.TabIndex = 52;
            this.LblDescripcion.Text = "Descripcion:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.TxtNombre.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(128, 83);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(404, 31);
            this.TxtNombre.TabIndex = 1;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.ForeColor = System.Drawing.Color.White;
            this.LblNombre.Location = new System.Drawing.Point(12, 89);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(89, 22);
            this.LblNombre.TabIndex = 51;
            this.LblNombre.Text = "Nombre:";
            // 
            // DgvPuesto
            // 
            this.DgvPuesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPuesto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar});
            this.DgvPuesto.Location = new System.Drawing.Point(11, 165);
            this.DgvPuesto.Name = "DgvPuesto";
            this.DgvPuesto.ReadOnly = true;
            this.DgvPuesto.Size = new System.Drawing.Size(658, 273);
            this.DgvPuesto.TabIndex = 50;
            this.DgvPuesto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPuesto_CellContentClick);
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = ((System.Drawing.Image)(resources.GetObject("Editar.Image")));
            this.Editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Width = 55;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.Image")));
            this.BtnCerrar.Location = new System.Drawing.Point(660, 0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(22, 20);
            this.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnCerrar.TabIndex = 46;
            this.BtnCerrar.TabStop = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // LblTituloPuesto
            // 
            this.LblTituloPuesto.AutoSize = true;
            this.LblTituloPuesto.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloPuesto.ForeColor = System.Drawing.Color.White;
            this.LblTituloPuesto.Location = new System.Drawing.Point(285, 0);
            this.LblTituloPuesto.Name = "LblTituloPuesto";
            this.LblTituloPuesto.Size = new System.Drawing.Size(119, 39);
            this.LblTituloPuesto.TabIndex = 45;
            this.LblTituloPuesto.Text = "Puesto";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.DarkRed;
            this.BtnEliminar.Enabled = false;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminar.Image")));
            this.BtnEliminar.Location = new System.Drawing.Point(539, 122);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(131, 37);
            this.BtnEliminar.TabIndex = 86;
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
            this.BtnActualizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizar.ForeColor = System.Drawing.Color.White;
            this.BtnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnActualizar.Image")));
            this.BtnActualizar.Location = new System.Drawing.Point(539, 79);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(131, 37);
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
            this.BtnAgregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.White;
            this.BtnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("BtnAgregar.Image")));
            this.BtnAgregar.Location = new System.Drawing.Point(539, 36);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(131, 37);
            this.BtnAgregar.TabIndex = 84;
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
            this.BtnLimpiar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.ForeColor = System.Drawing.Color.White;
            this.BtnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("BtnLimpiar.Image")));
            this.BtnLimpiar.Location = new System.Drawing.Point(402, 36);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(131, 37);
            this.BtnLimpiar.TabIndex = 83;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // FrmPuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(682, 450);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.ChkActivo);
            this.Controls.Add(this.LblPuestoId);
            this.Controls.Add(this.LblIdPuesto);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.LblDescripcion);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.DgvPuesto);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.LblTituloPuesto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPuesto";
            this.Text = "FrmPuesto";
            ((System.ComponentModel.ISupportInitialize)(this.DgvPuesto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ChkActivo;
        private System.Windows.Forms.Label LblPuestoId;
        private System.Windows.Forms.Label LblIdPuesto;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.DataGridView DgvPuesto;
        private System.Windows.Forms.PictureBox BtnCerrar;
        private System.Windows.Forms.Label LblTituloPuesto;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnLimpiar;
    }
}