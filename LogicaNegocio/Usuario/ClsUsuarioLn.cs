using AccesoDatos.DataBase;
using Entidades.Usuario;
using System;
using System.Data;

namespace LogicaNegocio.Usuario
{
    public class ClsUsuarioLn
    {

        #region Variables privadas
        private ClsDataBase ObjDataBase = null;
        #endregion

        #region Metodo Index

        public void Index(ref ClsUsuario ObjUsuario)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "Usuarios",
                NombreSP = "[dbo].[SP_Usuarios_Index]",
                Scalar = false
            };
            Ejecutar(ref ObjUsuario);
        }

        #endregion

        #region CRUD Usuario

        public void Create(ref ClsUsuario ObjUsuario)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "Usuarios",
                NombreSP = "[dbo].[SP_Usuarios_Create]",
                Scalar = true
            };

            ObjDataBase.DtParametros.Rows.Add(@"@Nombre", "17", ObjUsuario.Nombre);
            ObjDataBase.DtParametros.Rows.Add(@"@Apellido1", "17", ObjUsuario.Apellido1);
            ObjDataBase.DtParametros.Rows.Add(@"@Apellido2", "17", ObjUsuario.Apellido2);
            ObjDataBase.DtParametros.Rows.Add(@"@FechaNacimiento", "13", ObjUsuario.FechaNacimiento);
            ObjDataBase.DtParametros.Rows.Add(@"@Estado", "1", ObjUsuario.Estado);

            Ejecutar(ref ObjUsuario);
        }

        public void Read(ref ClsUsuario ObjUsuario)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "Usuarios",
                NombreSP = "[dbo].[SP_Usuarios_Read]",
                Scalar = false
            };

            ObjDataBase.DtParametros.Rows.Add(@"@IdUsuario", "2", ObjUsuario.IdUsuario);
            Ejecutar(ref ObjUsuario);
        }

        public void Update(ref ClsUsuario ObjUsuario)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "Usuarios",
                NombreSP = "[dbo].[SP_Usuarios_Update]",
                Scalar = true
            };

            ObjDataBase.DtParametros.Rows.Add(@"@IdUsuario", "2", ObjUsuario.IdUsuario);
            ObjDataBase.DtParametros.Rows.Add(@"@Nombre", "17", ObjUsuario.Nombre);
            ObjDataBase.DtParametros.Rows.Add(@"@Apellido1", "17", ObjUsuario.Apellido1);
            ObjDataBase.DtParametros.Rows.Add(@"@Apellido2", "17", ObjUsuario.Apellido2);
            ObjDataBase.DtParametros.Rows.Add(@"@FechaNacimiento", "13", ObjUsuario.FechaNacimiento);
            ObjDataBase.DtParametros.Rows.Add(@"@Estado", "1", ObjUsuario.Estado);

            Ejecutar(ref ObjUsuario);
        }

        public void Delete(ref ClsUsuario ObjUsuario)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "Usuarios",
                NombreSP = "[dbo].[SP_Usuarios_Delete]",
                Scalar = true
            };

            ObjDataBase.DtParametros.Rows.Add(@"@IdUsuario", "2", ObjUsuario.IdUsuario);
            Ejecutar(ref ObjUsuario);
        }

        #endregion

        #region Metodos Privados

        private void Ejecutar(ref ClsUsuario ObjUsuario)
        {
            ObjDataBase.CRUD(ref ObjDataBase);

            if (ObjDataBase.MensajeErrorDB == null)
            {
                if (ObjDataBase.Scalar)
                {
                    ObjUsuario.ValorEscalar = ObjDataBase.ValorScalar;
                }
                else
                {
                    ObjUsuario.DtResultados = ObjDataBase.DsResultados.Tables[0];
                    if (ObjUsuario.DtResultados.Rows.Count == 1)
                    {
                        foreach(DataRow dr in ObjUsuario.DtResultados.Rows)
                        {
                            ObjUsuario.IdUsuario=Convert.ToByte(dr["IdUsuario"].ToString());
                            ObjUsuario.Nombre = dr["Nombre"].ToString();
                            ObjUsuario.Apellido1 = dr["Apellido1"].ToString();
                            ObjUsuario.Apellido2 = dr["Apellido2"].ToString();
                            ObjUsuario.FechaNacimiento = Convert.ToDateTime(dr["FechaNacimiento"].ToString());
                            ObjUsuario.Estado = Convert.ToBoolean(dr["Estado"].ToString());
                        }
                    }
                }
            }
            else
            {
                ObjUsuario.MsjError = ObjDataBase.MensajeErrorDB;
            }
        }

        #endregion

    }
}
