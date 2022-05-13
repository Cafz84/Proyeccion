using AccesoDatos.DataBase;
using Entidades.Usuario;
using System.Data;

namespace LogicaNegocio.Usuario
{
    public class ClsEstadoLn
    {
        #region Variables Privadas
        private ClsDataBase ObjDataBase = null;
        //private string Log;
        #endregion

        #region Metodo Index
        public void Index(ref ClsEstado ObjEstado)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreTabla = "OCST",
                NombreSP = "dbo.SP_OCST_Index",
                Scalar = false
            };

            ObjDataBase.DtParametros.Rows.Add(@"NamePais", "18", ObjEstado.NamePais);

            Ejecutar(ref ObjEstado);
        }

        public void CargarCbEstado(ref ClsEstado ObjEstado)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreTabla = "OCST",
                NombreSP = "dbo.SP_CargarEstado",
                Scalar = false
            };

            ObjDataBase.DtParametros.Rows.Add(@"@Name", "18", ObjEstado.Country);

            CargarListaEstado(ref ObjEstado);
        }
        #endregion

        #region CRUD Estado
        public void Create(ref ClsEstado ObjEstado)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreTabla = "OCST",
                NombreSP = "dbo.SP_OCST_Create",
                Scalar = false
            };

            ObjDataBase.DtParametros.Rows.Add(@"@Code", "18", ObjEstado.Code);
            ObjDataBase.DtParametros.Rows.Add(@"@Name", "18", ObjEstado.Name);
            ObjDataBase.DtParametros.Rows.Add(@"@Country", "18", ObjEstado.Country);

            Ejecutar(ref ObjEstado);
        }

        public void Read(ref ClsEstado ObjEstado)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreTabla = "OCST",
                NombreSP = "dbo.SP_OCST_Read",
                Scalar = false
            };

            ObjDataBase.DtParametros.Rows.Add(@"@Code", "18", ObjEstado.Code);

            Ejecutar(ref ObjEstado);
        }

        public void ReadCountry(ref ClsEstado ObjEstado)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreTabla = "OCST",
                NombreSP = "dbo.SP_OCST_ReadCountry",
                Scalar = false
            };

            ObjDataBase.DtParametros.Rows.Add(@"@Country", "18", ObjEstado.Country);

            Ejecutar(ref ObjEstado);
        }

        public void Update(ref ClsEstado ObjEstado)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreTabla = "OCST",
                NombreSP = "dbo.SP_OCST_Update",
                Scalar = true
            };

            ObjDataBase.DtParametros.Rows.Add(@"@Code", "18", ObjEstado.Code);
            ObjDataBase.DtParametros.Rows.Add(@"@Name", "18", ObjEstado.Name);
            ObjDataBase.DtParametros.Rows.Add(@"@Country", "18", ObjEstado.Country);

            Ejecutar(ref ObjEstado);
        }

        public void Delete(ref ClsEstado ObjEstado)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreTabla = "OCST",
                NombreSP = "dbo.SP_OCST_Delete",
                Scalar = true
            };

            ObjDataBase.DtParametros.Rows.Add(@"@Code", "18", ObjEstado.Code);

            Ejecutar(ref ObjEstado);
        }
        #endregion

        #region Metodos Privados
        private void Ejecutar(ref ClsEstado ObjEstado)
        {
            ObjDataBase.CRUD(ref ObjDataBase);

            if (ObjDataBase.MensajeErrorDB == null)
            {
                if (ObjDataBase.Scalar)
                {
                    ObjEstado.ValorEscalar = ObjDataBase.ValorScalar;
                }
                else
                {
                    ObjEstado.DtResultados = ObjDataBase.DsResultados.Tables[0];
                    if (ObjEstado.DtResultados.Rows.Count == 1)
                    {
                        foreach (DataRow dr in ObjEstado.DtResultados.Rows)
                        {
                            ObjEstado.Code = dr["Code"].ToString();
                            ObjEstado.Name = dr["Name"].ToString();
                            ObjEstado.Country = dr["Country"].ToString();
                        }
                    }
                }
            }
            else
            {
                ObjEstado.MsjError = ObjDataBase.MensajeErrorDB;
            }
        }

        private void CargarListaEstado(ref ClsEstado ObjEstado)
        {
            ObjDataBase.CRUD(ref ObjDataBase);

            if (ObjDataBase.MensajeErrorDB == null)
            {
                if (ObjDataBase.Scalar)
                {
                    ObjEstado.ValorEscalar = ObjDataBase.ValorScalar;
                }
                else
                {
                    ObjEstado.DtResultados = ObjDataBase.DsResultados.Tables[0];
                    if (ObjEstado.DtResultados.Rows.Count == 1)
                    {
                        foreach (DataRow dr in ObjEstado.DtResultados.Rows)
                        {
                            ObjEstado.Code = dr["Code"].ToString();
                            ObjEstado.Name = dr["Name"].ToString();
                        }
                    }
                    ObjEstado.DtResultados.Rows.Add(ObjEstado.DtResultados.Rows.Count + 1, "Nuevo Estado");
                }
            }
            else
            {
                ObjEstado.MsjError = ObjDataBase.MensajeErrorDB;
            }
        }
        #endregion
    }
}
