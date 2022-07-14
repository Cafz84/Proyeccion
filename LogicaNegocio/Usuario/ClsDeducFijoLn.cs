using AccesoDatos.DataBase;
using Entidades.Usuario;
using System;
using System.Data;

namespace LogicaNegocio.Usuario
{
    public class ClsDeducFijoLn
    {
        #region Variables Privadas
        private ClsDataBase ObjDataBase = null;
        private string Log;
        private bool bIndex;
        #endregion

        #region Metodo Index
        public void Index(ref ClsDeducFijo ObjDeducFijo)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "DeducFija",
                NombreSP = "dbo.SP_DeducFija_Index",
                Scalar = false
            };

            bIndex = true;
            ObjDataBase.DtParametros.Rows.Add(@"@U_EmpId", "4", ObjDeducFijo.U_EmpId);
            Ejecutar(ref ObjDeducFijo);
        }
        #endregion

        #region CRUD Aportaciones
        public void Create(ref ClsDeducFijo ObjDeducFijo)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "DeducFija",
                NombreSP = "dbo.SP_DeducFija_Create",
                Scalar = false
            };

            ObjDataBase.DtParametros.Rows.Add(@"@U_EmpId", "4", ObjDeducFijo.U_EmpId);
            ObjDataBase.DtParametros.Rows.Add(@"@U_IdDeduccion", "4", ObjDeducFijo.U_IdDeduccion);
            ObjDataBase.DtParametros.Rows.Add(@"@Costo", "9", ObjDeducFijo.Costo);

            Ejecutar(ref ObjDeducFijo);
        }

        public void Read(ref ClsDeducFijo ObjDeducFijo)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "DeducFija",
                NombreSP = "dbo.SP_DeducFija_Read",
                Scalar = false
            };

            bIndex = false;
            ObjDataBase.DtParametros.Rows.Add(@"@U_EmpId", "4", ObjDeducFijo.U_EmpId);
            ObjDataBase.DtParametros.Rows.Add(@"@U_IdDeduccion", "4", ObjDeducFijo.U_IdDeduccion);
            Ejecutar(ref ObjDeducFijo);
        }

        public void Update(ref ClsDeducFijo ObjDeducFijo)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "DeducFija",
                NombreSP = "dbo.SP_DeducFija_Update",
                Scalar = true
            };

            ObjDataBase.DtParametros.Rows.Add(@"@U_EmpId", "4", ObjDeducFijo.U_EmpId);
            ObjDataBase.DtParametros.Rows.Add(@"@U_IdDeduccion", "4", ObjDeducFijo.U_IdDeduccion);
            ObjDataBase.DtParametros.Rows.Add(@"@Costo", "9", ObjDeducFijo.Costo);

            Ejecutar(ref ObjDeducFijo);
        }

        public void Delete(ref ClsDeducFijo ObjDeducFijo)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "DeducFija",
                NombreSP = "dbo.SP_DeducFija_Delete",
                Scalar = true
            };

            ObjDataBase.DtParametros.Rows.Add(@"@U_EmpId", "4", ObjDeducFijo.U_EmpId);
            ObjDataBase.DtParametros.Rows.Add(@"@U_IdDeduccion", "4", ObjDeducFijo.U_IdDeduccion);
            Ejecutar(ref ObjDeducFijo);
        }
        #endregion

        #region Metodos Privados
        private void Ejecutar(ref ClsDeducFijo ObjDeducFijo)
        {
            ObjDataBase.CRUD(ref ObjDataBase);

            if (ObjDataBase.MensajeErrorDB == null)
            {
                if (ObjDataBase.Scalar)
                {
                    ObjDeducFijo.ValorEscalar = ObjDataBase.ValorScalar;
                }
                else
                {
                    ObjDeducFijo.DtResultados = ObjDataBase.DsResultados.Tables[0];
                    if (ObjDeducFijo.DtResultados.Rows.Count == 1 && bIndex == false)
                    {
                        foreach (DataRow dr in ObjDeducFijo.DtResultados.Rows)
                        {
                            try
                            {
                                ObjDeducFijo.U_EmpId = Convert.ToByte(dr["U_EmpId"].ToString());
                                ObjDeducFijo.U_IdDeduccion = Convert.ToByte(dr["U_IdDeduccion"].ToString());
                                ObjDeducFijo.Costo = Convert.ToSingle(dr["Costo"].ToString());
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
                ObjDeducFijo.MsjError = ObjDataBase.MensajeErrorDB;
            }
        }
        #endregion
    }
}
