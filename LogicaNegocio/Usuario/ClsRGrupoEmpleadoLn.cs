using AccesoDatos.DataBase;
using Entidades.Usuario;
using System;
using System.Data;

namespace LogicaNegocio.Usuario
{
    public class ClsRGrupoEmpleadoLn
    {
        #region Variables Privadas
        private ClsDataBase ObjDataBase = null;
        private string Log;
        private bool bIndex;
        #endregion

        #region Metodos Index
        public void Index(ref ClsRGrupoEmpleado ObjRGrupoEmpleado)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "RGrupoEmpleado",
                NombreSP = "dbo.SP_RGrupoEmpleado_Index",
                Scalar = false
            };

            bIndex = true;
            ObjDataBase.DtParametros.Rows.Add(@"@Grupo", "18", ObjRGrupoEmpleado.Grupo);
            Ejecutar(ref ObjRGrupoEmpleado);
        }
        #endregion

        #region CRUD RGrupoEmpleado
        public void Create(ref ClsRGrupoEmpleado ObjRGrupoEmpleado)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "RGrupoEmpleado",
                NombreSP = "dbo.SP_RGrupoEmpleado_Create",
                Scalar = false
            };

            ObjDataBase.DtParametros.Rows.Add(@"@U_GrupoId", "4", ObjRGrupoEmpleado.U_GrupoId);
            ObjDataBase.DtParametros.Rows.Add(@"@U_EmpId", "4", ObjRGrupoEmpleado.U_EmpId);
            ObjDataBase.DtParametros.Rows.Add(@"@Porcentaje", "9", ObjRGrupoEmpleado.Porcentaje);

            Ejecutar(ref ObjRGrupoEmpleado);
        }

        public void Read(ref ClsRGrupoEmpleado ObjRGrupoEmpleado)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "RGrupoEmpleado",
                NombreSP = "dbo.SP_RGrupoEmpleado_Read",
                Scalar = false
            };

            bIndex = false;
            ObjDataBase.DtParametros.Rows.Add(@"@U_GrupoId", "4", ObjRGrupoEmpleado.U_GrupoId);
            ObjDataBase.DtParametros.Rows.Add(@"@U_EmpId", "4", ObjRGrupoEmpleado.U_EmpId);

            Ejecutar(ref ObjRGrupoEmpleado);
        }

        public void Update(ref ClsRGrupoEmpleado ObjRGrupoEmpleado)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "RGrupoEmpleado",
                NombreSP = "dbo.SP_RGrupoEmpleado_Update",
                Scalar = true
            };

            ObjDataBase.DtParametros.Rows.Add(@"@U_GrupoId", "4", ObjRGrupoEmpleado.U_GrupoId);
            ObjDataBase.DtParametros.Rows.Add(@"@U_EmpId", "4", ObjRGrupoEmpleado.U_EmpId);
            ObjDataBase.DtParametros.Rows.Add(@"@C_GrupoId", "4", ObjRGrupoEmpleado.C_GrupoId);
            ObjDataBase.DtParametros.Rows.Add(@"@C_EmpId", "4", ObjRGrupoEmpleado.C_EmpId);
            ObjDataBase.DtParametros.Rows.Add(@"@Porcentaje", "9", ObjRGrupoEmpleado.Porcentaje);

            Ejecutar(ref ObjRGrupoEmpleado);
        }

        public void Delete(ref ClsRGrupoEmpleado ObjRGrupoEmpleado)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "ObjRGrupoEmpleado",
                NombreSP = "dbo.SP_ObjRGrupoEmpleado_Delete",
                Scalar = true
            };

            ObjDataBase.DtParametros.Rows.Add(@"@U_GrupoId", "4", ObjRGrupoEmpleado.U_GrupoId);
            ObjDataBase.DtParametros.Rows.Add(@"@U_EmpId", "4", ObjRGrupoEmpleado.U_EmpId);

            Ejecutar(ref ObjRGrupoEmpleado);
        }
        #endregion

        #region Metodos Privados
        private void Ejecutar(ref ClsRGrupoEmpleado ObjRGrupoEmpleado)
        {
            ObjDataBase.CRUD(ref ObjDataBase);

            if (ObjDataBase.MensajeErrorDB == null)
            {
                if (ObjDataBase.Scalar)
                {
                    ObjRGrupoEmpleado.ValorEscalar = ObjDataBase.ValorScalar;
                }
                else
                {
                    ObjRGrupoEmpleado.DtResultados = ObjDataBase.DsResultados.Tables[0];
                    if (ObjRGrupoEmpleado.DtResultados.Rows.Count == 1 && bIndex == false)
                    {
                        foreach (DataRow dr in ObjRGrupoEmpleado.DtResultados.Rows)
                        {
                            try
                            {
                                ObjRGrupoEmpleado.U_GrupoId = Convert.ToInt32(dr["U_GrupoId"].ToString());
                                ObjRGrupoEmpleado.U_EmpId = Convert.ToInt16(dr["U_EmpId"].ToString());
                                ObjRGrupoEmpleado.Porcentaje = Convert.ToSingle(dr["Porcentaje"].ToString());
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
                ObjRGrupoEmpleado.MsjError = ObjDataBase.MensajeErrorDB;
            }
        }
        #endregion
    }
}
