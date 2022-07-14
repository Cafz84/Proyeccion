using AccesoDatos.DataBase;
using Entidades.Usuario;
using System;
using System.Data;

namespace LogicaNegocio.Usuario
{
    public class ClsDeducEmpLn
    {
        #region Variables Privadas
        private ClsDataBase ObjDataBase = null;
        private string Log;
        private bool bIndex;
        #endregion

        #region Metodo Index
        public void Index(ref ClsDeducEmp ObjDeducEmp)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "DeducEmp",
                NombreSP = "dbo.SP_DeducEmp_Index",
                Scalar = false
            };

            bIndex = true;
            ObjDataBase.DtParametros.Rows.Add(@"@U_Semana", "4", ObjDeducEmp.U_Semana);
            ObjDataBase.DtParametros.Rows.Add(@"@U_EmpId", "4", ObjDeducEmp.U_EmpId);
            Ejecutar(ref ObjDeducEmp);
        }
        #endregion

        #region CRUD Aportaciones
        public void Create(ref ClsDeducEmp ObjDeducEmp)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "DeducEmp",
                NombreSP = "dbo.SP_DeducEmp_Create",
                Scalar = false
            };

            ObjDataBase.DtParametros.Rows.Add(@"@U_Semana", "4", ObjDeducEmp.U_Semana);
            ObjDataBase.DtParametros.Rows.Add(@"@U_EmpId", "4", ObjDeducEmp.U_EmpId);
            ObjDataBase.DtParametros.Rows.Add(@"@U_IdDeduccion", "4", ObjDeducEmp.U_IdDeduccion);
            ObjDataBase.DtParametros.Rows.Add(@"@Costo", "9", ObjDeducEmp.Costo);

            Ejecutar(ref ObjDeducEmp);
        }

        public void Read(ref ClsDeducEmp ObjDeducEmp)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "DeducEmp",
                NombreSP = "dbo.SP_DeducEmp_Read",
                Scalar = false
            };

            bIndex = false;
            ObjDataBase.DtParametros.Rows.Add(@"@U_Semana", "4", ObjDeducEmp.U_Semana);
            ObjDataBase.DtParametros.Rows.Add(@"@U_EmpId", "4", ObjDeducEmp.U_EmpId);
            ObjDataBase.DtParametros.Rows.Add(@"@U_IdDeduccion", "4", ObjDeducEmp.U_IdDeduccion);
            Ejecutar(ref ObjDeducEmp);
        }

        public void Update(ref ClsDeducEmp ObjDeducEmp)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "DeducEmp",
                NombreSP = "dbo.SP_DeducEmp_Update",
                Scalar = true
            };

            ObjDataBase.DtParametros.Rows.Add(@"@U_Semana", "4", ObjDeducEmp.U_Semana);
            ObjDataBase.DtParametros.Rows.Add(@"@U_EmpId", "4", ObjDeducEmp.U_EmpId);
            ObjDataBase.DtParametros.Rows.Add(@"@U_IdDeduccion", "4", ObjDeducEmp.U_IdDeduccion);
            ObjDataBase.DtParametros.Rows.Add(@"@Costo", "9", ObjDeducEmp.Costo);

            Ejecutar(ref ObjDeducEmp);
        }

        public void Delete(ref ClsDeducEmp ObjDeducEmp)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "DeducEmp",
                NombreSP = "dbo.SP_DeducEmp_Delete",
                Scalar = true
            };

            ObjDataBase.DtParametros.Rows.Add(@"@U_Semana", "4", ObjDeducEmp.U_Semana);
            ObjDataBase.DtParametros.Rows.Add(@"@U_EmpId", "4", ObjDeducEmp.U_EmpId);
            ObjDataBase.DtParametros.Rows.Add(@"@U_IdDeduccion", "4", ObjDeducEmp.U_IdDeduccion);
            Ejecutar(ref ObjDeducEmp);
        }
        #endregion

        #region Metodos Privados
        private void Ejecutar(ref ClsDeducEmp ObjDeducEmp)
        {
            ObjDataBase.CRUD(ref ObjDataBase);

            if (ObjDataBase.MensajeErrorDB == null)
            {
                if (ObjDataBase.Scalar)
                {
                    ObjDeducEmp.ValorEscalar = ObjDataBase.ValorScalar;
                }
                else
                {
                    ObjDeducEmp.DtResultados = ObjDataBase.DsResultados.Tables[0];
                    if (ObjDeducEmp.DtResultados.Rows.Count == 1 && bIndex == false)
                    {
                        foreach (DataRow dr in ObjDeducEmp.DtResultados.Rows)
                        {
                            try
                            {
                                ObjDeducEmp.U_Semana = Convert.ToByte(dr["U_Semana"].ToString());
                                ObjDeducEmp.U_EmpId = Convert.ToByte(dr["U_EmpId"].ToString());
                                ObjDeducEmp.U_IdDeduccion = Convert.ToByte(dr["U_IdDeduccion"].ToString());
                                ObjDeducEmp.Costo = Convert.ToSingle(dr["Costo"].ToString());
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
                ObjDeducEmp.MsjError = ObjDataBase.MensajeErrorDB;
            }
        }
        #endregion
    }
}
