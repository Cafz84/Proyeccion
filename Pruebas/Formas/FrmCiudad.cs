using Entidades.Usuario;
using LogicaNegocio.Usuario;
using Proyeccion.Principal;
using Pruebas.Utilidades;
using System;
using System.Windows.Forms;

namespace Pruebas.Formas
{
    public partial class FrmCiudad : Form
    {
        #region Variables Privadas
        //private ClsPais ObjPais = null;
        //private ClsEstado ObjEstado = null;
        private ClsCiudad ObjCiudad = null;
        //private readonly ClsPaisLn ObjPaisLn = new ClsPaisLn();
        //private readonly ClsEstadoLn ObjEstadoLn = new ClsEstadoLn();
        private readonly ClsUtilidades ObjUtilidades = new ClsUtilidades();
        private readonly ClsCiudadLn ObjCiudadLn = new ClsCiudadLn();

        private readonly FrmEmpleados FrmEmpleadosHandler;
        #endregion

        #region Variables Publicas
        public string nomEstado;
        #endregion

        #region Metodos Constructores
        public FrmCiudad()
        {
            InitializeComponent();
        }

        public FrmCiudad(FrmEmpleados frmEmpleados, string NameEstado)
        {
            InitializeComponent();
            nomEstado = NameEstado;
            CargarListaCiudad();
            FrmEmpleadosHandler = frmEmpleados;
        }
        #endregion

        #region Metodos Privados
        private void CargarListaCiudad()
        {
            ObjCiudad = new ClsCiudad()
            {
                Estado = nomEstado
            };
            ObjCiudadLn.Index(ref ObjCiudad);
            if (ObjCiudad.MsjError == null)
            {
                DgvCiudad.DataSource = ObjCiudad.DtResultados;
                ObjUtilidades.FormatoDataGridView(ref DgvCiudad);
            }
            else
            {
                MessageBox.Show(ObjCiudad.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Accion con Botones
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtCode.Text = string.Empty;
            TxtNombre.Text = string.Empty;
            LblCodeEstado.Text = string.Empty;

            BtnLimpiar.Enabled = false;
            BtnAgregar.Enabled = true;
            BtnActualizar.Enabled = false;
            BtnEliminar.Enabled = false;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (TxtCode.Text != string.Empty || TxtNombre.Text != string.Empty)
            {
                DialogResult result = MessageBox.Show("¿Realmente quiere agregar el registro?", "Mensaje de sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    ObjCiudad = new ClsCiudad()
                    {
                        Code = TxtCode.Text,
                        Name = TxtNombre.Text,
                        Estado = nomEstado
                    };

                    ObjCiudadLn.ReadCodeEstado(ref ObjCiudad);

                    ObjCiudadLn.Create(ref ObjCiudad);
                    if (ObjCiudad.MsjError == null)
                    {
                        MessageBox.Show("Alta exitosa");
                        CargarListaCiudad();
                        TxtCode.Text = string.Empty;
                        TxtNombre.Text = string.Empty;

                        BtnLimpiar.Enabled = false;
                        BtnAgregar.Enabled = true;
                        BtnActualizar.Enabled = false;
                        BtnEliminar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show(ObjCiudad.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    ObjCiudad = new ClsCiudad()
                    {
                        Code = TxtCode.Text,
                        Name = TxtNombre.Text,
                    };

                    ObjCiudadLn.Update(ref ObjCiudad);
                    if (ObjCiudad.MsjError == null)
                    {
                        MessageBox.Show("La Ciudad fue actualizada correctamente");
                        CargarListaCiudad();

                        TxtCode.Text = string.Empty;
                        TxtNombre.Text = string.Empty;
                        LblCodeEstado.Text = string.Empty;

                        BtnLimpiar.Enabled = false;
                        BtnAgregar.Enabled = true;
                        BtnActualizar.Enabled = false;
                        BtnEliminar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show(ObjCiudad.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        Code = TxtCode.Text
                    };

                    ObjCiudadLn.Delete(ref ObjCiudad);
                    if (ObjCiudad.MsjError == null)
                    {
                        MessageBox.Show("Baja exitosa");
                        CargarListaCiudad();
                        TxtCode.Text = string.Empty;
                        TxtNombre.Text = string.Empty;
                        LblCodeEstado.Text = string.Empty;

                        BtnLimpiar.Enabled = false;
                        BtnAgregar.Enabled = true;
                        BtnActualizar.Enabled = false;
                        BtnEliminar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show(ObjCiudad.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }   
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmEmpleadosHandler.CargarListaCiudad();
            FrmEmpleadosHandler.CambiarSelectedIndexCiudad();
        }
        #endregion

        #region Acciones con DataGridView
        private void DgvCiudad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvCiudad.Columns[e.ColumnIndex].Name == "Editar")
            {
                ObjCiudad = new ClsCiudad()
                {
                    Code = DgvCiudad.Rows[e.RowIndex].Cells["Codigo"].Value.ToString(),
                    Name = DgvCiudad.Rows[e.RowIndex].Cells["Nombre"].Value.ToString(),
                    Estado = DgvCiudad.Rows[e.RowIndex].Cells["Estado"].Value.ToString()
                };

                TxtCode.Text = ObjCiudad.Code.ToString();

                ObjCiudadLn.Read(ref ObjCiudad);
                TxtNombre.Text = ObjCiudad.Name;
                LblCodeEstado.Text = ObjCiudad.Estado;

                BtnLimpiar.Enabled = true;
                BtnAgregar.Enabled = false;
                BtnActualizar.Enabled = true;
                BtnEliminar.Enabled = true;
            }
        }
        #endregion
    }
}
