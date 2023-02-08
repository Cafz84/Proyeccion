using Entidades.Usuario;
using LogicaNegocio.Usuario;
using Pruebas.Utilidades;
using System;
using System.Windows.Forms;

namespace Proyeccion.Principal
{
    public partial class FrmUsers : Form
    {
        #region Variables Privadas
        private ClsUser ObjUser = null;
        private ClsPermisosUsers ObjPermisosUsers = null;
        private readonly ClsUserLn ObjUserLn = new ClsUserLn();
        private readonly ClsPermisosUsersLn ObjPermisosUsersLn = new ClsPermisosUsersLn();
        private readonly ClsUtilidades ObjUtilidades = new ClsUtilidades();
        #endregion

        #region Metodos Constructores
        public FrmUsers()
        {
            InitializeComponent();
            CargarListaUsers();
        }
        #endregion

        #region Metodos Privados
        private void Limpiar()
        {
            TxtApellido.Clear();
            TxtPuesto.Clear();
            TxtContrasena.Clear();
            TxtEmail.Clear();
            TxtNombre.Clear();
            TxtUsuario.Clear();
            TxtNombre.Focus();
            LblUserId.Text = string.Empty;
            ChkAvances.Checked = false;
            ChkCapDestajo.Checked = false;
            ChkEmpleados.Checked = false;
            ChkEscaneo.Checked = false;
            ChkFraccEstilo.Checked = false;
            ChkFracciones.Checked = false;
            ChkRevDestajo.Checked = false;
            ChkUsuarios.Checked = false;
            ChkLoteo.Checked = false;
            ChkUAvances.Checked = false;

            BtnActualizar.Enabled = false;
            BtnEliminar.Enabled = false;
            BtnAgregar.Enabled = true;
        }

        private void CargarListaUsers()
        {
            ObjUser = new ClsUser()
            {
                Nombre = TxtBNombre.Text
            };

            ObjUserLn.Index(ref ObjUser);
            if (ObjUser.MsjError == null)
            {
                DgvUsers.DataSource = ObjUser.DtResultados;
                ObjUtilidades.FormatoDgvPEC(ref DgvUsers);
                DgvUsers.Columns["Id"].Visible = false;
                DgvUsers.Columns["FirstName"].Visible = false;
                DgvUsers.Columns["LastName"].Visible = false;
                DgvUsers.Columns["Editar"].Width = 30;
                DgvUsers.Columns["Nombre"].Width = 150;
                DgvUsers.Columns["Usuario"].Width = 75;
                DgvUsers.Columns["Puesto"].Width = 100;
                DgvUsers.Columns["Password"].Width = 75;
                DgvUsers.Columns["Email"].Width = 150;
            }
            else
            {
                MessageBox.Show(ObjUser.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Acción con Botones
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Quieres agregar el registro?", "Mensaje de Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                ObjUser = new ClsUser()
                {
                    FirstName = TxtNombre.Text,
                    LastName = TxtApellido.Text,
                    Position = TxtPuesto.Text.ToUpper(),
                    LoginName = TxtUsuario.Text,
                    Password = TxtContrasena.Text,
                    Email = TxtEmail.Text
                };

                ObjUserLn.Create(ref ObjUser);

                if (ObjUser.MsjError == null)
                {
                    ObjUserLn.ReadMaxId(ref ObjUser);
                    if (ObjUser.MsjError == null)
                    {
                        ObjPermisosUsers = new ClsPermisosUsers()
                        {
                            U_UserId = ObjUser.IdMax,
                            PAvances = ChkAvances.Checked,
                            PCapturaDestajo = ChkCapDestajo.Checked,
                            PEmpleados = ChkEmpleados.Checked,
                            PEscaneo = ChkEscaneo.Checked,
                            PFraccEstilo = ChkFraccEstilo.Checked,
                            PFracciones = ChkFracciones.Checked,
                            PRevDestajo = ChkRevDestajo.Checked,
                            PUsuario = ChkUsuarios.Checked,
                            PLoteo = ChkLoteo.Checked,
                            PUAvances = ChkUAvances.Checked
                        };

                        ObjPermisosUsersLn.Create(ref ObjPermisosUsers);
                        if (ObjPermisosUsers.MsjError == null)
                        {
                            MessageBox.Show("Registro exitoso");
                            CargarListaUsers();
                            Limpiar();
                        }
                        else
                        {
                            MessageBox.Show(ObjPermisosUsers.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show(ObjUser.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(ObjUser.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Quieres actualizar el registro?", "Mensaje de Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                ObjUser = new ClsUser()
                {
                    UserId = Convert.ToByte(LblUserId.Text),
                    FirstName = TxtNombre.Text,
                    LastName = TxtApellido.Text,
                    LoginName = TxtUsuario.Text,
                    Password = TxtContrasena.Text,
                    Position = TxtPuesto.Text.ToUpper(),
                    Email = TxtEmail.Text
                };

                ObjUserLn.Update(ref ObjUser);
                if (ObjUser.MsjError == null)
                {
                    ObjPermisosUsers = new ClsPermisosUsers()
                    {
                        U_UserId = Convert.ToByte(LblUserId.Text),
                        PAvances = ChkAvances.Checked,
                        PCapturaDestajo = ChkCapDestajo.Checked,
                        PEmpleados = ChkEmpleados.Checked,
                        PEscaneo = ChkEscaneo.Checked,
                        PFraccEstilo = ChkFraccEstilo.Checked,
                        PFracciones = ChkFracciones.Checked,
                        PRevDestajo = ChkRevDestajo.Checked,
                        PUsuario = ChkUsuarios.Checked,
                        PLoteo = ChkLoteo.Checked,
                        PUAvances = ChkUAvances.Checked
                    };

                    ObjPermisosUsersLn.Update(ref ObjPermisosUsers);
                    if (ObjPermisosUsers.MsjError == null)
                    {
                        MessageBox.Show("El registro fue actualizado correctamente");
                        CargarListaUsers();
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show(ObjPermisosUsers.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(ObjUser.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Quieres actualizar el registro?", "Mensaje de Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                ObjUser = new ClsUser()
                {
                    UserId = Convert.ToByte(LblUserId.Text)
                };

                ObjUserLn.Delete(ref ObjUser);
                if (ObjUser.MsjError == null)
                {
                    ObjPermisosUsers = new ClsPermisosUsers()
                    {
                        U_UserId = Convert.ToByte(LblUserId.Text)
                    };

                    ObjPermisosUsersLn.Delete(ref ObjPermisosUsers);
                    if (ObjPermisosUsers.MsjError == null)
                    {
                        MessageBox.Show("Registro eliminado");
                        CargarListaUsers();
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show(ObjPermisosUsers.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(ObjUser.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        #endregion

        #region Acción con DataGridView
        private void DgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DgvUsers.Columns[e.ColumnIndex].Name == "Editar")
                {
                    ObjUser = new ClsUser()
                    {
                        UserId = Convert.ToByte(DgvUsers.Rows[e.RowIndex].Cells["Id"].Value.ToString())
                    };

                    ObjPermisosUsers = new ClsPermisosUsers()
                    {
                        U_UserId = Convert.ToByte(DgvUsers.Rows[e.RowIndex].Cells["Id"].Value.ToString())
                    };

                    LblUserId.Text = ObjUser.UserId.ToString();

                    ObjUserLn.Read(ref ObjUser);
                    ObjPermisosUsersLn.Read(ref ObjPermisosUsers);
                    TxtNombre.Text = ObjUser.FirstName;
                    TxtApellido.Text = ObjUser.LastName;
                    TxtPuesto.Text = ObjUser.Position;
                    TxtUsuario.Text = ObjUser.LoginName;
                    TxtContrasena.Text = ObjUser.Password;
                    TxtEmail.Text = ObjUser.Email;
                    ChkAvances.Checked = ObjPermisosUsers.PAvances;
                    ChkCapDestajo.Checked = ObjPermisosUsers.PCapturaDestajo;
                    ChkEmpleados.Checked = ObjPermisosUsers.PEmpleados;
                    ChkEscaneo.Checked = ObjPermisosUsers.PEscaneo;
                    ChkFraccEstilo.Checked = ObjPermisosUsers.PFraccEstilo;
                    ChkFracciones.Checked = ObjPermisosUsers.PFracciones;
                    ChkRevDestajo.Checked = ObjPermisosUsers.PRevDestajo;
                    ChkUsuarios.Checked = ObjPermisosUsers.PUsuario;
                    ChkLoteo.Checked = ObjPermisosUsers.PLoteo;

                    BtnActualizar.Enabled = true;
                    BtnEliminar.Enabled = true;
                    BtnAgregar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion

        #region Acción con TextBox
        private void TxtBNombre_TextChanged(object sender, EventArgs e)
        {
            CargarListaUsers();
        }
        #endregion
    }
}
