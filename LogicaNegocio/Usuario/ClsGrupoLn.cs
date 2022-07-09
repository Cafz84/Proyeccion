using AccesoDatos.DataBase;
using Entidades.Usuario;
using System;
using System.Data;

namespace LogicaNegocio.Usuario
{
    public class ClsGrupoLn
    {
        #region Variables Privadas
        private ClsDataBase ObjDataBase = null;
        private string Log;
        private bool bIndex;
        #endregion

        #region Metodos Index
        public void Index(ref ClsGrupo ObjGrupo)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "DB_BasePruebas",
                NombreTabla = "GrupoD",
                NombreSP = "dbo.SP_GrupoD_Index",
                Scalar = false
            };

            bIndex = true;
            ObjDataBase.DtParametros.Rows.Add(@"@Grupo", "18", ObjGrupo.Grupo);
            Ejecutar(ref ObjGrupo);
        }

        public void CargarIndexGrupo(ref ClsGrupo ObjGrupo)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "DB_BasePruebas",
                NombreTabla = "GrupoD",
                NombreSP = "dbo.SP_CargarGrupoD",
                Scalar = false
            };

            ObjDataBase.DtParametros.Rows.Add(@"@Grupo", "18", ObjGrupo.Grupo);
            CargarListaGrupo(ref ObjGrupo);
        }
        #endregion

        #region CRUD Grupo
        public void Create(ref ClsGrupo ObjGrupo)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "DB_BasePruebas",
                NombreTabla = "GrupoD",
                NombreSP = "dbo.SP_GrupoD_Create",
                Scalar = false
            };

            ObjDataBase.DtParametros.Rows.Add(@"@GrupoDId", "4", ObjGrupo.GrupoDId);
            ObjDataBase.DtParametros.Rows.Add(@"@Grupo", "18", ObjGrupo.Grupo);
            ObjDataBase.DtParametros.Rows.Add(@"@Descripcion", "18", ObjGrupo.Descripcion);
            ObjDataBase.DtParametros.Rows.Add(@"@Activo", "1", ObjGrupo.Activo);

            Ejecutar(ref ObjGrupo);
        }

        public void Read(ref ClsGrupo ObjGrupo)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "DB_BasePruebas",
                NombreTabla = "GrupoD",
                NombreSP = "dbo.SP_GrupoD_Read",
                Scalar = false
            };

            bIndex = false;
            ObjDataBase.DtParametros.Rows.Add(@"@GrupoDId", "4", ObjGrupo.GrupoDId);

            Ejecutar(ref ObjGrupo);
        }

        public void Update(ref ClsGrupo ObjGrupo)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "DB_BasePruebas",
                NombreTabla = "GrupoD",
                NombreSP = "dbo.SP_GrupoD_Update",
                Scalar = true
            };

            ObjDataBase.DtParametros.Rows.Add(@"@GrupoDId", "4", ObjGrupo.GrupoDId);
            ObjDataBase.DtParametros.Rows.Add(@"@Grupo", "18", ObjGrupo.Grupo);
            ObjDataBase.DtParametros.Rows.Add(@"@Descripcion", "18", ObjGrupo.Descripcion);
            ObjDataBase.DtParametros.Rows.Add(@"@Activo", "1", ObjGrupo.Activo);

            Ejecutar(ref ObjGrupo);
        }

        public void UpdateActivo(ref ClsGrupo ObjGrupo)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "DB_BasePruebas",
                NombreTabla = "GrupoD",
                NombreSP = "dbo.SP_GrupoD_UpdateActivo",
                Scalar = true
            };

            ObjDataBase.DtParametros.Rows.Add(@"@GrupoDId", "4", ObjGrupo.GrupoDId);
            ObjDataBase.DtParametros.Rows.Add(@"@Activo", "1", ObjGrupo.Activo);

            Ejecutar(ref ObjGrupo);
        }

        public void Delete(ref ClsGrupo ObjGrupo)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "DB_BasePruebas",
                NombreTabla = "GrupoD",
                NombreSP = "dbo.SP_GrupoD_Delete",
                Scalar = true
            };

            ObjDataBase.DtParametros.Rows.Add(@"@GrupoDId", "4", ObjGrupo.GrupoDId);

            Ejecutar(ref ObjGrupo);
        }
        #endregion

        #region Metodos Privados
        private void Ejecutar(ref ClsGrupo ObjGrupo)
        {
            ObjDataBase.CRUD(ref ObjDataBase);

            if (ObjDataBase.MensajeErrorDB == null)
            {
                if (ObjDataBase.Scalar)
                {
                    ObjGrupo.ValorEscalar = ObjDataBase.ValorScalar;
                }
                else
                {
                    ObjGrupo.DtResultados = ObjDataBase.DsResultados.Tables[0];
                    if (ObjGrupo.DtResultados.Rows.Count == 1 && bIndex == false)
                    {
                        foreach (DataRow dr in ObjGrupo.DtResultados.Rows)
                        {
                            try
                            {
                                ObjGrupo.GrupoDId = Convert.ToByte(dr["GrupoDId"].ToString());
                                ObjGrupo.Grupo = dr["Grupo"].ToString();
                                ObjGrupo.Descripcion = dr["Descripcion"].ToString();
                                ObjGrupo.Activo = Convert.ToBoolean(dr["Activo"].ToString());
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
                ObjGrupo.MsjError = ObjDataBase.MensajeErrorDB;
            }
        }

        private void CargarListaGrupo(ref ClsGrupo ObjGrupo)
        {
            ObjDataBase.CRUD(ref ObjDataBase);

            if (ObjDataBase.MensajeErrorDB == null)
            {
                if (ObjDataBase.Scalar)
                {
                    ObjGrupo.ValorEscalar = ObjDataBase.ValorScalar;
                }
                else
                {
                    ObjGrupo.DtResultados = ObjDataBase.DsResultados.Tables[0];
                    if (ObjGrupo.DtResultados.Rows.Count == 1)
                    {
                        try
                        {
                            foreach (DataRow dr in ObjGrupo.DtResultados.Rows)
                            {
                                ObjGrupo.GrupoDId = Convert.ToByte(dr["Id"].ToString());
                                ObjGrupo.Grupo = dr["Grupo"].ToString();
                                ObjGrupo.Empleados = dr["Empleados"].ToString();
                            }
                        }
                        catch (Exception e)
                        {
                            Log = e.ToString();
                        }
                    }
                }
            }
            else
            {
                ObjGrupo.MsjError = ObjDataBase.MensajeErrorDB;
            }
        }
        #endregion
    }
}
