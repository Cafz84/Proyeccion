using AccesoDatos.DataBase;
using Entidades.Usuario;
using System;
using System.Data;

namespace LogicaNegocio.Usuario
{
    public class ClsUserLn
    {
        #region Variables privadas
        private ClsDataBase ObjDataBase = null;
        private bool bIndex;
        #endregion

        #region Metodo Index
        public void Index(ref ClsUser ObjUser)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "TBL_Users",
                NombreSP = "[dbo].[SP_Users_Index]",
                Scalar = false
            };

            bIndex = true;
            ObjDataBase.DtParametros.Rows.Add(@"@Nombre", "18", ObjUser.Nombre);
            Ejecutar(ref ObjUser);
        }

        public void UsersAvanceIndex(ref ClsUser ObjUser)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "TBL_Users",
                NombreSP = "[dbo].[SP_UsersAvance_Index]",
                Scalar = false
            };

            bIndex = true;
            ObjDataBase.DtParametros.Rows.Add(@"@Usuario", "18", ObjUser.LoginName);
            Ejecutar(ref ObjUser);
        }
        #endregion

        #region CRUD User
        public void Create(ref ClsUser ObjUser)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "TBL_Users",
                NombreSP = "[dbo].[SP_Users_Create]",
                Scalar = true
            };

            ObjDataBase.DtParametros.Rows.Add(@"@LoginName", "18", ObjUser.LoginName);
            ObjDataBase.DtParametros.Rows.Add(@"@Password", "18", ObjUser.Password);
            ObjDataBase.DtParametros.Rows.Add(@"@FirstName", "18", ObjUser.FirstName);
            ObjDataBase.DtParametros.Rows.Add(@"@LastName", "18", ObjUser.LastName);
            ObjDataBase.DtParametros.Rows.Add(@"@Position", "18", ObjUser.Position);
            ObjDataBase.DtParametros.Rows.Add(@"@Email", "18", ObjUser.Email);

            Ejecutar(ref ObjUser);
        }

        public void Read(ref ClsUser ObjUser)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "TBL_Users",
                NombreSP = "[dbo].[SP_Users_Read]",
                Scalar = false
            };

            bIndex = false;
            ObjDataBase.DtParametros.Rows.Add(@"@UserId", "4", ObjUser.UserId);
            Ejecutar(ref ObjUser);
        }

        public void ReadLogin(ref ClsUser ObjUser)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "TBL_Users",
                NombreSP = "[dbo].[SP_Users_Read_Login]",
                Scalar = false
            };

            bIndex = false;
            ObjDataBase.DtParametros.Rows.Add(@"@LoginName", "18", ObjUser.LoginName);
            ObjDataBase.DtParametros.Rows.Add(@"@Password", "18", ObjUser.Password);
            Ejecutar(ref ObjUser);
        }

        public void ReadMaxId(ref ClsUser ObjUser)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "TBL_Users",
                NombreSP = "[dbo].[SP_Users_ReadMax]",
                Scalar = false
            };

            EjecutarMaxId(ref ObjUser);
        }

        public void Update(ref ClsUser ObjUser)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "TBL_Users",
                NombreSP = "[dbo].[SP_Users_Update]",
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
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "TBL_Users",
                NombreSP = "[dbo].[SP_Users_Delete]",
                Scalar = true
            };

            ObjDataBase.DtParametros.Rows.Add(@"@UserId", "4", ObjUser.UserId);
            Ejecutar(ref ObjUser);
        }
        #endregion

        #region Metodos privados
        private void Ejecutar(ref ClsUser ObjUser)
        {
            ObjDataBase.CRUD(ref ObjDataBase);

            if (ObjDataBase.MensajeErrorDB == null)
            {
                if (ObjDataBase.Scalar)
                {
                    ObjUser.ValorEscalar = ObjDataBase.ValorScalar;
                }
                else
                {
                    ObjUser.DtResultados = ObjDataBase.DsResultados.Tables[0];
                    if (ObjUser.DtResultados.Rows.Count == 1 && bIndex == false)
                    {
                        foreach (DataRow dr in ObjUser.DtResultados.Rows)
                        {
                            ObjUser.UserId = Convert.ToByte(dr["UserId"].ToString());
                            ObjUser.LoginName = dr["LoginName"].ToString();
                            ObjUser.Password = dr["Password"].ToString();
                            ObjUser.FirstName = dr["FirstName"].ToString();
                            ObjUser.LastName = dr["LastName"].ToString();
                            ObjUser.Position = dr["Position"].ToString();
                            ObjUser.Email = dr["Email"].ToString();
                        }
                    }
                }
            }
            else
            {
                ObjUser.MsjError = ObjDataBase.MensajeErrorDB;
            }
        }

        private void EjecutarMaxId(ref ClsUser ObjUser)
        {
            ObjDataBase.CRUD(ref ObjDataBase);

            if (ObjDataBase.MensajeErrorDB == null)
            {
                if (ObjDataBase.Scalar)
                {
                    ObjUser.ValorEscalar = ObjDataBase.ValorScalar;
                }
                else
                {
                    ObjUser.DtResultados = ObjDataBase.DsResultados.Tables[0];
                    if (ObjUser.DtResultados.Rows.Count == 1)
                    {
                        foreach (DataRow dr in ObjUser.DtResultados.Rows)
                        {
                            ObjUser.IdMax = Convert.ToByte(dr["IdMax"].ToString());
                        }
                    }
                }
            }
            else
            {
                ObjUser.MsjError = ObjDataBase.MensajeErrorDB;
            }
        }
        #endregion
    }
}