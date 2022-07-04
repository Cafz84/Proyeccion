using AccesoDatos.DataBase;
using Entidades.Usuario;
using System;
using System.Data;

namespace LogicaNegocio.Usuario
{
    public class ClsEmpleadoLn
    {

        #region Variables privadas
        private ClsDataBase ObjDataBase = null;
        #endregion

        #region Metodo Index
        public void Index(ref ClsEmpleado ObjEmpleado)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "DB_BasePruebas",
                NombreTabla = "OHEM",
                NombreSP = "[dbo].[SP_OHEM_Index]",
                Scalar = false
            };

            ObjDataBase.DtParametros.Rows.Add(@"@Nombre", "18", ObjEmpleado.Nombre);
            EjecutarActivoVariable(ref ObjEmpleado);
        }

        public void IndexActivoVariable(ref ClsEmpleado ObjEmpleado)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "DB_BasePruebas",
                NombreTabla = "OHEM",
                NombreSP = "[dbo].[SP_OHEM_IndexActivoVariable]",
                Scalar = false
            };

            ObjDataBase.DtParametros.Rows.Add(@"@Nombre", "18", ObjEmpleado.Nombre);
            EjecutarActivoVariable(ref ObjEmpleado);
        }

        public void IndexRelacion(ref ClsEmpleado ObjEmpleado)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "DB_BasePruebas",
                NombreTabla = "OHEM",
                NombreSP = "[dbo].[SP_OHEM_IndexRelacion]",
                Scalar = false
            };

            ObjDataBase.DtParametros.Rows.Add(@"@Nombre", "18", ObjEmpleado.Nombre);
            EjecutarActivoVariable(ref ObjEmpleado);
        }

        public int? EmpId(ref ClsEmpleado ObjEmpleado)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "DB_BasePruebas",
                NombreTabla = "OHEM",
                NombreSP = "[dbo].[SP_OHEM_EmpID]",
                Scalar = false
            };

            ObtMaxId(ref ObjEmpleado);
            return ObjEmpleado.EmpID+1;
        }
        #endregion

        #region CRUD Empleado
        public void Create(ref ClsEmpleado ObjEmpleado)
        { 
            int? spEmpIdMax = EmpId(ref ObjEmpleado);
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "DB_BasePruebas",
                NombreTabla = "OHEM",
                NombreSP = "[dbo].[SP_OHEM_Create]",
                Scalar = true
            };

            ObjDataBase.DtParametros.Rows.Add(@"@empID", "4", spEmpIdMax);
            ObjDataBase.DtParametros.Rows.Add(@"@middleName", "18", ObjEmpleado.MiddleName);
            ObjDataBase.DtParametros.Rows.Add(@"@firstName", "18", ObjEmpleado.FirstName);
            ObjDataBase.DtParametros.Rows.Add(@"@lastName", "18", ObjEmpleado.LastName);
            ObjDataBase.DtParametros.Rows.Add(@"@sex", "15", ObjEmpleado.Sex);
            ObjDataBase.DtParametros.Rows.Add(@"@govID", "18", ObjEmpleado.GovID);
            ObjDataBase.DtParametros.Rows.Add(@"@birthDate", "14", ObjEmpleado.BirthDate);
            ObjDataBase.DtParametros.Rows.Add(@"@jobTitle", "18", ObjEmpleado.JobTitle);
            ObjDataBase.DtParametros.Rows.Add(@"@position", "4", ObjEmpleado.Position);
            ObjDataBase.DtParametros.Rows.Add(@"@dept", "3", ObjEmpleado.Dept);
            ObjDataBase.DtParametros.Rows.Add(@"@mobile", "18", ObjEmpleado.Mobile);
            ObjDataBase.DtParametros.Rows.Add(@"@homeTel", "18", ObjEmpleado.HomeTel);
            ObjDataBase.DtParametros.Rows.Add(@"@email", "18", ObjEmpleado.Email);
            ObjDataBase.DtParametros.Rows.Add(@"@homeStreet", "18", ObjEmpleado.HomeStreet);
            ObjDataBase.DtParametros.Rows.Add(@"@homeBlock", "18", ObjEmpleado.HomeBlock);
            ObjDataBase.DtParametros.Rows.Add(@"@homeZip", "18", ObjEmpleado.HomeZip);
            ObjDataBase.DtParametros.Rows.Add(@"@homeCity", "18", ObjEmpleado.HomeCity);
            ObjDataBase.DtParametros.Rows.Add(@"@homeCounty", "18", ObjEmpleado.HomeCounty);
            ObjDataBase.DtParametros.Rows.Add(@"@homeCountr", "18", ObjEmpleado.HomeCountr);
            ObjDataBase.DtParametros.Rows.Add(@"@homeState", "18", ObjEmpleado.HomeState);
            ObjDataBase.DtParametros.Rows.Add(@"@UpdateDate", "14", ObjEmpleado.UpdateDate);
            ObjDataBase.DtParametros.Rows.Add(@"@salary", "8", ObjEmpleado.Salary);
            ObjDataBase.DtParametros.Rows.Add(@"@salaryUnit", "15", ObjEmpleado.SalaryUnit);
            ObjDataBase.DtParametros.Rows.Add(@"@startDate", "14", ObjEmpleado.StartDate);
            ObjDataBase.DtParametros.Rows.Add(@"@sueldoBase", "8", ObjEmpleado.SueldoBase);
            ObjDataBase.DtParametros.Rows.Add(@"@sueldoLimite", "8", ObjEmpleado.SueldoLimite);
            ObjDataBase.DtParametros.Rows.Add(@"@Active", "15", ObjEmpleado.Active);
            ObjDataBase.DtParametros.Rows.Add(@"@TipoPago", "15", ObjEmpleado.TipoPago);
            ObjDataBase.DtParametros.Rows.Add(@"@StreetNoH", "18", ObjEmpleado.StreetNoH);
            ObjDataBase.DtParametros.Rows.Add(@"@nChildren", "3", ObjEmpleado.NChildren);
            ObjDataBase.DtParametros.Rows.Add(@"@HomeBuild", "18", ObjEmpleado.HomeBuild);
            ObjDataBase.DtParametros.Rows.Add(@"@USueldoBase", "15", ObjEmpleado.USueldoBase);
            ObjDataBase.DtParametros.Rows.Add(@"@USueldoLimite", "15", ObjEmpleado.USueldoLimite);
            ObjDataBase.DtParametros.Rows.Add(@"@TermDate", "14", ObjEmpleado.TermDate);
            ObjDataBase.DtParametros.Rows.Add(@"@martStatus", "15", ObjEmpleado.MartStatus);

            Ejecutar(ref ObjEmpleado);
        }

        public void CreateGrupo(ref ClsEmpleado ObjEmpleado)
        {
            int? spEmpIdMax = EmpId(ref ObjEmpleado);
            ObjEmpleado.EmpID = spEmpIdMax;
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "DB_BasePruebas",
                NombreTabla = "OHEM",
                NombreSP = "[dbo].[SP_OHEM_CreateGrupo]",
                Scalar = true
            };

            ObjDataBase.DtParametros.Rows.Add(@"@empID", "4", spEmpIdMax);
            ObjDataBase.DtParametros.Rows.Add(@"@firstName", "18", ObjEmpleado.FirstName);
            ObjDataBase.DtParametros.Rows.Add(@"@Active", "15", 'N');

            Ejecutar(ref ObjEmpleado);
        }

        public void Read(ref ClsEmpleado ObjEmpleado)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "DB_BasePruebas",
                NombreTabla = "OHEM",
                NombreSP = "[dbo].[SP_OHEM_Read]",
                Scalar = false
            };

            ObjDataBase.DtParametros.Rows.Add(@"@empID", "4", ObjEmpleado.EmpID);
            Ejecutar(ref ObjEmpleado);
        }

        public void Update(ref ClsEmpleado ObjEmpleado)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "DB_BasePruebas",
                NombreTabla = "OHEM",
                NombreSP = "[dbo].[SP_OHEM_Update]",
                Scalar = true
            };

            ObjDataBase.DtParametros.Rows.Add(@"@empID", "4", ObjEmpleado.EmpID);
            ObjDataBase.DtParametros.Rows.Add(@"@middleName", "18", ObjEmpleado.MiddleName);
            ObjDataBase.DtParametros.Rows.Add(@"@firstName", "18", ObjEmpleado.FirstName);
            ObjDataBase.DtParametros.Rows.Add(@"@lastName", "18", ObjEmpleado.LastName);
            ObjDataBase.DtParametros.Rows.Add(@"@sex", "15", ObjEmpleado.Sex);
            ObjDataBase.DtParametros.Rows.Add(@"@govID", "18", ObjEmpleado.GovID);
            ObjDataBase.DtParametros.Rows.Add(@"@birthDate", "14", ObjEmpleado.BirthDate);
            ObjDataBase.DtParametros.Rows.Add(@"@jobTitle", "18", ObjEmpleado.JobTitle);
            ObjDataBase.DtParametros.Rows.Add(@"@position", "4", ObjEmpleado.Position);
            ObjDataBase.DtParametros.Rows.Add(@"@dept", "3", ObjEmpleado.Dept);
            ObjDataBase.DtParametros.Rows.Add(@"@mobile", "18", ObjEmpleado.Mobile);
            ObjDataBase.DtParametros.Rows.Add(@"@homeTel", "18", ObjEmpleado.HomeTel);
            ObjDataBase.DtParametros.Rows.Add(@"@email", "18", ObjEmpleado.Email);
            ObjDataBase.DtParametros.Rows.Add(@"@homeStreet", "18", ObjEmpleado.HomeStreet);
            ObjDataBase.DtParametros.Rows.Add(@"@homeBlock", "18", ObjEmpleado.HomeBlock);
            ObjDataBase.DtParametros.Rows.Add(@"@homeZip", "18", ObjEmpleado.HomeZip);
            ObjDataBase.DtParametros.Rows.Add(@"@homeCity", "18", ObjEmpleado.HomeCity);
            ObjDataBase.DtParametros.Rows.Add(@"@homeCounty", "18", ObjEmpleado.HomeCounty);
            ObjDataBase.DtParametros.Rows.Add(@"@homeCountr", "18", ObjEmpleado.HomeCountr);
            ObjDataBase.DtParametros.Rows.Add(@"@homeState", "18", ObjEmpleado.HomeState);
            ObjDataBase.DtParametros.Rows.Add(@"@UpdateDate", "14", ObjEmpleado.UpdateDate);
            ObjDataBase.DtParametros.Rows.Add(@"@salary", "8", ObjEmpleado.Salary);
            ObjDataBase.DtParametros.Rows.Add(@"@salaryUnit", "15", ObjEmpleado.SalaryUnit);
            ObjDataBase.DtParametros.Rows.Add(@"@startDate", "14", ObjEmpleado.StartDate);
            ObjDataBase.DtParametros.Rows.Add(@"@sueldoBase", "8", ObjEmpleado.SueldoBase);
            ObjDataBase.DtParametros.Rows.Add(@"@sueldoLimite", "8", ObjEmpleado.SueldoLimite);
            ObjDataBase.DtParametros.Rows.Add(@"@Active", "15", ObjEmpleado.Active);
            ObjDataBase.DtParametros.Rows.Add(@"@TipoPago", "15", ObjEmpleado.TipoPago);
            ObjDataBase.DtParametros.Rows.Add(@"@StreetNoH", "18", ObjEmpleado.StreetNoH);
            ObjDataBase.DtParametros.Rows.Add(@"@nChildren", "3", ObjEmpleado.NChildren);
            ObjDataBase.DtParametros.Rows.Add(@"@HomeBuild", "18", ObjEmpleado.HomeBuild);
            ObjDataBase.DtParametros.Rows.Add(@"@USueldoBase", "15", ObjEmpleado.USueldoBase);
            ObjDataBase.DtParametros.Rows.Add(@"@USueldoLimite", "15", ObjEmpleado.USueldoLimite);
            ObjDataBase.DtParametros.Rows.Add(@"@TermDate", "14", ObjEmpleado.TermDate);
            ObjDataBase.DtParametros.Rows.Add(@"@martStatus", "15", ObjEmpleado.MartStatus);
            Ejecutar(ref ObjEmpleado);
        }

        public void UpdateActivo(ref ClsEmpleado ObjEmpleado)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "DB_BasePruebas",
                NombreTabla = "OHEM",
                NombreSP = "dbo.SP_OHEM_UpdateActivo",
                Scalar = true
            };

            ObjDataBase.DtParametros.Rows.Add(@"@empId", "4", ObjEmpleado.EmpID);
            ObjDataBase.DtParametros.Rows.Add(@"@Active", "15", ObjEmpleado.Active);

            Ejecutar(ref ObjEmpleado);
        }

        public void UpdateGrupo(ref ClsEmpleado ObjEmpleado)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "DB_BasePruebas",
                NombreTabla = "OHEM",
                NombreSP = "dbo.SP_OHEM_UpdateGrupo",
                Scalar = true
            };

            ObjDataBase.DtParametros.Rows.Add(@"@empId", "4", ObjEmpleado.EmpID);
            ObjDataBase.DtParametros.Rows.Add(@"@firstName", "18", ObjEmpleado.FirstName);

            Ejecutar(ref ObjEmpleado);
        }

        public void Delete(ref ClsEmpleado ObjEmpleado)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "DB_BasePruebas",
                NombreTabla = "OHEM",
                NombreSP = "[dbo].[SP_OHEM_Delete]",
                Scalar = true
            };

            ObjDataBase.DtParametros.Rows.Add(@"@empId", "4", ObjEmpleado.EmpID);
            Ejecutar(ref ObjEmpleado);
        }
        #endregion

        #region Metodos privados
        private void Ejecutar(ref ClsEmpleado ObjEmpleado)
        {
            ObjDataBase.CRUD(ref ObjDataBase);

            if (ObjDataBase.MensajeErrorDB == null)
            {
                if (ObjDataBase.Scalar)
                {
                    ObjEmpleado.ValorEscalar = ObjDataBase.ValorScalar;
                }
                else
                {
                    ObjEmpleado.DtResultados = ObjDataBase.DsResultados.Tables[0];
                    if (ObjEmpleado.DtResultados.Rows.Count == 1)
                    {
                        foreach (DataRow dr in ObjEmpleado.DtResultados.Rows)
                        {
                            ObjEmpleado.EmpID = Convert.ToInt16(dr["empID"].ToString());
                            ObjEmpleado.FirstName = dr["firstName"].ToString();

                            if (dr["middleName"] == DBNull.Value)
                                ObjEmpleado.MiddleName = "";
                            else
                                ObjEmpleado.MiddleName = dr["middleName"].ToString();

                            if (dr["lastName"] == DBNull.Value)
                                ObjEmpleado.LastName = "";
                            else
                                ObjEmpleado.LastName = dr["lastName"].ToString();

                            if (dr["sex"] == DBNull.Value)
                                ObjEmpleado.Sex = null;
                            else
                                ObjEmpleado.Sex = Convert.ToChar(dr["sex"].ToString());

                            if (dr["govID"] == DBNull.Value)
                                ObjEmpleado.GovID = "";
                            else
                                ObjEmpleado.GovID = dr["govID"].ToString();

                            if (dr["jobTitle"] == DBNull.Value)
                                ObjEmpleado.JobTitle = "";
                            else
                                ObjEmpleado.JobTitle = dr["jobTitle"].ToString();

                            if (dr["dept"] == DBNull.Value)
                                ObjEmpleado.Dept = -1;
                            else
                                ObjEmpleado.Dept = Convert.ToInt16(dr["dept"].ToString());

                            if (dr["mobile"] == DBNull.Value)
                                ObjEmpleado.Mobile = "";
                            else
                                ObjEmpleado.Mobile = dr["mobile"].ToString();

                            if (dr["homeTel"] == DBNull.Value)
                                ObjEmpleado.HomeTel = "";
                            else
                                ObjEmpleado.HomeTel = dr["homeTel"].ToString();

                            if (dr["email"] == DBNull.Value)
                                ObjEmpleado.Email = "";
                            else
                                ObjEmpleado.Email = dr["email"].ToString();

                            if (dr["homeStreet"] == DBNull.Value)
                                ObjEmpleado.HomeStreet = "";
                            else
                                ObjEmpleado.HomeStreet = dr["homeStreet"].ToString();

                            if (dr["homeBlock"] == DBNull.Value)
                                ObjEmpleado.HomeBlock = "";
                            else
                                ObjEmpleado.HomeBlock = dr["homeBlock"].ToString();

                            if (dr["homeZip"] == DBNull.Value)
                                ObjEmpleado.HomeZip = "";
                            else
                                ObjEmpleado.HomeZip = dr["homeZip"].ToString();

                            if (dr["homeCity"] == DBNull.Value)
                                ObjEmpleado.HomeCity = "";
                            else
                                ObjEmpleado.HomeCity = dr["homeCity"].ToString();

                            if (dr["homeCounty"] == DBNull.Value)
                                ObjEmpleado.HomeCounty = "";
                            else
                                ObjEmpleado.HomeCounty = dr["homeCounty"].ToString();

                            if (dr["homeCountr"] == DBNull.Value)
                                ObjEmpleado.HomeCountr = "";
                            else
                                ObjEmpleado.HomeCountr = dr["homeCountr"].ToString();

                            if (dr["homeState"] == DBNull.Value)
                                ObjEmpleado.HomeState = "";
                            else
                                ObjEmpleado.HomeState = dr["homeState"].ToString();

                            if (dr["UpdateDate"] == DBNull.Value)
                                ObjEmpleado.UpdateDate = null;
                            else
                                ObjEmpleado.UpdateDate = Convert.ToDateTime(dr["UpdateDate"].ToString());

                            if (dr["salary"] == DBNull.Value)
                                ObjEmpleado.Salary = 0;
                            else
                                ObjEmpleado.Salary = Convert.ToDecimal(dr["salary"].ToString());

                            if (dr["salaryUnit"] == DBNull.Value)
                                ObjEmpleado.SalaryUnit = null;
                            else
                                ObjEmpleado.SalaryUnit = Convert.ToChar(dr["salaryUnit"].ToString());

                            if (dr["sueldoBase"] == DBNull.Value)
                                ObjEmpleado.SueldoBase = 0;
                            else
                                ObjEmpleado.SueldoBase = Convert.ToDecimal(dr["sueldoBase"].ToString());

                            if (dr["sueldoLimite"] == DBNull.Value)
                                ObjEmpleado.SueldoLimite = 0;
                            else
                                ObjEmpleado.SueldoLimite = Convert.ToDecimal(dr["sueldoLimite"].ToString());

                            if (dr["birthDate"] == DBNull.Value)
                                ObjEmpleado.BirthDate = null;
                            else 
                                ObjEmpleado.BirthDate = Convert.ToDateTime(dr["birthDate"].ToString());
                            
                            if (dr["position"] == DBNull.Value)
                                ObjEmpleado.Position = -1;
                            else
                                ObjEmpleado.Position = Convert.ToInt16(dr["position"].ToString());

                            if (dr["AreaId"] == DBNull.Value)
                                ObjEmpleado.AreaId = -1;
                            else
                                ObjEmpleado.AreaId = Convert.ToByte(dr["AreaId"].ToString());

                            if (dr["startDate"] == DBNull.Value)
                                ObjEmpleado.StartDate = null;
                            else
                                ObjEmpleado.StartDate = Convert.ToDateTime(dr["startDate"].ToString());

                            if (dr["Active"] == DBNull.Value)
                                ObjEmpleado.Active = 'N';
                            else
                                ObjEmpleado.Active = Convert.ToChar(dr["Active"].ToString());

                            if (dr["TipoPago"] == DBNull.Value)
                                ObjEmpleado.TipoPago = 'F';
                            else
                                ObjEmpleado.TipoPago = Convert.ToChar(dr["TipoPago"].ToString());

                            if (dr["StreetNoH"] == DBNull.Value)
                                ObjEmpleado.StreetNoH = "";
                            else
                                ObjEmpleado.StreetNoH = dr["StreetNoH"].ToString();

                            if (dr["nChildren"] == DBNull.Value)
                                ObjEmpleado.NChildren = 0;
                            else
                                ObjEmpleado.NChildren = Convert.ToInt16(dr["nChildren"].ToString());

                            if (dr["HomeBuild"] == DBNull.Value)
                                ObjEmpleado.HomeBuild = "";
                            else
                                ObjEmpleado.HomeBuild = dr["HomeBuild"].ToString();

                            if (dr["USueldoBase"] == DBNull.Value)
                                ObjEmpleado.USueldoBase = null;
                            else
                                ObjEmpleado.USueldoBase = Convert.ToChar(dr["USueldoBase"].ToString());

                            if (dr["USueldoLimite"] == DBNull.Value)
                                ObjEmpleado.USueldoLimite = null;
                            else
                                ObjEmpleado.USueldoLimite = Convert.ToChar(dr["USueldoLimite"].ToString());

                            if (dr["termDate"] == DBNull.Value)
                                ObjEmpleado.TermDate = null;
                            else
                                ObjEmpleado.TermDate = Convert.ToDateTime(dr["termDate"].ToString());

                            if (dr["martStatus"] == DBNull.Value)
                                ObjEmpleado.MartStatus = null;
                            else
                                ObjEmpleado.MartStatus = Convert.ToChar(dr["martStatus"].ToString());
                        }
                    }
                }
            }
            else
            {
                ObjEmpleado.MsjError = ObjDataBase.MensajeErrorDB;
            }
        }

        private void EjecutarActivoVariable(ref ClsEmpleado ObjEmpleado)
        {
            ObjDataBase.CRUD(ref ObjDataBase);

            if (ObjDataBase.MensajeErrorDB == null)
            {
                if (ObjDataBase.Scalar)
                {
                    ObjEmpleado.ValorEscalar = ObjDataBase.ValorScalar;
                }
                else
                {
                    ObjEmpleado.DtResultados = ObjDataBase.DsResultados.Tables[0];
                }
            }
            else
            {
                ObjEmpleado.MsjError = ObjDataBase.MensajeErrorDB;
            }
        }

        private void ObtMaxId(ref ClsEmpleado ObjEmpleado)
        {
            ObjDataBase.CRUD(ref ObjDataBase);

            if (ObjDataBase.MensajeErrorDB == null)
            {
                if (ObjDataBase.Scalar)
                {
                    ObjEmpleado.ValorEscalar = ObjDataBase.ValorScalar;
                }
                else
                {
                    ObjEmpleado.DtResultados = ObjDataBase.DsResultados.Tables[0];
                    if (ObjEmpleado.DtResultados.Rows.Count == 1)
                    {
                        //ObjEmpleado.EmpID = Convert.ToInt16(ObjEmpleado.DtResultados.Rows[0]["ID"].ToString());
                        foreach (DataRow dr in ObjEmpleado.DtResultados.Rows)
                        {
                            ObjEmpleado.EmpID = Convert.ToByte(dr["ID"].ToString());
                        }
                    }
                }
            }
            else
            {
                ObjEmpleado.MsjError = ObjDataBase.MensajeErrorDB;
            }
        }
        #endregion

    }
}
