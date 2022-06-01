using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Pruebas.Formas;

namespace Proyeccion.Principal
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BtnMaximizar.Visible = false;
            BtnRestaurar.Visible = true;
        }

        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            BtnRestaurar.Visible = false;
            BtnMaximizar.Visible = true;
        }

        /*Codigo para mover la ventana a voluntad de uno*/
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            SubMenuReporte.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SubMenuReporte.Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            SubMenuReporte.Visible=false;
        }

        private void AbrirFrmHijo(object FormHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }

            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AbrirFrmHijo(new FrmInicio());
        }

        private void BtnReportes_Click_1(object sender, EventArgs e)
        {
            SubMenuReporte.Visible = true;
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFrmHijo(new FrmUsers());
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFrmHijo(new FrmEmpleados());
        }

        private void BtnEscaneo_Click(object sender, EventArgs e)
        {
            AbrirFrmHijo(new FrmEscaneo());
        }
    }
}
