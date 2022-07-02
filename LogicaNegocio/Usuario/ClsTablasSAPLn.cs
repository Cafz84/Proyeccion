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
        #endregion
    }
}
