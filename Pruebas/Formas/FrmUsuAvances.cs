using Entidades.Usuario;
using LogicaNegocio.Usuario;
using System;
using System.Windows.Forms;

namespace Pruebas.Formas
{
    public partial class FrmUsuAvances : Form
    {
        #region Variables Privadas
        ClsRUsuarioAvance ObjRUsuarioAvance = null;
        ClsAvance ObjAvance = null;
        ClsUser ObjUser = null;
        readonly ClsRUsuarioAvanceLn ObjRUsuarioAvanceLn = new ClsRUsuarioAvanceLn();
        readonly ClsAvanceLn ObjAvanceLn = new ClsAvanceLn();
        readonly ClsUserLn ObjUserLn = new ClsUserLn();

        private int idUsuaraio, cambioIdUsuario;
        private char area, cambioArea;
        private float idAvance, cambioIdAvance;
        #endregion

        #region Metodos Constructores
        public FrmUsuAvances()
        {
            InitializeComponent();
            Limpiar();
            LimpiarAvance();
            CargarIndex();
            CargarUsuario();
            CargarRAvance();
            CargarAvance();
        }
        #endregion

        #region Metodos Privados
        private void Limpiar()
        {
            LblUsuario.Text = string.Empty;
            LblArea.Text = string.Empty;
            LblAvance.Text = string.Empty;

            BtnActualizar.Enabled = false;
            BtnEliminar.Enabled = false;
            BtnAgregar.Enabled = true;
        }

        private void LimpiarAvance()
        {
            TxtId.Clear();
            TxtAvance.Clear();
            CbArea.SelectedIndex = -1;
            TxtDescripcion.Clear();

            BtnAActualizar.Enabled = false;
            BtnAEliminar.Enabled = false;
            BtnAAgregar.Enabled = true;
            TxtId.Enabled = true;
            CbArea.Enabled = true;
        }

        private void CargarIndex()
        {
            ObjRUsuarioAvance = new ClsRUsuarioAvance()
            {
                Usuario = TxtBIUsuario.Text
            };

            ObjRUsuarioAvanceLn.Index(ref ObjRUsuarioAvance);
            if (ObjRUsuarioAvance.MsjError == null)
            {
                DgvUserAvance.DataSource = ObjRUsuarioAvance.DtResultados;
                DgvUserAvance.Columns["AvanceId"].Visible = false;
                DgvUserAvance.Columns["UserId"].Visible = false;
                DgvUserAvance.Columns["Editar"].Width = 35;
            }
        }

        private void CargarUsuario()
        {
            ObjUser = new ClsUser()
            {
                LoginName = TxtBRUsuario.Text
            };

            ObjUserLn.UsersAvanceIndex(ref ObjUser);
            if (ObjUser.MsjError == null)
            {
                DgvRUsuario.DataSource = ObjUser.DtResultados;
                DgvRUsuario.Columns["UserId"].Visible = false;
                DgvRUsuario.Columns["RSelUsuario"].Width = 30;
            }
        }

        private void CargarRAvance()
        {
            ObjAvance = new ClsAvance()
            {
                Avance = TxtBRAvance.Text
            };

            ObjAvanceLn.Index(ref ObjAvance);
            if (ObjAvance.MsjError == null)
            {
                DgvRAvance.DataSource = ObjAvance.DtResultados;
                DgvRAvance.Columns["Descripcion"].Visible = false;
                DgvRAvance.Columns["RSelAvance"].Width = 30;
            }
        }

        private void CargarAvance()
        {
            ObjAvance = new ClsAvance()
            {
                Avance = TxtBAvance.Text
            };

            ObjAvanceLn.Index(ref ObjAvance);
            if (ObjAvance.MsjError == null)
            {
                DgvAvance.DataSource = ObjAvance.DtResultados;
                DgvAvance.Columns["AEdit"].Width = 35;
            }
        }
        #endregion

        #region Acción con Botones
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (LblUsuario.Text == string.Empty)
            {
                MessageBox.Show("Se requere seleccionar un usuario", "Mensaje de sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (LblArea.Text == string.Empty)
            {
                MessageBox.Show("Se requere seleccionar un avance", "Mensaje de sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Quieres asignar el avance?", "Mensaje de Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    ObjRUsuarioAvance = new ClsRUsuarioAvance()
                    {
                        UserId = cambioIdUsuario,
                        Area = cambioArea,
                        AvanceId = cambioIdAvance
                    };

                    ObjRUsuarioAvanceLn.Create(ref ObjRUsuarioAvance);
                    if (ObjRUsuarioAvance.MsjError == null)
                    {
                        MessageBox.Show("Avance asignado exitosamente", "Mensaje de sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        CargarIndex();
                    }
                    else
                    {
                        MessageBox.Show(ObjRUsuarioAvance.MsjError, "Mensaje de sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Quieres modificar la asignación de avance?", "Mensaje de Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ObjRUsuarioAvance = new ClsRUsuarioAvance()
                {
                    UserId = idUsuaraio,
                    Area = area,
                    AvanceId = idAvance,
                    CambioArea = cambioArea,
                    CambioAvanceId = cambioIdAvance,
                    CambioUserId = cambioIdUsuario
                };

                ObjRUsuarioAvanceLn.Update(ref ObjRUsuarioAvance);
                if (ObjRUsuarioAvance.MsjError == null)
                {
                    MessageBox.Show("Actualización exitosa", "Mensaje de sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    CargarIndex();
                }
                else
                {
                    MessageBox.Show(ObjRUsuarioAvance.MsjError, "Mensaje de sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Quieres elimar el registro?", "Mensaje de Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ObjRUsuarioAvance = new ClsRUsuarioAvance()
                {
                    UserId = cambioIdUsuario,
                    Area = cambioArea,
                    AvanceId = cambioIdAvance
                };

                ObjRUsuarioAvanceLn.Delete(ref ObjRUsuarioAvance);
                if (ObjRUsuarioAvance.MsjError == null)
                {
                    MessageBox.Show("Eliminación exitosa", "Mensaje de sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    CargarIndex();
                }
                else
                {
                    MessageBox.Show(ObjRUsuarioAvance.MsjError, "Mensaje de sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnALimpiar_Click(object sender, EventArgs e)
        {
            LimpiarAvance();
        }

        private void BtnAAgregar_Click(object sender, EventArgs e)
        {
            if (TxtId.Text == string.Empty)
            {
                MessageBox.Show("Favor de ingresar el Id", "Mensaje de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtId.Focus();
            }
            else if (CbArea.Text == string.Empty)
            {
                MessageBox.Show("Favor de ingresar la Area", "Mensaje de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CbArea.Focus();
            }
            else if (TxtAvance.Text == string.Empty)
            {
                MessageBox.Show("Favor de ingresar un Avance", "Mensaje de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtAvance.Focus();
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Quieres agregar el registro?", "Mensaje de Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    ObjAvance = new ClsAvance()
                    {
                        Id = Convert.ToSingle(TxtId.Text),
                        Area = CbArea.Text[0],
                        Avance = TxtAvance.Text.ToUpper(),
                        Descripcion = TxtDescripcion.Text
                    };

                    ObjAvanceLn.Create(ref ObjAvance);
                    if (ObjAvance.MsjError == null)
                    {
                        MessageBox.Show("Registro exitoso", "Mensaje de sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarAvance();
                        TxtId.Focus();
                        CargarAvance();
                    }
                    else
                    {
                        MessageBox.Show(ObjAvance.MsjError, "Mensaje de sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BtnAActualizar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Quieres modificar el avance?", "Mensaje de Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ObjAvance = new ClsAvance()
                {
                    Id = Convert.ToSingle(TxtId.Text),
                    Area = CbArea.Text[0],
                    Avance = TxtAvance.Text.ToUpper(),
                    Descripcion = TxtDescripcion.Text
                };

                ObjAvanceLn.Update(ref ObjAvance);
                if (ObjAvance.MsjError == null)
                {
                    MessageBox.Show("Actualización exitosa", "Mensaje de sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarAvance();
                    TxtId.Focus();
                    CargarAvance();
                }
                else
                {
                    MessageBox.Show(ObjAvance.MsjError, "Mensaje de sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnAEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Quieres elimar el registro?", "Mensaje de Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ObjAvance = new ClsAvance()
                {
                    Id = Convert.ToSingle(TxtId.Text),
                    Area = CbArea.Text[0]
                };

                ObjAvanceLn.Delete(ref ObjAvance);
                if (ObjRUsuarioAvance.MsjError == null)
                {
                    MessageBox.Show("Eliminación exitosa", "Mensaje de sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarAvance();
                }
                else
                {
                    MessageBox.Show(ObjAvance.MsjError, "Mensaje de sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        #region Acciones con DataGrieView
        private void DgvUserAvance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvUserAvance.Columns[e.ColumnIndex].Name == "Editar")
            {
                LblUsuario.Text = DgvUserAvance.Rows[e.RowIndex].Cells["Usuario"].Value.ToString();
                if (Convert.ToChar(DgvUserAvance.Rows[e.RowIndex].Cells["Area"].Value.ToString()) == 'C')
                {
                    LblArea.Text = "Calzado";
                }
                else
                {
                    LblArea.Text = "Marroquineria";
                }
                LblAvance.Text = DgvUserAvance.Rows[e.RowIndex].Cells["Avance"].Value.ToString();

                idUsuaraio = Convert.ToInt16(DgvUserAvance.Rows[e.RowIndex].Cells["UserId"].Value.ToString());
                area = Convert.ToChar(DgvUserAvance.Rows[e.RowIndex].Cells["Area"].Value.ToString());
                idAvance = Convert.ToSingle(DgvUserAvance.Rows[e.RowIndex].Cells["AvanceId"].Value.ToString());

                cambioArea = area;
                cambioIdAvance = idAvance;
                cambioIdUsuario = idUsuaraio;

                BtnAgregar.Enabled = false;
                BtnActualizar.Enabled = true;
                BtnEliminar.Enabled = true;
            }
        }

        private void DgvRUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvRUsuario.Columns[e.ColumnIndex].Name == "RSelUsuario")
            {
                LblUsuario.Text = DgvRUsuario.Rows[e.RowIndex].Cells["Usuario"].Value.ToString();
                cambioIdUsuario = Convert.ToInt16(DgvRUsuario.Rows[e.RowIndex].Cells["UserId"].Value.ToString());
            }
        }

        private void DgvRAvance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvRAvance.Columns[e.ColumnIndex].Name == "RSelAvance")
            {
                LblAvance.Text = DgvRAvance.Rows[e.RowIndex].Cells["Avance"].Value.ToString();
                if (Convert.ToChar(DgvRAvance.Rows[e.RowIndex].Cells["Area"].Value.ToString()) == 'C')
                {
                    LblArea.Text = "Calzado";
                }
                else
                {
                    LblArea.Text = "Marroquineria";
                }

                cambioArea = Convert.ToChar(DgvRAvance.Rows[e.RowIndex].Cells["Area"].Value.ToString());
                cambioIdAvance = Convert.ToSingle(DgvRAvance.Rows[e.RowIndex].Cells["Id"].Value.ToString());
            }
        }

        private void DgvAvance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvAvance.Columns[e.ColumnIndex].Name == "AEdit")
            {
                ObjAvance = new ClsAvance()
                {
                    Id = Convert.ToInt16(DgvAvance.Rows[e.RowIndex].Cells["Id"].Value.ToString()),
                    Area = Convert.ToChar(DgvAvance.Rows[e.RowIndex].Cells["Area"].Value.ToString())
                };

                ObjAvanceLn.Read(ref ObjAvance);
                if (ObjAvance.MsjError == null)
                {
                    TxtId.Text = ObjAvance.Id.ToString();
                    if (ObjAvance.Area == 'C')
                    {
                        CbArea.SelectedIndex = 0;
                    }
                    else
                    {
                        CbArea.SelectedIndex = 1;
                    }
                    TxtAvance.Text = ObjAvance.Avance;
                    TxtDescripcion.Text = ObjAvance.Descripcion;
                    TxtId.Enabled = false;
                    CbArea.Enabled = false;

                    BtnAAgregar.Enabled = false;
                    BtnAActualizar.Enabled = true;

                    ObjRUsuarioAvance = new ClsRUsuarioAvance()
                    {
                        AvanceId = ObjAvance.Id,
                        Area = ObjAvance.Area
                    };

                    ObjRUsuarioAvanceLn.ReadVal(ref ObjRUsuarioAvance);
                    if (ObjRUsuarioAvance.MsjError == null)
                    {
                        if (ObjRUsuarioAvance.DtResultados.Rows.Count > 0)
                        {
                            BtnAEliminar.Enabled = false;
                        }
                        else
                        {
                            BtnAEliminar.Enabled = true;
                        }
                    }
                }
            }
        }
        #endregion

        #region Acciones con TextBox
        private void TxtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para que solo acepte numeros y no texto
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            //Para que solo se pueda colocar un solo punto y no mas
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        #endregion

        #region Acciones con ComboBox
        private void CbArea_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        #endregion
    }
}