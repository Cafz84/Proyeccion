using AccesoDatos.DataBase;
using Entidades.Usuario;
using System.Data;

namespace LogicaNegocio.Usuario
{
    public class ClsCiudadLn
    {
        #region Variables Privadas
        private ClsDataBase ObjDataBase = null;
        #endregion

        #region Metodo Index
        public void Index(ref ClsCiudad ObjCiudad)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreTabla = "Ciudad",
                NombreSP = "dbo.SP_Ciudad_Index",
                Scalar = false
            };

            ObjDataBase.DtParametros.Rows.Add(@"@NameEstado", "18", ObjCiudad.Estado);

            Ejecutar(ref ObjCiudad);
        }

        public void CargarCbCiudad(ref ClsCiudad ObjCiudad)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreTabla = "Ciudad",
                NombreSP = "dbo.SP_CargarCiudad",
                Scalar = false
            };

            ObjDataBase.DtParametros.Rows.Add(@"@Name", "18", ObjCiudad.Estado);

            CargarListaCiudad(ref ObjCiudad);
        }
        #endregion

        #region CRUD Estado
        public void Create(ref ClsCiudad ObjCiudad)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreTabla = "Ciudad",
                NombreSP = "dbo.SP_Ciudad_Create",
                Scalar = false
            };

            ObjDataBase.DtParametros.Rows.Add(@"@Code", "18", ObjCiudad.Code);
            ObjDataBase.DtParametros.Rows.Add(@"@Name", "18", ObjCiudad.Name);
            ObjDataBase.DtParametros.Rows.Add(@"@Country", "18", ObjCiudad.Estado);

            Ejecutar(ref ObjCiudad);
        }

        public void Read(ref ClsCiudad ObjCiudad)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreTabla = "Ciudad",
                NombreSP = "dbo.SP_Ciudad_Read",
                Scalar = false
            };

            ObjDataBase.DtParametros.Rows.Add(@"@Code", "18", ObjCiudad.Code);

            Ejecutar(ref ObjCiudad);
        }

        public void ReadCountry(ref ClsCiudad ObjCiudad)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreTabla = "Ciudad",
                NombreSP = "dbo.SP_Ciudad_ReadEstado",
                Scalar = false
            };

            ObjDataBase.DtParametros.Rows.Add(@"@Estado", "18", ObjCiudad.Estado);

            Ejecutar(ref ObjCiudad);
        }

        public void Update(ref ClsCiudad ObjCiudad)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreTabla = "Ciudad",
                NombreSP = "dbo.SP_Ciudad_Update",
                Scalar = true
            };

            ObjDataBase.DtParametros.Rows.Add(@"@Code", "18", ObjCiudad.Code);
            ObjDataBase.DtParametros.Rows.Add(@"@Name", "18", ObjCiudad.Name);
            ObjDataBase.DtParametros.Rows.Add(@"@Estado", "18", ObjCiudad.Estado);

            Ejecutar(ref ObjCiudad);
        }

        public void Delete(ref ClsCiudad ObjCiudad)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreTabla = "Ciudad",
                NombreSP = "dbo.SP_Ciudad_Delete",
                Scalar = true
            };

            ObjDataBase.DtParametros.Rows.Add(@"@Code", "18", ObjCiudad.Code);

            Ejecutar(ref ObjCiudad);
        }
        #endregion

        #region Metodos Privados
        private void Ejecutar(ref ClsCiudad ObjCiudad)
        {
            ObjDataBase.CRUD(ref ObjDataBase);

            if (ObjDataBase.MensajeErrorDB == null)
            {
                if (ObjDataBase.Scalar)
                {
                    ObjCiudad.ValorEscalar = ObjDataBase.ValorScalar;
                }
                else
                {
                    ObjCiudad.DtResultados = ObjDataBase.DsResultados.Tables[0];
                    if (ObjCiudad.DtResultados.Rows.Count == 1)
                    {
                        foreach (DataRow dr in ObjCiudad.DtResultados.Rows)
                        {
                            ObjCiudad.Code = dr["Code"].ToString();
                            ObjCiudad.Name = dr["Name"].ToString();
                            ObjCiudad.Estado = dr["Estado"].ToString();
                        }
                    }
                }
            }
            else
            {
                ObjCiudad.MsjError = ObjDataBase.MensajeErrorDB;
            }
        }

        private void CargarListaCiudad(ref ClsCiudad ObjCiudad)
        {
            ObjDataBase.CRUD(ref ObjDataBase);

            if (ObjDataBase.MensajeErrorDB == null)
            {
                if (ObjDataBase.Scalar)
                {
                    ObjCiudad.ValorEscalar = ObjDataBase.ValorScalar;
                }
                else
                {
                    ObjCiudad.DtResultados = ObjDataBase.DsResultados.Tables[0];
                    if (ObjCiudad.DtResultados.Rows.Count == 1)
                    {
                        foreach (DataRow dr in ObjCiudad.DtResultados.Rows)
                        {
                            ObjCiudad.Code = dr["Code"].ToString();
                            ObjCiudad.Name = dr["Name"].ToString();
                        }
                    }
                    ObjCiudad.DtResultados.Rows.Add(ObjCiudad.DtResultados.Rows.Count + 1, "Nueva Ciudad");
                }
            }
            else
            {
                ObjCiudad.MsjError = ObjDataBase.MensajeErrorDB;
            }
        }
        #endregion
    }
}
