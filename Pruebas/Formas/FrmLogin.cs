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
        #region Variables Privadas
        private ClsUser ObjUser = null;
        private readonly ClsUserLn ObjUserLn = new ClsUserLn();
        #endregion

        #region Metodos Constructores
        public FrmLogin()
        {
            InitializeComponent();
        }
        #endregion

        #region Metodos Privados
        private void MsgError(string msg)
        {
            LblError.Text = "        " + msg;
            LblError.Visible = true;
        }
        #endregion

        /*Codigo para mover la ventana a voluntad de uno*/
        #region Mover Ventana
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

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

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region Accion con TxtBox
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
        #endregion

        #region Acción con Botones
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
                        if (ObjUser.DtResultados.Rows.Count == 0)
                        {
                            MsgError("USUARIO o CONTRASEÑA es incorrecto");
                            TxtContrasena.Clear();
                            TxtUsuario.Focus();
                        }
                        else
                        {
                            FrmMenu frmMenu = new FrmMenu(ObjUser.UserId);
                            frmMenu.Show();
                            this.Hide();
                        }
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
                    TxtContrasena.Focus();
                }
            }
            else
            {
                MsgError("Favor de colocar tu USUARIO");
                TxtUsuario.Focus();
            }

        }
        #endregion
    }
}
