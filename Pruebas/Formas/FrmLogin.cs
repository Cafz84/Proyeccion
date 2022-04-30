using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Entidades.Usuario;
using LogicaNegocio.Usuario;

namespace Proyeccion.Principal
{
    public partial class FrmLogin : Form
    {
        private ClsUser ObjUser = null;
        private readonly ClsUserLn ObjUserLn = new ClsUserLn();
        
        public FrmLogin()
        {
            InitializeComponent();
        }

        /*Codigo para mover la ventana a voluntad de uno*/
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void TxtUsuario_Enter(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "USUARIO")
            {
                TxtUsuario.Text = "";
                TxtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void TxtUsuario_Leave(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "")
            {
                TxtUsuario.Text = "USUARIO";
                TxtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void TxtContrasena_Enter(object sender, EventArgs e)
        {
            if (TxtContrasena.Text == "CONTRASEÑA")
            {
                TxtContrasena.Text = "";
                TxtContrasena.ForeColor = Color.LightGray;
                TxtContrasena.UseSystemPasswordChar = true;
            }
        }

        private void TxtContrasena_Leave(object sender, EventArgs e)
        {
            if (TxtContrasena.Text == "")
            {
                TxtContrasena.Text = "CONTRASEÑA";
                TxtContrasena.ForeColor = Color.DimGray;
                TxtContrasena.UseSystemPasswordChar = false;
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (TxtUsuario.Text != "USUARIO")
            {
                if (TxtContrasena.Text != "CONTRASEÑA")
                {
                    ObjUser = new ClsUser()
                    {
                        LoginName = TxtUsuario.Text,
                        Password = TxtContrasena.Text
                    };

                    ObjUserLn.ReadLogin(ref ObjUser);

                    if (ObjUser.MsjError == null)
                    {
                        FrmMenu frmMenu = new FrmMenu();
                        frmMenu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MsgError("USUARIO o CONTRASEÑA es incorrecto");
                        TxtContrasena.Clear();
                        TxtUsuario.Focus();
                    }
                }
                else
                {
                    MsgError("Favor de ingresar tu CONTRASEÑA");
                }
            }
            else
            {
                MsgError("Favor de colocar tu USUARIO");
            }
            
        }

        private void MsgError(string msg)
        {
            LblError.Text = "        " + msg;
            LblError.Visible = true;
        }
    }
}
