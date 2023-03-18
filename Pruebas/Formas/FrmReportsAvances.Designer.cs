namespace Pruebas.Formas
{
    partial class FrmReportesAvances
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportesAvances));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LblTituloRepAvances = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.PictureBox();
            this.TcDestajo = new System.Windows.Forms.TabControl();
            this.TpGeneral = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtBNombre = new System.Windows.Forms.TextBox();
            this.DgvUsers = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.TpPrograma = new System.Windows.Forms.TabPage();
            this.TpFecha = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            this.TcDestajo.SuspendLayout();
            this.TpGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTituloRepAvances
            // 
            this.LblTituloRepAvances.AutoSize = true;
            this.LblTituloRepAvances.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloRepAvances.ForeColor = System.Drawing.Color.White;
            this.LblTituloRepAvances.Location = new System.Drawing.Point(326, 2);
            this.LblTituloRepAvances.Name = "LblTituloRepAvances";
            this.LblTituloRepAvances.Size = new System.Drawing.Size(352, 39);
            this.LblTituloRepAvances.TabIndex = 24;
            this.LblTituloRepAvances.Text = "Reportes de Avances";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.Image")));
            this.BtnCerrar.Location = new System.Drawing.Point(1055, 2);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(23, 23);
            this.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnCerrar.TabIndex = 23;
            this.BtnCerrar.TabStop = false;
            // 
            // TcDestajo
            // 
            this.TcDestajo.Controls.Add(this.TpGeneral);
            this.TcDestajo.Controls.Add(this.TpPrograma);
            this.TcDestajo.Controls.Add(this.TpFecha);
            this.TcDestajo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TcDestajo.Location = new System.Drawing.Point(3, 68);
            this.TcDestajo.Name = "TcDestajo";
            this.TcDestajo.SelectedIndex = 0;
            this.TcDestajo.Size = new System.Drawing.Size(1074, 596);
            this.TcDestajo.TabIndex = 85;
            // 
            // TpGeneral
            // 
            this.TpGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.TpGeneral.Controls.Add(this.pictureBox1);
            this.TpGeneral.Controls.Add(this.TxtBNombre);
            this.TpGeneral.Controls.Add(this.DgvUsers);
            this.TpGeneral.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TpGeneral.Location = new System.Drawing.Point(4, 26);
            this.TpGeneral.Name = "TpGeneral";
            this.TpGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.TpGeneral.Size = new System.Drawing.Size(1066, 566);
            this.TpGeneral.TabIndex = 0;
            this.TpGeneral.Text = "General";
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
            // 
            // DgvUsers
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar});
            this.DgvUsers.EnableHeadersVisualStyles = false;
            this.DgvUsers.Location = new System.Drawing.Point(0, 32);
            this.DgvUsers.Name = "DgvUsers";
            this.DgvUsers.RowHeadersVisible = false;
            this.DgvUsers.Size = new System.Drawing.Size(1065, 360);
            this.DgvUsers.TabIndex = 0;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Edit";
            this.Editar.Image = ((System.Drawing.Image)(resources.GetObject("Editar.Image")));
            this.Editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Editar.Name = "Editar";
            this.Editar.Width = 55;
            // 
            // TpPrograma
            // 
            this.TpPrograma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.TpPrograma.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TpPrograma.ForeColor = System.Drawing.Color.Transparent;
            this.TpPrograma.Location = new System.Drawing.Point(4, 26);
            this.TpPrograma.Name = "TpPrograma";
            this.TpPrograma.Padding = new System.Windows.Forms.Padding(3);
            this.TpPrograma.Size = new System.Drawing.Size(1066, 566);
            this.TpPrograma.TabIndex = 1;
            this.TpPrograma.Text = "Programa";
            // 
            // TpFecha
            // 
            this.TpFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.TpFecha.Location = new System.Drawing.Point(4, 26);
            this.TpFecha.Name = "TpFecha";
            this.TpFecha.Size = new System.Drawing.Size(1066, 566);
            this.TpFecha.TabIndex = 2;
            this.TpFecha.Text = "Fecha";
            // 
            // FrmReportesAvances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1080, 665);
            this.Controls.Add(this.TcDestajo);
            this.Controls.Add(this.LblTituloRepAvances);
            this.Controls.Add(this.BtnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReportesAvances";
            this.Text = "Reportes Avances";
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            this.TcDestajo.ResumeLayout(false);
            this.TpGeneral.ResumeLayout(false);
            this.TpGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTituloRepAvances;
        private System.Windows.Forms.PictureBox BtnCerrar;
        private System.Windows.Forms.TabControl TcDestajo;
        private System.Windows.Forms.TabPage TpGeneral;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TxtBNombre;
        private System.Windows.Forms.DataGridView DgvUsers;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.TabPage TpPrograma;
        private System.Windows.Forms.TabPage TpFecha;
    }
}