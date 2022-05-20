namespace Proyeccion.Principal
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblLine1 = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtContrasena = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.BtnCerrar = new System.Windows.Forms.PictureBox();
            this.BtnMinimizar = new System.Windows.Forms.PictureBox();
            this.LblError = new System.Windows.Forms.Label();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(89)))), ((int)(((byte)(65)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 330);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 223);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LblLine1
            // 
            this.LblLine1.AutoSize = true;
            this.LblLine1.ForeColor = System.Drawing.Color.White;
            this.LblLine1.Location = new System.Drawing.Point(302, 95);
            this.LblLine1.Name = "LblLine1";
            this.LblLine1.Size = new System.Drawing.Size(415, 13);
            this.LblLine1.TabIndex = 1;
            this.LblLine1.Text = "____________________________________________________________________";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(43)))));
            this.TxtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.TxtUsuario.Location = new System.Drawing.Point(305, 84);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(412, 20);
            this.TxtUsuario.TabIndex = 1;
            this.TxtUsuario.Text = "USUARIO";
            this.TxtUsuario.Enter += new System.EventHandler(this.TxtUsuario_Enter);
            this.TxtUsuario.Leave += new System.EventHandler(this.TxtUsuario_Leave);
            // 
            // TxtContrasena
            // 
            this.TxtContrasena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(43)))));
            this.TxtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtContrasena.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContrasena.ForeColor = System.Drawing.Color.DimGray;
            this.TxtContrasena.Location = new System.Drawing.Point(305, 155);
            this.TxtContrasena.Name = "TxtContrasena";
            this.TxtContrasena.Size = new System.Drawing.Size(412, 20);
            this.TxtContrasena.TabIndex = 2;
            this.TxtContrasena.Text = "CONTRASEÑA";
            this.TxtContrasena.Enter += new System.EventHandler(this.TxtContrasena_Enter);
            this.TxtContrasena.Leave += new System.EventHandler(this.TxtContrasena_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(302, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "____________________________________________________________________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(464, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 36);
            this.label2.TabIndex = 6;
            this.label2.Text = "LOGIN";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.linkLabel1.LinkColor = System.Drawing.Color.DimGray;
            this.linkLabel1.Location = new System.Drawing.Point(414, 304);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(187, 17);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "¿Has olvidado contraseña?";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.Image")));
            this.BtnCerrar.Location = new System.Drawing.Point(764, 0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(15, 15);
            this.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnCerrar.TabIndex = 9;
            this.BtnCerrar.TabStop = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnMinimizar.Image")));
            this.BtnMinimizar.Location = new System.Drawing.Point(743, 0);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(15, 15);
            this.BtnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnMinimizar.TabIndex = 10;
            this.BtnMinimizar.TabStop = false;
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // LblError
            // 
            this.LblError.AutoSize = true;
            this.LblError.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblError.ForeColor = System.Drawing.Color.Red;
            this.LblError.Image = ((System.Drawing.Image)(resources.GetObject("LblError.Image")));
            this.LblError.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblError.Location = new System.Drawing.Point(302, 200);
            this.LblError.Name = "LblError";
            this.LblError.Size = new System.Drawing.Size(123, 19);
            this.LblError.TabIndex = 11;
            this.LblError.Text = "Mensaje de Error";
            this.LblError.Visible = false;
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.ForeColor = System.Drawing.Color.LightGray;
            this.BtnLogin.Location = new System.Drawing.Point(305, 244);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(412, 40);
            this.BtnLogin.TabIndex = 12;
            this.BtnLogin.Text = "ACCEDER";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.LblError);
            this.Controls.Add(this.BtnMinimizar);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtContrasena);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LblLine1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmLogin_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblLine1;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtContrasena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox BtnCerrar;
        private System.Windows.Forms.PictureBox BtnMinimizar;
        private System.Windows.Forms.Label LblError;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnLogin;
    }
}