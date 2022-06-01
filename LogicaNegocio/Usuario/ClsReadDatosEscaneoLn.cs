using AccesoDatos.DataBase;
using Entidades.Usuario;
using System;
using System.Data;

namespace LogicaNegocio.Usuario
{
    public class ClsReadDatosEscaneoLn
    {
        #region Variables Privadas
        private ClsDataBase ObjDataBase = null;
        private string Log;
        #endregion

        #region Crud DatosEscaneo
        public void ReadDatosEscaneo(ref ClsReadDatosEscaneo ObjReadDatosEscaneo)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "Laboraciones_Monnaaci_P",
                NombreTabla = "OWOR",
                NombreSP = "dbo.SPC_ReadDatosEscaneo",
                Scalar = false
            };

            ObjDataBase.DtParametros.Rows.Add(@"@Programa", "18", ObjReadDatosEscaneo.OrdenProduccion);
            ObjDataBase.DtParametros.Rows.Add(@"@Escaneo", "18", ObjReadDatosEscaneo.Codigo);

            Ejecutar(ref ObjReadDatosEscaneo);
        }
        #endregion

        #region Metodos Privados
        private void Ejecutar(ref ClsReadDatosEscaneo ObjReadDatosEscaneo)
        {
            ObjDataBase.CRUD(ref ObjDataBase);

            if (ObjDataBase.MensajeErrorDB == null)
            {
                if (ObjDataBase.Scalar)
                {
                    ObjReadDatosEscaneo.ValorEscalar = ObjDataBase.ValorScalar;
                }
                else
                {
                    ObjReadDatosEscaneo.DtResultados = ObjDataBase.DsResultados.Tables[0];
                    if (ObjReadDatosEscaneo.DtResultados.Rows.Count == 1)
                    {
                        foreach (DataRow dr in ObjReadDatosEscaneo.DtResultados.Rows)
                        {
                            try
                            {
                                ObjReadDatosEscaneo.OrdenProduccion = dr["ordenproduccion"].ToString();
                                ObjReadDatosEscaneo.OrdenFrabricacion = Convert.ToInt16(dr["ordenfabricacion"].ToString());
                                ObjReadDatosEscaneo.Estatus = Convert.ToChar(dr["estatus"].ToString());
                                ObjReadDatosEscaneo.Pedido = Convert.ToInt16(dr["pedido"].ToString());
                                ObjReadDatosEscaneo.U_Argns_Mod = dr["U_ARGNS_MOD"].ToString();
                                ObjReadDatosEscaneo.Estilo = dr["ESTILO"].ToString();
                                ObjReadDatosEscaneo.U_Argns_Col = dr["U_ARGNS_COL"].ToString();
                                ObjReadDatosEscaneo.Color = dr["COLOR"].ToString();
                                ObjReadDatosEscaneo.USA = dr["USA"].ToString();
                                ObjReadDatosEscaneo.ItemNo = dr["ITEMNO"].ToString();
                                ObjReadDatosEscaneo.Codigo = dr["CODIGO"].ToString();
                                ObjReadDatosEscaneo.Cantidad = Convert.ToDouble(dr["CANTIDAD"].ToString());
                                ObjReadDatosEscaneo.Genero = dr["pedido"].ToString();
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
                ObjReadDatosEscaneo.MsjError = ObjDataBase.MensajeErrorDB;
            }
        }
        #endregion
    }
}
