using AccesoDatos.DataBase;
using Entidades.Usuario;
using System;
using System.Data;

namespace LogicaNegocio.Usuario
{
    public class ClsAvancesLn
    {
        #region Variables Privadas
        private ClsDataBase ObjDataBase = null;
        private string Log;
        private bool bIndex;
        #endregion

        #region Metodo Index
        public void Index(ref ClsAvances ObjAvances)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "Avances",
                NombreSP = "dbo.SP_Avances_Index",
                Scalar = false
            };

            bIndex = true;
            ObjDataBase.DtParametros.Rows.Add(@"@Codigo", "18", ObjAvances.UCodigo);
            ObjDataBase.DtParametros.Rows.Add(@"@Usuario", "18", ObjAvances.Usuario);
            ObjDataBase.DtParametros.Rows.Add(@"@Estilo", "18", ObjAvances.Estilo);
            ObjDataBase.DtParametros.Rows.Add(@"@Color", "18", ObjAvances.Color);
            ObjDataBase.DtParametros.Rows.Add(@"@Area", "15", ObjAvances.Area);
            Ejecutar(ref ObjAvances);
        }
        #endregion

        #region CRUD Avances
        public void Create(ref ClsAvances ObjAvances)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "Avances",
                NombreSP = "dbo.SP_Avances_Create",
                Scalar = false
            };

            ObjDataBase.DtParametros.Rows.Add(@"@UCodigo", "18", ObjAvances.UCodigo);
            ObjDataBase.DtParametros.Rows.Add(@"@UUserId", "4", ObjAvances.UUserId);
            ObjDataBase.DtParametros.Rows.Add(@"@UAvanceId", "9", ObjAvances.UAvanceId);
            ObjDataBase.DtParametros.Rows.Add(@"@FAvance", "14", ObjAvances.FAvance);
            ObjDataBase.DtParametros.Rows.Add(@"@Tiempo", "18", ObjAvances.Tiempo);

            Ejecutar(ref ObjAvances);
        }

        public void Read(ref ClsAvances ObjAvances)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "Avances",
                NombreSP = "dbo.SP_Avances_Read",
                Scalar = false
            };

            bIndex = false;
            ObjDataBase.DtParametros.Rows.Add(@"@UCodigo", "18", ObjAvances.UCodigo);
            ObjDataBase.DtParametros.Rows.Add(@"@UUserId", "4", ObjAvances.UUserId);
            ObjDataBase.DtParametros.Rows.Add(@"@UAvanceId", "9", ObjAvances.UAvanceId);
            Ejecutar(ref ObjAvances);
        }

        public void ReadUserCod(ref ClsAvances ObjAvances)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "Avances",
                NombreSP = "dbo.SP_Avances_ReadUserCod",
                Scalar = false
            };

            bIndex = false;
            ObjDataBase.DtParametros.Rows.Add(@"@UCodigo", "18", ObjAvances.UCodigo);
            ObjDataBase.DtParametros.Rows.Add(@"@UUserId", "4", ObjAvances.UUserId);
            Ejecutar(ref ObjAvances);
        }

        public void ReadSeguir(ref ClsAvances ObjAvances)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "Avances",
                NombreSP = "dbo.SP_Avances_ReadSeguir",
                Scalar = false
            };

            bIndex = true;
            ObjDataBase.DtParametros.Rows.Add(@"@UCodigo", "18", ObjAvances.UCodigo);
            Ejecutar(ref ObjAvances);
        }

        public void Update(ref ClsAvances ObjAvances)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "Avances",
                NombreSP = "dbo.SP_Avances_Update",
                Scalar = true
            };

            ObjDataBase.DtParametros.Rows.Add(@"@UCodigo", "18", ObjAvances.UCodigo);
            ObjDataBase.DtParametros.Rows.Add(@"@UUserId", "4", ObjAvances.UUserId);
            ObjDataBase.DtParametros.Rows.Add(@"@UAvanceId", "9", ObjAvances.UAvanceId);
            ObjDataBase.DtParametros.Rows.Add(@"@FAvance", "14", ObjAvances.FAvance);
            ObjDataBase.DtParametros.Rows.Add(@"@Tiempo", "18", ObjAvances.Tiempo);

            Ejecutar(ref ObjAvances);
        }

        public void Delete(ref ClsAvances ObjAvances)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "Avances",
                NombreSP = "dbo.SP_Avances_Delete",
                Scalar = true
            };

            ObjDataBase.DtParametros.Rows.Add(@"@UCodigo", "18", ObjAvances.UCodigo);
            ObjDataBase.DtParametros.Rows.Add(@"@UUserId", "4", ObjAvances.UUserId);
            ObjDataBase.DtParametros.Rows.Add(@"@UAvanceId", "9", ObjAvances.UAvanceId);

            Ejecutar(ref ObjAvances);
        }
        #endregion

        #region Metodos Privados
        private void Ejecutar(ref ClsAvances ObjAvances)
        {
            ObjDataBase.CRUD(ref ObjDataBase);

            if (ObjDataBase.MensajeErrorDB == null)
            {
                if (ObjDataBase.Scalar)
                {
                    ObjAvances.ValorEscalar = ObjDataBase.ValorScalar;
                }
                else
                {
                    ObjAvances.DtResultados = ObjDataBase.DsResultados.Tables[0];
                    if (ObjAvances.DtResultados.Rows.Count == 1 && bIndex == false)
                    {
                        foreach (DataRow dr in ObjAvances.DtResultados.Rows)
                        {
                            try
                            {
                                ObjAvances.UCodigo = dr["UCodigo"].ToString();
                                ObjAvances.UUserId = Convert.ToInt16(dr["UUserId"].ToString());
                                ObjAvances.UAvanceId = Convert.ToSingle(dr["FAvance"].ToString());
                                ObjAvances.FAvance = Convert.ToDateTime(dr["Activo"].ToString());
                                ObjAvances.Tiempo = dr["Tiempo"].ToString();
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
                ObjAvances.MsjError = ObjDataBase.MensajeErrorDB;
            }
        }
        #endregion
    }
}
