using AccesoDatos.DataBase;
using Entidades.Usuario;
using System;
using System.Data;

namespace LogicaNegocio.Usuario
{
    public class ClsFraccionLn
    {
        #region Variables privadas
        private ClsDataBase ObjDataBase = null;
        #endregion

        #region Metodo Index
        public void Index(ref ClsFraccion ObjFraccion)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "DB_BasePruebas",
                NombreTabla = "Fraccion",
                NombreSP = "[dbo].[SP_Fraccion_Index]",
                Scalar = false
            };

            Ejecutar(ref ObjFraccion);
        }
        #endregion

        #region CRUD Fracciones
        public void Create(ref ClsFraccion ObjFraccion)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "DB_BasePruebas",
                NombreTabla = "Fraccion",
                NombreSP = "[dbo].[SP_Fraccion_Create]",
                Scalar = true
            };

            ObjDataBase.DtParametros.Rows.Add(@"@Codigo", "18", ObjFraccion.Codigo);
            ObjDataBase.DtParametros.Rows.Add(@"@Name", "18", ObjFraccion.Name);
            ObjDataBase.DtParametros.Rows.Add(@"@Descripcion", "18", ObjFraccion.Descripcion);
            ObjDataBase.DtParametros.Rows.Add(@"@Activo", "1", ObjFraccion.Activo);
            ObjDataBase.DtParametros.Rows.Add(@"@Tiempo", "10", ObjFraccion.Tiempo);
            ObjDataBase.DtParametros.Rows.Add(@"@Costo", "6", ObjFraccion.Costo);
            ObjDataBase.DtParametros.Rows.Add(@"@CostoMuestra", "9", ObjFraccion.CostoMuestra);

            Ejecutar(ref ObjFraccion);
        }

        public void Read(ref ClsFraccion ObjFraccion)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "DB_BasePruebas",
                NombreTabla = "Fraccion",
                NombreSP = "[dbo].[SP_Fraccion_Read]",
                Scalar = false
            };

            ObjDataBase.DtParametros.Rows.Add(@"@FraccionId", "4", ObjFraccion.FraccionId);
            Ejecutar(ref ObjFraccion);
        }

        public void Update(ref ClsFraccion ObjFraccion)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "DB_BasePruebas",
                NombreTabla = "Fraccion",
                NombreSP = "[dbo].[SP_Fraccion_Update]",
                Scalar = true
            };

            ObjDataBase.DtParametros.Rows.Add(@"@FraccionId", "4", ObjFraccion.FraccionId);
            ObjDataBase.DtParametros.Rows.Add(@"@Codigo", "18", ObjFraccion.Codigo);
            ObjDataBase.DtParametros.Rows.Add(@"@Name", "18", ObjFraccion.Name);
            ObjDataBase.DtParametros.Rows.Add(@"@Descripcion", "18", ObjFraccion.Descripcion);
            ObjDataBase.DtParametros.Rows.Add(@"@Activo", "1", ObjFraccion.Activo);
            ObjDataBase.DtParametros.Rows.Add(@"@Tiempo", "10", ObjFraccion.Tiempo);
            ObjDataBase.DtParametros.Rows.Add(@"@Costo", "6", ObjFraccion.Costo);
            ObjDataBase.DtParametros.Rows.Add(@"@CostoMuestra", "9", ObjFraccion.CostoMuestra);
            Ejecutar(ref ObjFraccion);
        }

        public void UpdateActivo(ref ClsFraccion ObjFraccion)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "DB_BasePruebas",
                NombreTabla = "Fraccion",
                NombreSP = "dbo.SP_Fraccion_UpdateActivo",
                Scalar = true
            };

            ObjDataBase.DtParametros.Rows.Add(@"@Fraccion", "4", ObjFraccion.FraccionId);
            ObjDataBase.DtParametros.Rows.Add(@"@Activo", "1", ObjFraccion.Activo);

            Ejecutar(ref ObjFraccion);
        }

        public void Delete(ref ClsFraccion ObjFraccion)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "DB_BasePruebas",
                NombreTabla = "Fraccion",
                NombreSP = "[dbo].[SP_Fraccion_Delete]",
                Scalar = true
            };

            ObjDataBase.DtParametros.Rows.Add(@"@FraccionId", "4", ObjFraccion.FraccionId);
            Ejecutar(ref ObjFraccion);
        }
        #endregion

        #region Metodos privados
        private void Ejecutar(ref ClsFraccion ObjFraccion)
        {
            ObjDataBase.CRUD(ref ObjDataBase);

            if (ObjDataBase.MensajeErrorDB == null)
            {
                if (ObjDataBase.Scalar)
                {
                    ObjFraccion.ValorEscalar = ObjDataBase.ValorScalar;
                }
                else
                {
                    ObjFraccion.DtResultados = ObjDataBase.DsResultados.Tables[0];
                    if (ObjFraccion.DtResultados.Rows.Count == 1)
                    {
                        foreach (DataRow dr in ObjFraccion.DtResultados.Rows)
                        {
                            ObjFraccion.FraccionId = Convert.ToInt16(dr["FraccionId"].ToString());
                            ObjFraccion.Codigo = dr["Codigo"].ToString();
                            ObjFraccion.Name = dr["Name"].ToString();
                            ObjFraccion.Activo = Convert.ToBoolean(dr["Activo"].ToString());

                            if (dr["Tiempo"] == DBNull.Value)
                                ObjFraccion.Tiempo = 0;
                            else
                                ObjFraccion.Tiempo = Convert.ToDouble(dr["Tiempo"].ToString());

                            if (dr["Costo"] == DBNull.Value)
                                ObjFraccion.Costo = 0;
                            else
                                ObjFraccion.Costo = Convert.ToDouble(dr["Costo"].ToString());

                            if (dr["CostoMuestra"] == DBNull.Value)
                                ObjFraccion.CostoMuestra = 0;
                            else
                                ObjFraccion.CostoMuestra = Convert.ToSingle(dr["CostoMuestra"].ToString());
                        }
                    }
                }
            }
            else
            {
                ObjFraccion.MsjError = ObjDataBase.MensajeErrorDB;
            }
        }
        #endregion
    }
}
