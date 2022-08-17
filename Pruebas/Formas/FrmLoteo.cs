using Entidades.Usuario;
using LogicaNegocio.Usuario;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;

namespace Pruebas.Formas
{
    public partial class FrmLoteo : Form
    {
        #region Variables Privadas
        private ClsTablasSAP ObjTablasSAP = null;
        private ClsLoteo ObjLoteo = null;
        private readonly ClsTablasSAPLn ObjTablasSAPLn = new ClsTablasSAPLn();
        private readonly ClsLoteoLn ObjLoteoLn = new ClsLoteoLn();

        private DateTime fInicial, fEmbarque;
        #endregion

        #region Metodo Constructor
        public FrmLoteo()
        {
            InitializeComponent();
            CargarIndex();
            Limpiar();
        }
        #endregion

        #region Metodos Privados
        private void Limpiar()
        {
            TxtPrograma.Clear();
            TxtCtdLote.Clear();
            LblEstilo.Text = string.Empty;
            LblColor.Text = string.Empty;
            LblHorma.Text = string.Empty;
            LblCtdPrograma.Text = string.Empty;
            LblTLotes.Text = string.Empty;
            RbDistribuido.Checked = true;
            TxtObs.Clear();
            DgvCorridaCalzado.DataSource = null;
            DgvCorridaMarroquineria.DataSource = null;
            DgvLotes.DataSource = null;
            DgvLotes.Rows.Clear();
            DgvLotes.Columns.Clear();
            
            DtpFechaEmbarque.Format = DateTimePickerFormat.Custom;
            DtpFechaEmbarque.CustomFormat = " ";

            BtnGuardar.Enabled = false;
        }

        private void Limpiar2()
        {
            TxtCtdLote.Clear();
            LblEstilo.Text = string.Empty;
            LblColor.Text = string.Empty;
            LblHorma.Text = string.Empty;
            LblCtdPrograma.Text = string.Empty;
            LblTLotes.Text = string.Empty;
            RbDistribuido.Checked = true;
            TxtObs.Clear();
            DgvCorridaCalzado.DataSource = null;
            DgvLotes.DataSource = null;
            DgvLotes.Rows.Clear();
            DgvLotes.Columns.Clear();

            DtpFechaEmbarque.Format = DateTimePickerFormat.Custom;
            DtpFechaEmbarque.CustomFormat = " ";
        }

        private void CargarDatos()
        {
            ObjTablasSAP = new ClsTablasSAP()
            {
                Programa = TxtPrograma.Text
            };

            ObjTablasSAPLn.ReadInfoPrograma(ref ObjTablasSAP);
            if (ObjTablasSAP.MsjError == null)
            {
                if (ObjTablasSAP.DtResultados.Rows.Count == 0)
                {
                    MessageBox.Show("Favor de colocar un programa existente", "Mensaje de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtPrograma.Focus();
                }
                else
                {
                    DgvCorridaCalzado.DataSource = null;
                    DgvCorridaMarroquineria.DataSource = null;
                    LblEstilo.Text = ObjTablasSAP.Estilo;
                    LblColor.Text = ObjTablasSAP.Color;
                    LblHorma.Text = ObjTablasSAP.Horma;
                    LblCtdPrograma.Text = ObjTablasSAP.Cantidad.ToString();
                    if (ObjTablasSAP.Genero == "Unisex")
                    {
                        DgvCorridaMarroquineria.DataSource = ObjTablasSAP.DtTallaCtd;
                    }
                    else
                    {
                        DgvCorridaCalzado.DataSource = ObjTablasSAP.DtTallaCtd;
                    }
                }
            }
        }

        private void CargarIndex()
        {
            ObjLoteo = new ClsLoteo()
            {
                Estilo = TxtBEstilo.Text,
                Color = TxtBColor.Text
            };
            if (TxtBPrograma.Text == string.Empty)
            {
                ObjLoteo.Programa = 0;
            }
            else
            {
                ObjLoteo.Programa = Convert.ToByte(TxtBPrograma.Text);
            }

            ObjLoteoLn.Index(ref ObjLoteo);
            if (ObjLoteo.MsjError == null)
            {
                DgvIndex.DataSource = ObjLoteo.DtResultados;
                DgvIndex.Columns["Sel"].Width = 30;
                DgvIndex.Columns["TipoLote"].Visible = false;
            }
            else
            {
                MessageBox.Show(ObjLoteo.MsjError, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LotearDistribuido(DataGridView data)
        {
            int Nlotes, suma;
            float[] div;
            int[] resta, cont;
            int[,] lote;
            object[] rows;
            string[] linea;
            resta = new int[data.ColumnCount];
            cont = new int[data.ColumnCount];
            div = new float[data.ColumnCount];

            Nlotes = (int)Math.Ceiling(Convert.ToDouble(LblCtdPrograma.Text) / Convert.ToDouble(TxtCtdLote.Text));
            LblTLotes.Text = Nlotes.ToString();
            lote = new int[Nlotes,data.ColumnCount + 1];

            //Se hace el barrido de información para crear el loteo
            for (int a = 0; a < Nlotes; a++)
            {
                suma = 0;
                lote[a, 0] = a + 1;
                if (a == 0)
                {
                    for (int i = 0; i < data.ColumnCount; i++)
                    {
                        div[i] = Convert.ToSingle(data.Rows[0].Cells[i].Value.ToString()) / Nlotes;
                        lote[a, i + 1] = (int)Math.Floor(div[i]);
                        resta[i] = Convert.ToInt32(data.Rows[0].Cells[i].Value.ToString()) - (int)Math.Floor(div[i]);
                        suma = (int)Math.Floor(div[i]) + suma;
                        cont[i] = Convert.ToInt32(data.Rows[0].Cells[i].Value.ToString()) - (int)Math.Floor(div[i]) * Nlotes;
                    }
                }
                else
                {
                    for (int i = 0; i < data.ColumnCount; i++)
                    {
                        lote[a, i + 1] = (int)Math.Floor(div[i]);
                        resta[i] = resta[i] - (int)Math.Floor(div[i]);
                        suma = (int)Math.Floor(div[i]) + suma;
                    }
                }

                if (suma < Convert.ToInt32(TxtCtdLote.Text))
                {
                    for (int i = 0; i < data.ColumnCount; i++)
                    {
                        if (resta[i] > 0)
                        {
                            if (div[i] > (int)Math.Floor(div[i]) && cont[i] > 0)
                            {
                                lote[a, i + 1] = lote[a, i + 1] + 1;
                                suma = suma + 1;
                                resta[i] = resta[i] - 1;
                                cont[i] = cont[i] - 1;
                            }
                        }

                        if ((a + 1) == Nlotes && cont[i] > 0)
                        {
                            i -= 1;
                        }

                        if (suma == Convert.ToInt32(TxtCtdLote.Text))
                            break;
                    }
                }
            }

            //Agregar información de loteo en un DataGridView
            DgvLotes.ColumnCount = data.ColumnCount + 1;
            DgvLotes.Columns[0].Name = "Lotes";
            for(int i = 0; i < data.ColumnCount; i++)
            {
                DgvLotes.Columns[i + 1].Name = data.Columns[i].Name;
            }

            rows = new object[Nlotes];
            for (int i = 0; i < Nlotes; i++)
            {
                linea = new string[data.ColumnCount + 1];
                for (int j = 0; j < data.ColumnCount + 1; j++)
                {
                    linea[j] = lote[i, j].ToString();
                }
                rows[i] = linea;
            }

            foreach (string[] rowArray in rows)
            {
                DgvLotes.Rows.Add(rowArray);
            }
        }

        private void LotearXTalla(DataGridView data)
        {
            int Nlotes, validar, lot, resta = 0, acum = 0;
            int[,] lote;
            object[] rows;
            string[] linea;

            Nlotes = (int)Math.Ceiling(Convert.ToDouble(LblCtdPrograma.Text) / Convert.ToDouble(TxtCtdLote.Text));
            LblTLotes.Text = Nlotes.ToString();
            lote = new int[Nlotes, data.ColumnCount + 1];
            lot = Convert.ToInt32(TxtCtdLote.Text);

            for (int f = 0; f < Nlotes; f++)
            {
                lote[f, 0] = f + 1;
            }
            
            int i = 0;
            for (int j = 0; j < data.ColumnCount; j++)
            {
                if (Convert.ToInt32(data.Rows[0].Cells[j].Value.ToString()) <= lot)
                {
                    if (resta == 0 && acum == 0)
                    {
                        lote[i, j + 1] = Convert.ToInt32(data.Rows[0].Cells[j].Value.ToString());
                        resta = lot - Convert.ToByte(data.Rows[0].Cells[j].Value.ToString());
                    }
                    else if (resta != 0 && acum == 0)
                    {
                        validar = Convert.ToInt32(data.Rows[0].Cells[j].Value.ToString()) - resta;
                        if (validar < 0)
                        {
                            lote[i, j + 1] = Convert.ToInt32(data.Rows[0].Cells[j].Value.ToString());
                            resta -= Convert.ToInt32(data.Rows[0].Cells[j].Value.ToString());
                        }
                        else if (validar == 0)
                        {
                            lote[i, j + 1] = Convert.ToInt32(data.Rows[0].Cells[j].Value.ToString());
                            resta -= Convert.ToInt32(data.Rows[0].Cells[j].Value.ToString());
                            i++;
                        }
                        else
                        {
                            lote[i, j + 1] = resta;
                            resta = 0;
                            acum = validar;
                            i++;
                            j--;
                        }
                    }else if (resta == 0 && acum != 0)
                    {
                        lote[i, j + 1] = acum;
                        resta = lot - acum;
                        acum = 0;
                    }
                    else
                    {
                        validar = acum - resta;
                        if (validar < 0)
                        {
                            lote[i, j + 1] = resta - acum;
                            resta -= acum;
                            acum = 0;
                        }
                        else if (validar == 0)
                        {
                            lote[i, j + 1] = resta - acum;
                            resta -= acum;
                            acum = 0;
                            i++;
                        }
                        else
                        {
                            lote[i, j + 1] = validar;
                            resta = 0;
                            acum -= resta;
                            i++;
                        }
                    }
                }
                else
                {
                    if (resta == 0 && acum == 0)
                    {
                        lote[i, j + 1] = lot;
                        acum = Convert.ToInt32(data.Rows[0].Cells[j].Value.ToString()) - lot;
                        i++;
                        j--;
                    }
                    else if (resta != 0 && acum == 0)
                    {
                        validar = Convert.ToInt32(data.Rows[0].Cells[j].Value.ToString()) - resta;
                        if (validar < 0)
                        {
                            lote[i, j + 1] = Convert.ToInt32(data.Rows[0].Cells[j].Value.ToString());
                            resta -= Convert.ToInt32(data.Rows[0].Cells[j].Value.ToString());
                        }
                        else if (validar == 0)
                        {
                            lote[i, j + 1] = Convert.ToInt32(data.Rows[0].Cells[j].Value.ToString());
                            resta -= Convert.ToInt32(data.Rows[0].Cells[j].Value.ToString());
                            i++;
                        }
                        else
                        {
                            lote[i, j + 1] = resta;
                            resta = 0;
                            acum = validar;
                            i++;
                            j--;
                        }
                    }
                    else if (resta == 0 && acum != 0)
                    {
                        validar = acum - lot;
                        if (validar < 0)
                        {
                            lote[i, j + 1] = acum;
                            resta = lot - acum;
                            acum = 0;
                        }
                        else if (validar == 0)
                        {
                            lote[i, j + 1] = acum;
                            resta = lot - acum;
                            acum = 0;
                            i++;
                        }
                        else
                        {
                            lote[i, j + 1] = lot;
                            acum -= lot;
                            i++;
                            j--;
                        }
                    }
                    else
                    {
                        validar = acum - resta;
                        if (validar < 0)
                        {
                            lote[i, j + 1] = resta - acum;
                            resta -= acum;
                            acum = 0;
                        }
                        else if (validar == 0)
                        {
                            lote[i, j + 1] = resta - acum;
                            resta -= acum;
                            acum = 0;
                            i++;
                        }
                        else
                        {
                            lote[i, j + 1] = validar;
                            resta = 0;
                            acum -= resta;
                            i++;
                        }
                    }
                }

                    
                if (i == Nlotes)
                {
                    break;
                }
                    
            }
            

            //Agregar información de loteo en un DataGridView
            DgvLotes.ColumnCount = data.ColumnCount + 1;
            DgvLotes.Columns[0].Name = "Lotes";
            for (int a = 0; a < data.ColumnCount; a++)
            {
                DgvLotes.Columns[a + 1].Name = data.Columns[a].Name;
            }

            rows = new object[Nlotes];
            for (int a = 0; a < Nlotes; a++)
            {
                linea = new string[data.ColumnCount + 1];
                for (int j = 0; j <= data.ColumnCount; j++)
                {
                    linea[j] = lote[a, j].ToString();
                }
                rows[a] = linea;
            }

            foreach (string[] rowArray in rows)
            {
                DgvLotes.Rows.Add(rowArray);
            }
        }
        #endregion

        #region Acción con TextBox
        private void TxtPrograma_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para que solo acepte numeros y no texto
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void TxtCtdLote_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para que solo acepte números y no texto
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void TxtPrograma_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (TxtPrograma.Text == string.Empty || TxtPrograma.Text == "0")
                {
                    MessageBox.Show("Favor de colocar un programa existente", "Mensaje de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtPrograma.SelectAll();
                    TxtPrograma.Focus();
                    Limpiar2();
                    BtnVistaPrevia.Enabled = false;
                    BtnCrearLoteo.Enabled = false;
                }
                else
                {
                    Limpiar2();
                    CargarDatos();
                    BtnVistaPrevia.Enabled = true;
                    BtnCrearLoteo.Enabled = false;
                }
            }
        }

        private void TxtBPrograma_TextChanged(object sender, EventArgs e)
        {
            CargarIndex();
        }

        private void TxtBEstilo_TextChanged(object sender, EventArgs e)
        {
            CargarIndex();
        }

        private void TxtBColor_TextChanged(object sender, EventArgs e)
        {
            CargarIndex();
        }
        #endregion

        #region Acción con DataTimePicker
        private void DtpFechaEmbarque_ValueChanged(object sender, System.EventArgs e)
        {
            DtpFechaEmbarque.Format = DateTimePickerFormat.Custom;
            DtpFechaEmbarque.CustomFormat = "dd/MM/yyyy";
        }
        #endregion

        #region Acción con Botones
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void BtnCerrar_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void BtnVistaPrevia_Click(object sender, EventArgs e)
        {
            if (TxtCtdLote.Text == string.Empty || Convert.ToInt16(TxtCtdLote.Text) < 6)
            {
                MessageBox.Show("Colocar una cantidad de loteo valida", "Mensaje de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtCtdLote.SelectAll();
                TxtCtdLote.Focus();
            }
            else
            {
                DgvLotes.DataSource = null;
                DgvLotes.Rows.Clear();
                DgvLotes.Columns.Clear();
                if (RbDistribuido.Checked)
                {
                    if (DgvCorridaCalzado.DataSource != null)
                    {
                        LotearDistribuido(DgvCorridaCalzado);
                    }
                    else
                    {
                        LotearDistribuido(DgvCorridaMarroquineria);
                    }

                    if (DgvLotes.DataSource != null)
                    {
                        BtnCrearLoteo.Enabled = true;
                    }
                    else
                    {
                        BtnCrearLoteo.Enabled = false;
                    }
                }
                else
                {
                    if (DgvCorridaCalzado.DataSource != null)
                    {
                        LotearXTalla(DgvCorridaCalzado);
                    }
                    else
                    {
                        LotearXTalla(DgvCorridaMarroquineria);
                    }
                }

                if (DgvLotes != null)
                {
                    BtnCrearLoteo.Enabled = true;
                }
                else
                {
                    BtnCrearLoteo.Enabled = false;
                }
            }
        }

        private void BtnCrearLoteo_Click(object sender, EventArgs e)
        {
            ObjLoteo = new ClsLoteo()
            {
                Programa = Convert.ToInt16(TxtPrograma.Text)
            };
            ObjLoteoLn.ProgramaRead(ref ObjLoteo);

            if (ObjLoteo.DtResultados.Rows.Count != 0)
            {
                MessageBox.Show("El programa ya fue loteado", "Mensaje de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtPrograma.SelectAll();
                TxtPrograma.Focus();
            }
            else if (Regex.Replace(DtpFechaEmbarque.Text, @"\s", "") == "")
            {
                MessageBox.Show("Favor de colocar una fecha de Embarque", "Mensaje de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DtpFechaEmbarque.Focus();
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Quieres crear el Loteo?", "Mensaje de Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    int cont = 0;
                    for (int i = 0; i < DgvLotes.Rows.Count; i++)
                    {
                        ObjLoteo = new ClsLoteo()
                        {
                            CodLote = TxtPrograma.Text + "L" + (i + 1),
                            ImpLote = "*" + TxtPrograma.Text + "L" + (i + 1) + "*",
                            Programa = Convert.ToInt16(TxtPrograma.Text),
                            CantPrograma = Convert.ToInt16(LblCtdPrograma.Text),
                            CantLote = Convert.ToInt16(TxtCtdLote.Text),
                            TLotes = DgvLotes.Rows.Count,
                            NLote = i + 1,
                            Estilo = LblEstilo.Text,
                            Color = LblColor.Text,
                            Horma = LblHorma.Text,
                            FLote = DateTime.Now,
                            FEmbarque = DtpFechaEmbarque.Value,
                            Info = TxtObs.Text
                        };
                        if (DgvCorridaCalzado != null)
                        {
                            ObjLoteo.Area = "Calzado";
                        }
                        else
                        {
                            ObjLoteo.Area = "Marroquineria";
                        }

                        if (RbDistribuido.Checked)
                        {
                            ObjLoteo.TipoLote = 'D';
                        }
                        else
                        {
                            ObjLoteo.TipoLote = 'T';
                        }

                        for (int j = 1; j < DgvLotes.Columns.Count; j++)
                        {
                            ObjLoteo.CantxLote += Convert.ToInt16(DgvLotes.Rows[i].Cells[j].Value.ToString());

                            switch (DgvLotes.Columns[j].Name)
                            {
                                case "5":
                                    ObjLoteo.T5 = Convert.ToInt16(DgvLotes.Rows[i].Cells[j].Value.ToString());
                                    break;
                                case "5.5":
                                    ObjLoteo.T55 = Convert.ToInt16(DgvLotes.Rows[i].Cells[j].Value.ToString());
                                    break;
                                case "6":
                                    ObjLoteo.T6 = Convert.ToInt16(DgvLotes.Rows[i].Cells[j].Value.ToString());
                                    break;
                                case "6.5":
                                    ObjLoteo.T65 = Convert.ToInt16(DgvLotes.Rows[i].Cells[j].Value.ToString());
                                    break;
                                case "7":
                                    ObjLoteo.T7 = Convert.ToInt16(DgvLotes.Rows[i].Cells[j].Value.ToString());
                                    break;
                                case "7.5":
                                    ObjLoteo.T75 = Convert.ToInt16(DgvLotes.Rows[i].Cells[j].Value.ToString());
                                    break;
                                case "8":
                                    ObjLoteo.T8 = Convert.ToInt16(DgvLotes.Rows[i].Cells[j].Value.ToString());
                                    break;
                                case "8.5":
                                    ObjLoteo.T85 = Convert.ToInt16(DgvLotes.Rows[i].Cells[j].Value.ToString());
                                    break;
                                case "9":
                                    ObjLoteo.T9 = Convert.ToInt16(DgvLotes.Rows[i].Cells[j].Value.ToString());
                                    break;
                                case "9.5":
                                    ObjLoteo.T95 = Convert.ToInt16(DgvLotes.Rows[i].Cells[j].Value.ToString());
                                    break;
                                case "10":
                                    ObjLoteo.T10 = Convert.ToInt16(DgvLotes.Rows[i].Cells[j].Value.ToString());
                                    break;
                                case "10.5":
                                    ObjLoteo.T105 = Convert.ToInt16(DgvLotes.Rows[i].Cells[j].Value.ToString());
                                    break;
                                case "11":
                                    ObjLoteo.T11 = Convert.ToInt16(DgvLotes.Rows[i].Cells[j].Value.ToString());
                                    break;
                                case "11.5":
                                    ObjLoteo.T115 = Convert.ToInt16(DgvLotes.Rows[i].Cells[j].Value.ToString());
                                    break;
                                case "12":
                                    ObjLoteo.T12 = Convert.ToInt16(DgvLotes.Rows[i].Cells[j].Value.ToString());
                                    break;
                                case "13":
                                    ObjLoteo.T13 = Convert.ToInt16(DgvLotes.Rows[i].Cells[j].Value.ToString());
                                    break;
                                case "14":
                                    ObjLoteo.T14 = Convert.ToInt16(DgvLotes.Rows[i].Cells[j].Value.ToString());
                                    break;
                                case "15":
                                    ObjLoteo.T15 = Convert.ToInt16(DgvLotes.Rows[i].Cells[j].Value.ToString());
                                    break;
                                case "16":
                                    ObjLoteo.T16 = Convert.ToInt16(DgvLotes.Rows[i].Cells[j].Value.ToString());
                                    break;
                                case "17":
                                    ObjLoteo.T17 = Convert.ToInt16(DgvLotes.Rows[i].Cells[j].Value.ToString());
                                    break;
                                case "28":
                                    ObjLoteo.T28 = Convert.ToInt16(DgvLotes.Rows[i].Cells[j].Value.ToString());
                                    break;
                                case "30":
                                    ObjLoteo.T30 = Convert.ToInt16(DgvLotes.Rows[i].Cells[j].Value.ToString());
                                    break;
                                case "32":
                                    ObjLoteo.T32 = Convert.ToInt16(DgvLotes.Rows[i].Cells[j].Value.ToString());
                                    break;
                                case "34":
                                    ObjLoteo.T34 = Convert.ToInt16(DgvLotes.Rows[i].Cells[j].Value.ToString());
                                    break;
                                case "36":
                                    ObjLoteo.T36 = Convert.ToInt16(DgvLotes.Rows[i].Cells[j].Value.ToString());
                                    break;
                                case "38":
                                    ObjLoteo.T38 = Convert.ToInt16(DgvLotes.Rows[i].Cells[j].Value.ToString());
                                    break;
                                case "40":
                                    ObjLoteo.T40 = Convert.ToInt16(DgvLotes.Rows[i].Cells[j].Value.ToString());
                                    break;
                                case "42":
                                    ObjLoteo.T42 = Convert.ToInt16(DgvLotes.Rows[i].Cells[j].Value.ToString());
                                    break;
                                case "44":
                                    ObjLoteo.T5 = Convert.ToInt16(DgvLotes.Rows[i].Cells[j].Value.ToString());
                                    break;
                                case "46":
                                    ObjLoteo.T46 = Convert.ToInt16(DgvLotes.Rows[i].Cells[j].Value.ToString());
                                    break;
                                case "L":
                                    ObjLoteo.TL = Convert.ToInt16(DgvLotes.Rows[i].Cells[j].Value.ToString());
                                    break;
                                case "M":
                                    ObjLoteo.TM = Convert.ToInt16(DgvLotes.Rows[i].Cells[j].Value.ToString());
                                    break;
                                case "S":
                                    ObjLoteo.TS = Convert.ToInt16(DgvLotes.Rows[i].Cells[j].Value.ToString());
                                    break;
                                case "X":
                                    ObjLoteo.TX = Convert.ToInt16(DgvLotes.Rows[i].Cells[j].Value.ToString());
                                    break;
                                case "XL":
                                    ObjLoteo.TXL = Convert.ToInt16(DgvLotes.Rows[i].Cells[j].Value.ToString());
                                    break;
                                case "XS":
                                    ObjLoteo.TXS = Convert.ToInt16(DgvLotes.Rows[i].Cells[j].Value.ToString());
                                    break;
                            }
                        }

                        ObjLoteoLn.Create(ref ObjLoteo);
                        if (ObjLoteo.MsjError != null)
                        {
                            MessageBox.Show(ObjLoteo.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            cont++;
                        }
                    }

                    if (cont == 0)
                    {
                        BtnCrearLoteo.Enabled = false;
                        BtnVistaPrevia.Enabled = false;
                        Limpiar();
                        CargarIndex();
                        MessageBox.Show("Loteo exitoso", "Mensaje de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TxtPrograma.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Problemas para crear Loteo", "Mensaje de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ObjLoteo = new ClsLoteo()
                        {
                            Programa = Convert.ToInt16(TxtPrograma.Text)
                        };

                        ObjLoteoLn.Delete(ref ObjLoteo);
                        if (ObjLoteo.MsjError != null)
                        {
                            MessageBox.Show(ObjLoteo.MsjError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.FileName = "L" + TxtPrograma.Text + "_" + LblEstilo.Text + "_" + LblColor.Text + "_" + DateTime.Now.ToString("ddMMyyyy") + ".pdf";
            //guardar.ShowDialog();

            //string paginahtml = "<table><tr><td>HOLA MUNDO</td></tr></table>";
            try
            {
                if (guardar.ShowDialog() == DialogResult.OK)
                {
                    //Se crea un espacio en memoria del sistema para almacenar la información de manera virtual
                    using (FileStream stream = new FileStream(guardar.FileName, FileMode.Create))
                    {
                        Document pdfDoc = new Document(PageSize.A4, 15, 15, 15, 15);
                        pdfDoc.AddAuthor("Cristian Frausto");
                        pdfDoc.AddTitle("Plantilla Lotes");

                        //Cada ves que se modifique el archivo se estara creando el cambio en el archivo de memoria
                        PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();

                        /*using (StringReader sr = new StringReader(CrearHtml()))
                        {
                            XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                        }*/

                        #region Fuentes para el formato
                        string fubicacion = "C:/Archon Code 39 Barcode.ttf";
                        BaseFont _fcodigo = BaseFont.CreateFont(fubicacion, BaseFont.CP1250, true);
                        iTextSharp.text.Font fcodigo = new iTextSharp.text.Font(_fcodigo, 70f, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

                        BaseFont _ftitulo = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1250, true);
                        iTextSharp.text.Font ftitulo = new iTextSharp.text.Font(_ftitulo, 16f, iTextSharp.text.Font.BOLD, BaseColor.WHITE);

                        BaseFont _fsubtitulo = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1250, true);
                        iTextSharp.text.Font fsubtitulo = new iTextSharp.text.Font(_fsubtitulo, 12f, iTextSharp.text.Font.BOLD, BaseColor.WHITE);

                        BaseFont _ftexto1 = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1250, true);
                        iTextSharp.text.Font ftexto1 = new iTextSharp.text.Font(_ftexto1, 12f, iTextSharp.text.Font.BOLD, BaseColor.BLACK);

                        BaseFont _ftexto2 = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1250, true);
                        iTextSharp.text.Font ftexto2 = new iTextSharp.text.Font(_ftexto2, 12f, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                        #endregion

                        for (int i = 0; i < DgvLotes.Rows.Count; i++)
                        {
                            var tbl = new PdfPTable(new float[] { 15f, 55f, 15f, 15f }) { WidthPercentage = 100f };
                            tbl.AddCell(new PdfPCell(new Phrase("AVANCE DE PRODUCCION", ftitulo)) { Rowspan = 2, Colspan = 2, HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_MIDDLE, BackgroundColor = new BaseColor(0, 0, 0) });
                            tbl.AddCell(new PdfPCell(new Phrase("No. Prog.:", ftexto1)) { HorizontalAlignment = Element.ALIGN_RIGHT, BackgroundColor = new BaseColor(230, 230, 230) });
                            tbl.AddCell(new PdfPCell(new Phrase(TxtPrograma.Text, ftexto2)) { HorizontalAlignment = Element.ALIGN_LEFT });
                            tbl.AddCell(new PdfPCell(new Phrase("Cant. Prog.:", ftexto1)) { HorizontalAlignment = Element.ALIGN_RIGHT, BackgroundColor = new BaseColor(230, 230, 230) });
                            tbl.AddCell(new PdfPCell(new Phrase(LblCtdPrograma.Text, ftexto2)) { HorizontalAlignment = Element.ALIGN_LEFT });
                            tbl.AddCell(new PdfPCell(new Phrase("Area:", ftexto1)) { HorizontalAlignment = Element.ALIGN_RIGHT, BackgroundColor = new BaseColor(230, 230, 230) });
                            if (DgvCorridaCalzado.DataSource == null)
                                tbl.AddCell(new PdfPCell(new Phrase("Marroquineria", ftexto2)) { HorizontalAlignment = Element.ALIGN_LEFT });
                            else
                                tbl.AddCell(new PdfPCell(new Phrase("Calzado", ftexto2)) { HorizontalAlignment = Element.ALIGN_LEFT });
                            tbl.AddCell(new PdfPCell(new Phrase("F. Inicio:", ftexto1)) { HorizontalAlignment = Element.ALIGN_RIGHT, BackgroundColor = new BaseColor(230, 230, 230) });
                            tbl.AddCell(new PdfPCell(new Phrase(fInicial.ToString("d"), ftexto2)) { HorizontalAlignment = Element.ALIGN_LEFT });
                            tbl.AddCell(new PdfPCell(new Phrase("Linea:", ftexto1)) { HorizontalAlignment = Element.ALIGN_RIGHT, BackgroundColor = new BaseColor(230, 230, 230) });
                            tbl.AddCell(new PdfPCell(new Phrase(LblHorma.Text, ftexto2)) { HorizontalAlignment = Element.ALIGN_LEFT });
                            tbl.AddCell(new PdfPCell(new Phrase("F. Embarque:", ftexto1)) { HorizontalAlignment = Element.ALIGN_RIGHT, BackgroundColor = new BaseColor(230, 230, 230) });
                            tbl.AddCell(new PdfPCell(new Phrase(fEmbarque.ToString("d"), ftexto2)) { HorizontalAlignment = Element.ALIGN_LEFT });
                            tbl.AddCell(new PdfPCell(new Phrase("Estilo Color:", ftexto1)) { HorizontalAlignment = Element.ALIGN_RIGHT, BackgroundColor = new BaseColor(230, 230, 230) });
                            tbl.AddCell(new PdfPCell(new Phrase(LblEstilo.Text + " " + LblColor.Text, ftexto2)) { Colspan = 3, HorizontalAlignment = Element.ALIGN_LEFT });

                            pdfDoc.Add(tbl);
                            switch (DgvLotes.Columns.Count)
                            {
                                case 2:
                                    tbl = new PdfPTable(new float[] { 15f, 85f }) { WidthPercentage = 100f };
                                    break;
                                case 3:
                                    tbl = new PdfPTable(new float[] { 15f, 42.5f, 42.5f }) { WidthPercentage = 100f };
                                    break;
                                case 4:
                                    tbl = new PdfPTable(new float[] { 15f, 28.3f, 28.3f, 28.4f }) { WidthPercentage = 100f };
                                    break;
                                case 5:
                                    tbl = new PdfPTable(new float[] { 15f, 21.25f, 21.25f, 21.25f, 21.25f }) { WidthPercentage = 100f };
                                    break;
                                case 6:
                                    tbl = new PdfPTable(new float[] { 15f, 17f, 17f, 17f, 17f, 17f }) { WidthPercentage = 100f };
                                    break;
                                case 7:
                                    tbl = new PdfPTable(new float[] { 15f, 14.16f, 14.16f, 14.17f, 14.17f, 14.7f, 14.17f }) { WidthPercentage = 100f };
                                    break;
                                case 8:
                                    tbl = new PdfPTable(new float[] { 15f, 12.14f, 12.14f, 12.14f, 12.14f, 12.14f, 12.15f, 12.15f }) { WidthPercentage = 100f };
                                    break;
                                case 9:
                                    tbl = new PdfPTable(new float[] { 15f, 10.625f, 10.625f, 10.625f, 10.625f, 10.625f, 10.625f, 10.625f, 10.625f }) { WidthPercentage = 100f };
                                    break;
                                case 10:
                                    tbl = new PdfPTable(new float[] { 15f, 9.44f, 9.44f, 9.44f, 9.44f, 9.44f, 9.45f, 9.45f, 9.45f, 9.45f }) { WidthPercentage = 100f };
                                    break;
                                case 11:
                                    tbl = new PdfPTable(new float[] { 15f, 8.5f, 8.5f, 8.5f, 8.5f, 8.5f, 8.5f, 8.5f, 8.5f, 8.5f, 8.5f }) { WidthPercentage = 100f };
                                    break;
                                case 12:
                                    tbl = new PdfPTable(new float[] { 15f, 7.72f, 7.72f, 7.72f, 7.73f, 7.73f, 7.73f, 7.73f, 7.73f, 7.73f, 7.73f, 7.73f }) { WidthPercentage = 100f };
                                    break;
                                case 13:
                                    tbl = new PdfPTable(new float[] { 15f, 7.08f, 7.08f, 7.08f, 7.08f, 7.08f, 7.08f, 7.08f, 7.08f, 7.09f, 7.09f, 7.09f, 7.09f }) { WidthPercentage = 100f };
                                    break;
                                case 14:
                                    tbl = new PdfPTable(new float[] { 15f, 6.53f, 6.53f, 6.53f, 6.53f, 6.53f, 6.53f, 6.53f, 6.53f, 6.53f, 6.54f, 6.54f, 6.54f, 6.54f }) { WidthPercentage = 100f };
                                    break;
                                case 15:
                                    tbl = new PdfPTable(new float[] { 15f, 6.07f, 6.07f, 6.07f, 6.07f, 6.07f, 6.07f, 6.07f, 6.07f, 6.07f, 6.07f, 6.07f, 6.07f, 6.08f, 6.08f }) { WidthPercentage = 100f };
                                    break;
                                case 16:
                                    tbl = new PdfPTable(new float[] { 15f, 5.66f, 5.66f, 5.66f, 5.66f, 5.66f, 5.67f, 5.67f, 5.67f, 5.67f, 5.67f, 5.67f, 5.67f, 5.67f, 5.67f, 5.67f }) { WidthPercentage = 100f };
                                    break;
                            }
                            tbl.AddCell(new PdfPCell(new Phrase("Talla:", ftexto1)) { HorizontalAlignment = Element.ALIGN_RIGHT, BackgroundColor = new BaseColor(230, 230, 230) });
                            for (int j = 1; j < DgvLotes.Columns.Count; j++)
                                tbl.AddCell(new PdfPCell(new Phrase(DgvLotes.Columns[j].Name, ftexto1)) { HorizontalAlignment = Element.ALIGN_CENTER, BackgroundColor = new BaseColor(230, 230, 230) });
                            tbl.AddCell(new PdfPCell(new Phrase("Cantidad:", ftexto1)) { HorizontalAlignment = Element.ALIGN_RIGHT, BackgroundColor = new BaseColor(230, 230, 230) });

                            int clote = 0;
                            for (int j = 1; j < DgvLotes.Columns.Count; j++)
                            {
                                tbl.AddCell(new PdfPCell(new Phrase(DgvLotes.Rows[i].Cells[j].Value.ToString(), ftexto2)) { HorizontalAlignment = Element.ALIGN_CENTER });
                                clote += Convert.ToInt16(DgvLotes.Rows[i].Cells[j].Value);
                            }

                            pdfDoc.Add(tbl);

                            tbl = new PdfPTable(new float[] { 15f, 25f, 60f }) { WidthPercentage = 100f };
                            tbl.AddCell(new PdfPCell(new Phrase("INFORMACION LOTE", fsubtitulo)) { Colspan = 2, HorizontalAlignment = Element.ALIGN_CENTER, BackgroundColor = new BaseColor(0, 0, 0) });
                            tbl.AddCell(new PdfPCell(new Phrase("CODIGO LOTE", fsubtitulo)) { HorizontalAlignment = Element.ALIGN_CENTER, BackgroundColor = new BaseColor(0, 0, 0) });
                            tbl.AddCell(new PdfPCell(new Phrase("Lote:", ftexto1)) { HorizontalAlignment = Element.ALIGN_RIGHT, BackgroundColor = new BaseColor(230, 230, 230) });
                            tbl.AddCell(new PdfPCell(new Phrase(DgvLotes.Rows[i].Cells[0].Value.ToString(), ftexto2)) { HorizontalAlignment = Element.ALIGN_LEFT });
                            tbl.AddCell(new PdfPCell(new Phrase("*" + TxtPrograma.Text + "L" + DgvLotes.Rows[i].Cells[0].Value.ToString() + "*", fcodigo)) { Rowspan = 7, HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_MIDDLE });
                            tbl.AddCell(new PdfPCell(new Phrase("L./T.L.:", ftexto1)) { HorizontalAlignment = Element.ALIGN_RIGHT, BackgroundColor = new BaseColor(230, 230, 230) });
                            tbl.AddCell(new PdfPCell(new Phrase(DgvLotes.Rows[i].Cells[0].Value.ToString() + "/" + LblTLotes.Text, ftexto2)) { HorizontalAlignment = Element.ALIGN_LEFT });
                            tbl.AddCell(new PdfPCell(new Phrase("Cant. Lote:", ftexto1)) { HorizontalAlignment = Element.ALIGN_RIGHT, BackgroundColor = new BaseColor(230, 230, 230) });
                            tbl.AddCell(new PdfPCell(new Phrase(clote.ToString(), ftexto2)) { HorizontalAlignment = Element.ALIGN_LEFT });
                            tbl.AddCell(new PdfPCell(new Phrase("Codigo:", ftexto1)) { HorizontalAlignment = Element.ALIGN_RIGHT, BackgroundColor = new BaseColor(230, 230, 230) });
                            tbl.AddCell(new PdfPCell(new Phrase(TxtPrograma.Text + "L" + DgvLotes.Rows[i].Cells[0].Value.ToString(), ftexto2)) { HorizontalAlignment = Element.ALIGN_LEFT });
                            tbl.AddCell(new PdfPCell(new Phrase("OBSERVACIONES", fsubtitulo)) { Colspan = 2, HorizontalAlignment = Element.ALIGN_CENTER, BackgroundColor = new BaseColor(0, 0, 0) });
                            if (TxtObs.Text == string.Empty)
                                tbl.AddCell(new PdfPCell(new Phrase(" \n ", ftexto2)) { Rowspan = 2, Colspan = 2, HorizontalAlignment = Element.ALIGN_LEFT });
                            else
                                tbl.AddCell(new PdfPCell(new Phrase(TxtObs.Text, ftexto2)) { Rowspan = 2, Colspan = 2, HorizontalAlignment = Element.ALIGN_LEFT });
                            
                            pdfDoc.Add(tbl);

                            if (i != DgvLotes.RowCount - 1)
                                pdfDoc.Add(new Phrase(" "));
                        }
                        
                        //pdfDoc.Add(new Phrase("*7105L2*", fcodigo));

                        pdfDoc.Close();
                        stream.Close();
                        TxtPrograma.Enabled = false;
                        TxtCtdLote.Enabled = false;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al guardar\n"+ex.ToString(), "Mensaje de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Acción con DataGridView
        private void DgvIndex_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvIndex.Columns[e.ColumnIndex].Name == "Sel")
            {
                Limpiar();
                TxtPrograma.Text = DgvIndex.Rows[e.RowIndex].Cells["Programa"].Value.ToString();
                if (DgvIndex.Rows[e.RowIndex].Cells["TipoLote"].Value.ToString() == "D")
                {
                    RbDistribuido.Checked = true;
                    RbXTalla.Checked = false;
                }
                else
                {
                    RbDistribuido.Checked = false;
                    RbXTalla.Checked = true;
                }
                TxtObs.Text = DgvIndex.Rows[e.RowIndex].Cells["Obs"].Value.ToString();
                TxtCtdLote.Text = DgvIndex.Rows[e.RowIndex].Cells["CantLote"].Value.ToString();
                DtpFechaEmbarque.Format = DateTimePickerFormat.Custom;
                DtpFechaEmbarque.CustomFormat = "dd/MM/yyyy";
                DtpFechaEmbarque.Value = Convert.ToDateTime(DgvIndex.Rows[e.RowIndex].Cells["FEmbarque"].Value);
                fEmbarque = Convert.ToDateTime(DgvIndex.Rows[e.RowIndex].Cells["FEmbarque"].Value);
                fInicial = Convert.ToDateTime(DgvIndex.Rows[e.RowIndex].Cells["FInicial"].Value);
                CargarDatos();

                BtnVistaPrevia.Enabled = false;
                BtnCrearLoteo.Enabled = false;
                BtnGuardar.Enabled = true;

                DgvLotes.DataSource = null;
                DgvLotes.Rows.Clear();
                DgvLotes.Columns.Clear();
                if (RbDistribuido.Checked)
                {
                    if (DgvCorridaCalzado.DataSource != null)
                    {
                        LotearDistribuido(DgvCorridaCalzado);
                    }
                    else
                    {
                        LotearDistribuido(DgvCorridaMarroquineria);
                    }
                }
                else
                {
                    if (DgvCorridaCalzado.DataSource != null)
                    {
                        LotearXTalla(DgvCorridaCalzado);
                    }
                    else
                    {
                        LotearXTalla(DgvCorridaMarroquineria);
                    }
                }
            }
        }
        #endregion
    }
}
