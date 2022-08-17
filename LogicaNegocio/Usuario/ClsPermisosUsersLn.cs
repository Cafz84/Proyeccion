using AccesoDatos.DataBase;
using Entidades.Usuario;
using System;
using System.Data;

namespace LogicaNegocio.Usuario
{
    public class ClsPermisosUsersLn
    {
        #region Variables Privadas
        private ClsDataBase ObjDataBase = null;
        private bool bIndex;
        #endregion

        #region CRUD PermisosUsers
        public void Create(ref ClsPermisosUsers ObjPermisosUsers)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "PermisosUsers",
                NombreSP = "[dbo].[SP_PermisosUsers_Create]",
                Scalar = true
            };

            ObjDataBase.DtParametros.Rows.Add(@"@U_UserId", "4", ObjPermisosUsers.U_UserId);
            ObjDataBase.DtParametros.Rows.Add(@"@PUsuario", "1", ObjPermisosUsers.PUsuario);
            ObjDataBase.DtParametros.Rows.Add(@"@PEscaneo", "1", ObjPermisosUsers.PEscaneo);
            ObjDataBase.DtParametros.Rows.Add(@"@PEmpleados", "1", ObjPermisosUsers.PEmpleados);
            ObjDataBase.DtParametros.Rows.Add(@"@PFracciones", "1", ObjPermisosUsers.PFracciones);
            ObjDataBase.DtParametros.Rows.Add(@"@PFraccEstilo", "1", ObjPermisosUsers.PFraccEstilo);
            ObjDataBase.DtParametros.Rows.Add(@"@PCapturaDestajo", "1", ObjPermisosUsers.PCapturaDestajo);
            ObjDataBase.DtParametros.Rows.Add(@"@PRevDestajo", "1", ObjPermisosUsers.PRevDestajo);
            ObjDataBase.DtParametros.Rows.Add(@"@PAvances", "1", ObjPermisosUsers.PAvances);
            ObjDataBase.DtParametros.Rows.Add(@"@PLoteo", "1", ObjPermisosUsers.PLoteo);
            ObjDataBase.DtParametros.Rows.Add(@"@PUAvances", "1", ObjPermisosUsers.PUAvances);

            Ejecutar(ref ObjPermisosUsers);
        }

        public void Read(ref ClsPermisosUsers ObjPermisosUsers)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "PermisosUsers",
                NombreSP = "[dbo].[SP_PermisosUsers_Read]",
                Scalar = false
            };

            bIndex = false;
            ObjDataBase.DtParametros.Rows.Add(@"@U_UserId", "4", ObjPermisosUsers.U_UserId);
            Ejecutar(ref ObjPermisosUsers);
        }

        public void Update(ref ClsPermisosUsers ObjPermisosUsers)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "PermisosUsers",
                NombreSP = "[dbo].[SP_PermisosUsers_Update]",
                Scalar = true
            };

            ObjDataBase.DtParametros.Rows.Add(@"@U_UserId", "4", ObjPermisosUsers.U_UserId);
            ObjDataBase.DtParametros.Rows.Add(@"@PUsuario", "1", ObjPermisosUsers.PUsuario);
            ObjDataBase.DtParametros.Rows.Add(@"@PEscaneo", "1", ObjPermisosUsers.PEscaneo);
            ObjDataBase.DtParametros.Rows.Add(@"@PEmpleados", "1", ObjPermisosUsers.PEmpleados);
            ObjDataBase.DtParametros.Rows.Add(@"@PFracciones", "1", ObjPermisosUsers.PFracciones);
            ObjDataBase.DtParametros.Rows.Add(@"@PFraccEstilo", "1", ObjPermisosUsers.PFraccEstilo);
            ObjDataBase.DtParametros.Rows.Add(@"@PCapturaDestajo", "1", ObjPermisosUsers.PCapturaDestajo);
            ObjDataBase.DtParametros.Rows.Add(@"@PRevDestajo", "1", ObjPermisosUsers.PRevDestajo);
            ObjDataBase.DtParametros.Rows.Add(@"@PAvances", "1", ObjPermisosUsers.PAvances);
            ObjDataBase.DtParametros.Rows.Add(@"@PLoteo", "1", ObjPermisosUsers.PLoteo);
            ObjDataBase.DtParametros.Rows.Add(@"@PUAvances", "1", ObjPermisosUsers.PUAvances);
            Ejecutar(ref ObjPermisosUsers);
        }

        public void Delete(ref ClsPermisosUsers ObjPermisosUsers)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "PermisosUsers",
                NombreSP = "[dbo].[SP_PermisosUsers_Delete]",
                Scalar = true
            };

            ObjDataBase.DtParametros.Rows.Add(@"@U_UserId", "4", ObjPermisosUsers.U_UserId);
            Ejecutar(ref ObjPermisosUsers);
        }
        #endregion

        #region Metodos privados
        private void Ejecutar(ref ClsPermisosUsers ObjPermisosUsers)
        {
            ObjDataBase.CRUD(ref ObjDataBase);

            if (ObjDataBase.MensajeErrorDB == null)
            {
                if (ObjDataBase.Scalar)
                {
                    ObjPermisosUsers.ValorEscalar = ObjDataBase.ValorScalar;
                }
                else
                {
                    ObjPermisosUsers.DtResultados = ObjDataBase.DsResultados.Tables[0];
                    if (ObjPermisosUsers.DtResultados.Rows.Count == 1 && bIndex == false)
                    {
                        foreach (DataRow dr in ObjPermisosUsers.DtResultados.Rows)
                        {
                            ObjPermisosUsers.U_UserId = Convert.ToByte(dr["U_UserId"].ToString());
                            ObjPermisosUsers.PUsuario = Convert.ToBoolean(dr["PUsuario"].ToString());
                            ObjPermisosUsers.PEscaneo = Convert.ToBoolean(dr["PEscaneo"].ToString());
                            ObjPermisosUsers.PEmpleados = Convert.ToBoolean(dr["PEmpleados"].ToString());
                            ObjPermisosUsers.PFracciones = Convert.ToBoolean(dr["PFracciones"].ToString());
                            ObjPermisosUsers.PCapturaDestajo = Convert.ToBoolean(dr["PCapturaDestajo"].ToString());
                            ObjPermisosUsers.PFraccEstilo = Convert.ToBoolean(dr["PFraccEstilo"].ToString());
                            ObjPermisosUsers.PRevDestajo = Convert.ToBoolean(dr["PRevDestajo"].ToString());
                            ObjPermisosUsers.PAvances = Convert.ToBoolean(dr["PAvances"].ToString());
                            ObjPermisosUsers.PLoteo = Convert.ToBoolean(dr["PLoteo"].ToString());
                        }
                    }
                }
            }
            else
            {
                ObjPermisosUsers.MsjError = ObjDataBase.MensajeErrorDB;
            }
        }
        #endregion
    }
}
