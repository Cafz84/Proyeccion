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

            Ejecutar(ref ObjEmpleado);
        }

        public int EmpId(ref ClsEmpleado ObjEmpleado)
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
            int spEmpIdMax = EmpId(ref ObjEmpleado);
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
                        }
                    }
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
