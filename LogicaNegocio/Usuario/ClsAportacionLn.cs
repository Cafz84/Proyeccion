using AccesoDatos.DataBase;
using Entidades.Usuario;
using System;
using System.Data;

namespace LogicaNegocio.Usuario
{
    public class ClsAportacionLn
    {
        #region Variables Privadas
        private ClsDataBase ObjDataBase = null;
        private string Log;
        private bool bIndex;
        #endregion

        #region Metodo Index
        public void Index(ref ClsAportacion ObjAportacion)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "DB_BasePruebas",
                NombreTabla = "Aportaciones",
                NombreSP = "dbo.SP_Aportaciones_Index",
                Scalar = false
            };

            bIndex = true;
            ObjDataBase.DtParametros.Rows.Add(@"@Aportacion", "18", ObjAportacion.Aportacion);
            Ejecutar(ref ObjAportacion);
        }
        #endregion

        #region CRUD Aportaciones
        public void Create(ref ClsAportacion ObjAportacion)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "DB_BasePruebas",
                NombreTabla = "Aportaciones",
                NombreSP = "dbo.SP_Aportaciones_Create",
                Scalar = false
            };

            ObjDataBase.DtParametros.Rows.Add(@"@Aportacion", "18", ObjAportacion.Aportacion);
            ObjDataBase.DtParametros.Rows.Add(@"@Descripcion", "18", ObjAportacion.Descripcion);
            ObjDataBase.DtParametros.Rows.Add(@"@Activo", "1", ObjAportacion.Activo);

            Ejecutar(ref ObjAportacion);
        }

        public void Read(ref ClsAportacion ObjAportacion)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "DB_BasePruebas",
                NombreTabla = "Aportaciones",
                NombreSP = "dbo.SP_Aportaciones_Read",
                Scalar = false
            };

            bIndex = false;
            ObjDataBase.DtParametros.Rows.Add(@"@IdAportacion", "4", ObjAportacion.IdAportacion);
            Ejecutar(ref ObjAportacion);
        }

        public void ReadRepetido(ref ClsAportacion ObjAportacion)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "DB_BasePruebas",
                NombreTabla = "Aportaciones",
                NombreSP = "dbo.SP_Aportaciones_ReadRepetido",
                Scalar = false
            };

            bIndex = false;
            ObjDataBase.DtParametros.Rows.Add(@"@Aportacion", "18", ObjAportacion.Aportacion);
            Ejecutar(ref ObjAportacion);
        }

        public void Update(ref ClsAportacion ObjAportacion)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "DB_BasePruebas",
                NombreTabla = "Aportaciones",
                NombreSP = "dbo.SP_Aportaciones_Update",
                Scalar = true
            };

            ObjDataBase.DtParametros.Rows.Add(@"@IdAportacion", "4", ObjAportacion.IdAportacion);
            ObjDataBase.DtParametros.Rows.Add(@"@Aportacion", "18", ObjAportacion.Aportacion);
            ObjDataBase.DtParametros.Rows.Add(@"@Descripcion", "18", ObjAportacion.Descripcion);
            ObjDataBase.DtParametros.Rows.Add(@"@Activo", "1", ObjAportacion.Activo);

            Ejecutar(ref ObjAportacion);
        }

        public void UpdateActivo(ref ClsAportacion ObjAportacion)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "DB_BasePruebas",
                NombreTabla = "Aportaciones",
                NombreSP = "dbo.SP_Aportaciones_UpdateActivo",
                Scalar = true
            };

            ObjDataBase.DtParametros.Rows.Add(@"@IdAportacion", "4", ObjAportacion.IdAportacion);
            ObjDataBase.DtParametros.Rows.Add(@"@Activo", "1", ObjAportacion.Activo);

            Ejecutar(ref ObjAportacion);
        }

        public void Delete(ref ClsAportacion ObjAportacion)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "DB_BasePruebas",
                NombreTabla = "Aportaciones",
                NombreSP = "dbo.SP_Aportaciones_Delete",
                Scalar = true
            };

            ObjDataBase.DtParametros.Rows.Add(@"@IdAportacion", "4", ObjAportacion.IdAportacion);

            Ejecutar(ref ObjAportacion);
        }
        #endregion

        #region Metodos Privados
        private void Ejecutar(ref ClsAportacion ObjAportacion)
        {
            ObjDataBase.CRUD(ref ObjDataBase);

            if (ObjDataBase.MensajeErrorDB == null)
            {
                if (ObjDataBase.Scalar)
                {
                    ObjAportacion.ValorEscalar = ObjDataBase.ValorScalar;
                }
                else
                {
                    ObjAportacion.DtResultados = ObjDataBase.DsResultados.Tables[0];
                    if (ObjAportacion.DtResultados.Rows.Count == 1 && bIndex == false)
                    {
                        foreach (DataRow dr in ObjAportacion.DtResultados.Rows)
                        {
                            try
                            {
                                ObjAportacion.IdAportacion = Convert.ToByte(dr["PuestoId"].ToString());
                                ObjAportacion.Aportacion = dr["Puesto"].ToString();
                                ObjAportacion.Descripcion = dr["Descripcion"].ToString();
                                ObjAportacion.Activo = Convert.ToBoolean(dr["Activo"].ToString());
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
                ObjAportacion.MsjError = ObjDataBase.MensajeErrorDB;
            }
        }
        #endregion
    }
}
