using AccesoDatos.DataBase;
using Entidades.Usuario;
using System.Data;

namespace LogicaNegocio.Usuario
{
    public class ClsPaisLn
    {
        #region Variables Privadas
        private ClsDataBase ObjDataBase = null;
        //private string Log;
        #endregion

        #region Metodo Index
        public void Index(ref ClsPais ObjPais)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "OCRY",
                NombreSP = "dbo.SP_OCRY_Index",
                Scalar = false
            };

            Ejecutar(ref ObjPais);
        }

        public void CargarCbPais(ref ClsPais ObjPais)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "OCRY",
                NombreSP = "dbo.SP_CargarPais",
                Scalar = false
            };

            CargarListaPuesto(ref ObjPais);
        }
        #endregion

        #region CRUD Pais
        public void Create(ref ClsPais ObjPais)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "OCRY",
                NombreSP = "dbo.SP_OCRY_Create",
                Scalar = false
            };

            ObjDataBase.DtParametros.Rows.Add(@"@Code", "18", ObjPais.Code);
            ObjDataBase.DtParametros.Rows.Add(@"@Name", "18", ObjPais.Name);

            Ejecutar(ref ObjPais);
        }

        public void Read(ref ClsPais ObjPais)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "OCRY",
                NombreSP = "dbo.SP_OCRY_Read",
                Scalar = false
            };

            ObjDataBase.DtParametros.Rows.Add(@"@Code", "18", ObjPais.Code);

            Ejecutar(ref ObjPais);
        }

        public void Update(ref ClsPais ObjPais)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "OCRY",
                NombreSP = "dbo.SP_OCRY_Update",
                Scalar = true
            };

            ObjDataBase.DtParametros.Rows.Add(@"@Code", "18", ObjPais.Code);
            ObjDataBase.DtParametros.Rows.Add(@"@Name", "18", ObjPais.Name);

            Ejecutar(ref ObjPais);
        }

        public void Delete(ref ClsPais ObjPais)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "OCRY",
                NombreSP = "dbo.SP_OCRY_Delete",
                Scalar = true
            };

            ObjDataBase.DtParametros.Rows.Add(@"@Code", "18", ObjPais.Code);

            Ejecutar(ref ObjPais);
        }
        #endregion

        #region Metodos Privados
        private void Ejecutar(ref ClsPais ObjPais)
        {
            ObjDataBase.CRUD(ref ObjDataBase);

            if (ObjDataBase.MensajeErrorDB == null)
            {
                if (ObjDataBase.Scalar)
                {
                    ObjPais.ValorEscalar = ObjDataBase.ValorScalar;
                }
                else
                {
                    ObjPais.DtResultados = ObjDataBase.DsResultados.Tables[0];
                    if (ObjPais.DtResultados.Rows.Count == 1)
                    {
                        foreach (DataRow dr in ObjPais.DtResultados.Rows)
                        {
                            ObjPais.Code = dr["Code"].ToString();
                            ObjPais.Name = dr["Name"].ToString();
                        }
                    }
                }
            }
            else
            {
                ObjPais.MsjError = ObjDataBase.MensajeErrorDB;
            }
        }

        private void CargarListaPuesto(ref ClsPais ObjPais)
        {
            ObjDataBase.CRUD(ref ObjDataBase);

            if (ObjDataBase.MensajeErrorDB == null)
            {
                if (ObjDataBase.Scalar)
                {
                    ObjPais.ValorEscalar = ObjDataBase.ValorScalar;
                }
                else
                {
                    ObjPais.DtResultados = ObjDataBase.DsResultados.Tables[0];
                    if (ObjPais.DtResultados.Rows.Count == 1)
                    {
                        foreach (DataRow dr in ObjPais.DtResultados.Rows)
                        {
                            ObjPais.Code = dr["PuestoId"].ToString();
                            ObjPais.Name = dr["Puesto"].ToString();
                        }
                    }
                    ObjPais.DtResultados.Rows.Add(ObjPais.DtResultados.Rows.Count + 1, "Nuevo Pais");
                }
            }
            else
            {
                ObjPais.MsjError = ObjDataBase.MensajeErrorDB;
            }
        }
        #endregion
    }
}
