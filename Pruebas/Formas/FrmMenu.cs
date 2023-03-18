using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Pruebas.Formas;
using Entidades.Usuario;
using LogicaNegocio.Usuario;

namespace Proyeccion.Principal
{
    public partial class FrmMenu : Form
    {
        #region Variables Privadas
        private ClsPermisosUsers ObjPermisosUsers = null;
        private readonly ClsPermisosUsersLn ObjPermisosUsersLn = new ClsPermisosUsersLn();

        private int userId;
        #endregion

        #region Metodos Contructores
        public FrmMenu()
        {
            InitializeComponent();
        }

        public FrmMenu(int Id)
        {
            InitializeComponent();
            userId = Id;
            Permisos();
        }
        #endregion

        #region Acciones con Botones
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

        private void BtnRepAvances_Click(object sender, EventArgs e)
        {
            AbrirFrmHijo(new FrmReportesAvances());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SubMenuReporte.Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            SubMenuReporte.Visible = false;
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

        private void BtnFraccion_Click(object sender, EventArgs e)
        {
            AbrirFrmHijo(new FrmFracciones());
        }

        private void BtnFraccEstilo_Click(object sender, EventArgs e)
        {
            AbrirFrmHijo(new FrmFraccEstilo());
        }

        private void BtnCapturaDestajo_Click(object sender, EventArgs e)
        {
            AbrirFrmHijo(new FrmDestajo());
        }

        private void BtnRevDestajo_Click(object sender, EventArgs e)
        {
            AbrirFrmHijo(new FrmRevDestajo());
        }

        private void BtnUsuAvances_Click(object sender, EventArgs e)
        {
            AbrirFrmHijo(new FrmUsuAvances());
        }

        private void BtnAvances_Click(object sender, EventArgs e)
        {
            AbrirFrmHijo(new FrmAvances(userId));
        }

        private void BtnLoteo_Click(object sender, EventArgs e)
        {
            AbrirFrmHijo(new FrmLoteo());
        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Quieres cerrar sesión?", "Mensaje de Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                FrmLogin frmLogin = new FrmLogin();
                frmLogin.Show();
                this.Close();
            }
        }
        #endregion

        #region Metodos Privados
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

        private void Permisos()
        {
            ObjPermisosUsers = new ClsPermisosUsers()
            {
                U_UserId = userId
            };

            ObjPermisosUsersLn.Read(ref ObjPermisosUsers);
            if (ObjPermisosUsers.MsjError == null)
            {
                BtnAvances.Enabled = ObjPermisosUsers.PAvances;
                BtnCapturaDestajo.Enabled = ObjPermisosUsers.PCapturaDestajo;
                BtnEmpleados.Enabled = ObjPermisosUsers.PEmpleados;
                BtnEscaneo.Enabled = ObjPermisosUsers.PEscaneo;
                BtnFraccEstilo.Enabled = ObjPermisosUsers.PFraccEstilo;
                BtnFraccion.Enabled = ObjPermisosUsers.PFracciones;
                BtnUsuarios.Enabled = ObjPermisosUsers.PUsuario;
                BtnRevDestajo.Enabled = ObjPermisosUsers.PRevDestajo;
                BtnLoteo.Enabled = ObjPermisosUsers.PLoteo;
                BtnUsuAvances.Enabled = ObjPermisosUsers.PUAvances;
                BtnRepAvances.Enabled = ObjPermisosUsers.PRepAvances;
            }
        }
        #endregion

        /*Codigo para mover la ventana a voluntad de uno*/
        #region Mover Ventana
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
    }
}
