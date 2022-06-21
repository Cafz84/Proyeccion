using Entidades.Usuario;
using LogicaNegocio.Usuario;
using Pruebas.Utilidades;
using System;
using System.Windows.Forms;

namespace Pruebas.Formas
{
    public partial class FrmGrupo : Form
    {
        #region Variables Privadas
        private ClsGrupo ObjGrupo = null;
        private ClsEmpleado ObjEmpleado = null;
        private readonly ClsUtilidades ObjUtilidades = new ClsUtilidades();
        private readonly ClsEmpleadoLn ObjEmpleadoLn = new ClsEmpleadoLn();
        private readonly ClsGrupoLn ObjGrupoLn = new ClsGrupoLn();

        private readonly FrmDestajo FrmDestajoHandler;
        #endregion

        #region Constructores
        public FrmGrupo()
        {
            InitializeComponent();
        }

        public FrmGrupo(FrmDestajo frmDestajo)
        {
            InitializeComponent();
            CargarListaGrupo();
            FrmDestajoHandler = frmDestajo;
        }
        #endregion

        #region Metodos Privados
        private void LimpiarDatos()
        {
            LblGrupoId.Text = string.Empty;
            TxtNombre.Text = string.Empty;
            TxtDescripcion.Text = string.Empty;
            ChkActivo.Checked = false;

            BtnLimpiar.Enabled = false;
            BtnAgregar.Enabled = true;
            BtnActualizar.Enabled = false;
            BtnEliminar.Enabled = false;
        }

        private void CargarListaGrupo()
        {
            ObjGrupo = new ClsGrupo();
            ObjGrupoLn.Index(ref ObjGrupo);
            if (ObjGrupo.MsjError == null)
            {
                DgvGrupo.DataSource = ObjGrupo.DtResultados;
                ObjUtilidades.FormatoDataGridView(ref DgvGrupo);
            }
            else
            {
                MessageBox.Show(ObjGrupo.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Accion con Botones
        private void BtnCerrar_Click(object sender, System.EventArgs e)
        {
            this.Close();
            FrmDestajoHandler.CargarListaGrupo();
        }

        private void BtnLimpiar_Click(object sender, System.EventArgs e)
        {
            LimpiarDatos();
        }

        private void BtnAgregar_Click(object sender, System.EventArgs e)
        {
            if (LblGrupoId.Text == string.Empty)
            {
                DialogResult respuesta = MessageBox.Show("¿Quieres agregar el registro?", "Mensaje de sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (respuesta == DialogResult.OK)
                {
                    ObjEmpleado = new ClsEmpleado()
                    {
                        FirstName = TxtNombre.Text
                    };
                    
                    ObjEmpleadoLn.CreateGrupo(ref ObjEmpleado);
                    if (ObjEmpleado.MsjError == null)
                    {
                        ObjGrupo = new ClsGrupo()
                        {
                            GrupoDId = ObjEmpleado.EmpID,
                            Grupo = TxtNombre.Text,
                            Descripcion = TxtDescripcion.Text,
                            Activo = true
                        };

                        ObjGrupoLn.Create(ref ObjGrupo);
                        if (ObjGrupo.MsjError == null)
                        {
                            MessageBox.Show("Alta exitosa");
                            CargarListaGrupo();
                            LimpiarDatos();
                        }
                        else
                        {
                            MessageBox.Show(ObjGrupo.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show(ObjEmpleado.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("No se puede generar alta si se selecciono para editar favor de limpiar primero");
            }
        }

        private void BtnActualizar_Click(object sender, System.EventArgs e)
        {
            if (LblGrupoId.Text == string.Empty)
            {
                MessageBox.Show("Selecciona un dato para actualizar");
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Quieres actualizar el registo?", "Mensaje de sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    ObjEmpleado = new ClsEmpleado()
                    {
                        EmpID = Convert.ToByte(LblGrupoId.Text),
                        FirstName = TxtNombre.Text
                    };

                    ObjEmpleadoLn.UpdateGrupo(ref ObjEmpleado);
                    if (ObjEmpleado.MsjError == null)
                    {
                        ObjGrupo = new ClsGrupo()
                        {
                            GrupoDId = Convert.ToByte(LblGrupoId.Text),
                            Grupo = TxtNombre.Text,
                            Descripcion = TxtDescripcion.Text,
                            Activo = ChkActivo.Checked
                        };

                        ObjGrupoLn.Update(ref ObjGrupo);
                        if (ObjGrupo.MsjError == null)
                        {
                            MessageBox.Show("El Grupo fue actualizado correctamente");
                            CargarListaGrupo();
                            LimpiarDatos();
                        }
                        else
                        {
                            MessageBox.Show(ObjGrupo.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show(ObjEmpleado.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    
                }
            }
        }

        private void BtnEliminar_Click(object sender, System.EventArgs e)
        {
            if (LblGrupoId.Text == "")
            {
                MessageBox.Show("Debes seleccionar un registro para eliminar");
            }
            else
            {
                if (ChkActivo.Checked == false)
                {
                    DialogResult result = MessageBox.Show("¿Quieres eliminar el registro?", "Mensaje de sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        ObjEmpleado = new ClsEmpleado()
                        {
                            EmpID = Convert.ToByte(LblGrupoId.Text)
                        };

                        ObjEmpleadoLn.Delete(ref ObjEmpleado);
                        if (ObjEmpleado.MsjError == null)
                        {
                            ObjGrupo = new ClsGrupo()
                            {
                                GrupoDId = Convert.ToByte(LblGrupoId.Text)
                            };

                            ObjGrupoLn.Delete(ref ObjGrupo);
                            if (ObjGrupo.MsjError == null)
                            {
                                MessageBox.Show("Baja exitosa");
                                CargarListaGrupo();
                                LimpiarDatos();
                            }
                            else
                            {
                                MessageBox.Show(ObjGrupo.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show(ObjEmpleado.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("El registro se desactivara primero.\n¿Quieres continuar?", "Mensaje de sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        ObjGrupo = new ClsGrupo()
                        {
                            GrupoDId = Convert.ToByte(LblGrupoId.Text),
                            Activo = false
                        };

                        ObjGrupoLn.UpdateActivo(ref ObjGrupo);
                        if (ObjGrupo.MsjError == null)
                        {
                            MessageBox.Show("El Grupo fue desactivado");
                            CargarListaGrupo();
                            LimpiarDatos();
                        }
                        else
                        {
                            MessageBox.Show(ObjGrupo.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
        #endregion

        #region Accion con DataGredView
        private void DgvGrupo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DgvGrupo.Columns[e.ColumnIndex].Name == "Editar")
                {
                    ObjGrupo = new ClsGrupo()
                    {
                        GrupoDId = Convert.ToByte(DgvGrupo.Rows[e.RowIndex].Cells["GrupoDId"].Value.ToString())
                    };

                    LblGrupoId.Text = ObjGrupo.GrupoDId.ToString();

                    ObjGrupoLn.Read(ref ObjGrupo);
                    TxtNombre.Text = ObjGrupo.Grupo;
                    TxtDescripcion.Text = ObjGrupo.Descripcion;
                    ChkActivo.Checked = ObjGrupo.Activo;

                    BtnActualizar.Enabled = true;
                    BtnLimpiar.Enabled = true;
                    BtnAgregar.Enabled = false;
                    BtnEliminar.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion
    }
}
