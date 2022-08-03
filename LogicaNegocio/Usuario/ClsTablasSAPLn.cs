using AccesoDatos.DataBase;
using Entidades.Usuario;
using System;
using System.Data;

namespace LogicaNegocio.Usuario
{
    public class ClsTablasSAPLn
    {
        #region Variables privadas
        private ClsDataBase ObjDataBase = null;
        #endregion

        #region Index TablasSAP
        public void IndexModel(ref ClsTablasSAP ObjTablasSAP)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "Lavoraziones_Monnaaci_P",
                NombreTabla = "dbo.[@ARGNS_MODEL]",
                NombreSP = "[dbo].[SPC_Model_Read]",
                Scalar = false
            };

            ObjDataBase.DtParametros.Rows.Add(@"@Codigo", "18", ObjTablasSAP.U_ModCode);
            ObjDataBase.DtParametros.Rows.Add(@"@Estilo", "18", ObjTablasSAP.U_ModDesc);
            Ejecutar(ref ObjTablasSAP);
        }
        #endregion

        #region CRUD TablasSAP
        public void ReadPedidoCantidad(ref ClsTablasSAP ObjTablasSAP)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "Lavoraziones_Monnaaci_P",
                NombreTabla = "OWOR",
                NombreSP = "[dbo].[SPC_PedidoCantidad_Read]",
                Scalar = false
            };

            ObjDataBase.DtParametros.Rows.Add(@"@Programa", "18", ObjTablasSAP.Programa);
            EjecutarPedidoCantidad(ref ObjTablasSAP);
        }

        public void ReadInfoPrograma(ref ClsTablasSAP ObjTablasSAP)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "Lavoraziones_Monnaaci_P",
                NombreTabla = "OWOR",
                NombreSP = "[dbo].[SPC_InfoPrograma_Read]",
                Scalar = false
            };

            ObjDataBase.DtParametros.Rows.Add(@"@Programa", "18", ObjTablasSAP.Programa);
            EjecutarInfoPrograma(ref ObjTablasSAP);
        }
        #endregion

        #region Metodos privados
        private void Ejecutar(ref ClsTablasSAP ObjTablasSAP)
        {
            ObjDataBase.CRUD(ref ObjDataBase);

            if (ObjDataBase.MensajeErrorDB == null)
            {
                if (ObjDataBase.Scalar)
                {
                    ObjTablasSAP.ValorEscalar = ObjDataBase.ValorScalar;
                }
                else
                {
                    ObjTablasSAP.DtResultados = ObjDataBase.DsResultados.Tables[0];
                    if (ObjTablasSAP.DtResultados.Rows.Count == 1)
                    {
                        foreach (DataRow dr in ObjTablasSAP.DtResultados.Rows)
                        {
                            ObjTablasSAP.Code = dr["Code"].ToString();
                            ObjTablasSAP.U_ModCode = dr["Codigo"].ToString();
                            ObjTablasSAP.U_ModDesc = dr["Estilo"].ToString();
                        }
                    }
                }
            }
            else
            {
                ObjTablasSAP.MsjError = ObjDataBase.MensajeErrorDB;
            }
        }

        private void EjecutarPedidoCantidad(ref ClsTablasSAP ObjTablasSAP)
        {
            ObjDataBase.CRUD(ref ObjDataBase);

            if (ObjDataBase.MensajeErrorDB == null)
            {
                if (ObjDataBase.Scalar)
                {
                    ObjTablasSAP.ValorEscalar = ObjDataBase.ValorScalar;
                }
                else
                {
                    ObjTablasSAP.DtResultados = ObjDataBase.DsResultados.Tables[0];
                    if (ObjTablasSAP.DtResultados.Rows.Count == 1)
                    {
                        foreach (DataRow dr in ObjTablasSAP.DtResultados.Rows)
                        {
                            ObjTablasSAP.Programa = dr["Programa"].ToString();
                            ObjTablasSAP.Estilo = dr["Estilo"].ToString();
                            ObjTablasSAP.Color = dr["Color"].ToString();
                            ObjTablasSAP.CantPedido = Convert.ToDecimal(dr["Cantidad"].ToString());
                        }
                    }
                }
            }
            else
            {
                ObjTablasSAP.MsjError = ObjDataBase.MensajeErrorDB;
            }
        }

        private void EjecutarInfoPrograma(ref ClsTablasSAP ObjTablasSAP)
        {
            ObjDataBase.CRUD(ref ObjDataBase);

            if (ObjDataBase.MensajeErrorDB == null)
            {
                if (ObjDataBase.Scalar)
                {
                    ObjTablasSAP.ValorEscalar = ObjDataBase.ValorScalar;
                }
                else
                {
                    ObjTablasSAP.DtResultados = ObjDataBase.DsResultados.Tables[0];
                    if (ObjTablasSAP.DtResultados.Rows.Count > 0)
                    {
                        ObjTablasSAP.DtTallaCtd = new DataTable("Tallas");
                        object[] rowVals = new object[ObjTablasSAP.DtResultados.Rows.Count];
                        ObjTablasSAP.Estilo = ObjTablasSAP.DtResultados.Rows[0]["Estilo"].ToString();
                        ObjTablasSAP.Color = ObjTablasSAP.DtResultados.Rows[0]["Color"].ToString();
                        ObjTablasSAP.Horma = ObjTablasSAP.DtResultados.Rows[0]["Horma"].ToString();
                        ObjTablasSAP.Genero = ObjTablasSAP.DtResultados.Rows[0]["Genero"].ToString();

                        for (int i = 0; i < ObjTablasSAP.DtResultados.Rows.Count; i++)
                        {
                            ObjTablasSAP.DtTallaCtd.Columns.Add(ObjTablasSAP.DtResultados.Rows[i]["Talla"].ToString());
                            rowVals[i] = ObjTablasSAP.DtResultados.Rows[i]["Cantidad"].ToString().Substring(0, 
                                ObjTablasSAP.DtResultados.Rows[i]["Cantidad"].ToString().IndexOf("."));
                            int sum = Convert.ToInt16(ObjTablasSAP.DtResultados.Rows[i]["Cantidad"].ToString().Substring(0,
                                ObjTablasSAP.DtResultados.Rows[i]["Cantidad"].ToString().IndexOf(".")));
                            ObjTablasSAP.Cantidad = sum + ObjTablasSAP.Cantidad;
                        }

                        ObjTablasSAP.DtTallaCtd.Rows.Add(rowVals);
                        
                        /*
                        foreach (DataRow dr in ObjTablasSAP.DtResultados.Rows)
                        {
                            ObjTablasSAP.Programa = dr["Programa"].ToString();
                            ObjTablasSAP.OrdenFabricacion = Convert.ToByte(dr["OrdenFabricacion"].ToString());
                            ObjTablasSAP.Estatus = Convert.ToChar(dr["Estatus"].ToString());
                            ObjTablasSAP.Pedido = Convert.ToByte(dr["Pedido"].ToString());
                            ObjTablasSAP.PO = dr["PO"].ToString();
                            ObjTablasSAP.CodEstilo = dr["CodEstilo"].ToString();
                            ObjTablasSAP.Estilo = dr["Estilo"].ToString();
                            ObjTablasSAP.CodColor = dr["CodColor"].ToString();
                            ObjTablasSAP.Color = dr["Color"].ToString();
                            ObjTablasSAP.Talla = dr["Talla"].ToString();
                            ObjTablasSAP.ItemNo = dr["ItemNo"].ToString();
                            ObjTablasSAP.CodBarra = dr["CodBarra"].ToString();
                            ObjTablasSAP.Horma = dr["Horma"].ToString();
                            ObjTablasSAP.Cantidad = Convert.ToByte(dr["Cantidad"].ToString());
                            ObjTablasSAP.Genero = dr["Genero"].ToString();
                        }
                        */
                    }
                }
            }
            else
            {
                ObjTablasSAP.MsjError = ObjDataBase.MensajeErrorDB;
            }
        }
        #endregion
    }
}
