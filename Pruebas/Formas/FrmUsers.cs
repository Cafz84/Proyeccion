using Entidades.Usuario;
using LogicaNegocio.Usuario;
using System;
using System.Windows.Forms;

namespace Proyeccion.Principal
{
    public partial class FrmUsers : Form
    {
        
        private ClsUser ObjUser = null;
        private readonly ClsUserLn ObjUserLn = new ClsUserLn();

        public FrmUsers()
        {
            InitializeComponent();
            CargarListaUsers();
        }

        
        private void CargarListaUsers()
        {
            ObjUser = new ClsUser(); 
            ObjUserLn.Index(ref ObjUser);
            if (ObjUser.MsjError == null)
            {
                DgvUsers.DataSource = ObjUser.DtResultados;
            }
            else
            {
                MessageBox.Show(ObjUser.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            ObjUser = new ClsUser()
            {
                FirstName = TxtNombre.Text,
                LastName = TxtApellido.Text,
                Position = TxtPuesto.Text,
                LoginName = TxtUsuario.Text,
                Password = TxtContrasena.Text,
                Email = TxtEmail.Text
            };

            ObjUserLn.Create(ref ObjUser);

            if (ObjUser.MsjError == null)
            {
                MessageBox.Show("El Id: " + ObjUser.ValorEscalar + ", fue agregado correctamente");
                CargarListaUsers();
                TxtApellido.Clear();
                TxtPuesto.Clear();
                TxtContrasena.Clear();
                TxtEmail.Clear();
                TxtNombre.Clear();
                TxtUsuario.Clear();
                TxtNombre.Focus();
            }
            else
            {
                MessageBox.Show(ObjUser.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DgvUsers.Columns[e.ColumnIndex].Name == "Editar")
                {
                    ObjUser = new ClsUser()
                    {
                        UserId = Convert.ToByte(DgvUsers.Rows[e.RowIndex].Cells["UserId"].Value.ToString())
                    };

                    LblUserId.Text = ObjUser.UserId.ToString();

                    ObjUserLn.Read(ref ObjUser);
                    TxtNombre.Text = ObjUser.FirstName;
                    TxtApellido.Text = ObjUser.LastName;
                    TxtPuesto.Text = ObjUser.Position;
                    TxtUsuario.Text = ObjUser.LoginName;
                    TxtContrasena.Text = ObjUser.Password;
                    TxtEmail.Text = ObjUser.Email;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            ObjUser = new ClsUser()
            {
                UserId = Convert.ToByte(LblUserId.Text),
                FirstName = TxtNombre.Text,
                LastName = TxtApellido.Text,
                LoginName = TxtUsuario.Text,
                Password = TxtContrasena.Text,
                Position = TxtPuesto.Text,
                Email = TxtEmail.Text
            };

            ObjUserLn.Update(ref ObjUser);
            if (ObjUser.MsjError == null)
            {
                MessageBox.Show("El usuario fue actualizado correctamente");
                CargarListaUsers();
            }
            else
            {
                MessageBox.Show(ObjUser.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            ObjUser = new ClsUser()
            {
                UserId = Convert.ToByte(LblUserId.Text)
            };

            ObjUserLn.Delete(ref ObjUser);

            CargarListaUsers();
        }
    }
}
