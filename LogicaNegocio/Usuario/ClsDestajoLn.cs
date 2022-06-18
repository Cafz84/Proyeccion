using AccesoDatos.DataBase;
using Entidades.Usuario;
using System;
using System.Data;

namespace LogicaNegocio.Usuario
{
    public class ClsDestajoLn
    {
        #region Variables Privadas
        private ClsDataBase ObjDataBase = null;
        private string Log;
        #endregion

        #region Metodos Index
        public void Index(ref ClsDestajo ObjDestajo)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "DB_BasePruebas",
                NombreTabla = "Destajo",
                NombreSP = "dbo.SP_Destajo_Index",
                Scalar = false
            };

            Ejecutar(ref ObjDestajo);
        }
        #endregion

        #region CRUD Destajo
        public void ReadPagados(ref ClsDestajo ObjDestajo)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "DB_BasePruebas",
                NombreTabla = "Destajo",
                NombreSP = "dbo.SP_DestajoPagados_Read",
                Scalar = false
            };

            ObjDataBase.DtParametros.Rows.Add(@"@Programa", "18", ObjDestajo.Programa);
            ObjDataBase.DtParametros.Rows.Add(@"@UFraccId", "4", ObjDestajo.UFraccId);
            EjecutarPagados(ref ObjDestajo);
        }
        #endregion

        #region Metodos Privados
        private void Ejecutar(ref ClsDestajo ObjDestajo)
        {
            ObjDataBase.CRUD(ref ObjDataBase);

            if (ObjDataBase.MensajeErrorDB == null)
            {
                if (ObjDataBase.Scalar)
                {
                    ObjDestajo.ValorEscalar = ObjDataBase.ValorScalar;
                }
                else
                {
                    ObjDestajo.DtResultados = ObjDataBase.DsResultados.Tables[0];
                    if (ObjDestajo.DtResultados.Rows.Count == 1)
                    {
                        foreach (DataRow dr in ObjDestajo.DtResultados.Rows)
                        {
                            try
                            {
                                ObjDestajo.UEmpId = Convert.ToInt16(dr["UEmpId"].ToString());
                                ObjDestajo.Nombre = dr["Nombre"].ToString();
                                ObjDestajo.UFraccId = Convert.ToInt16(dr["UFraccId"].ToString());
                                ObjDestajo.Programa = dr["Programa"].ToString();
                                ObjDestajo.UEstilo = dr["Estilo"].ToString();
                                ObjDestajo.UColor = dr["Color"].ToString();
                                ObjDestajo.Cantidad = Convert.ToSingle(dr["Cantidad"].ToString());
                                ObjDestajo.FechaCaptura = Convert.ToDateTime(dr["FechaCaptura"].ToString());
                                ObjDestajo.Semana = Convert.ToInt16(dr["Semana"].ToString());
                                ObjDestajo.UFracCosto = Convert.ToSingle(dr["UFracCosto"].ToString());
                                ObjDestajo.UCantidadFE = Convert.ToInt16(dr["UCAntidadFE"].ToString());
                                ObjDestajo.Pago = Convert.ToSingle(dr["Pago"].ToString());
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
                ObjDestajo.MsjError = ObjDataBase.MensajeErrorDB;
            }
        }

        private void EjecutarPagados(ref ClsDestajo ObjDestajo)
        {
            ObjDataBase.CRUD(ref ObjDataBase);

            if (ObjDataBase.MensajeErrorDB == null)
            {
                if (ObjDataBase.Scalar)
                {
                    ObjDestajo.ValorEscalar = ObjDataBase.ValorScalar;
                }
                else
                {
                    ObjDestajo.DtResultados = ObjDataBase.DsResultados.Tables[0];
                    if (ObjDestajo.DtResultados.Rows.Count == 1)
                    {
                        foreach (DataRow dr in ObjDestajo.DtResultados.Rows)
                        {
                            try
                            {
                                if (dr["Pagado"] == DBNull.Value)
                                    ObjDestajo.Pagado = 0;
                                else
                                    ObjDestajo.Pagado = Convert.ToSingle(dr["Pagado"].ToString());
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
                ObjDestajo.MsjError = ObjDataBase.MensajeErrorDB;
            }
        }
        #endregion
    }
}
