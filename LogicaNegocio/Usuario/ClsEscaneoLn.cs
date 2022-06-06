using AccesoDatos.DataBase;
using Entidades.Usuario;
using System;
using System.Data;

namespace LogicaNegocio.Usuario
{
    public class ClsEscaneoLn
    {
        #region Variables privadas
        private ClsDataBase ObjDataBase = null;
        #endregion

        #region Metodo Index
        public void Index(ref ClsEscaneo ObjEscaneo)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "DB_BasePruebas",
                NombreTabla = "Escaneo",
                NombreSP = "[dbo].[SP_Escaneo_Index]",
                Scalar = false
            };

            Ejecutar(ref ObjEscaneo);
        }
        #endregion

        #region CRUD Escaneo
        public void Create(ref ClsEscaneo ObjEscaneo)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "DB_BasePruebas",
                NombreTabla = "Escaneo",
                NombreSP = "[dbo].[SP_Escaneo_Create]",
                Scalar = false
            };

            ObjDataBase.DtParametros.Rows.Add(@"@Programa", "4", ObjEscaneo.Programa);
            ObjDataBase.DtParametros.Rows.Add(@"@Escaneo", "18", ObjEscaneo.Escaneo);
            ObjDataBase.DtParametros.Rows.Add(@"@Area", "18", ObjEscaneo.Area);
            ObjDataBase.DtParametros.Rows.Add(@"@Selecc", "18", ObjEscaneo.Selecc);
            ObjDataBase.DtParametros.Rows.Add(@"@Cantidad", "4", ObjEscaneo.Cantidad);
            ObjDataBase.DtParametros.Rows.Add(@"@NCajaEmbarque", "4", ObjEscaneo.NCajaEmbarque);
            ObjDataBase.DtParametros.Rows.Add(@"@PO", "14", ObjEscaneo.PO);
            ObjDataBase.DtParametros.Rows.Add(@"@ItemCode", "18", ObjEscaneo.ItemCode);
            ObjDataBase.DtParametros.Rows.Add(@"@Cod_Modelo", "18", ObjEscaneo.Cod_Modelo);
            ObjDataBase.DtParametros.Rows.Add(@"@Modelo", "18", ObjEscaneo.Modelo);
            ObjDataBase.DtParametros.Rows.Add(@"@Cod_Color", "18", ObjEscaneo.Cod_Color);
            ObjDataBase.DtParametros.Rows.Add(@"@Color", "18", ObjEscaneo.Color);
            ObjDataBase.DtParametros.Rows.Add(@"@Punto", "18", ObjEscaneo.Punto);
            ObjDataBase.DtParametros.Rows.Add(@"@FechaAlta", "14", ObjEscaneo.FechaAlta);
            ObjDataBase.DtParametros.Rows.Add(@"@Error", "18", ObjEscaneo.Error);
            ObjDataBase.DtParametros.Rows.Add(@"@NEscaneoXCaja", "4", ObjEscaneo.NEscaneoXCaja);
            ObjDataBase.DtParametros.Rows.Add(@"@NEmbarque", "4", ObjEscaneo.NEmbarque);

            Ejecutar(ref ObjEscaneo);
        }

        public void Read(ref ClsEscaneo ObjEscaneo)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "DB_BasePruebas",
                NombreTabla = "Escaneo",
                NombreSP = "[dbo].[SP_Escaneo_Read]",
                Scalar = true
            };

            ObjDataBase.DtParametros.Rows.Add(@"@NEmbarque", "4", ObjEscaneo.NEmbarque);
            ObjDataBase.DtParametros.Rows.Add(@"@Programa", "4", ObjEscaneo.Programa);
            ObjDataBase.DtParametros.Rows.Add(@"@Escaneo", "18", ObjEscaneo.Escaneo);
            ObjDataBase.DtParametros.Rows.Add(@"@NEscaneoXCaja", "4", ObjEscaneo.NEscaneoXCaja);

            Ejecutar(ref ObjEscaneo);
        }

        public void ReadEmbarqueMax(ref ClsEscaneo ObjEscaneo)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "DB_BasePruebas",
                NombreTabla = "Escaneo",
                NombreSP = "[dbo].[SP_Escaneo_ReadEmbarqueMax]",
                Scalar = false
            };

            EjecutarEmbarqueMax(ref ObjEscaneo);
        }

        public void ReadCajaMax(ref ClsEscaneo ObjEscaneo)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "DB_BasePruebas",
                NombreTabla = "Escaneo",
                NombreSP = "[dbo].[SP_Escaneo_ReadCajaMax]",
                Scalar = false
            };

            ObjDataBase.DtParametros.Rows.Add(@"@NEmbarque", "4", ObjEscaneo.NEmbarque);
            ObjDataBase.DtParametros.Rows.Add(@"@Area", "18", ObjEscaneo.Area);
            ObjDataBase.DtParametros.Rows.Add(@"@Selecc", "4", ObjEscaneo.Selecc);

            EjecutarCajaMax(ref ObjEscaneo);
        }

        public void Update(ref ClsEscaneo ObjEscaneo)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "DB_BasePruebas",
                NombreTabla = "Escaneo",
                NombreSP = "[dbo].[SP_Escaneo_Update]",
                Scalar = true
            };

            ObjDataBase.DtParametros.Rows.Add(@"@Programa", "4", ObjEscaneo.Programa);
            ObjDataBase.DtParametros.Rows.Add(@"@Escaneo", "18", ObjEscaneo.Escaneo);
            ObjDataBase.DtParametros.Rows.Add(@"@Area", "18", ObjEscaneo.Area);
            ObjDataBase.DtParametros.Rows.Add(@"@Selecc", "18", ObjEscaneo.Selecc);
            ObjDataBase.DtParametros.Rows.Add(@"@Cantidad", "4", ObjEscaneo.Cantidad);
            ObjDataBase.DtParametros.Rows.Add(@"@NCajaEmbarque", "4", ObjEscaneo.NCajaEmbarque);
            ObjDataBase.DtParametros.Rows.Add(@"@PO", "14", ObjEscaneo.PO);
            ObjDataBase.DtParametros.Rows.Add(@"@ItemCode", "18", ObjEscaneo.ItemCode);
            ObjDataBase.DtParametros.Rows.Add(@"@Cod_Modelo", "18", ObjEscaneo.Cod_Modelo);
            ObjDataBase.DtParametros.Rows.Add(@"@Modelo", "18", ObjEscaneo.Modelo);
            ObjDataBase.DtParametros.Rows.Add(@"@Cod_Colo", "18", ObjEscaneo.Cod_Color);
            ObjDataBase.DtParametros.Rows.Add(@"@Color", "18", ObjEscaneo.Color);
            ObjDataBase.DtParametros.Rows.Add(@"@Punto", "18", ObjEscaneo.Punto);
            ObjDataBase.DtParametros.Rows.Add(@"@FechaAlta", "14", ObjEscaneo.FechaAlta);
            ObjDataBase.DtParametros.Rows.Add(@"@Error", "18", ObjEscaneo.Error);
            ObjDataBase.DtParametros.Rows.Add(@"@NEscaneoXCaja", "4", ObjEscaneo.NEscaneoXCaja);
            ObjDataBase.DtParametros.Rows.Add(@"@NEmbarque", "4", ObjEscaneo.NEmbarque);

            Ejecutar(ref ObjEscaneo);
        }

        public void Delete(ref ClsEscaneo ObjEscaneo)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "DB_BasePruebas",
                NombreTabla = "Escaneo",
                NombreSP = "[dbo].[SP_Escaneo_Delete]",
                Scalar = true
            };

            ObjDataBase.DtParametros.Rows.Add(@"@NEmbarque", "4", ObjEscaneo.NEmbarque);
            ObjDataBase.DtParametros.Rows.Add(@"@Programa", "4", ObjEscaneo.Programa);
            ObjDataBase.DtParametros.Rows.Add(@"@Escaneo", "18", ObjEscaneo.Escaneo);
            ObjDataBase.DtParametros.Rows.Add(@"@NEscaneoXCaja", "4", ObjEscaneo.NEscaneoXCaja);

            Ejecutar(ref ObjEscaneo);
        }
        #endregion

        #region Metodos privados
        private void Ejecutar(ref ClsEscaneo ObjEscaneo)
        {
            ObjDataBase.CRUD(ref ObjDataBase);

            if (ObjDataBase.MensajeErrorDB == null)
            {
                if (ObjDataBase.Scalar)
                {
                    ObjEscaneo.ValorEscalar = ObjDataBase.ValorScalar;
                }
                else
                {
                    ObjEscaneo.DtResultados = ObjDataBase.DsResultados.Tables[0];
                    if (ObjEscaneo.DtResultados.Rows.Count == 1)
                    {
                        try
                        {
                            foreach (DataRow dr in ObjEscaneo.DtResultados.Rows)
                            {
                                ObjEscaneo.Programa = Convert.ToInt16(dr["Programa"].ToString());
                                ObjEscaneo.Escaneo = dr["Escaneo"].ToString();

                                if (dr["Area"] == DBNull.Value)
                                    ObjEscaneo.Area = string.Empty;
                                else
                                    ObjEscaneo.Area = dr["Area"].ToString();

                                if (dr["Selecc"] == DBNull.Value)
                                    ObjEscaneo.Selecc = string.Empty;
                                else
                                    ObjEscaneo.Selecc = dr["Selecc"].ToString();

                                if (dr["Cantidad"] == DBNull.Value)
                                    ObjEscaneo.Cantidad = 0;
                                else
                                    ObjEscaneo.Cantidad = Convert.ToInt16(dr["Cantidad"].ToString());

                                if (dr["NCajaEmbarque"] == DBNull.Value)
                                    ObjEscaneo.NCajaEmbarque = 0;
                                else
                                    ObjEscaneo.NCajaEmbarque = Convert.ToInt16(dr["NCajaEmbarque"].ToString());

                                if (dr["PO"] == DBNull.Value)
                                    ObjEscaneo.PO = string.Empty;
                                else
                                    ObjEscaneo.PO = dr["PO"].ToString();

                                if (dr["ItemCode"] == DBNull.Value)
                                    ObjEscaneo.ItemCode = string.Empty;
                                else
                                    ObjEscaneo.ItemCode = dr["ItemCode"].ToString();

                                if (dr["Cod_Modelo"] == DBNull.Value)
                                    ObjEscaneo.Cod_Modelo = string.Empty;
                                else
                                    ObjEscaneo.Cod_Modelo = dr["Cod_Modelo"].ToString();

                                if (dr["Modelo"] == DBNull.Value)
                                    ObjEscaneo.Modelo = string.Empty;
                                else
                                    ObjEscaneo.Modelo = dr["Modelo"].ToString();

                                if (dr["Cod_Color"] == DBNull.Value)
                                    ObjEscaneo.Cod_Color = string.Empty;
                                else
                                    ObjEscaneo.Cod_Color = dr["Cod_Color"].ToString();

                                if (dr["Color"] == DBNull.Value)
                                    ObjEscaneo.Color = string.Empty;
                                else
                                    ObjEscaneo.Color = dr["Color"].ToString();

                                if (dr["Punto"] == DBNull.Value)
                                    ObjEscaneo.Punto = string.Empty;
                                else
                                    ObjEscaneo.Punto = dr["Punto"].ToString();

                                if (dr["FechaAlta"] == DBNull.Value)
                                    ObjEscaneo.FechaAlta = DateTime.Today;
                                else
                                    ObjEscaneo.FechaAlta = Convert.ToDateTime(dr["FechaAlta"].ToString());

                                if (dr["Error"] == DBNull.Value)
                                    ObjEscaneo.Error = string.Empty;
                                else
                                    ObjEscaneo.Error = dr["Error"].ToString();

                                if (dr["NEscaneoXCaja"] == DBNull.Value)
                                    ObjEscaneo.NEscaneoXCaja = 0;
                                else
                                    ObjEscaneo.NEscaneoXCaja = Convert.ToInt16(dr["NEscaneoXCaja"].ToString());

                                if (dr["NEmbarque"] == DBNull.Value)
                                    ObjEscaneo.NEmbarque = 0;
                                else
                                    ObjEscaneo.NEmbarque = Convert.ToInt16(dr["NEmbarque"].ToString());
                            }
                        }
                        catch(Exception e)
                        {
                            ObjEscaneo.MsjError = e.ToString();
                        }
                        
                    }
                }
            }
            else
            {
                ObjEscaneo.MsjError = ObjDataBase.MensajeErrorDB;
            }
        }

        private void EjecutarEmbarqueMax(ref ClsEscaneo ObjEscaneo)
        {
            ObjDataBase.CRUD(ref ObjDataBase);

            if (ObjDataBase.MensajeErrorDB == null)
            {
                if (ObjDataBase.Scalar)
                {
                    ObjEscaneo.ValorEscalar = ObjDataBase.ValorScalar;
                }
                else
                {
                    ObjEscaneo.DtResultados = ObjDataBase.DsResultados.Tables[0];
                    if (ObjEscaneo.DtResultados.Rows.Count == 1)
                    {
                        foreach (DataRow dr in ObjEscaneo.DtResultados.Rows)
                        {
                            if (dr["MaxEmbarque"] == DBNull.Value)
                                ObjEscaneo.NEmbarque = 1;
                            else
                                ObjEscaneo.NEmbarque = Convert.ToInt16(dr["MaxEmbarque"].ToString())+1;
                        }
                    }
                }
            }
            else
            {
                ObjEscaneo.MsjError = ObjDataBase.MensajeErrorDB;
            }
        }

        private void EjecutarCajaMax(ref ClsEscaneo ObjEscaneo)
        {
            ObjDataBase.CRUD(ref ObjDataBase);

            if (ObjDataBase.MensajeErrorDB == null)
            {
                if (ObjDataBase.Scalar)
                {
                    ObjEscaneo.ValorEscalar = ObjDataBase.ValorScalar;
                }
                else
                {
                    ObjEscaneo.DtResultados = ObjDataBase.DsResultados.Tables[0];
                    if (ObjEscaneo.DtResultados.Rows.Count == 1)
                    {
                        foreach (DataRow dr in ObjEscaneo.DtResultados.Rows)
                        {
                            if (dr["MaxCaja"] == DBNull.Value)
                                ObjEscaneo.NCajaEmbarque = 1;
                            else
                                ObjEscaneo.NCajaEmbarque = Convert.ToInt16(dr["MaxCaja"].ToString()) + 1;
                        }
                    }
                }
            }
            else
            {
                ObjEscaneo.MsjError = ObjDataBase.MensajeErrorDB;
            }
        }
        #endregion
    }
}
