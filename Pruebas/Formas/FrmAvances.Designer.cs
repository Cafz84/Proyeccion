namespace Pruebas.Formas
{
    partial class FrmAvances
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAvances));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LblTituloAvances = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.PictureBox();
            this.DgvAvances = new System.Windows.Forms.DataGridView();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.LblTCodigo = new System.Windows.Forms.Label();
            this.LblCorrecto = new System.Windows.Forms.Label();
            this.LblIncorrecto = new System.Windows.Forms.Label();
            this.TxtBEstilo = new System.Windows.Forms.TextBox();
            this.TxtBUsuario = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TxtBCodigo = new System.Windows.Forms.TextBox();
            this.TxtBColor = new System.Windows.Forms.TextBox();
            this.TxtBArea = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAvances)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTituloAvances
            // 
            this.LblTituloAvances.AutoSize = true;
            this.LblTituloAvances.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloAvances.ForeColor = System.Drawing.Color.White;
            this.LblTituloAvances.Location = new System.Drawing.Point(452, 0);
            this.LblTituloAvances.Name = "LblTituloAvances";
            this.LblTituloAvances.Size = new System.Drawing.Size(155, 39);
            this.LblTituloAvances.TabIndex = 2;
            this.LblTituloAvances.Text = "Avances";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.Image")));
            this.BtnCerrar.Location = new System.Drawing.Point(1058, 1);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(21, 24);
            this.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnCerrar.TabIndex = 21;
            this.BtnCerrar.TabStop = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // DgvAvances
            // 
            this.DgvAvances.AllowUserToAddRows = false;
            this.DgvAvances.AllowUserToDeleteRows = false;
            this.DgvAvances.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvAvances.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvAvances.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvAvances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAvances.EnableHeadersVisualStyles = false;
            this.DgvAvances.Location = new System.Drawing.Point(1, 169);
            this.DgvAvances.Name = "DgvAvances";
            this.DgvAvances.RowHeadersVisible = false;
            this.DgvAvances.Size = new System.Drawing.Size(1078, 494);
            this.DgvAvances.TabIndex = 22;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.BurlyWood;
            this.BtnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.ForeColor = System.Drawing.Color.White;
            this.BtnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("BtnLimpiar.Image")));
            this.BtnLimpiar.Location = new System.Drawing.Point(1, 0);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(38, 37);
            this.BtnLimpiar.TabIndex = 62;
            this.BtnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.BackColor = System.Drawing.Color.LightCyan;
            this.TxtCodigo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigo.Location = new System.Drawing.Point(16, 75);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(244, 33);
            this.TxtCodigo.TabIndex = 63;
            this.TxtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCodigo_KeyDown);
            // 
            // LblTCodigo
            // 
            this.LblTCodigo.AutoSize = true;
            this.LblTCodigo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTCodigo.ForeColor = System.Drawing.Color.White;
            this.LblTCodigo.Location = new System.Drawing.Point(12, 50);
            this.LblTCodigo.Name = "LblTCodigo";
            this.LblTCodigo.Size = new System.Drawing.Size(83, 22);
            this.LblTCodigo.TabIndex = 64;
            this.LblTCodigo.Text = "Codigo:";
            // 
            // LblCorrecto
            // 
            this.LblCorrecto.AutoSize = true;
            this.LblCorrecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblCorrecto.Font = new System.Drawing.Font("Tahoma", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCorrecto.ForeColor = System.Drawing.Color.DarkGreen;
            this.LblCorrecto.Location = new System.Drawing.Point(382, 50);
            this.LblCorrecto.Name = "LblCorrecto";
            this.LblCorrecto.Size = new System.Drawing.Size(565, 77);
            this.LblCorrecto.TabIndex = 65;
            this.LblCorrecto.Text = "!Avance Exitoso¡";
            this.LblCorrecto.Visible = false;
            // 
            // LblIncorrecto
            // 
            this.LblIncorrecto.AutoSize = true;
            this.LblIncorrecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblIncorrecto.Font = new System.Drawing.Font("Tahoma", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIncorrecto.ForeColor = System.Drawing.Color.DarkRed;
            this.LblIncorrecto.Location = new System.Drawing.Point(325, 69);
            this.LblIncorrecto.Name = "LblIncorrecto";
            this.LblIncorrecto.Size = new System.Drawing.Size(500, 39);
            this.LblIncorrecto.TabIndex = 66;
            this.LblIncorrecto.Text = "Falta generar Avance de Corte";
            this.LblIncorrecto.Visible = false;
            // 
            // TxtBEstilo
            // 
            this.TxtBEstilo.BackColor = System.Drawing.Color.LightGray;
            this.TxtBEstilo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBEstilo.Location = new System.Drawing.Point(203, 143);
            this.TxtBEstilo.MaxLength = 50;
            this.TxtBEstilo.Name = "TxtBEstilo";
            this.TxtBEstilo.Size = new System.Drawing.Size(121, 23);
            this.TxtBEstilo.TabIndex = 143;
            // 
            // TxtBUsuario
            // 
            this.TxtBUsuario.BackColor = System.Drawing.Color.LightGray;
            this.TxtBUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBUsuario.Location = new System.Drawing.Point(81, 143);
            this.TxtBUsuario.MaxLength = 50;
            this.TxtBUsuario.Name = "TxtBUsuario";
            this.TxtBUsuario.Size = new System.Drawing.Size(118, 23);
            this.TxtBUsuario.TabIndex = 142;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Pruebas.Properties.Resources.xmag_search_find_export_locate_32x32;
            this.pictureBox2.Location = new System.Drawing.Point(2, 143);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 141;
            this.pictureBox2.TabStop = false;
            // 
            // TxtBCodigo
            // 
            this.TxtBCodigo.BackColor = System.Drawing.Color.LightGray;
            this.TxtBCodigo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBCodigo.Location = new System.Drawing.Point(28, 143);
            this.TxtBCodigo.MaxLength = 50;
            this.TxtBCodigo.Name = "TxtBCodigo";
            this.TxtBCodigo.Size = new System.Drawing.Size(49, 23);
            this.TxtBCodigo.TabIndex = 140;
            // 
            // TxtBColor
            // 
            this.TxtBColor.BackColor = System.Drawing.Color.LightGray;
            this.TxtBColor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBColor.Location = new System.Drawing.Point(328, 143);
            this.TxtBColor.MaxLength = 50;
            this.TxtBColor.Name = "TxtBColor";
            this.TxtBColor.Size = new System.Drawing.Size(118, 23);
            this.TxtBColor.TabIndex = 144;
            // 
            // TxtBArea
            // 
            this.TxtBArea.BackColor = System.Drawing.Color.LightGray;
            this.TxtBArea.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBArea.Location = new System.Drawing.Point(450, 143);
            this.TxtBArea.MaxLength = 1;
            this.TxtBArea.Name = "TxtBArea";
            this.TxtBArea.Size = new System.Drawing.Size(30, 23);
            this.TxtBArea.TabIndex = 145;
            // 
            // FrmAvances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1080, 665);
            this.Controls.Add(this.TxtBArea);
            this.Controls.Add(this.TxtBColor);
            this.Controls.Add(this.TxtBEstilo);
            this.Controls.Add(this.TxtBUsuario);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.TxtBCodigo);
            this.Controls.Add(this.LblIncorrecto);
            this.Controls.Add(this.LblCorrecto);
            this.Controls.Add(this.LblTCodigo);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.DgvAvances);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.LblTituloAvances);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAvances";
            this.Text = "FrmAvances";
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAvances)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTituloAvances;
        private System.Windows.Forms.PictureBox BtnCerrar;
        private System.Windows.Forms.DataGridView DgvAvances;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label LblTCodigo;
        private System.Windows.Forms.Label LblCorrecto;
        private System.Windows.Forms.Label LblIncorrecto;
        private System.Windows.Forms.TextBox TxtBEstilo;
        private System.Windows.Forms.TextBox TxtBUsuario;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox TxtBCodigo;
        private System.Windows.Forms.TextBox TxtBColor;
        private System.Windows.Forms.TextBox TxtBArea;
    }
}