using Entidades.Usuario;
using LogicaNegocio.Usuario;
using Proyeccion.Principal;
using Pruebas.Utilidades;
using System;
using System.Windows.Forms;

namespace Pruebas.Formas
{
    public partial class FrmEstado : Form
    {
        #region Variables Privadas
        private ClsPais ObjPais = null;
        private ClsEstado ObjEstado = null;
        private ClsCiudad ObjCiudad = null;
        private readonly ClsPaisLn ObjPaisLn = new ClsPaisLn();
        private readonly ClsEstadoLn ObjEstadoLn = new ClsEstadoLn();
        private readonly ClsUtilidades ObjUtilidades = new ClsUtilidades();
        private readonly ClsCiudadLn ObjCiudadLn = new ClsCiudadLn();

        private FrmEmpleados FrmEmpleadosHandler;
        #endregion

        #region Variables Publicas
        public string nomPais;
        #endregion

        #region Metodos Constructores
        public FrmEstado()
        {
            InitializeComponent();
            CargarListaEstado();
        }

        public FrmEstado(FrmEmpleados frmEmpleados, string namePais)
        {
            InitializeComponent();
            nomPais = namePais;
            CargarListaEstado();
            FrmEmpleadosHandler = frmEmpleados;
        }
        #endregion

        #region Metodos Privados
        private void CargarListaEstado()
        {
            ObjEstado = new ClsEstado()
            {
                NamePais = nomPais
            };
            ObjEstadoLn.Index(ref ObjEstado);
            if (ObjEstado.MsjError == null)
            {
                DgvEstado.DataSource = ObjEstado.DtResultados;
                ObjUtilidades.FormatoDataGridView(ref DgvEstado);
            }
            else
            {
                MessageBox.Show(ObjPais.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Acciones con Botones
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmEmpleadosHandler.CargarListaEstado();
            FrmEmpleadosHandler.CambiarSelectedIndexEstado();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (TxtCode.Text != string.Empty || TxtNombre.Text != string.Empty)
            {
                DialogResult result = MessageBox.Show("¿Realmente quiere agregar el registro?", "Mensaje de sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    ObjEstado = new ClsEstado()
                    {
                        Code = TxtCode.Text,
                        Name = TxtNombre.Text,
                        NamePais = nomPais
                    };

                    ObjEstadoLn.ReadCodePais(ref ObjEstado);

                    ObjEstadoLn.Create(ref ObjEstado);
                    if (ObjEstado.MsjError == null)
                    {
                        MessageBox.Show("Alta exitosa");
                        CargarListaEstado();
                        TxtCode.Text = string.Empty;
                        TxtNombre.Text = string.Empty;

                        BtnLimpiar.Enabled = false;
                        BtnAgregar.Enabled = true;
                        BtnActualizar.Enabled = false;
                        BtnEliminar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show(ObjPais.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("No se puede generar alta si se selecciono para editar favor de limpiar primero");
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (TxtCode.Text == string.Empty || TxtNombre.Text == string.Empty)
            {
                MessageBox.Show("Selecciona un dato para actualizar");
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Realmente quiere actualizar el registro?", "Mensaje de sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    ObjEstado = new ClsEstado()
                    {
                        Code = TxtCode.Text,
                        Name = TxtNombre.Text,
                    };

                    ObjEstadoLn.Update(ref ObjEstado);
                    if (ObjEstado.MsjError == null)
                    {
                        MessageBox.Show("El Pais fue actualizado correctamente");
                        CargarListaEstado();

                        TxtCode.Text = string.Empty;
                        TxtNombre.Text = string.Empty;
                        LblCodePais.Text = string.Empty;

                        BtnLimpiar.Enabled = false;
                        BtnAgregar.Enabled = true;
                        BtnActualizar.Enabled = false;
                        BtnEliminar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show(ObjPais.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (TxtCode.Text == string.Empty || TxtNombre.Text == string.Empty)
            {
                MessageBox.Show("Debes seleccionar un dato para eliminar");
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Realmente quiere eliminar el registro?", "Mensaje de sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    ObjCiudad = new ClsCiudad()
                    {
                        Estado = TxtCode.Text
                    };
                    ObjCiudadLn.ReadEstado(ref ObjCiudad);

                    if (ObjCiudad.DtResultados.Rows.Count < 1)
                    {
                        ObjEstado = new ClsEstado()
                        {
                            Code = TxtCode.Text
                        };

                        ObjEstadoLn.Delete(ref ObjEstado);
                        if (ObjEstado.MsjError == null)
                        {
                            MessageBox.Show("Baja exitosa");
                            CargarListaEstado();
                            TxtCode.Text = string.Empty;
                            TxtNombre.Text = string.Empty;
                            LblCodePais.Text = string.Empty;

                            BtnLimpiar.Enabled = false;
                            BtnAgregar.Enabled = true;
                            BtnActualizar.Enabled = false;
                            BtnEliminar.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show(ObjEstado.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se puede dar de baja ya que el estado esta ligado con alguna ciudad");
                    }
                }
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtCode.Text = string.Empty;
            TxtNombre.Text = string.Empty;
            LblCodePais.Text = string.Empty;

            BtnLimpiar.Enabled = false;
            BtnAgregar.Enabled = true;
            BtnActualizar.Enabled = false;
            BtnEliminar.Enabled = false;
        }
        #endregion

        #region Acciones con DataGridView
        private void DgvEstado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvEstado.Columns[e.ColumnIndex].Name == "Editar")
            {
                ObjEstado = new ClsEstado()
                {
                    Code = DgvEstado.Rows[e.RowIndex].Cells["Codigo"].Value.ToString(),
                    Name = DgvEstado.Rows[e.RowIndex].Cells["Nombre"].Value.ToString(),
                    Country = DgvEstado.Rows[e.RowIndex].Cells["Pais"].Value.ToString()
                };

                TxtCode.Text = ObjEstado.Code.ToString();

                ObjEstadoLn.Read(ref ObjEstado);
                TxtNombre.Text = ObjEstado.Name;
                LblCodePais.Text = ObjEstado.Country;

                BtnLimpiar.Enabled = true;
                BtnAgregar.Enabled = false;
                BtnActualizar.Enabled = true;
                BtnEliminar.Enabled = true;
            }
        }
        #endregion
    }
}
