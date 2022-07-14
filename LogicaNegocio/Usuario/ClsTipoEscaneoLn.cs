using AccesoDatos.DataBase;
using Entidades.Usuario;
using System;
using System.Data;

namespace LogicaNegocio.Usuario
{
    public class ClsTipoEscaneoLn
    {

        #region Variables Privadas
        private ClsDataBase ObjDataBase = null;
        private string Log;
        #endregion

        #region Metodos Index
        public void Index(ref ClsTipoEscaneo ObjTipoEscaneo)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "TipoEscaneo",
                NombreSP = "dbo.SP_TipoEscaneo_Index",
                Scalar = false
            };

            Ejecutar(ref ObjTipoEscaneo);
        }

        public void CargarCbTipoEscaneo(ref ClsTipoEscaneo ObjTipoEscaneo)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "TipoEscaneo",
                NombreSP = "dbo.SP_CargarTipoEscaneo",
                Scalar = false
            };

            CargarListaTipoEscaneo(ref ObjTipoEscaneo);
        }
        #endregion

        #region CRUD TipoEscaneo
        public void Create(ref ClsTipoEscaneo ObjTipoEscaneo)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "TipoEscaneo",
                NombreSP = "dbo.SP_TipoEscaneo_Create",
                Scalar = false
            };

            ObjDataBase.DtParametros.Rows.Add(@"@Nombre", "18", ObjTipoEscaneo.Nombre);
            ObjDataBase.DtParametros.Rows.Add(@"@Descripcion", "18", ObjTipoEscaneo.Descripcion);
            ObjDataBase.DtParametros.Rows.Add(@"@Activo", "1", ObjTipoEscaneo.Activo);

            Ejecutar(ref ObjTipoEscaneo);
        }

        public void Read(ref ClsTipoEscaneo ObjTipoEscaneo)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "TipoEscaneo",
                NombreSP = "dbo.SP_TipoEscaneo_Read",
                Scalar = false
            };

            ObjDataBase.DtParametros.Rows.Add(@"@TipoId", "4", ObjTipoEscaneo.TipoId);

            Ejecutar(ref ObjTipoEscaneo);
        }

        public void Update(ref ClsTipoEscaneo ObjTipoEscaneo)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "TipoEscaneo",
                NombreSP = "dbo.SP_TipoEscaneo_Update",
                Scalar = true
            };

            ObjDataBase.DtParametros.Rows.Add(@"@TipoId", "4", ObjTipoEscaneo.TipoId);
            ObjDataBase.DtParametros.Rows.Add(@"@Nombre", "18", ObjTipoEscaneo.Nombre);
            ObjDataBase.DtParametros.Rows.Add(@"@Descripcion", "18", ObjTipoEscaneo.Descripcion);
            ObjDataBase.DtParametros.Rows.Add(@"@Activo", "1", ObjTipoEscaneo.Activo);

            Ejecutar(ref ObjTipoEscaneo);
        }

        public void UpdateActivo(ref ClsTipoEscaneo ObjTipoEscaneo)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "TipoEscaneo",
                NombreSP = "dbo.SP_TipoEscaneo_UpdateActivo",
                Scalar = true
            };

            ObjDataBase.DtParametros.Rows.Add(@"@TipoId", "4", ObjTipoEscaneo.TipoId);
            ObjDataBase.DtParametros.Rows.Add(@"@Activo", "1", ObjTipoEscaneo.Activo);

            Ejecutar(ref ObjTipoEscaneo);
        }

        public void Delete(ref ClsTipoEscaneo ObjTipoEscaneo)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "TipoEscaneo",
                NombreSP = "dbo.SP_TipoEscaneo_Delete",
                Scalar = true
            };

            ObjDataBase.DtParametros.Rows.Add(@"@TipoId", "4", ObjTipoEscaneo.TipoId);

            Ejecutar(ref ObjTipoEscaneo);
        }
        #endregion

        #region Metodos Privados
        private void Ejecutar(ref ClsTipoEscaneo ObjTipoEscaneo)
        {
            ObjDataBase.CRUD(ref ObjDataBase);

            if (ObjDataBase.MensajeErrorDB == null)
            {
                if (ObjDataBase.Scalar)
                {
                    ObjTipoEscaneo.ValorEscalar = ObjDataBase.ValorScalar;
                }
                else
                {
                    ObjTipoEscaneo.DtResultados = ObjDataBase.DsResultados.Tables[0];
                    if (ObjTipoEscaneo.DtResultados.Rows.Count == 1)
                    {
                        foreach (DataRow dr in ObjTipoEscaneo.DtResultados.Rows)
                        {
                            try
                            {
                                ObjTipoEscaneo.TipoId = Convert.ToByte(dr["TipoId"].ToString());
                                ObjTipoEscaneo.Nombre = dr["Nombre"].ToString();
                                ObjTipoEscaneo.Descripcion = dr["Descripcion"].ToString();
                                ObjTipoEscaneo.Activo = Convert.ToBoolean(dr["Activo"].ToString());
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
                ObjTipoEscaneo.MsjError = ObjDataBase.MensajeErrorDB;
            }
        }

        private void CargarListaTipoEscaneo(ref ClsTipoEscaneo ObjTipoEscaneo)
        {
            ObjDataBase.CRUD(ref ObjDataBase);

            if (ObjDataBase.MensajeErrorDB == null)
            {
                if (ObjDataBase.Scalar)
                {
                    ObjTipoEscaneo.ValorEscalar = ObjDataBase.ValorScalar;
                }
                else
                {
                    ObjTipoEscaneo.DtResultados = ObjDataBase.DsResultados.Tables[0];
                    if (ObjTipoEscaneo.DtResultados.Rows.Count == 1)
                    {
                        foreach (DataRow dr in ObjTipoEscaneo.DtResultados.Rows)
                        {
                            ObjTipoEscaneo.TipoId = Convert.ToByte(dr["TipoId"].ToString());
                            ObjTipoEscaneo.Nombre = dr["Nombre"].ToString();
                        }
                    }
                    ObjTipoEscaneo.DtResultados.Rows.Add(ObjTipoEscaneo.DtResultados.Rows.Count + 1, "Nuevo Tipo");
                }
            }
            else
            {
                ObjTipoEscaneo.MsjError = ObjDataBase.MensajeErrorDB;
            }
        }
        #endregion

    }
}
