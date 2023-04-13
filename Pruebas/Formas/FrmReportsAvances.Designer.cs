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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LblTituloRepAvances = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.PictureBox();
            this.TcDestajo = new System.Windows.Forms.TabControl();
            this.TpGeneral = new System.Windows.Forms.TabPage();
            this.TxtBArea = new System.Windows.Forms.TextBox();
            this.TxtBColor = new System.Windows.Forms.TextBox();
            this.TxtBEstilo = new System.Windows.Forms.TextBox();
            this.TxtBUsuario = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TxtBCodigo = new System.Windows.Forms.TextBox();
            this.BtnLimpiarGeneral = new System.Windows.Forms.Button();
            this.DgvGeneral = new System.Windows.Forms.DataGridView();
            this.TpPrograma = new System.Windows.Forms.TabPage();
            this.TpFecha = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            this.TcDestajo.SuspendLayout();
            this.TpGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGeneral)).BeginInit();
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
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // TcDestajo
            // 
            this.TcDestajo.Controls.Add(this.TpGeneral);
            this.TcDestajo.Controls.Add(this.TpPrograma);
            this.TcDestajo.Controls.Add(this.TpFecha);
            this.TcDestajo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TcDestajo.Location = new System.Drawing.Point(3, 64);
            this.TcDestajo.Name = "TcDestajo";
            this.TcDestajo.SelectedIndex = 0;
            this.TcDestajo.Size = new System.Drawing.Size(1074, 600);
            this.TcDestajo.TabIndex = 85;
            // 
            // TpGeneral
            // 
            this.TpGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.TpGeneral.Controls.Add(this.TxtBArea);
            this.TpGeneral.Controls.Add(this.TxtBColor);
            this.TpGeneral.Controls.Add(this.TxtBEstilo);
            this.TpGeneral.Controls.Add(this.TxtBUsuario);
            this.TpGeneral.Controls.Add(this.pictureBox2);
            this.TpGeneral.Controls.Add(this.TxtBCodigo);
            this.TpGeneral.Controls.Add(this.BtnLimpiarGeneral);
            this.TpGeneral.Controls.Add(this.DgvGeneral);
            this.TpGeneral.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TpGeneral.Location = new System.Drawing.Point(4, 26);
            this.TpGeneral.Name = "TpGeneral";
            this.TpGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.TpGeneral.Size = new System.Drawing.Size(1066, 570);
            this.TpGeneral.TabIndex = 0;
            this.TpGeneral.Text = "General";
            // 
            // TxtBArea
            // 
            this.TxtBArea.BackColor = System.Drawing.Color.LightGray;
            this.TxtBArea.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBArea.Location = new System.Drawing.Point(449, 2);
            this.TxtBArea.MaxLength = 1;
            this.TxtBArea.Name = "TxtBArea";
            this.TxtBArea.Size = new System.Drawing.Size(30, 23);
            this.TxtBArea.TabIndex = 151;
            this.TxtBArea.TextChanged += new System.EventHandler(this.TxtBArea_TextChanged);
            // 
            // TxtBColor
            // 
            this.TxtBColor.BackColor = System.Drawing.Color.LightGray;
            this.TxtBColor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBColor.Location = new System.Drawing.Point(207, 2);
            this.TxtBColor.MaxLength = 50;
            this.TxtBColor.Name = "TxtBColor";
            this.TxtBColor.Size = new System.Drawing.Size(153, 23);
            this.TxtBColor.TabIndex = 150;
            this.TxtBColor.TextChanged += new System.EventHandler(this.TxtBColor_TextChanged);
            // 
            // TxtBEstilo
            // 
            this.TxtBEstilo.BackColor = System.Drawing.Color.LightGray;
            this.TxtBEstilo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBEstilo.Location = new System.Drawing.Point(80, 2);
            this.TxtBEstilo.MaxLength = 50;
            this.TxtBEstilo.Name = "TxtBEstilo";
            this.TxtBEstilo.Size = new System.Drawing.Size(123, 23);
            this.TxtBEstilo.TabIndex = 149;
            this.TxtBEstilo.TextChanged += new System.EventHandler(this.TxtBEstilo_TextChanged);
            // 
            // TxtBUsuario
            // 
            this.TxtBUsuario.BackColor = System.Drawing.Color.LightGray;
            this.TxtBUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBUsuario.Location = new System.Drawing.Point(364, 2);
            this.TxtBUsuario.MaxLength = 50;
            this.TxtBUsuario.Name = "TxtBUsuario";
            this.TxtBUsuario.Size = new System.Drawing.Size(82, 23);
            this.TxtBUsuario.TabIndex = 148;
            this.TxtBUsuario.TextChanged += new System.EventHandler(this.TxtBUsuario_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Pruebas.Properties.Resources.xmag_search_find_export_locate_32x32;
            this.pictureBox2.Location = new System.Drawing.Point(2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 147;
            this.pictureBox2.TabStop = false;
            // 
            // TxtBCodigo
            // 
            this.TxtBCodigo.BackColor = System.Drawing.Color.LightGray;
            this.TxtBCodigo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBCodigo.Location = new System.Drawing.Point(27, 2);
            this.TxtBCodigo.MaxLength = 50;
            this.TxtBCodigo.Name = "TxtBCodigo";
            this.TxtBCodigo.Size = new System.Drawing.Size(49, 23);
            this.TxtBCodigo.TabIndex = 146;
            this.TxtBCodigo.TextChanged += new System.EventHandler(this.TxtBCodigo_TextChanged);
            // 
            // BtnLimpiarGeneral
            // 
            this.BtnLimpiarGeneral.BackColor = System.Drawing.Color.BurlyWood;
            this.BtnLimpiarGeneral.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLimpiarGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiarGeneral.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiarGeneral.ForeColor = System.Drawing.Color.White;
            this.BtnLimpiarGeneral.Image = ((System.Drawing.Image)(resources.GetObject("BtnLimpiarGeneral.Image")));
            this.BtnLimpiarGeneral.Location = new System.Drawing.Point(1037, 1);
            this.BtnLimpiarGeneral.Name = "BtnLimpiarGeneral";
            this.BtnLimpiarGeneral.Size = new System.Drawing.Size(28, 25);
            this.BtnLimpiarGeneral.TabIndex = 86;
            this.BtnLimpiarGeneral.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnLimpiarGeneral.UseVisualStyleBackColor = false;
            this.BtnLimpiarGeneral.Click += new System.EventHandler(this.BtnLimpiarGeneral_Click);
            // 
            // DgvGeneral
            // 
            this.DgvGeneral.AllowUserToAddRows = false;
            this.DgvGeneral.AllowUserToDeleteRows = false;
            this.DgvGeneral.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvGeneral.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvGeneral.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvGeneral.EnableHeadersVisualStyles = false;
            this.DgvGeneral.Location = new System.Drawing.Point(0, 26);
            this.DgvGeneral.Name = "DgvGeneral";
            this.DgvGeneral.ReadOnly = true;
            this.DgvGeneral.RowHeadersVisible = false;
            this.DgvGeneral.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvGeneral.Size = new System.Drawing.Size(1065, 543);
            this.DgvGeneral.TabIndex = 0;
            // 
            // TpPrograma
            // 
            this.TpPrograma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.TpPrograma.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TpPrograma.ForeColor = System.Drawing.Color.Transparent;
            this.TpPrograma.Location = new System.Drawing.Point(4, 26);
            this.TpPrograma.Name = "TpPrograma";
            this.TpPrograma.Padding = new System.Windows.Forms.Padding(3);
            this.TpPrograma.Size = new System.Drawing.Size(1066, 570);
            this.TpPrograma.TabIndex = 1;
            this.TpPrograma.Text = "Programa";
            // 
            // TpFecha
            // 
            this.TpFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.TpFecha.Location = new System.Drawing.Point(4, 26);
            this.TpFecha.Name = "TpFecha";
            this.TpFecha.Size = new System.Drawing.Size(1066, 570);
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
            this.Text = "+";
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            this.TcDestajo.ResumeLayout(false);
            this.TpGeneral.ResumeLayout(false);
            this.TpGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGeneral)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTituloRepAvances;
        private System.Windows.Forms.PictureBox BtnCerrar;
        private System.Windows.Forms.TabControl TcDestajo;
        private System.Windows.Forms.TabPage TpGeneral;
        private System.Windows.Forms.DataGridView DgvGeneral;
        private System.Windows.Forms.TabPage TpPrograma;
        private System.Windows.Forms.TabPage TpFecha;
        private System.Windows.Forms.Button BtnLimpiarGeneral;
        private System.Windows.Forms.TextBox TxtBArea;
        private System.Windows.Forms.TextBox TxtBColor;
        private System.Windows.Forms.TextBox TxtBEstilo;
        private System.Windows.Forms.TextBox TxtBUsuario;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox TxtBCodigo;
    }
}