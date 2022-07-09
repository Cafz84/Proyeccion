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
        private bool bIndex;
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

            bIndex = true;
            ObjDataBase.DtParametros.Rows.Add(@"@Semana", "4", ObjDestajo.Semana);
            ObjDataBase.DtParametros.Rows.Add(@"@Nombre", "18", ObjDestajo.Nombre);
            ObjDataBase.DtParametros.Rows.Add(@"@Fraccion", "18", ObjDestajo.Fraccion);
            Ejecutar(ref ObjDestajo);
        }

        public void IndexBNombre(ref ClsDestajo ObjDestajo)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "DB_BasePruebas",
                NombreTabla = "Destajo",
                NombreSP = "dbo.SP_Destajo_IndexBNombre",
                Scalar = false
            };

            ObjDataBase.DtParametros.Rows.Add(@"@Nombre", "18", ObjDestajo.Nombre);
            Ejecutar(ref ObjDestajo);
        }

        public void IndexRD(ref ClsDestajo ObjDestajo)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "DB_BasePruebas",
                NombreTabla = "Destajo",
                NombreSP = "dbo.SP_Destajo_IndexRevision",
                Scalar = false
            };

            bIndex = true;
            ObjDataBase.DtParametros.Rows.Add(@"@Semana", "4", ObjDestajo.Semana);
            ObjDataBase.DtParametros.Rows.Add(@"@Nombre", "18", ObjDestajo.Nombre);
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

        public void Create(ref ClsDestajo ObjDestajo)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "DB_BasePruebas",
                NombreTabla = "Destajo",
                NombreSP = "dbo.SP_Destajo_Create",
                Scalar = true
            };

            ObjDataBase.DtParametros.Rows.Add(@"@UEmpId", "4", ObjDestajo.UEmpId);
            ObjDataBase.DtParametros.Rows.Add(@"@UFraccId", "4", ObjDestajo.UFraccId);
            ObjDataBase.DtParametros.Rows.Add(@"@UEstilo", "18", ObjDestajo.UEstilo);
            ObjDataBase.DtParametros.Rows.Add(@"@Programa", "18", ObjDestajo.Programa);
            ObjDataBase.DtParametros.Rows.Add(@"@UColor", "18", ObjDestajo.UColor);
            ObjDataBase.DtParametros.Rows.Add(@"@Cantidad", "9", ObjDestajo.Cantidad);
            ObjDataBase.DtParametros.Rows.Add(@"@FechaCaptura", "14", ObjDestajo.FechaCaptura);
            ObjDataBase.DtParametros.Rows.Add(@"@Semana", "3", ObjDestajo.Semana);
            ObjDataBase.DtParametros.Rows.Add(@"@Pago", "9", ObjDestajo.Pago);
            ObjDataBase.DtParametros.Rows.Add(@"@UFracCosto", "9", ObjDestajo.UFracCosto);
            ObjDataBase.DtParametros.Rows.Add(@"@UCantidadFE", "4", ObjDestajo.UCantidadFE);
            
            Ejecutar(ref ObjDestajo);
        }

        public void Read(ref ClsDestajo ObjDestajo)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "DB_BasePruebas",
                NombreTabla = "Destajo",
                NombreSP = "dbo.SP_Destajo_Read",
                Scalar = false
            };

            bIndex = false;
            ObjDataBase.DtParametros.Rows.Add(@"@UEmpId", "4", ObjDestajo.UEmpId);
            ObjDataBase.DtParametros.Rows.Add(@"@UFraccId", "4", ObjDestajo.UFraccId);
            ObjDataBase.DtParametros.Rows.Add(@"@UEstilo", "18", ObjDestajo.UEstilo);
            ObjDataBase.DtParametros.Rows.Add(@"@Programa", "18", ObjDestajo.Programa);
            ObjDataBase.DtParametros.Rows.Add(@"@Semana", "3", ObjDestajo.Semana);
            Ejecutar(ref ObjDestajo);
        }

        public void Update(ref ClsDestajo ObjDestajo)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "DB_BasePruebas",
                NombreTabla = "Destajo",
                NombreSP = "dbo.SP_Destajo_Update",
                Scalar = true
            };

            ObjDataBase.DtParametros.Rows.Add(@"@UEmpId", "4", ObjDestajo.UEmpId);
            ObjDataBase.DtParametros.Rows.Add(@"@UFraccId", "4", ObjDestajo.UFraccId);
            ObjDataBase.DtParametros.Rows.Add(@"@UEstilo", "18", ObjDestajo.UEstilo);
            ObjDataBase.DtParametros.Rows.Add(@"@Programa", "18", ObjDestajo.Programa);
            ObjDataBase.DtParametros.Rows.Add(@"@UColor", "18", ObjDestajo.UColor);
            ObjDataBase.DtParametros.Rows.Add(@"@Cantidad", "9", ObjDestajo.Cantidad);
            ObjDataBase.DtParametros.Rows.Add(@"@FechaCaptura", "14", ObjDestajo.FechaCaptura);
            ObjDataBase.DtParametros.Rows.Add(@"@Semana", "3", ObjDestajo.Semana);
            ObjDataBase.DtParametros.Rows.Add(@"@Pago", "9", ObjDestajo.Pago);
            ObjDataBase.DtParametros.Rows.Add(@"@UFracCosto", "9", ObjDestajo.UFracCosto);
            ObjDataBase.DtParametros.Rows.Add(@"@UCantidadFE", "4", ObjDestajo.UCantidadFE);
            ObjDataBase.DtParametros.Rows.Add(@"@CEmpId", "4", ObjDestajo.CEmpId);
            ObjDataBase.DtParametros.Rows.Add(@"@CFraccId", "4", ObjDestajo.CFraccId);
            ObjDataBase.DtParametros.Rows.Add(@"@CEstilo", "18", ObjDestajo.CEmpId);
            ObjDataBase.DtParametros.Rows.Add(@"@CPrograma", "18", ObjDestajo.CPrograma);
            ObjDataBase.DtParametros.Rows.Add(@"@CSemana", "3", ObjDestajo.CSemana);
            Ejecutar(ref ObjDestajo);
        }

        public void Delete(ref ClsDestajo ObjDestajo)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "DB_BasePruebas",
                NombreTabla = "Destajo",
                NombreSP = "dbo.SP_Destajo_Delete",
                Scalar = true
            };

            ObjDataBase.DtParametros.Rows.Add(@"@UEmpId", "4", ObjDestajo.UEmpId);
            ObjDataBase.DtParametros.Rows.Add(@"@UFraccId", "4", ObjDestajo.UFraccId);
            ObjDataBase.DtParametros.Rows.Add(@"@UEstilo", "18", ObjDestajo.UEstilo);
            ObjDataBase.DtParametros.Rows.Add(@"@Programa", "18", ObjDestajo.Programa);
            ObjDataBase.DtParametros.Rows.Add(@"@Semana", "3", ObjDestajo.Semana);
            Ejecutar(ref ObjDestajo);
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
                    if (ObjDestajo.DtResultados.Rows.Count == 1 && bIndex == false)
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
