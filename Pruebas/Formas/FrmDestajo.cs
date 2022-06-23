using Entidades.Usuario;
using LogicaNegocio.Usuario;
using Pruebas.Utilidades;
using System;
using System.Windows.Forms;

namespace Pruebas.Formas
{
    public partial class FrmDestajo : Form
    {
        #region Variables Privadas
        private ClsDestajo ObjDestajo = null;
        private ClsEmpleado ObjEmpleado = null;
        private ClsFraccEstilo ObjFraccEstilo = null;
        private ClsTablasSAP ObjTablasSAP = null;
        private ClsFraccion ObjFraccion = null;
        private ClsGrupo ObjGrupo = null;
        private readonly ClsDestajoLn ObjDestajoLn = new ClsDestajoLn();
        private readonly ClsEmpleadoLn ObjEmpleadoLn = new ClsEmpleadoLn();
        private readonly ClsFraccEstiloLn ObjFraccEstiloLn = new ClsFraccEstiloLn();
        private readonly ClsTablasSAPLn ObjTabasSAPLn = new ClsTablasSAPLn();
        private readonly ClsFraccionLn ObjFraccionLn = new ClsFraccionLn();
        private readonly ClsUtilidades ObjUtilidades = new ClsUtilidades();
        private readonly ClsGrupoLn ObjGrupoLn = new ClsGrupoLn();
        private readonly FrmDestajo intance;

        private float fracCosto;
        private int uEmpId, uFraccId, uSemana;
        private string uEstilo, uPrograma;
        #endregion

        #region Metodo Constructor
        public FrmDestajo()
        {
            InitializeComponent();
            CargarListaDestajo();
            CargarListaEmpleado();
            CargarListaMuestra();
            CargarListaGrupo();
            intance = this;
            fracCosto = 0;
            uEmpId = 0;
            uFraccId = 0;
            uSemana = 0;
            uEstilo = string.Empty;
            uPrograma = string.Empty;
            
            //Se llena Combo con el No. de semanas del año
            for (int i = 0; i < 52; i++)
            {
                CbSemana.Items.Add(i + 1);
            }
        }
        #endregion

        #region Metodos Privados
        private void CargarListaDestajo()
        {
            ObjDestajo = new ClsDestajo();
            ObjDestajoLn.Index(ref ObjDestajo);
            if (ObjDestajo.MsjError == null)
            {
                DgvDestajo.DataSource = ObjDestajo.DtResultados;
                ObjUtilidades.FormatoDgvEmpleado(ref DgvDestajo);
            }
            else
            {
                MessageBox.Show(ObjDestajo.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarListaEmpleado()
        {
            ObjEmpleado = new ClsEmpleado();
            ObjEmpleadoLn.IndexActivoVariable(ref ObjEmpleado);
            if (ObjEmpleado.MsjError == null)
            {
                DgvEmpleado.DataSource = ObjEmpleado.DtResultados;
                ObjUtilidades.FormatoDgvPEC(ref DgvEmpleado);
            }
            else
            {
                MessageBox.Show(ObjEmpleado.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarListaMuestra()
        {
            ObjFraccion = new ClsFraccion();
            ObjFraccionLn.ReadMuestra(ref ObjFraccion);
            if (ObjFraccion.MsjError == null)
            {
                DgvMuestra.DataSource = ObjFraccion.DtResultados;
                ObjUtilidades.FormatoDgvPEC(ref DgvMuestra);
            }
        }

        private void Limpiar()
        {
            CbSemana.SelectedIndex = -1;
            LblEmpId.Text = string.Empty;
            LblFraccId.Text = string.Empty;
            LblTrabajador.Text = string.Empty;
            TxtPrograma.Text = string.Empty;
            LblColor.Text = string.Empty;
            LblEstilo.Text = string.Empty;
            LblPP.Text = string.Empty;
            LblPagado.Text = string.Empty;
            LblRestante.Text = string.Empty;
            LblFraccion.Text = string.Empty;
            TxtCantidad.Text = string.Empty;
            DgvFraccion.DataSource = null;
            DgvFraccion.Rows.Clear();

            fracCosto = 0;
            uEmpId = 0;
            uFraccId = 0;
            uSemana = 0;
            uEstilo = string.Empty;
            uPrograma = string.Empty;

            BtnAgregar.Enabled = true;
            BtnActualizar.Enabled = false;
            BtnEliminar.Enabled = false;
        }
        #endregion

        #region Metodos Publicos
        public void CargarListaGrupo()
        {
            ObjGrupo = new ClsGrupo();
            ObjGrupoLn.CargarIndexGrupo(ref ObjGrupo);
            if (ObjGrupo.MsjError == null)
            {
                DgvGrupo.DataSource = ObjGrupo.DtResultados;
                ObjUtilidades.FormatoDgvPEC(ref DgvGrupo);

                DgvGrupo.Columns["Id"].Visible = false;
            }
            else
            {
                MessageBox.Show(ObjGrupo.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Accion con Botones
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
            if (CbSemana.Text != string.Empty)
            {
                if (LblEmpId.Text != string.Empty)
                {
                    if (TxtPrograma.Text != string.Empty)
                    {
                        if (LblFraccId.Text != string.Empty)
                        {
                            if (TxtCantidad.Text != string.Empty)
                            {
                                DialogResult respuesta = MessageBox.Show("¿Quieres agregar el registro?", "Mensaje de sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                                if (respuesta == DialogResult.OK)
                                {
                                    ObjDestajo = new ClsDestajo()
                                    {
                                        UEmpId = Convert.ToInt16(LblEmpId.Text),
                                        UFraccId = Convert.ToInt16(LblFraccId.Text),
                                        UEstilo = LblEstilo.Text,
                                        Programa = TxtPrograma.Text,
                                        UColor = LblColor.Text,
                                        Cantidad = Convert.ToSingle(TxtCantidad.Text),
                                        FechaCaptura = DateTime.Now,
                                        Semana = Convert.ToInt16(CbSemana.Text),
                                        UFracCosto = fracCosto,
                                        UCantidadFE = Convert.ToInt16(LblCXE.Text),
                                        Pago = Convert.ToSingle(TxtCantidad.Text) * Convert.ToInt16(LblCXE.Text) * fracCosto
                                    };

                                    ObjDestajoLn.Create(ref ObjDestajo);
                                    if (ObjDestajo.MsjError == null)
                                    {
                                        MessageBox.Show("Alta exitosa");
                                        CargarListaDestajo();
                                        Limpiar();
                                    }
                                    else
                                    {
                                        MessageBox.Show(ObjDestajo.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("No se puede generar alta favor de agregar una Cantidad");
                                TxtCantidad.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se puede generar alta favor de seleccionar una Fracción");
                            TcDestajo.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se puede generar alta favor de agregar un Programa");
                        TxtPrograma.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("No se puede generar alta favor de seleccionar un Empleado");
                    TcDestajo.Focus();
                }
            }
            else
            {
                MessageBox.Show("No se puede generar alta favor de seleccionar una semana");
                CbSemana.Focus();
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (CbSemana.Text != string.Empty)
            {
                if (TxtPrograma.Text != string.Empty)
                {
                    if (TxtCantidad.Text != string.Empty)
                    {
                        DialogResult respuesta = MessageBox.Show("¿Quieres editar el registro?", "Mensaje de sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (respuesta == DialogResult.OK)
                        {
                            ObjDestajo = new ClsDestajo()
                            {
                                UEmpId = uEmpId,
                                UFraccId = uFraccId,
                                UEstilo = uEstilo,
                                Programa = uPrograma,
                                UColor = LblColor.Text,
                                Cantidad = Convert.ToSingle(TxtCantidad.Text),
                                FechaCaptura = DateTime.Now,
                                Semana = uSemana,
                                UFracCosto = fracCosto,
                                UCantidadFE = Convert.ToInt16(LblCXE.Text),
                                Pago = Convert.ToSingle(TxtCantidad.Text) * Convert.ToInt16(LblCXE.Text) * fracCosto,
                                CEmpId = Convert.ToInt16(LblEmpId.Text),
                                CFraccId = Convert.ToInt16(LblFraccId.Text),
                                CEstilo = LblEstilo.Text,
                                CPrograma = TxtPrograma.Text,
                                CSemana = Convert.ToInt16(CbSemana.Text)
                            };

                            ObjDestajoLn.Update(ref ObjDestajo);
                            if (ObjDestajo.MsjError == null)
                            {
                                MessageBox.Show("Registro editado");
                                CargarListaDestajo();
                                Limpiar();
                            }
                            else
                            {
                                MessageBox.Show(ObjDestajo.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se puede editar favor de agregar una Cantidad");
                        TxtCantidad.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("No se puede editar favor de agregar un Programa");
                    TxtPrograma.Focus();
                }
            }
            else
            {
                MessageBox.Show("No se puede editar favor de seleccionar una semana");
                CbSemana.Focus();
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (CbSemana.Text == uSemana.ToString())
            {
                if (LblEmpId.Text == uEmpId.ToString())
                {
                    if (TxtPrograma.Text == uPrograma)
                    {
                        if (LblFraccId.Text == uFraccId.ToString())
                        {
                            DialogResult respuesta = MessageBox.Show("¿Quieres eliminar el registro?", "Mensaje de sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                            if (respuesta == DialogResult.OK)
                            {
                                ObjDestajo = new ClsDestajo()
                                {
                                    UEmpId = uEmpId,
                                    UFraccId = uFraccId,
                                    UEstilo = uEstilo,
                                    Programa = uPrograma,
                                    Semana = uSemana,
                                };

                                ObjDestajoLn.Delete(ref ObjDestajo);
                                if (ObjDestajo.MsjError == null)
                                {
                                    MessageBox.Show("Baja exitosa");
                                    CargarListaDestajo();
                                    Limpiar();
                                }
                                else
                                {
                                    MessageBox.Show(ObjDestajo.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se puede eliminar registro ya que se cambio el valor original de la Fracción");
                            TcDestajo.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se puede eliminar registro ya que se cambio el valor original del Programa");
                        TxtPrograma.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("No se puede eliminar registro ya que se cambio el valor original del Empleado");
                    TcDestajo.Focus();
                }
            }
            else
            {
                MessageBox.Show("No se puede eliminar registro ya que se cambio el valor original de la Semana");
                CbSemana.Focus();
            }
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            FrmGrupo frmGrupo = new FrmGrupo(this);
            frmGrupo.ShowDialog();
        }

        private void BtnRelacion_Click(object sender, EventArgs e)
        {
            FrmRGrupoEmp frmRGrupoEmp = new FrmRGrupoEmp(this);
            frmRGrupoEmp.ShowDialog();
        }
        #endregion

        #region Acciones con DataGridView
        private void DgvEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvEmpleado.Columns[e.ColumnIndex].Name == "SelT")
            {
                LblEmpId.Text = DgvEmpleado.Rows[e.RowIndex].Cells["empID"].Value.ToString();
                LblNombre.Text = DgvEmpleado.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
            }
        }

        private void DgvFraccion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvFraccion.Columns[e.ColumnIndex].Name == "SelF")
            {
                LblFraccId.Text = DgvFraccion.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                LblFraccion.Text = DgvFraccion.Rows[e.RowIndex].Cells["Fraccion"].Value.ToString();
                LblCXE.Text = DgvFraccion.Rows[e.RowIndex].Cells["Cantidad"].Value.ToString();

                ObjDestajo = new ClsDestajo()
                {
                    Programa = TxtPrograma.Text,
                    UFraccId = Convert.ToInt16(LblFraccId.Text)
                };

                ObjDestajoLn.ReadPagados(ref ObjDestajo);
                if (ObjDestajo.MsjError == null)
                {
                    LblPagado.Text = ObjDestajo.Pagado.ToString();
                }
                else
                {
                    MessageBox.Show(ObjDestajo.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                LblRestante.Text = (Convert.ToSingle(LblPP.Text) - Convert.ToSingle(LblPagado.Text)).ToString();
            }
        }

        private void DgvMuestra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvMuestra.Columns[e.ColumnIndex].Name == "SelM")
            {
                TxtPrograma.Text = "MUESTRA";
                LblEstilo.Text = DgvMuestra.Rows[e.RowIndex].Cells["Estilo"].Value.ToString();
                LblColor.Text = "N/A";
                LblPP.Text = "N/A";
                LblPagado.Text = "N/A";
                LblRestante.Text = "N/A";

                ObjFraccEstilo = new ClsFraccEstilo()
                {
                    U_ModDesc = LblEstilo.Text
                };

                ObjFraccEstiloLn.ReadMuestra(ref ObjFraccEstilo);
                if (ObjFraccEstilo.MsjError == null)
                {
                    DgvFraccion.DataSource = ObjFraccEstilo.DtResultados;
                    ObjUtilidades.FormatoDgvPEC(ref DgvFraccion);
                }
            }
        }
        #endregion

        #region Acciones con TextBox
        private void TxtPrograma_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ObjTablasSAP = new ClsTablasSAP()
                {
                    Programa = TxtPrograma.Text
                };

                ObjTabasSAPLn.ReadPedidoCantidad(ref ObjTablasSAP);
                if (ObjTablasSAP.MsjError == null)
                {
                    LblEstilo.Text = ObjTablasSAP.Estilo;
                    LblColor.Text = ObjTablasSAP.Color;
                    LblPP.Text = ObjTablasSAP.CantPedido.ToString();
                }
                else
                {
                    MessageBox.Show(ObjTablasSAP.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //Revisar si ya se pago algo de la Fraccion y que no este vacia la captura de la Fracción
                if (LblFraccId.Text != string.Empty)
                {
                    ObjDestajo = new ClsDestajo()
                    {
                        Programa = TxtPrograma.Text,
                        UFraccId = Convert.ToInt16(LblFraccId.Text)
                    };

                    ObjDestajoLn.ReadPagados(ref ObjDestajo);
                    if (ObjDestajo.MsjError == null)
                    {
                        LblPagado.Text = ObjDestajo.Pagado.ToString();
                    }
                    else
                    {
                        MessageBox.Show(ObjDestajo.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                //Se carga la lista de fracciones
                ObjFraccEstilo = new ClsFraccEstilo()
                {
                    U_ModDesc = LblEstilo.Text
                };
                ObjFraccEstiloLn.ReadEstilo(ref ObjFraccEstilo);
                if (ObjFraccEstilo.MsjError == null)
                {
                    DgvFraccion.DataSource = ObjFraccEstilo.DtResultados;
                    ObjUtilidades.FormatoDgvPEC(ref DgvFraccion);
                }
                else
                {
                    MessageBox.Show(ObjFraccEstilo.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion
    }
}
