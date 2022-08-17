using AccesoDatos.DataBase;
using Entidades.Usuario;
using System;
using System.Data;

namespace LogicaNegocio.Usuario
{
    public class ClsLoteoLn
    {
        #region Variables Privadas
        private ClsDataBase ObjDataBase = null;
        private string Log;
        private bool bIndex;
        #endregion

        #region Metodo Index
        public void Index(ref ClsLoteo ObjLoteo)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "Loteo",
                NombreSP = "dbo.SP_Loteo_Index",
                Scalar = false
            };

            bIndex = true;
            ObjDataBase.DtParametros.Rows.Add(@"@Programa", "4", ObjLoteo.Programa);
            ObjDataBase.DtParametros.Rows.Add(@"@Estilo", "18", ObjLoteo.Estilo);
            ObjDataBase.DtParametros.Rows.Add(@"@Color", "18", ObjLoteo.Color);
            Ejecutar(ref ObjLoteo);
        }
        #endregion

        #region CRUD Aportaciones
        public void Create(ref ClsLoteo ObjLoteo)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "Loteo",
                NombreSP = "dbo.SP_Loteo_Create",
                Scalar = false
            };

            ObjDataBase.DtParametros.Rows.Add(@"@CodLote", "18", ObjLoteo.CodLote);
            ObjDataBase.DtParametros.Rows.Add(@"@ImpLote", "18", ObjLoteo.ImpLote);
            ObjDataBase.DtParametros.Rows.Add(@"@Area", "18", ObjLoteo.Area);
            ObjDataBase.DtParametros.Rows.Add(@"@Programa", "4", ObjLoteo.Programa);
            ObjDataBase.DtParametros.Rows.Add(@"@CantPrograma", "4", ObjLoteo.CantPrograma);
            ObjDataBase.DtParametros.Rows.Add(@"@CantLote", "4", ObjLoteo.CantLote);
            ObjDataBase.DtParametros.Rows.Add(@"@CantxLote", "4", ObjLoteo.CantxLote);
            ObjDataBase.DtParametros.Rows.Add(@"@TLotes", "4", ObjLoteo.TLotes);
            ObjDataBase.DtParametros.Rows.Add(@"@NLote", "4", ObjLoteo.NLote);
            ObjDataBase.DtParametros.Rows.Add(@"@TipoLote", "15", ObjLoteo.TipoLote);
            ObjDataBase.DtParametros.Rows.Add(@"@Estilo", "18", ObjLoteo.Estilo);
            ObjDataBase.DtParametros.Rows.Add(@"@Color", "18", ObjLoteo.Color);
            ObjDataBase.DtParametros.Rows.Add(@"@Horma", "18", ObjLoteo.Horma);
            ObjDataBase.DtParametros.Rows.Add(@"@FLote", "14", ObjLoteo.FLote);
            ObjDataBase.DtParametros.Rows.Add(@"@FEmbarque", "14", ObjLoteo.FEmbarque);
            ObjDataBase.DtParametros.Rows.Add(@"@Info", "18", ObjLoteo.Info);
            ObjDataBase.DtParametros.Rows.Add(@"@5", "4", ObjLoteo.T5);
            ObjDataBase.DtParametros.Rows.Add(@"@55", "4", ObjLoteo.T55);
            ObjDataBase.DtParametros.Rows.Add(@"@6", "4", ObjLoteo.T6);
            ObjDataBase.DtParametros.Rows.Add(@"@65", "4", ObjLoteo.T65);
            ObjDataBase.DtParametros.Rows.Add(@"@7", "4", ObjLoteo.T7);
            ObjDataBase.DtParametros.Rows.Add(@"@75", "4", ObjLoteo.T75);
            ObjDataBase.DtParametros.Rows.Add(@"@8", "4", ObjLoteo.T8);
            ObjDataBase.DtParametros.Rows.Add(@"@85", "4", ObjLoteo.T85);
            ObjDataBase.DtParametros.Rows.Add(@"@9", "4", ObjLoteo.T9);
            ObjDataBase.DtParametros.Rows.Add(@"@95", "4", ObjLoteo.T95);
            ObjDataBase.DtParametros.Rows.Add(@"@10", "4", ObjLoteo.T10);
            ObjDataBase.DtParametros.Rows.Add(@"@105", "4", ObjLoteo.T105);
            ObjDataBase.DtParametros.Rows.Add(@"@11", "4", ObjLoteo.T11);
            ObjDataBase.DtParametros.Rows.Add(@"@115", "4", ObjLoteo.T115);
            ObjDataBase.DtParametros.Rows.Add(@"@12", "4", ObjLoteo.T12);
            ObjDataBase.DtParametros.Rows.Add(@"@13", "4", ObjLoteo.T13);
            ObjDataBase.DtParametros.Rows.Add(@"@14", "4", ObjLoteo.T14);
            ObjDataBase.DtParametros.Rows.Add(@"@15", "4", ObjLoteo.T15);
            ObjDataBase.DtParametros.Rows.Add(@"@16", "4", ObjLoteo.T16);
            ObjDataBase.DtParametros.Rows.Add(@"@17", "4", ObjLoteo.T17);
            ObjDataBase.DtParametros.Rows.Add(@"@28", "4", ObjLoteo.T28);
            ObjDataBase.DtParametros.Rows.Add(@"@30", "4", ObjLoteo.T30);
            ObjDataBase.DtParametros.Rows.Add(@"@32", "4", ObjLoteo.T32);
            ObjDataBase.DtParametros.Rows.Add(@"@34", "4", ObjLoteo.T34);
            ObjDataBase.DtParametros.Rows.Add(@"@36", "4", ObjLoteo.T36);
            ObjDataBase.DtParametros.Rows.Add(@"@38", "4", ObjLoteo.T38);
            ObjDataBase.DtParametros.Rows.Add(@"@40", "4", ObjLoteo.T40);
            ObjDataBase.DtParametros.Rows.Add(@"@42", "4", ObjLoteo.T42);
            ObjDataBase.DtParametros.Rows.Add(@"@44", "4", ObjLoteo.T44);
            ObjDataBase.DtParametros.Rows.Add(@"@46", "4", ObjLoteo.T46);
            ObjDataBase.DtParametros.Rows.Add(@"@L", "4", ObjLoteo.TL);
            ObjDataBase.DtParametros.Rows.Add(@"@M", "4", ObjLoteo.TM);
            ObjDataBase.DtParametros.Rows.Add(@"@S", "4", ObjLoteo.TS);
            ObjDataBase.DtParametros.Rows.Add(@"@X", "4", ObjLoteo.TX);
            ObjDataBase.DtParametros.Rows.Add(@"@XL", "4", ObjLoteo.TXL);
            ObjDataBase.DtParametros.Rows.Add(@"@XS", "4", ObjLoteo.TXS);

            Ejecutar(ref ObjLoteo);
        }

        public void Read(ref ClsLoteo ObjLoteo)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "Loteo",
                NombreSP = "dbo.SP_Loteo_Read",
                Scalar = false
            };

            bIndex = false;
            ObjDataBase.DtParametros.Rows.Add(@"@CodLote", "18", ObjLoteo.CodLote);
            Ejecutar(ref ObjLoteo);
        }

        public void ProgramaRead(ref ClsLoteo ObjLoteo)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "Loteo",
                NombreSP = "dbo.SP_Loteo_ProgramaRead",
                Scalar = false
            };

            bIndex = false;
            ObjDataBase.DtParametros.Rows.Add(@"@Programa", "4", ObjLoteo.Programa);
            Ejecutar(ref ObjLoteo);
        }

        public void Update(ref ClsLoteo ObjLoteo)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "Loteo",
                NombreSP = "dbo.SP_Loteo_Update",
                Scalar = true
            };

            ObjDataBase.DtParametros.Rows.Add(@"@CodLote", "18", ObjLoteo.CodLote);
            ObjDataBase.DtParametros.Rows.Add(@"@ImpLote", "18", ObjLoteo.ImpLote);
            ObjDataBase.DtParametros.Rows.Add(@"@Area", "18", ObjLoteo.Area);
            ObjDataBase.DtParametros.Rows.Add(@"@Programa", "4", ObjLoteo.Programa);
            ObjDataBase.DtParametros.Rows.Add(@"@CantPrograma", "4", ObjLoteo.CantPrograma);
            ObjDataBase.DtParametros.Rows.Add(@"@CantLote", "4", ObjLoteo.CantLote);
            ObjDataBase.DtParametros.Rows.Add(@"@TLotes", "4", ObjLoteo.TLotes);
            ObjDataBase.DtParametros.Rows.Add(@"@NLote", "4", ObjLoteo.NLote);
            ObjDataBase.DtParametros.Rows.Add(@"@TipoLote", "15", ObjLoteo.TipoLote);
            ObjDataBase.DtParametros.Rows.Add(@"@Estilo", "18", ObjLoteo.Estilo);
            ObjDataBase.DtParametros.Rows.Add(@"@Color", "18", ObjLoteo.Color);
            ObjDataBase.DtParametros.Rows.Add(@"@Horma", "18", ObjLoteo.Horma);
            ObjDataBase.DtParametros.Rows.Add(@"@FLote", "14", ObjLoteo.FLote);
            ObjDataBase.DtParametros.Rows.Add(@"@FEmbarque", "14", ObjLoteo.FEmbarque);
            ObjDataBase.DtParametros.Rows.Add(@"@Info", "18", ObjLoteo.Info);
            ObjDataBase.DtParametros.Rows.Add(@"@5", "4", ObjLoteo.T5);
            ObjDataBase.DtParametros.Rows.Add(@"@55", "4", ObjLoteo.T55);
            ObjDataBase.DtParametros.Rows.Add(@"@6", "4", ObjLoteo.T6);
            ObjDataBase.DtParametros.Rows.Add(@"@65", "4", ObjLoteo.T65);
            ObjDataBase.DtParametros.Rows.Add(@"@7", "4", ObjLoteo.T7);
            ObjDataBase.DtParametros.Rows.Add(@"@75", "4", ObjLoteo.T75);
            ObjDataBase.DtParametros.Rows.Add(@"@8", "4", ObjLoteo.T8);
            ObjDataBase.DtParametros.Rows.Add(@"@85", "4", ObjLoteo.T85);
            ObjDataBase.DtParametros.Rows.Add(@"@9", "4", ObjLoteo.T9);
            ObjDataBase.DtParametros.Rows.Add(@"@95", "4", ObjLoteo.T95);
            ObjDataBase.DtParametros.Rows.Add(@"@10", "4", ObjLoteo.T10);
            ObjDataBase.DtParametros.Rows.Add(@"@105", "4", ObjLoteo.T105);
            ObjDataBase.DtParametros.Rows.Add(@"@11", "4", ObjLoteo.T11);
            ObjDataBase.DtParametros.Rows.Add(@"@115", "4", ObjLoteo.T115);
            ObjDataBase.DtParametros.Rows.Add(@"@12", "4", ObjLoteo.T12);
            ObjDataBase.DtParametros.Rows.Add(@"@13", "4", ObjLoteo.T13);
            ObjDataBase.DtParametros.Rows.Add(@"@14", "4", ObjLoteo.T14);
            ObjDataBase.DtParametros.Rows.Add(@"@15", "4", ObjLoteo.T15);
            ObjDataBase.DtParametros.Rows.Add(@"@16", "4", ObjLoteo.T16);
            ObjDataBase.DtParametros.Rows.Add(@"@17", "4", ObjLoteo.T17);
            ObjDataBase.DtParametros.Rows.Add(@"@28", "4", ObjLoteo.T28);
            ObjDataBase.DtParametros.Rows.Add(@"@30", "4", ObjLoteo.T30);
            ObjDataBase.DtParametros.Rows.Add(@"@32", "4", ObjLoteo.T32);
            ObjDataBase.DtParametros.Rows.Add(@"@34", "4", ObjLoteo.T34);
            ObjDataBase.DtParametros.Rows.Add(@"@36", "4", ObjLoteo.T36);
            ObjDataBase.DtParametros.Rows.Add(@"@38", "4", ObjLoteo.T38);
            ObjDataBase.DtParametros.Rows.Add(@"@40", "4", ObjLoteo.T40);
            ObjDataBase.DtParametros.Rows.Add(@"@42", "4", ObjLoteo.T42);
            ObjDataBase.DtParametros.Rows.Add(@"@44", "4", ObjLoteo.T44);
            ObjDataBase.DtParametros.Rows.Add(@"@46", "4", ObjLoteo.T46);
            ObjDataBase.DtParametros.Rows.Add(@"@L", "4", ObjLoteo.TL);
            ObjDataBase.DtParametros.Rows.Add(@"@M", "4", ObjLoteo.TM);
            ObjDataBase.DtParametros.Rows.Add(@"@S", "4", ObjLoteo.TS);
            ObjDataBase.DtParametros.Rows.Add(@"@X", "4", ObjLoteo.TX);
            ObjDataBase.DtParametros.Rows.Add(@"@XL", "4", ObjLoteo.TXL);
            ObjDataBase.DtParametros.Rows.Add(@"@XS", "4", ObjLoteo.TXS);

            Ejecutar(ref ObjLoteo);
        }

        public void Delete(ref ClsLoteo ObjLoteo)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "Loteo",
                NombreSP = "dbo.SP_Loteo_Delete",
                Scalar = true
            };

            ObjDataBase.DtParametros.Rows.Add(@"@Programa", "4", ObjLoteo.Programa);

            Ejecutar(ref ObjLoteo);
        }
        #endregion

        #region Metodos Privados
        private void Ejecutar(ref ClsLoteo ObjLoteo)
        {
            ObjDataBase.CRUD(ref ObjDataBase);

            if (ObjDataBase.MensajeErrorDB == null)
            {
                if (ObjDataBase.Scalar)
                {
                    ObjLoteo.ValorEscalar = ObjDataBase.ValorScalar;
                }
                else
                {
                    ObjLoteo.DtResultados = ObjDataBase.DsResultados.Tables[0];
                    if (ObjLoteo.DtResultados.Rows.Count == 1 && bIndex == false)
                    {
                        foreach (DataRow dr in ObjLoteo.DtResultados.Rows)
                        {
                            try
                            {
                                ObjLoteo.CodLote = dr["CodLote"].ToString();
                                ObjLoteo.ImpLote = dr["ImpLote"].ToString();
                                ObjLoteo.Area = dr["Area"].ToString();
                                ObjLoteo.Programa = Convert.ToByte(dr["Programa"].ToString());
                                ObjLoteo.CantPrograma = Convert.ToByte(dr["CantPrograma"].ToString());
                                ObjLoteo.CantLote = Convert.ToByte(dr["CantLote"].ToString());
                                ObjLoteo.TLotes = Convert.ToByte(dr["TLotes"].ToString());
                                ObjLoteo.NLote = Convert.ToByte(dr["NLote"].ToString());
                                ObjLoteo.TipoLote = Convert.ToChar(dr["TipoLote"].ToString());
                                ObjLoteo.Estilo = dr["Estilo"].ToString();
                                ObjLoteo.Color = dr["Color"].ToString();
                                ObjLoteo.Horma = dr["Horma"].ToString();
                                ObjLoteo.FLote = Convert.ToDateTime(dr["FLote"].ToString());
                                ObjLoteo.FEmbarque = Convert.ToDateTime(dr["FEmbarque"].ToString());
                                ObjLoteo.Info = dr["Info"].ToString();
                                ObjLoteo.T5 = Convert.ToByte(dr["5"].ToString());
                                ObjLoteo.T55 = Convert.ToByte(dr["5.5"].ToString());
                                ObjLoteo.T6 = Convert.ToByte(dr["6"].ToString());
                                ObjLoteo.T65 = Convert.ToByte(dr["6.5"].ToString());
                                ObjLoteo.T7 = Convert.ToByte(dr["7"].ToString());
                                ObjLoteo.T75 = Convert.ToByte(dr["7.5"].ToString());
                                ObjLoteo.T8 = Convert.ToByte(dr["8"].ToString());
                                ObjLoteo.T85 = Convert.ToByte(dr["8.5"].ToString());
                                ObjLoteo.T9 = Convert.ToByte(dr["9"].ToString());
                                ObjLoteo.T95 = Convert.ToByte(dr["9.5"].ToString());
                                ObjLoteo.T10 = Convert.ToByte(dr["10"].ToString());
                                ObjLoteo.T105 = Convert.ToByte(dr["10.5"].ToString());
                                ObjLoteo.T11 = Convert.ToByte(dr["11"].ToString());
                                ObjLoteo.T115 = Convert.ToByte(dr["11.5"].ToString());
                                ObjLoteo.T12 = Convert.ToByte(dr["12"].ToString());
                                ObjLoteo.T13 = Convert.ToByte(dr["13"].ToString());
                                ObjLoteo.T14 = Convert.ToByte(dr["14"].ToString());
                                ObjLoteo.T15 = Convert.ToByte(dr["15"].ToString());
                                ObjLoteo.T16 = Convert.ToByte(dr["16"].ToString());
                                ObjLoteo.T17 = Convert.ToByte(dr["17"].ToString());
                                ObjLoteo.T28 = Convert.ToByte(dr["28"].ToString());
                                ObjLoteo.T30 = Convert.ToByte(dr["30"].ToString());
                                ObjLoteo.T32 = Convert.ToByte(dr["32"].ToString());
                                ObjLoteo.T34 = Convert.ToByte(dr["34"].ToString());
                                ObjLoteo.T36 = Convert.ToByte(dr["36"].ToString());
                                ObjLoteo.T38 = Convert.ToByte(dr["38"].ToString());
                                ObjLoteo.T40 = Convert.ToByte(dr["40"].ToString());
                                ObjLoteo.T42 = Convert.ToByte(dr["42"].ToString());
                                ObjLoteo.T44 = Convert.ToByte(dr["44"].ToString());
                                ObjLoteo.T46 = Convert.ToByte(dr["46"].ToString());
                                ObjLoteo.TL = Convert.ToByte(dr["L"].ToString());
                                ObjLoteo.TM = Convert.ToByte(dr["M"].ToString());
                                ObjLoteo.TS = Convert.ToByte(dr["S"].ToString());
                                ObjLoteo.TX = Convert.ToByte(dr["X"].ToString());
                                ObjLoteo.TXL = Convert.ToByte(dr["XL"].ToString());
                                ObjLoteo.TXS = Convert.ToByte(dr["XS"].ToString());
                            }
                            catch (Exception ex)
                            {
                                Log = ex.ToString();
                            }
                        }
                    }
                }
            }
            else
            {
                ObjLoteo.MsjError = ObjDataBase.MensajeErrorDB;
            }
        }
        #endregion
    }
}
