namespace Pruebas.Formas
{
    partial class FrmDestajo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDestajo));
            this.LblTituloFraccEstilo = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.PictureBox();
            this.TxtPrograma = new System.Windows.Forms.TextBox();
            this.LblTrabajador = new System.Windows.Forms.Label();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.LblSemana = new System.Windows.Forms.Label();
            this.CbSemana = new System.Windows.Forms.ComboBox();
            this.LblIdTrabajador = new System.Windows.Forms.Label();
            this.LblIdFraccion = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblEmpId = new System.Windows.Forms.Label();
            this.LblFraccId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblEstilo = new System.Windows.Forms.Label();
            this.LblTEstilo = new System.Windows.Forms.Label();
            this.LblTColor = new System.Windows.Forms.Label();
            this.LblColor = new System.Windows.Forms.Label();
            this.LblTPP = new System.Windows.Forms.Label();
            this.LblPP = new System.Windows.Forms.Label();
            this.LblPagado = new System.Windows.Forms.Label();
            this.LblTPagado = new System.Windows.Forms.Label();
            this.LblRestante = new System.Windows.Forms.Label();
            this.LblTRestante = new System.Windows.Forms.Label();
            this.LblTCantidad = new System.Windows.Forms.Label();
            this.TcEmpleados = new System.Windows.Forms.TabControl();
            this.TpIndex = new System.Windows.Forms.TabPage();
            this.DgvEmpleados = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.TpTrabajador = new System.Windows.Forms.TabPage();
            this.TpFraccion = new System.Windows.Forms.TabPage();
            this.LblTFraccion = new System.Windows.Forms.Label();
            this.LblFraccion = new System.Windows.Forms.Label();
            this.TpMuestra = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            this.TcEmpleados.SuspendLayout();
            this.TpIndex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTituloFraccEstilo
            // 
            this.LblTituloFraccEstilo.AutoSize = true;
            this.LblTituloFraccEstilo.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloFraccEstilo.ForeColor = System.Drawing.Color.White;
            this.LblTituloFraccEstilo.Location = new System.Drawing.Point(374, -1);
            this.LblTituloFraccEstilo.Name = "LblTituloFraccEstilo";
            this.LblTituloFraccEstilo.Size = new System.Drawing.Size(274, 39);
            this.LblTituloFraccEstilo.TabIndex = 50;
            this.LblTituloFraccEstilo.Text = "Captura Destajo";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.DarkRed;
            this.BtnEliminar.Enabled = false;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminar.Image")));
            this.BtnEliminar.Location = new System.Drawing.Point(854, 190);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(214, 51);
            this.BtnEliminar.TabIndex = 93;
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
            this.BtnActualizar.Location = new System.Drawing.Point(854, 136);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(214, 51);
            this.BtnActualizar.TabIndex = 90;
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
            this.BtnAgregar.Location = new System.Drawing.Point(854, 82);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(214, 51);
            this.BtnAgregar.TabIndex = 92;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAgregar.UseVisualStyleBackColor = false;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.BurlyWood;
            this.BtnLimpiar.Enabled = false;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.ForeColor = System.Drawing.Color.White;
            this.BtnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("BtnLimpiar.Image")));
            this.BtnLimpiar.Location = new System.Drawing.Point(854, 27);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(214, 51);
            this.BtnLimpiar.TabIndex = 91;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.Image")));
            this.BtnCerrar.Location = new System.Drawing.Point(1060, -1);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(21, 24);
            this.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnCerrar.TabIndex = 89;
            this.BtnCerrar.TabStop = false;
            // 
            // TxtPrograma
            // 
            this.TxtPrograma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.TxtPrograma.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrograma.Location = new System.Drawing.Point(135, 145);
            this.TxtPrograma.MaxLength = 50;
            this.TxtPrograma.Name = "TxtPrograma";
            this.TxtPrograma.Size = new System.Drawing.Size(88, 31);
            this.TxtPrograma.TabIndex = 102;
            this.TxtPrograma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblTrabajador
            // 
            this.LblTrabajador.AutoSize = true;
            this.LblTrabajador.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTrabajador.ForeColor = System.Drawing.Color.White;
            this.LblTrabajador.Location = new System.Drawing.Point(24, 91);
            this.LblTrabajador.Name = "LblTrabajador";
            this.LblTrabajador.Size = new System.Drawing.Size(115, 22);
            this.LblTrabajador.TabIndex = 101;
            this.LblTrabajador.Text = "Trabajador:";
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.TxtCantidad.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCantidad.Location = new System.Drawing.Point(752, 201);
            this.TxtCantidad.MaxLength = 50;
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(88, 31);
            this.TxtCantidad.TabIndex = 104;
            this.TxtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblSemana
            // 
            this.LblSemana.AutoSize = true;
            this.LblSemana.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSemana.ForeColor = System.Drawing.Color.White;
            this.LblSemana.Location = new System.Drawing.Point(24, 48);
            this.LblSemana.Name = "LblSemana";
            this.LblSemana.Size = new System.Drawing.Size(91, 22);
            this.LblSemana.TabIndex = 103;
            this.LblSemana.Text = "Semana:";
            // 
            // CbSemana
            // 
            this.CbSemana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.CbSemana.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.CbSemana.FormattingEnabled = true;
            this.CbSemana.Location = new System.Drawing.Point(116, 46);
            this.CbSemana.Name = "CbSemana";
            this.CbSemana.Size = new System.Drawing.Size(77, 29);
            this.CbSemana.TabIndex = 105;
            // 
            // LblIdTrabajador
            // 
            this.LblIdTrabajador.AutoSize = true;
            this.LblIdTrabajador.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIdTrabajador.ForeColor = System.Drawing.Color.White;
            this.LblIdTrabajador.Location = new System.Drawing.Point(247, 48);
            this.LblIdTrabajador.Name = "LblIdTrabajador";
            this.LblIdTrabajador.Size = new System.Drawing.Size(138, 22);
            this.LblIdTrabajador.TabIndex = 106;
            this.LblIdTrabajador.Text = "Id Trabajador:";
            // 
            // LblIdFraccion
            // 
            this.LblIdFraccion.AutoSize = true;
            this.LblIdFraccion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIdFraccion.ForeColor = System.Drawing.Color.White;
            this.LblIdFraccion.Location = new System.Drawing.Point(531, 48);
            this.LblIdFraccion.Name = "LblIdFraccion";
            this.LblIdFraccion.Size = new System.Drawing.Size(117, 22);
            this.LblIdFraccion.TabIndex = 107;
            this.LblIdFraccion.Text = "Id Fracción:";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.ForeColor = System.Drawing.Color.Black;
            this.LblNombre.Location = new System.Drawing.Point(138, 91);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(0, 22);
            this.LblNombre.TabIndex = 108;
            // 
            // LblEmpId
            // 
            this.LblEmpId.AutoSize = true;
            this.LblEmpId.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmpId.ForeColor = System.Drawing.Color.Black;
            this.LblEmpId.Location = new System.Drawing.Point(386, 48);
            this.LblEmpId.Name = "LblEmpId";
            this.LblEmpId.Size = new System.Drawing.Size(115, 22);
            this.LblEmpId.TabIndex = 109;
            this.LblEmpId.Text = "Trabajador:";
            // 
            // LblFraccId
            // 
            this.LblFraccId.AutoSize = true;
            this.LblFraccId.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFraccId.ForeColor = System.Drawing.Color.Black;
            this.LblFraccId.Location = new System.Drawing.Point(649, 48);
            this.LblFraccId.Name = "LblFraccId";
            this.LblFraccId.Size = new System.Drawing.Size(115, 22);
            this.LblFraccId.TabIndex = 110;
            this.LblFraccId.Text = "Trabajador:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 22);
            this.label1.TabIndex = 111;
            this.label1.Text = "Programa:";
            // 
            // LblEstilo
            // 
            this.LblEstilo.AutoSize = true;
            this.LblEstilo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEstilo.ForeColor = System.Drawing.Color.Black;
            this.LblEstilo.Location = new System.Drawing.Point(301, 121);
            this.LblEstilo.Name = "LblEstilo";
            this.LblEstilo.Size = new System.Drawing.Size(115, 22);
            this.LblEstilo.TabIndex = 112;
            this.LblEstilo.Text = "Trabajador:";
            // 
            // LblTEstilo
            // 
            this.LblTEstilo.AutoSize = true;
            this.LblTEstilo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTEstilo.ForeColor = System.Drawing.Color.White;
            this.LblTEstilo.Location = new System.Drawing.Point(247, 121);
            this.LblTEstilo.Name = "LblTEstilo";
            this.LblTEstilo.Size = new System.Drawing.Size(57, 22);
            this.LblTEstilo.TabIndex = 113;
            this.LblTEstilo.Text = "Estilo:";
            // 
            // LblTColor
            // 
            this.LblTColor.AutoSize = true;
            this.LblTColor.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTColor.ForeColor = System.Drawing.Color.White;
            this.LblTColor.Location = new System.Drawing.Point(241, 150);
            this.LblTColor.Name = "LblTColor";
            this.LblTColor.Size = new System.Drawing.Size(63, 22);
            this.LblTColor.TabIndex = 115;
            this.LblTColor.Text = "Color:";
            // 
            // LblColor
            // 
            this.LblColor.AutoSize = true;
            this.LblColor.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblColor.ForeColor = System.Drawing.Color.Black;
            this.LblColor.Location = new System.Drawing.Point(301, 150);
            this.LblColor.Name = "LblColor";
            this.LblColor.Size = new System.Drawing.Size(115, 22);
            this.LblColor.TabIndex = 114;
            this.LblColor.Text = "Trabajador:";
            // 
            // LblTPP
            // 
            this.LblTPP.AutoSize = true;
            this.LblTPP.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTPP.ForeColor = System.Drawing.Color.White;
            this.LblTPP.Location = new System.Drawing.Point(232, 176);
            this.LblTPP.Name = "LblTPP";
            this.LblTPP.Size = new System.Drawing.Size(72, 22);
            this.LblTPP.TabIndex = 116;
            this.LblTPP.Text = "Par/Pz:";
            // 
            // LblPP
            // 
            this.LblPP.AutoSize = true;
            this.LblPP.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPP.ForeColor = System.Drawing.Color.Black;
            this.LblPP.Location = new System.Drawing.Point(301, 176);
            this.LblPP.Name = "LblPP";
            this.LblPP.Size = new System.Drawing.Size(54, 22);
            this.LblPP.TabIndex = 117;
            this.LblPP.Text = "1000";
            // 
            // LblPagado
            // 
            this.LblPagado.AutoSize = true;
            this.LblPagado.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPagado.ForeColor = System.Drawing.Color.Black;
            this.LblPagado.Location = new System.Drawing.Point(474, 176);
            this.LblPagado.Name = "LblPagado";
            this.LblPagado.Size = new System.Drawing.Size(54, 22);
            this.LblPagado.TabIndex = 119;
            this.LblPagado.Text = "1000";
            // 
            // LblTPagado
            // 
            this.LblTPagado.AutoSize = true;
            this.LblTPagado.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTPagado.ForeColor = System.Drawing.Color.White;
            this.LblTPagado.Location = new System.Drawing.Point(377, 176);
            this.LblTPagado.Name = "LblTPagado";
            this.LblTPagado.Size = new System.Drawing.Size(97, 22);
            this.LblTPagado.TabIndex = 118;
            this.LblTPagado.Text = "Pagados:";
            // 
            // LblRestante
            // 
            this.LblRestante.AutoSize = true;
            this.LblRestante.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRestante.ForeColor = System.Drawing.Color.Black;
            this.LblRestante.Location = new System.Drawing.Point(657, 176);
            this.LblRestante.Name = "LblRestante";
            this.LblRestante.Size = new System.Drawing.Size(54, 22);
            this.LblRestante.TabIndex = 121;
            this.LblRestante.Text = "1000";
            // 
            // LblTRestante
            // 
            this.LblTRestante.AutoSize = true;
            this.LblTRestante.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTRestante.ForeColor = System.Drawing.Color.White;
            this.LblTRestante.Location = new System.Drawing.Point(555, 176);
            this.LblTRestante.Name = "LblTRestante";
            this.LblTRestante.Size = new System.Drawing.Size(104, 22);
            this.LblTRestante.TabIndex = 120;
            this.LblTRestante.Text = "Restantes:";
            // 
            // LblTCantidad
            // 
            this.LblTCantidad.AutoSize = true;
            this.LblTCantidad.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTCantidad.ForeColor = System.Drawing.Color.White;
            this.LblTCantidad.Location = new System.Drawing.Point(641, 204);
            this.LblTCantidad.Name = "LblTCantidad";
            this.LblTCantidad.Size = new System.Drawing.Size(104, 22);
            this.LblTCantidad.TabIndex = 122;
            this.LblTCantidad.Text = "Cantidad:";
            // 
            // TcEmpleados
            // 
            this.TcEmpleados.Controls.Add(this.TpIndex);
            this.TcEmpleados.Controls.Add(this.TpTrabajador);
            this.TcEmpleados.Controls.Add(this.TpFraccion);
            this.TcEmpleados.Controls.Add(this.TpMuestra);
            this.TcEmpleados.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TcEmpleados.Location = new System.Drawing.Point(3, 240);
            this.TcEmpleados.Name = "TcEmpleados";
            this.TcEmpleados.SelectedIndex = 0;
            this.TcEmpleados.Size = new System.Drawing.Size(1073, 422);
            this.TcEmpleados.TabIndex = 123;
            // 
            // TpIndex
            // 
            this.TpIndex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.TpIndex.Controls.Add(this.DgvEmpleados);
            this.TpIndex.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TpIndex.Location = new System.Drawing.Point(4, 26);
            this.TpIndex.Name = "TpIndex";
            this.TpIndex.Padding = new System.Windows.Forms.Padding(3);
            this.TpIndex.Size = new System.Drawing.Size(1065, 392);
            this.TpIndex.TabIndex = 0;
            this.TpIndex.Text = "Index";
            // 
            // DgvEmpleados
            // 
            this.DgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar});
            this.DgvEmpleados.Location = new System.Drawing.Point(0, 0);
            this.DgvEmpleados.Name = "DgvEmpleados";
            this.DgvEmpleados.Size = new System.Drawing.Size(1065, 392);
            this.DgvEmpleados.TabIndex = 0;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = ((System.Drawing.Image)(resources.GetObject("Editar.Image")));
            this.Editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Editar.Name = "Editar";
            this.Editar.Width = 55;
            // 
            // TpTrabajador
            // 
            this.TpTrabajador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.TpTrabajador.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TpTrabajador.Location = new System.Drawing.Point(4, 26);
            this.TpTrabajador.Name = "TpTrabajador";
            this.TpTrabajador.Padding = new System.Windows.Forms.Padding(3);
            this.TpTrabajador.Size = new System.Drawing.Size(1065, 392);
            this.TpTrabajador.TabIndex = 1;
            this.TpTrabajador.Text = "Trabajador";
            // 
            // TpFraccion
            // 
            this.TpFraccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.TpFraccion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TpFraccion.Location = new System.Drawing.Point(4, 26);
            this.TpFraccion.Name = "TpFraccion";
            this.TpFraccion.Size = new System.Drawing.Size(1065, 392);
            this.TpFraccion.TabIndex = 2;
            this.TpFraccion.Text = "Fracción";
            // 
            // LblTFraccion
            // 
            this.LblTFraccion.AutoSize = true;
            this.LblTFraccion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTFraccion.ForeColor = System.Drawing.Color.White;
            this.LblTFraccion.Location = new System.Drawing.Point(24, 204);
            this.LblTFraccion.Name = "LblTFraccion";
            this.LblTFraccion.Size = new System.Drawing.Size(94, 22);
            this.LblTFraccion.TabIndex = 124;
            this.LblTFraccion.Text = "Fracción:";
            // 
            // LblFraccion
            // 
            this.LblFraccion.AutoSize = true;
            this.LblFraccion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFraccion.ForeColor = System.Drawing.Color.Black;
            this.LblFraccion.Location = new System.Drawing.Point(119, 204);
            this.LblFraccion.Name = "LblFraccion";
            this.LblFraccion.Size = new System.Drawing.Size(115, 22);
            this.LblFraccion.TabIndex = 125;
            this.LblFraccion.Text = "Trabajador:";
            // 
            // TpMuestra
            // 
            this.TpMuestra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.TpMuestra.Location = new System.Drawing.Point(4, 26);
            this.TpMuestra.Name = "TpMuestra";
            this.TpMuestra.Size = new System.Drawing.Size(1065, 392);
            this.TpMuestra.TabIndex = 3;
            this.TpMuestra.Text = "Muestra";
            // 
            // FrmDestajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1080, 665);
            this.Controls.Add(this.LblFraccion);
            this.Controls.Add(this.LblTFraccion);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.TcEmpleados);
            this.Controls.Add(this.LblTCantidad);
            this.Controls.Add(this.LblRestante);
            this.Controls.Add(this.LblTRestante);
            this.Controls.Add(this.LblPagado);
            this.Controls.Add(this.LblTPagado);
            this.Controls.Add(this.LblPP);
            this.Controls.Add(this.LblTPP);
            this.Controls.Add(this.LblTColor);
            this.Controls.Add(this.LblColor);
            this.Controls.Add(this.LblTEstilo);
            this.Controls.Add(this.LblEstilo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblFraccId);
            this.Controls.Add(this.LblEmpId);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.LblIdFraccion);
            this.Controls.Add(this.LblIdTrabajador);
            this.Controls.Add(this.CbSemana);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.LblSemana);
            this.Controls.Add(this.TxtPrograma);
            this.Controls.Add(this.LblTrabajador);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.LblTituloFraccEstilo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDestajo";
            this.Text = "FrmDestajo";
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            this.TcEmpleados.ResumeLayout(false);
            this.TpIndex.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmpleados)).EndInit();
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
        private System.Windows.Forms.TextBox TxtPrograma;
        private System.Windows.Forms.Label LblTrabajador;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.Label LblSemana;
        private System.Windows.Forms.ComboBox CbSemana;
        private System.Windows.Forms.Label LblIdTrabajador;
        private System.Windows.Forms.Label LblIdFraccion;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblEmpId;
        private System.Windows.Forms.Label LblFraccId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblEstilo;
        private System.Windows.Forms.Label LblTEstilo;
        private System.Windows.Forms.Label LblTColor;
        private System.Windows.Forms.Label LblColor;
        private System.Windows.Forms.Label LblTPP;
        private System.Windows.Forms.Label LblPP;
        private System.Windows.Forms.Label LblPagado;
        private System.Windows.Forms.Label LblTPagado;
        private System.Windows.Forms.Label LblRestante;
        private System.Windows.Forms.Label LblTRestante;
        private System.Windows.Forms.Label LblTCantidad;
        private System.Windows.Forms.TabControl TcEmpleados;
        private System.Windows.Forms.TabPage TpIndex;
        private System.Windows.Forms.DataGridView DgvEmpleados;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.TabPage TpTrabajador;
        private System.Windows.Forms.TabPage TpFraccion;
        private System.Windows.Forms.TabPage TpMuestra;
        private System.Windows.Forms.Label LblTFraccion;
        private System.Windows.Forms.Label LblFraccion;
    }
}