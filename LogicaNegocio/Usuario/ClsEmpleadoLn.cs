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
                NombreTabla = "OHEM",
                NombreSP = "[dbo].[SP_OHEM_EmpID]",
                Scalar = false
            };

            Ejecutar(ref ObjEmpleado);
            return ObjEmpleado.EmpID+1;
        }
        #endregion

        #region CRUD Empleado
        public void Create(ref ClsEmpleado ObjEmpleado)
        { 
            ObjDataBase = new ClsDataBase()
            {
                NombreTabla = "OHEM",
                NombreSP = "[dbo].[SP_OHEM_Create]",
                Scalar = true
            };

            ObjDataBase.DtParametros.Rows.Add(@"@empID", "4", EmpId(ref ObjEmpleado));
            ObjDataBase.DtParametros.Rows.Add(@"@middleName", "18", ObjEmpleado.MiddleName);
            ObjDataBase.DtParametros.Rows.Add(@"@firstName", "18", ObjEmpleado.FirstName);
            ObjDataBase.DtParametros.Rows.Add(@"@lastName", "18", ObjEmpleado.LastName);
            ObjDataBase.DtParametros.Rows.Add(@"@sex", "15", ObjEmpleado.Sex);
            ObjDataBase.DtParametros.Rows.Add(@"@govID", "18", ObjEmpleado.GovID);
            ObjDataBase.DtParametros.Rows.Add(@"@birthDate", "14", ObjEmpleado.BirthDate);
            ObjDataBase.DtParametros.Rows.Add(@"@jobTitle", "18", ObjEmpleado.JobTitle);
            ObjDataBase.DtParametros.Rows.Add(@"@type", "4", ObjEmpleado.Type);
            ObjDataBase.DtParametros.Rows.Add(@"@dept", "3", ObjEmpleado.Dept);
            ObjDataBase.DtParametros.Rows.Add(@"@mobile", "18", ObjEmpleado.Mobile);
            ObjDataBase.DtParametros.Rows.Add(@"@homeTel", "18", ObjEmpleado.HomeTel);
            ObjDataBase.DtParametros.Rows.Add(@"@email", "18", ObjEmpleado.Email);
            ObjDataBase.DtParametros.Rows.Add(@"@homeStreet", "18", ObjEmpleado.HomeStreet);
            ObjDataBase.DtParametros.Rows.Add(@"@homeBlock", "18", ObjEmpleado.HomeBlock);
            ObjDataBase.DtParametros.Rows.Add(@"@homeZip", "18", ObjEmpleado.HomeZip);
            ObjDataBase.DtParametros.Rows.Add(@"@homeCity", "18", ObjEmpleado.HomeCity);
            ObjDataBase.DtParametros.Rows.Add(@"@homeCounty", "18", ObjEmpleado.HomeCounty);
            ObjDataBase.DtParametros.Rows.Add(@"@homeConntr", "18", ObjEmpleado.HomeCountr);
            ObjDataBase.DtParametros.Rows.Add(@"@homeState", "18", ObjEmpleado.HomeState);
            ObjDataBase.DtParametros.Rows.Add(@"@UpdateDate", "14", ObjEmpleado.UpdateDate);
            ObjDataBase.DtParametros.Rows.Add(@"@salary", "6", ObjEmpleado.Salary);
            ObjDataBase.DtParametros.Rows.Add(@"@salaryUnit", "15", ObjEmpleado.SalaryUnit);
            ObjDataBase.DtParametros.Rows.Add(@"@startDate", "14", ObjEmpleado.StartDate);
            ObjDataBase.DtParametros.Rows.Add(@"@sueldoBase", "6", ObjEmpleado.SueldoBase);
            ObjDataBase.DtParametros.Rows.Add(@"@sueldoLimite", "6", ObjEmpleado.SueldoLimite);

            Ejecutar(ref ObjEmpleado);
        }

        /*public void Read(ref ClsUser ObjUser)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreTabla = "Users",
                NombreSP = "[SCH_GENERAL].[SP_Users_Read]",
                Scalar = false
            };

            ObjDataBase.DtParametros.Rows.Add(@"@UserId", "4", ObjUser.UserId);
            Ejecutar(ref ObjUser);
        }

        public void ReadLogin(ref ClsUser ObjUser)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreTabla = "Users",
                NombreSP = "[SCH_GENERAL].[SP_Users_Read_Login]",
                Scalar = false
            };

            ObjDataBase.DtParametros.Rows.Add(@"@LoginName", "18", ObjUser.LoginName);
            ObjDataBase.DtParametros.Rows.Add(@"@Password", "18", ObjUser.Password);
            Ejecutar(ref ObjUser);
        }

        public void Update(ref ClsUser ObjUser)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreTabla = "Users",
                NombreSP = "[SCH_GENERAL].[SP_Users_Update]",
                Scalar = true
            };

            ObjDataBase.DtParametros.Rows.Add(@"@UserId", "4", ObjUser.UserId);
            ObjDataBase.DtParametros.Rows.Add(@"@FirstName", "18", ObjUser.FirstName);
            ObjDataBase.DtParametros.Rows.Add(@"@LastName", "18", ObjUser.LastName);
            ObjDataBase.DtParametros.Rows.Add(@"@Position", "18", ObjUser.Position);
            ObjDataBase.DtParametros.Rows.Add(@"@LoginName", "18", ObjUser.LoginName);
            ObjDataBase.DtParametros.Rows.Add(@"@Password", "18", ObjUser.Password);
            ObjDataBase.DtParametros.Rows.Add(@"@Email", "18", ObjUser.Email);
            Ejecutar(ref ObjUser);
        }

        public void Delete(ref ClsUser ObjUser)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreTabla = "Users",
                NombreSP = "[SCH_GENERAL].[SP_Users_Delete]",
                Scalar = true
            };

            ObjDataBase.DtParametros.Rows.Add(@"@UserId", "4", ObjUser.UserId);
            Ejecutar(ref ObjUser);
        }*/
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
                            ObjEmpleado.UserId = Convert.ToByte(dr["empID"].ToString());
                            ObjEmpleado.FirstName = dr["firstName"].ToString();
                            ObjEmpleado.MiddleName = dr["middleName"].ToString();
                            ObjEmpleado.LastName = dr["lastName"].ToString();
                            ObjEmpleado.Sex = Convert.ToChar(dr["sex"].ToString());
                            ObjEmpleado.GovID = dr["govID"].ToString();
                            ObjEmpleado.BirthDate = Convert.ToDateTime(dr["birthDate"].ToString());
                            ObjEmpleado.JobTitle = dr["jobTitle"].ToString();
                            ObjEmpleado.Type = Convert.ToByte(dr["type"].ToString());
                            ObjEmpleado.Dept = Convert.ToByte(dr["dept"].ToString());
                            ObjEmpleado.Mobile = dr["mobile"].ToString();
                            ObjEmpleado.HomeTel = dr["homeTel"].ToString();
                            ObjEmpleado.Email = dr["email"].ToString();
                            ObjEmpleado.HomeStreet = dr["homeStreet"].ToString();
                            ObjEmpleado.HomeBlock = dr["homeBlock"].ToString();
                            ObjEmpleado.HomeZip = dr["homeZip"].ToString();
                            ObjEmpleado.HomeCity = dr["homeCity"].ToString();
                            ObjEmpleado.HomeCounty = dr["homeCounty"].ToString();
                            ObjEmpleado.HomeCountr = dr["homeCountr"].ToString();
                            ObjEmpleado.HomeState = dr["homeState"].ToString();
                            ObjEmpleado.UpdateDate = Convert.ToDateTime(dr["UpdateDate"].ToString());
                            ObjEmpleado.Salary = Convert.ToDouble(dr["salary"].ToString());
                            ObjEmpleado.SalaryUnit = Convert.ToChar(dr["salaryUnit"].ToString());
                            ObjEmpleado.StartDate = Convert.ToDateTime(dr["startDate"].ToString());
                            ObjEmpleado.SueldoBase = Convert.ToDouble(dr["sueldoBase"].ToString());
                            ObjEmpleado.SueldoLimite = Convert.ToDouble(dr["sueldoLimite"].ToString());
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
                        foreach (DataRow dr in ObjEmpleado.DtResultados.Rows)
                        {
                            ObjEmpleado.UserId = Convert.ToByte(dr["empID"].ToString());
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
