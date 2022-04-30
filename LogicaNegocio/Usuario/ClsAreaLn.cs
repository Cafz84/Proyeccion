using AccesoDatos.DataBase;
using Entidades.Usuario;
using System;
using System.Data;

namespace LogicaNegocio.Usuario
{
    public class ClsAreaLn
    {
        #region Variables Privadas
        private ClsDataBase ObjDataBase = null;
        #endregion

        #region Metodos Index
        public void Index(ref ClsArea ObjArea)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreTabla = "Area",
                NombreSP = "dbo.SP_Area_Index",
                Scalar = false
            };

            Ejecutar(ref ObjArea);
        }

        public void CargarCbArea(ref ClsArea ObjArea)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreTabla = "Area",
                NombreSP = "dbo.SP_CargarArea",
                Scalar = false
            };

            CargarListaArea(ref ObjArea);
        }
        #endregion

        #region CRUD Area
        public void Create(ref ClsArea ObjArea)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreTabla = "Area",
                NombreSP = "dbo.SP_Area_Create",
                Scalar = false
            };

            ObjDataBase.DtParametros.Rows.Add(@"@Area", "18", ObjArea.Area);
            ObjDataBase.DtParametros.Rows.Add(@"Descripcion", "18", ObjArea.Descripcion);

            Ejecutar(ref ObjArea);
        }

        public void Read(ref ClsArea ObjArea)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreTabla = "Area",
                NombreSP = "dbo.SP_Area_Read",
                Scalar = false
            };

            ObjDataBase.DtParametros.Rows.Add(@"@AreaId", "4", ObjArea.AreaId);

            Ejecutar(ref ObjArea);
        }

        public void Update(ref ClsArea ObjArea)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreTabla = "Area",
                NombreSP = "dbo.SP_Area_Update",
                Scalar = true
            };

            ObjDataBase.DtParametros.Rows.Add(@"@AreaId", "4", ObjArea.AreaId);
            ObjDataBase.DtParametros.Rows.Add(@"@Area", "18", ObjArea.Area);
            ObjDataBase.DtParametros.Rows.Add(@"@Descripcion", "18", ObjArea.Descripcion);

            Ejecutar(ref ObjArea);
        }

        public void Delete(ref ClsArea ObjArea)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreTabla = "Area",
                NombreSP = "dbo.SP_Area_Delete",
                Scalar = true
            };

            ObjDataBase.DtParametros.Rows.Add(@"@AreaId", "4", ObjArea.AreaId);

            Ejecutar(ref ObjArea);
        }
        #endregion

        #region Metodos Privados
        private void Ejecutar(ref ClsArea ObjArea)
        {
            ObjDataBase.CRUD(ref ObjDataBase);

            if (ObjDataBase.MensajeErrorDB == null)
            {
                if (ObjDataBase.Scalar)
                {
                    ObjArea.ValorEscalar = ObjDataBase.ValorScalar;
                }
                else
                {
                    ObjArea.DtResultados = ObjDataBase.DsResultados.Tables[0];
                    if (ObjArea.DtResultados.Rows.Count == 1)
                    {
                        foreach (DataRow dr in ObjArea.DtResultados.Rows)
                        {
                            ObjArea.AreaId = Convert.ToByte(dr["AreaId"].ToString());
                            ObjArea.Area = dr["Area"].ToString();
                            ObjArea.Descripcion = dr["Descripcion"].ToString();
                        }
                    }
                }
            }
            else
            {
                ObjArea.MsjError = ObjDataBase.MensajeErrorDB;
            }
        }

        private void CargarListaArea(ref ClsArea ObjArea)
        {
            ObjDataBase.CRUD(ref ObjDataBase);

            if (ObjDataBase.MensajeErrorDB == null)
            {
                if (ObjDataBase.Scalar)
                {
                    ObjArea.ValorEscalar = ObjDataBase.ValorScalar;
                }
                else
                {
                    ObjArea.DtResultados = ObjDataBase.DsResultados.Tables[0];
                    if (ObjArea.DtResultados.Rows.Count == 1)
                    {
                        foreach (DataRow dr in ObjArea.DtResultados.Rows)
                        {
                            ObjArea.AreaId = Convert.ToByte(dr["AreaId"].ToString());
                            ObjArea.Area = dr["Area"].ToString();
                        }
                    }
                    ObjArea.DtResultados.Rows.Add(ObjArea.DtResultados.Rows.Count+1, "Nueva Area");
                }
            }
            else
            {
                ObjArea.MsjError = ObjDataBase.MensajeErrorDB;
            }
        }
        #endregion
    }

}
