﻿namespace Pruebas.Formas
{
    partial class FrmRGrupoEmp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRGrupoEmp));
            this.TcRelacion = new System.Windows.Forms.TabControl();
            this.TpIndex = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtBGrupo = new System.Windows.Forms.TextBox();
            this.DgvRelacion = new System.Windows.Forms.DataGridView();
            this.TpRelacionar = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.TxtBEmpleado = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TxtBRGrupo = new System.Windows.Forms.TextBox();
            this.DgvEmpleado = new System.Windows.Forms.DataGridView();
            this.SelE = new System.Windows.Forms.DataGridViewImageColumn();
            this.DgvGrupo = new System.Windows.Forms.DataGridView();
            this.SelG = new System.Windows.Forms.DataGridViewImageColumn();
            this.LblTituloRelacionar = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.PictureBox();
            this.LblTGrupo = new System.Windows.Forms.Label();
            this.LblTEmpleado = new System.Windows.Forms.Label();
            this.LblEmpleado = new System.Windows.Forms.Label();
            this.LblGrupo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPorcentaje = new System.Windows.Forms.TextBox();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.TcRelacion.SuspendLayout();
            this.TpIndex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRelacion)).BeginInit();
            this.TpRelacionar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGrupo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // TcRelacion
            // 
            this.TcRelacion.Controls.Add(this.TpIndex);
            this.TcRelacion.Controls.Add(this.TpRelacionar);
            this.TcRelacion.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TcRelacion.Location = new System.Drawing.Point(3, 131);
            this.TcRelacion.Name = "TcRelacion";
            this.TcRelacion.SelectedIndex = 0;
            this.TcRelacion.Size = new System.Drawing.Size(794, 317);
            this.TcRelacion.TabIndex = 3;
            // 
            // TpIndex
            // 
            this.TpIndex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.TpIndex.Controls.Add(this.pictureBox1);
            this.TpIndex.Controls.Add(this.TxtBGrupo);
            this.TpIndex.Controls.Add(this.DgvRelacion);
            this.TpIndex.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TpIndex.Location = new System.Drawing.Point(4, 25);
            this.TpIndex.Name = "TpIndex";
            this.TpIndex.Padding = new System.Windows.Forms.Padding(3);
            this.TpIndex.Size = new System.Drawing.Size(786, 288);
            this.TpIndex.TabIndex = 0;
            this.TpIndex.Text = "Index";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pruebas.Properties.Resources.xmag_search_find_export_locate_32x32;
            this.pictureBox1.Location = new System.Drawing.Point(6, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 131;
            this.pictureBox1.TabStop = false;
            // 
            // TxtBGrupo
            // 
            this.TxtBGrupo.BackColor = System.Drawing.Color.LightGray;
            this.TxtBGrupo.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.TxtBGrupo.Location = new System.Drawing.Point(35, 2);
            this.TxtBGrupo.MaxLength = 50;
            this.TxtBGrupo.Name = "TxtBGrupo";
            this.TxtBGrupo.Size = new System.Drawing.Size(134, 21);
            this.TxtBGrupo.TabIndex = 132;
            this.TxtBGrupo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtBGrupo.TextChanged += new System.EventHandler(this.TxtBGrupo_TextChanged);
            // 
            // DgvRelacion
            // 
            this.DgvRelacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvRelacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar});
            this.DgvRelacion.Location = new System.Drawing.Point(0, 25);
            this.DgvRelacion.Name = "DgvRelacion";
            this.DgvRelacion.Size = new System.Drawing.Size(786, 263);
            this.DgvRelacion.TabIndex = 0;
            this.DgvRelacion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvRelacion_CellContentClick);
            // 
            // TpRelacionar
            // 
            this.TpRelacionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.TpRelacionar.Controls.Add(this.pictureBox3);
            this.TpRelacionar.Controls.Add(this.TxtBEmpleado);
            this.TpRelacionar.Controls.Add(this.pictureBox2);
            this.TpRelacionar.Controls.Add(this.TxtBRGrupo);
            this.TpRelacionar.Controls.Add(this.DgvEmpleado);
            this.TpRelacionar.Controls.Add(this.DgvGrupo);
            this.TpRelacionar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TpRelacionar.Location = new System.Drawing.Point(4, 25);
            this.TpRelacionar.Name = "TpRelacionar";
            this.TpRelacionar.Padding = new System.Windows.Forms.Padding(3);
            this.TpRelacionar.Size = new System.Drawing.Size(786, 288);
            this.TpRelacionar.TabIndex = 1;
            this.TpRelacionar.Text = "Relacionar";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Pruebas.Properties.Resources.xmag_search_find_export_locate_32x32;
            this.pictureBox3.Location = new System.Drawing.Point(408, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(23, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 135;
            this.pictureBox3.TabStop = false;
            // 
            // TxtBEmpleado
            // 
            this.TxtBEmpleado.BackColor = System.Drawing.Color.LightGray;
            this.TxtBEmpleado.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.TxtBEmpleado.Location = new System.Drawing.Point(437, 2);
            this.TxtBEmpleado.MaxLength = 50;
            this.TxtBEmpleado.Name = "TxtBEmpleado";
            this.TxtBEmpleado.Size = new System.Drawing.Size(134, 21);
            this.TxtBEmpleado.TabIndex = 136;
            this.TxtBEmpleado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtBEmpleado.TextChanged += new System.EventHandler(this.TxtBEmpleado_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Pruebas.Properties.Resources.xmag_search_find_export_locate_32x32;
            this.pictureBox2.Location = new System.Drawing.Point(6, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 133;
            this.pictureBox2.TabStop = false;
            // 
            // TxtBRGrupo
            // 
            this.TxtBRGrupo.BackColor = System.Drawing.Color.LightGray;
            this.TxtBRGrupo.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.TxtBRGrupo.Location = new System.Drawing.Point(35, 2);
            this.TxtBRGrupo.MaxLength = 50;
            this.TxtBRGrupo.Name = "TxtBRGrupo";
            this.TxtBRGrupo.Size = new System.Drawing.Size(134, 21);
            this.TxtBRGrupo.TabIndex = 134;
            this.TxtBRGrupo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtBRGrupo.TextChanged += new System.EventHandler(this.TxtBRGrupo_TextChanged);
            // 
            // DgvEmpleado
            // 
            this.DgvEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEmpleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelE});
            this.DgvEmpleado.Location = new System.Drawing.Point(398, 25);
            this.DgvEmpleado.Name = "DgvEmpleado";
            this.DgvEmpleado.Size = new System.Drawing.Size(388, 263);
            this.DgvEmpleado.TabIndex = 2;
            this.DgvEmpleado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEmpleado_CellContentClick);
            // 
            // SelE
            // 
            this.SelE.HeaderText = "Sel";
            this.SelE.Image = global::Pruebas.Properties.Resources._3592869_compose_create_edit_edit_file_office_pencil_writing_creative_107746;
            this.SelE.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.SelE.Name = "SelE";
            this.SelE.Width = 55;
            // 
            // DgvGrupo
            // 
            this.DgvGrupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvGrupo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelG});
            this.DgvGrupo.Location = new System.Drawing.Point(0, 25);
            this.DgvGrupo.Name = "DgvGrupo";
            this.DgvGrupo.Size = new System.Drawing.Size(392, 263);
            this.DgvGrupo.TabIndex = 1;
            this.DgvGrupo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvGrupo_CellContentClick);
            // 
            // SelG
            // 
            this.SelG.HeaderText = "Sel";
            this.SelG.Image = global::Pruebas.Properties.Resources._3592869_compose_create_edit_edit_file_office_pencil_writing_creative_107746;
            this.SelG.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.SelG.Name = "SelG";
            this.SelG.Width = 55;
            // 
            // LblTituloRelacionar
            // 
            this.LblTituloRelacionar.AutoSize = true;
            this.LblTituloRelacionar.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloRelacionar.ForeColor = System.Drawing.Color.White;
            this.LblTituloRelacionar.Location = new System.Drawing.Point(309, 0);
            this.LblTituloRelacionar.Name = "LblTituloRelacionar";
            this.LblTituloRelacionar.Size = new System.Drawing.Size(170, 36);
            this.LblTituloRelacionar.TabIndex = 4;
            this.LblTituloRelacionar.Text = "Relacionar";
            this.LblTituloRelacionar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LblTituloRelacionar_MouseDown);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.DarkRed;
            this.BtnEliminar.Enabled = false;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminar.Image")));
            this.BtnEliminar.Location = new System.Drawing.Point(662, 111);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(131, 37);
            this.BtnEliminar.TabIndex = 64;
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
            this.BtnActualizar.Location = new System.Drawing.Point(662, 68);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(131, 37);
            this.BtnActualizar.TabIndex = 63;
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
            this.BtnAgregar.Location = new System.Drawing.Point(662, 25);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(131, 37);
            this.BtnAgregar.TabIndex = 62;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.BurlyWood;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.ForeColor = System.Drawing.Color.White;
            this.BtnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("BtnLimpiar.Image")));
            this.BtnLimpiar.Location = new System.Drawing.Point(525, 25);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(131, 37);
            this.BtnLimpiar.TabIndex = 61;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.Image")));
            this.BtnCerrar.Location = new System.Drawing.Point(775, 2);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(22, 20);
            this.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnCerrar.TabIndex = 65;
            this.BtnCerrar.TabStop = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // LblTGrupo
            // 
            this.LblTGrupo.AutoSize = true;
            this.LblTGrupo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTGrupo.ForeColor = System.Drawing.Color.White;
            this.LblTGrupo.Location = new System.Drawing.Point(21, 49);
            this.LblTGrupo.Name = "LblTGrupo";
            this.LblTGrupo.Size = new System.Drawing.Size(75, 22);
            this.LblTGrupo.TabIndex = 66;
            this.LblTGrupo.Text = "Grupo:";
            // 
            // LblTEmpleado
            // 
            this.LblTEmpleado.AutoSize = true;
            this.LblTEmpleado.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTEmpleado.ForeColor = System.Drawing.Color.White;
            this.LblTEmpleado.Location = new System.Drawing.Point(21, 92);
            this.LblTEmpleado.Name = "LblTEmpleado";
            this.LblTEmpleado.Size = new System.Drawing.Size(108, 22);
            this.LblTEmpleado.TabIndex = 67;
            this.LblTEmpleado.Text = "Empleado:";
            // 
            // LblEmpleado
            // 
            this.LblEmpleado.AutoSize = true;
            this.LblEmpleado.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmpleado.ForeColor = System.Drawing.Color.Black;
            this.LblEmpleado.Location = new System.Drawing.Point(130, 92);
            this.LblEmpleado.Name = "LblEmpleado";
            this.LblEmpleado.Size = new System.Drawing.Size(0, 22);
            this.LblEmpleado.TabIndex = 69;
            // 
            // LblGrupo
            // 
            this.LblGrupo.AutoSize = true;
            this.LblGrupo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGrupo.ForeColor = System.Drawing.Color.Black;
            this.LblGrupo.Location = new System.Drawing.Point(130, 49);
            this.LblGrupo.Name = "LblGrupo";
            this.LblGrupo.Size = new System.Drawing.Size(0, 22);
            this.LblGrupo.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(567, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 22);
            this.label1.TabIndex = 70;
            this.label1.Text = "%";
            // 
            // TxtPorcentaje
            // 
            this.TxtPorcentaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.TxtPorcentaje.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPorcentaje.Location = new System.Drawing.Point(593, 89);
            this.TxtPorcentaje.MaxLength = 50;
            this.TxtPorcentaje.Name = "TxtPorcentaje";
            this.TxtPorcentaje.Size = new System.Drawing.Size(63, 31);
            this.TxtPorcentaje.TabIndex = 71;
            this.TxtPorcentaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Edit";
            this.Editar.Image = ((System.Drawing.Image)(resources.GetObject("Editar.Image")));
            this.Editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Editar.Name = "Editar";
            this.Editar.Width = 55;
            // 
            // FrmRGrupoEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtPorcentaje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblEmpleado);
            this.Controls.Add(this.LblGrupo);
            this.Controls.Add(this.LblTEmpleado);
            this.Controls.Add(this.LblTGrupo);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.LblTituloRelacionar);
            this.Controls.Add(this.TcRelacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRGrupoEmp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmRGrupoEmp";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmRGrupoEmp_MouseDown);
            this.TcRelacion.ResumeLayout(false);
            this.TpIndex.ResumeLayout(false);
            this.TpIndex.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRelacion)).EndInit();
            this.TpRelacionar.ResumeLayout(false);
            this.TpRelacionar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGrupo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TcRelacion;
        private System.Windows.Forms.TabPage TpIndex;
        private System.Windows.Forms.DataGridView DgvRelacion;
        private System.Windows.Forms.TabPage TpRelacionar;
        private System.Windows.Forms.DataGridView DgvEmpleado;
        private System.Windows.Forms.DataGridView DgvGrupo;
        private System.Windows.Forms.Label LblTituloRelacionar;
        private System.Windows.Forms.DataGridViewImageColumn SelE;
        private System.Windows.Forms.DataGridViewImageColumn SelG;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.PictureBox BtnCerrar;
        private System.Windows.Forms.Label LblTGrupo;
        private System.Windows.Forms.Label LblTEmpleado;
        private System.Windows.Forms.Label LblEmpleado;
        private System.Windows.Forms.Label LblGrupo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPorcentaje;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TxtBGrupo;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox TxtBEmpleado;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox TxtBRGrupo;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
    }
}