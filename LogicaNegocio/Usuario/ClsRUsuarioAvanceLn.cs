using AccesoDatos.DataBase;
using Entidades.Usuario;
using System;
using System.Data;

namespace LogicaNegocio.Usuario
{
    public class ClsRUsuarioAvanceLn
    {
        #region Variables Privadas
        private ClsDataBase ObjDataBase = null;
        private string Log;
        private bool bIndex;
        #endregion

        #region Metodos Index
        public void Index(ref ClsRUsuarioAvance ObjRUsuarioAvance)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "RUsuarioAvance",
                NombreSP = "dbo.SP_RUsuarioAvance_Index",
                Scalar = false
            };

            bIndex = true;
            ObjDataBase.DtParametros.Rows.Add(@"@Usuario", "18", ObjRUsuarioAvance.Usuario);
            Ejecutar(ref ObjRUsuarioAvance);
        }

        public void IndexId(ref ClsRUsuarioAvance ObjRUsuarioAvance)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "RUsuarioAvance",
                NombreSP = "dbo.SP_RUsuarioAvance_IndexId",
                Scalar = false
            };

            bIndex = true;
            ObjDataBase.DtParametros.Rows.Add(@"@Usuario", "4", ObjRUsuarioAvance.UserId);
            Ejecutar(ref ObjRUsuarioAvance);
        }
        #endregion

        #region CRUD RUsuarioAvance
        public void Create(ref ClsRUsuarioAvance ObjRUsuarioAvance)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "RUsuarioAvance",
                NombreSP = "dbo.SP_RUsuarioAvance_Create",
                Scalar = false
            };

            ObjDataBase.DtParametros.Rows.Add(@"@UserId", "4", ObjRUsuarioAvance.UserId);
            ObjDataBase.DtParametros.Rows.Add(@"@Area", "15", ObjRUsuarioAvance.Area);
            ObjDataBase.DtParametros.Rows.Add(@"@AvanceId", "9", ObjRUsuarioAvance.AvanceId);

            Ejecutar(ref ObjRUsuarioAvance);
        }

        public void Read(ref ClsRUsuarioAvance ObjRUsuarioAvance)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "RUsuarioAvance",
                NombreSP = "dbo.SP_RUsuarioAvance_Read",
                Scalar = false
            };

            bIndex = false;
            ObjDataBase.DtParametros.Rows.Add(@"@UserId", "4", ObjRUsuarioAvance.UserId);
            ObjDataBase.DtParametros.Rows.Add(@"@Area", "15", ObjRUsuarioAvance.Area);
            ObjDataBase.DtParametros.Rows.Add(@"@AvanceId", "9", ObjRUsuarioAvance.AvanceId);
            Ejecutar(ref ObjRUsuarioAvance);
        }

        public void ReadVal(ref ClsRUsuarioAvance ObjRUsuarioAvance)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "RUsuarioAvance",
                NombreSP = "dbo.SP_RUsuarioAvance_ReadVal",
                Scalar = false
            };

            bIndex = true;
            ObjDataBase.DtParametros.Rows.Add(@"@Area", "15", ObjRUsuarioAvance.Area);
            ObjDataBase.DtParametros.Rows.Add(@"@AvanceId", "9", ObjRUsuarioAvance.AvanceId);
            Ejecutar(ref ObjRUsuarioAvance);
        }

        public void Update(ref ClsRUsuarioAvance ObjRUsuarioAvance)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "RUsuarioAvance",
                NombreSP = "dbo.SP_RUsuarioAvance_Update",
                Scalar = true
            };

            ObjDataBase.DtParametros.Rows.Add(@"@UserId", "4", ObjRUsuarioAvance.UserId);
            ObjDataBase.DtParametros.Rows.Add(@"@Area", "15", ObjRUsuarioAvance.Area);
            ObjDataBase.DtParametros.Rows.Add(@"@AvanceId", "9", ObjRUsuarioAvance.AvanceId);
            ObjDataBase.DtParametros.Rows.Add(@"@CambioUserId", "4", ObjRUsuarioAvance.CambioUserId);
            ObjDataBase.DtParametros.Rows.Add(@"@CambioArea", "15", ObjRUsuarioAvance.CambioArea);
            ObjDataBase.DtParametros.Rows.Add(@"@CambioAvanceId", "9", ObjRUsuarioAvance.CambioAvanceId);

            Ejecutar(ref ObjRUsuarioAvance);
        }

        public void Delete(ref ClsRUsuarioAvance ObjRUsuarioAvance)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "RUsuarioAvance",
                NombreSP = "dbo.SP_RUsuarioAvance_Delete",
                Scalar = true
            };

            ObjDataBase.DtParametros.Rows.Add(@"@UserId", "4", ObjRUsuarioAvance.UserId);
            ObjDataBase.DtParametros.Rows.Add(@"@Area", "15", ObjRUsuarioAvance.Area);
            ObjDataBase.DtParametros.Rows.Add(@"@AvanceId", "9", ObjRUsuarioAvance.AvanceId);

            Ejecutar(ref ObjRUsuarioAvance);
        }
        #endregion

        #region Metodos Privados
        private void Ejecutar(ref ClsRUsuarioAvance ObjRUsuarioAvance)
        {
            ObjDataBase.CRUD(ref ObjDataBase);

            if (ObjDataBase.MensajeErrorDB == null)
            {
                if (ObjDataBase.Scalar)
                {
                    ObjRUsuarioAvance.ValorEscalar = ObjDataBase.ValorScalar;
                }
                else
                {
                    ObjRUsuarioAvance.DtResultados = ObjDataBase.DsResultados.Tables[0];
                    if (ObjRUsuarioAvance.DtResultados.Rows.Count == 1 && bIndex == false)
                    {
                        foreach (DataRow dr in ObjRUsuarioAvance.DtResultados.Rows)
                        {
                            try
                            {
                                ObjRUsuarioAvance.UserId = Convert.ToInt16(dr["UserId"].ToString());
                                ObjRUsuarioAvance.Area = Convert.ToChar(dr["Area"].ToString());
                                ObjRUsuarioAvance.AvanceId = Convert.ToSingle(dr["AvanceId"].ToString());
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
                ObjRUsuarioAvance.MsjError = ObjDataBase.MensajeErrorDB;
            }
        }
        #endregion
    }
}
