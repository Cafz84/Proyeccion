namespace Pruebas.Formas
{
    partial class FrmRevDestajo
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
            this.LblTDestajo = new System.Windows.Forms.Label();
            this.TcDestajo = new System.Windows.Forms.TabControl();
            this.TpIndex = new System.Windows.Forms.TabPage();
            this.TxtBNombre = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtBSemana = new System.Windows.Forms.TextBox();
            this.DgvDestajo = new System.Windows.Forms.DataGridView();
            this.SelI = new System.Windows.Forms.DataGridViewImageColumn();
            this.TpTrabajador = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.DgvEmpleado = new System.Windows.Forms.DataGridView();
            this.SelT = new System.Windows.Forms.DataGridViewImageColumn();
            this.TxtBTrabajador = new System.Windows.Forms.TextBox();
            this.TpFraccion = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.TxtBFraccion = new System.Windows.Forms.TextBox();
            this.DgvFraccion = new System.Windows.Forms.DataGridView();
            this.SelF = new System.Windows.Forms.DataGridViewImageColumn();
            this.TpMuestra = new System.Windows.Forms.TabPage();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.TxtBMuestra = new System.Windows.Forms.TextBox();
            this.DgvMuestra = new System.Windows.Forms.DataGridView();
            this.SelM = new System.Windows.Forms.DataGridViewImageColumn();
            this.TpGrupo = new System.Windows.Forms.TabPage();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.TxtBGrupo = new System.Windows.Forms.TextBox();
            this.DgvGrupo = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.BtnRelacion = new System.Windows.Forms.Button();
            this.BtnCrear = new System.Windows.Forms.Button();
            this.TcDestajo.SuspendLayout();
            this.TpIndex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDestajo)).BeginInit();
            this.TpTrabajador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmpleado)).BeginInit();
            this.TpFraccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFraccion)).BeginInit();
            this.TpMuestra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMuestra)).BeginInit();
            this.TpGrupo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGrupo)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTDestajo
            // 
            this.LblTDestajo.AutoSize = true;
            this.LblTDestajo.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTDestajo.ForeColor = System.Drawing.Color.White;
            this.LblTDestajo.Location = new System.Drawing.Point(367, -1);
            this.LblTDestajo.Name = "LblTDestajo";
            this.LblTDestajo.Size = new System.Drawing.Size(321, 39);
            this.LblTDestajo.TabIndex = 51;
            this.LblTDestajo.Text = "Revisión de Destajo";
            // 
            // TcDestajo
            // 
            this.TcDestajo.Controls.Add(this.TpIndex);
            this.TcDestajo.Controls.Add(this.TpTrabajador);
            this.TcDestajo.Controls.Add(this.TpFraccion);
            this.TcDestajo.Controls.Add(this.TpMuestra);
            this.TcDestajo.Controls.Add(this.TpGrupo);
            this.TcDestajo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TcDestajo.Location = new System.Drawing.Point(3, 240);
            this.TcDestajo.Name = "TcDestajo";
            this.TcDestajo.SelectedIndex = 0;
            this.TcDestajo.Size = new System.Drawing.Size(1073, 422);
            this.TcDestajo.TabIndex = 52;
            // 
            // TpIndex
            // 
            this.TpIndex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.TpIndex.Controls.Add(this.TxtBNombre);
            this.TpIndex.Controls.Add(this.pictureBox1);
            this.TpIndex.Controls.Add(this.TxtBSemana);
            this.TpIndex.Controls.Add(this.DgvDestajo);
            this.TpIndex.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TpIndex.Location = new System.Drawing.Point(4, 26);
            this.TpIndex.Name = "TpIndex";
            this.TpIndex.Padding = new System.Windows.Forms.Padding(3);
            this.TpIndex.Size = new System.Drawing.Size(1065, 392);
            this.TpIndex.TabIndex = 0;
            this.TpIndex.Text = "Index";
            // 
            // TxtBNombre
            // 
            this.TxtBNombre.BackColor = System.Drawing.Color.LightGray;
            this.TxtBNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBNombre.Location = new System.Drawing.Point(97, 3);
            this.TxtBNombre.MaxLength = 50;
            this.TxtBNombre.Name = "TxtBNombre";
            this.TxtBNombre.Size = new System.Drawing.Size(313, 27);
            this.TxtBNombre.TabIndex = 131;
            this.TxtBNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtBNombre.TextChanged += new System.EventHandler(this.TxtBNombre_TextChanged);
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
            // TxtBSemana
            // 
            this.TxtBSemana.BackColor = System.Drawing.Color.LightGray;
            this.TxtBSemana.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBSemana.Location = new System.Drawing.Point(45, 3);
            this.TxtBSemana.MaxLength = 50;
            this.TxtBSemana.Name = "TxtBSemana";
            this.TxtBSemana.Size = new System.Drawing.Size(46, 27);
            this.TxtBSemana.TabIndex = 130;
            this.TxtBSemana.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtBSemana.TextChanged += new System.EventHandler(this.TxtBSemana_TextChanged);
            // 
            // DgvDestajo
            // 
            this.DgvDestajo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDestajo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelI});
            this.DgvDestajo.Location = new System.Drawing.Point(0, 32);
            this.DgvDestajo.Name = "DgvDestajo";
            this.DgvDestajo.Size = new System.Drawing.Size(1065, 360);
            this.DgvDestajo.TabIndex = 0;
            // 
            // SelI
            // 
            this.SelI.HeaderText = "Sel";
            this.SelI.Image = global::Pruebas.Properties.Resources._3592869_compose_create_edit_edit_file_office_pencil_writing_creative_107746;
            this.SelI.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.SelI.Name = "SelI";
            this.SelI.Width = 55;
            // 
            // TpTrabajador
            // 
            this.TpTrabajador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.TpTrabajador.Controls.Add(this.pictureBox2);
            this.TpTrabajador.Controls.Add(this.DgvEmpleado);
            this.TpTrabajador.Controls.Add(this.TxtBTrabajador);
            this.TpTrabajador.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TpTrabajador.Location = new System.Drawing.Point(4, 26);
            this.TpTrabajador.Name = "TpTrabajador";
            this.TpTrabajador.Padding = new System.Windows.Forms.Padding(3);
            this.TpTrabajador.Size = new System.Drawing.Size(1065, 392);
            this.TpTrabajador.TabIndex = 1;
            this.TpTrabajador.Text = "Trabajador";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Pruebas.Properties.Resources.xmag_search_find_export_locate_32x32;
            this.pictureBox2.Location = new System.Drawing.Point(5, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 133;
            this.pictureBox2.TabStop = false;
            // 
            // DgvEmpleado
            // 
            this.DgvEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEmpleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelT});
            this.DgvEmpleado.Location = new System.Drawing.Point(0, 32);
            this.DgvEmpleado.Name = "DgvEmpleado";
            this.DgvEmpleado.Size = new System.Drawing.Size(1065, 360);
            this.DgvEmpleado.TabIndex = 1;
            // 
            // SelT
            // 
            this.SelT.HeaderText = "Sel";
            this.SelT.Image = global::Pruebas.Properties.Resources._3592869_compose_create_edit_edit_file_office_pencil_writing_creative_107746;
            this.SelT.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.SelT.Name = "SelT";
            this.SelT.Width = 55;
            // 
            // TxtBTrabajador
            // 
            this.TxtBTrabajador.BackColor = System.Drawing.Color.LightGray;
            this.TxtBTrabajador.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBTrabajador.Location = new System.Drawing.Point(45, 3);
            this.TxtBTrabajador.MaxLength = 50;
            this.TxtBTrabajador.Name = "TxtBTrabajador";
            this.TxtBTrabajador.Size = new System.Drawing.Size(313, 27);
            this.TxtBTrabajador.TabIndex = 132;
            this.TxtBTrabajador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TpFraccion
            // 
            this.TpFraccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.TpFraccion.Controls.Add(this.pictureBox3);
            this.TpFraccion.Controls.Add(this.TxtBFraccion);
            this.TpFraccion.Controls.Add(this.DgvFraccion);
            this.TpFraccion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TpFraccion.Location = new System.Drawing.Point(4, 26);
            this.TpFraccion.Name = "TpFraccion";
            this.TpFraccion.Size = new System.Drawing.Size(1065, 392);
            this.TpFraccion.TabIndex = 2;
            this.TpFraccion.Text = "Fracción";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Pruebas.Properties.Resources.xmag_search_find_export_locate_32x32;
            this.pictureBox3.Location = new System.Drawing.Point(5, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(34, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 129;
            this.pictureBox3.TabStop = false;
            // 
            // TxtBFraccion
            // 
            this.TxtBFraccion.BackColor = System.Drawing.Color.LightGray;
            this.TxtBFraccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBFraccion.Location = new System.Drawing.Point(45, 3);
            this.TxtBFraccion.MaxLength = 50;
            this.TxtBFraccion.Name = "TxtBFraccion";
            this.TxtBFraccion.Size = new System.Drawing.Size(313, 27);
            this.TxtBFraccion.TabIndex = 128;
            this.TxtBFraccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DgvFraccion
            // 
            this.DgvFraccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFraccion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelF});
            this.DgvFraccion.Location = new System.Drawing.Point(0, 32);
            this.DgvFraccion.Name = "DgvFraccion";
            this.DgvFraccion.Size = new System.Drawing.Size(1065, 360);
            this.DgvFraccion.TabIndex = 2;
            // 
            // SelF
            // 
            this.SelF.HeaderText = "Sel";
            this.SelF.Image = global::Pruebas.Properties.Resources._3592869_compose_create_edit_edit_file_office_pencil_writing_creative_107746;
            this.SelF.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.SelF.Name = "SelF";
            this.SelF.Width = 55;
            // 
            // TpMuestra
            // 
            this.TpMuestra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.TpMuestra.Controls.Add(this.pictureBox4);
            this.TpMuestra.Controls.Add(this.TxtBMuestra);
            this.TpMuestra.Controls.Add(this.DgvMuestra);
            this.TpMuestra.Location = new System.Drawing.Point(4, 26);
            this.TpMuestra.Name = "TpMuestra";
            this.TpMuestra.Size = new System.Drawing.Size(1065, 392);
            this.TpMuestra.TabIndex = 3;
            this.TpMuestra.Text = "Muestra";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Pruebas.Properties.Resources.xmag_search_find_export_locate_32x32;
            this.pictureBox4.Location = new System.Drawing.Point(5, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(34, 28);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 131;
            this.pictureBox4.TabStop = false;
            // 
            // TxtBMuestra
            // 
            this.TxtBMuestra.BackColor = System.Drawing.Color.LightGray;
            this.TxtBMuestra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBMuestra.Location = new System.Drawing.Point(45, 3);
            this.TxtBMuestra.MaxLength = 50;
            this.TxtBMuestra.Name = "TxtBMuestra";
            this.TxtBMuestra.Size = new System.Drawing.Size(313, 27);
            this.TxtBMuestra.TabIndex = 130;
            this.TxtBMuestra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DgvMuestra
            // 
            this.DgvMuestra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMuestra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelM});
            this.DgvMuestra.Location = new System.Drawing.Point(0, 32);
            this.DgvMuestra.Name = "DgvMuestra";
            this.DgvMuestra.Size = new System.Drawing.Size(1065, 360);
            this.DgvMuestra.TabIndex = 3;
            // 
            // SelM
            // 
            this.SelM.HeaderText = "Sel";
            this.SelM.Image = global::Pruebas.Properties.Resources._3592869_compose_create_edit_edit_file_office_pencil_writing_creative_107746;
            this.SelM.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.SelM.Name = "SelM";
            this.SelM.Width = 55;
            // 
            // TpGrupo
            // 
            this.TpGrupo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.TpGrupo.Controls.Add(this.pictureBox5);
            this.TpGrupo.Controls.Add(this.TxtBGrupo);
            this.TpGrupo.Controls.Add(this.DgvGrupo);
            this.TpGrupo.Controls.Add(this.BtnRelacion);
            this.TpGrupo.Controls.Add(this.BtnCrear);
            this.TpGrupo.Location = new System.Drawing.Point(4, 26);
            this.TpGrupo.Name = "TpGrupo";
            this.TpGrupo.Padding = new System.Windows.Forms.Padding(3);
            this.TpGrupo.Size = new System.Drawing.Size(1065, 392);
            this.TpGrupo.TabIndex = 4;
            this.TpGrupo.Text = "Grupo";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Pruebas.Properties.Resources.xmag_search_find_export_locate_32x32;
            this.pictureBox5.Location = new System.Drawing.Point(5, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(34, 28);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 132;
            this.pictureBox5.TabStop = false;
            // 
            // TxtBGrupo
            // 
            this.TxtBGrupo.BackColor = System.Drawing.Color.LightGray;
            this.TxtBGrupo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBGrupo.Location = new System.Drawing.Point(45, 3);
            this.TxtBGrupo.MaxLength = 50;
            this.TxtBGrupo.Name = "TxtBGrupo";
            this.TxtBGrupo.Size = new System.Drawing.Size(313, 27);
            this.TxtBGrupo.TabIndex = 131;
            this.TxtBGrupo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DgvGrupo
            // 
            this.DgvGrupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvGrupo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewImageColumn1});
            this.DgvGrupo.Location = new System.Drawing.Point(0, 32);
            this.DgvGrupo.Name = "DgvGrupo";
            this.DgvGrupo.Size = new System.Drawing.Size(885, 360);
            this.DgvGrupo.TabIndex = 2;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Sel";
            this.dataGridViewImageColumn1.Image = global::Pruebas.Properties.Resources._3592869_compose_create_edit_edit_file_office_pencil_writing_creative_107746;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 55;
            // 
            // BtnRelacion
            // 
            this.BtnRelacion.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnRelacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRelacion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRelacion.ForeColor = System.Drawing.Color.White;
            this.BtnRelacion.Image = global::Pruebas.Properties.Resources.partnership_icon_32x32;
            this.BtnRelacion.Location = new System.Drawing.Point(891, 56);
            this.BtnRelacion.Name = "BtnRelacion";
            this.BtnRelacion.Size = new System.Drawing.Size(170, 44);
            this.BtnRelacion.TabIndex = 129;
            this.BtnRelacion.Text = "Relacionar";
            this.BtnRelacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRelacion.UseVisualStyleBackColor = false;
            // 
            // BtnCrear
            // 
            this.BtnCrear.BackColor = System.Drawing.Color.Green;
            this.BtnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCrear.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCrear.ForeColor = System.Drawing.Color.White;
            this.BtnCrear.Image = global::Pruebas.Properties.Resources.Group_icon_icons32x32;
            this.BtnCrear.Location = new System.Drawing.Point(891, 6);
            this.BtnCrear.Name = "BtnCrear";
            this.BtnCrear.Size = new System.Drawing.Size(170, 44);
            this.BtnCrear.TabIndex = 128;
            this.BtnCrear.Text = "Crear Grupo";
            this.BtnCrear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCrear.UseVisualStyleBackColor = false;
            // 
            // FrmRevDestajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1080, 665);
            this.Controls.Add(this.TcDestajo);
            this.Controls.Add(this.LblTDestajo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRevDestajo";
            this.Text = "FrmRevNomina";
            this.TcDestajo.ResumeLayout(false);
            this.TpIndex.ResumeLayout(false);
            this.TpIndex.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDestajo)).EndInit();
            this.TpTrabajador.ResumeLayout(false);
            this.TpTrabajador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmpleado)).EndInit();
            this.TpFraccion.ResumeLayout(false);
            this.TpFraccion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFraccion)).EndInit();
            this.TpMuestra.ResumeLayout(false);
            this.TpMuestra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMuestra)).EndInit();
            this.TpGrupo.ResumeLayout(false);
            this.TpGrupo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGrupo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTDestajo;
        private System.Windows.Forms.TabControl TcDestajo;
        private System.Windows.Forms.TabPage TpIndex;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TxtBSemana;
        private System.Windows.Forms.DataGridView DgvDestajo;
        private System.Windows.Forms.TabPage TpTrabajador;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView DgvEmpleado;
        private System.Windows.Forms.DataGridViewImageColumn SelT;
        private System.Windows.Forms.TextBox TxtBTrabajador;
        private System.Windows.Forms.TabPage TpFraccion;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox TxtBFraccion;
        private System.Windows.Forms.DataGridView DgvFraccion;
        private System.Windows.Forms.DataGridViewImageColumn SelF;
        private System.Windows.Forms.TabPage TpMuestra;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox TxtBMuestra;
        private System.Windows.Forms.DataGridView DgvMuestra;
        private System.Windows.Forms.DataGridViewImageColumn SelM;
        private System.Windows.Forms.TabPage TpGrupo;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox TxtBGrupo;
        private System.Windows.Forms.DataGridView DgvGrupo;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Button BtnRelacion;
        private System.Windows.Forms.Button BtnCrear;
        private System.Windows.Forms.TextBox TxtBNombre;
        private System.Windows.Forms.DataGridViewImageColumn SelI;
    }
}