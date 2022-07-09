using AccesoDatos.DataBase;
using Entidades.Usuario;
using System;
using System.Data;

namespace LogicaNegocio.Usuario
{
    public class ClsAportEmpLn
    {
        #region Variables Privadas
        private ClsDataBase ObjDataBase = null;
        private string Log;
        private bool bIndex;
        #endregion

        #region Metodo Index
        public void Index(ref ClsAportEmp ObjAportEmp)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "DB_BasePruebas",
                NombreTabla = "AportEmp",
                NombreSP = "dbo.SP_AportEmp_Index",
                Scalar = false
            };

            bIndex = true;
            ObjDataBase.DtParametros.Rows.Add(@"@U_Semana", "4", ObjAportEmp.U_Semana);
            ObjDataBase.DtParametros.Rows.Add(@"@U_EmpId", "4", ObjAportEmp.U_EmpId);
            Ejecutar(ref ObjAportEmp);
        }
        #endregion

        #region CRUD Aportaciones
        public void Create(ref ClsAportEmp ObjAportEmp)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "DB_BasePruebas",
                NombreTabla = "AportEmp",
                NombreSP = "dbo.SP_AportEmp_Create",
                Scalar = false
            };

            ObjDataBase.DtParametros.Rows.Add(@"@U_Semana", "4", ObjAportEmp.U_Semana);
            ObjDataBase.DtParametros.Rows.Add(@"@U_EmpId", "4", ObjAportEmp.U_EmpId);
            ObjDataBase.DtParametros.Rows.Add(@"@U_IdAportacion", "4", ObjAportEmp.U_IdAportacion);
            ObjDataBase.DtParametros.Rows.Add(@"@Costo", "9", ObjAportEmp.Costo);

            Ejecutar(ref ObjAportEmp);
        }

        public void Read(ref ClsAportEmp ObjAportEmp)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "DB_BasePruebas",
                NombreTabla = "AportEmp",
                NombreSP = "dbo.SP_AportEmp_Read",
                Scalar = false
            };

            bIndex = false;
            ObjDataBase.DtParametros.Rows.Add(@"@U_Semana", "4", ObjAportEmp.U_Semana);
            ObjDataBase.DtParametros.Rows.Add(@"@U_EmpId", "4", ObjAportEmp.U_EmpId);
            Ejecutar(ref ObjAportEmp);
        }

        public void Update(ref ClsAportEmp ObjAportEmp)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "DB_BasePruebas",
                NombreTabla = "AportEmp",
                NombreSP = "dbo.SP_AportEmp_Update",
                Scalar = true
            };

            ObjDataBase.DtParametros.Rows.Add(@"@U_Semana", "4", ObjAportEmp.U_Semana);
            ObjDataBase.DtParametros.Rows.Add(@"@U_EmpId", "4", ObjAportEmp.U_EmpId);
            ObjDataBase.DtParametros.Rows.Add(@"@U_IdAportacion", "4", ObjAportEmp.U_IdAportacion);
            ObjDataBase.DtParametros.Rows.Add(@"@Costo", "9", ObjAportEmp.Costo);

            Ejecutar(ref ObjAportEmp);
        }

        public void Delete(ref ClsAportEmp ObjAportEmp)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "DB_BasePruebas",
                NombreTabla = "AportEmp",
                NombreSP = "dbo.SP_AportEmp_Delete",
                Scalar = true
            };

            ObjDataBase.DtParametros.Rows.Add(@"@U_Semana", "4", ObjAportEmp.U_Semana);
            ObjDataBase.DtParametros.Rows.Add(@"@U_EmpId", "4", ObjAportEmp.U_EmpId);
            Ejecutar(ref ObjAportEmp);
        }
        #endregion

        #region Metodos Privados
        private void Ejecutar(ref ClsAportEmp ObjAportEmp)
        {
            ObjDataBase.CRUD(ref ObjDataBase);

            if (ObjDataBase.MensajeErrorDB == null)
            {
                if (ObjDataBase.Scalar)
                {
                    ObjAportEmp.ValorEscalar = ObjDataBase.ValorScalar;
                }
                else
                {
                    ObjAportEmp.DtResultados = ObjDataBase.DsResultados.Tables[0];
                    if (ObjAportEmp.DtResultados.Rows.Count == 1 && bIndex == false)
                    {
                        foreach (DataRow dr in ObjAportEmp.DtResultados.Rows)
                        {
                            try
                            {
                                ObjAportEmp.U_EmpId = Convert.ToByte(dr["U_EmpId"].ToString());
                                ObjAportEmp.U_Semana = Convert.ToByte(dr["U_Semana"].ToString());
                                ObjAportEmp.U_IdAportacion = Convert.ToByte(dr["U_IdAportacion"].ToString());
                                ObjAportEmp.Costo = Convert.ToSingle(dr["Costo"].ToString());
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
                ObjAportEmp.MsjError = ObjDataBase.MensajeErrorDB;
            }
        }
        #endregion
    }
}
