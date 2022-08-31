using AccesoDatos.DataBase;
using Entidades.Usuario;
using System;
using System.Data;

namespace LogicaNegocio.Usuario
{
    public class ClsDeduccionLn
    {
        #region Variables Privadas
        private ClsDataBase ObjDataBase = null;
        private string Log;
        private bool bIndex;
        #endregion

        #region Metodo Index
        public void Index(ref ClsDeduccion ObjDeduccion)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "Deducciones",
                NombreSP = "dbo.SP_Deducciones_Index",
                Scalar = false
            };

            bIndex = true;
            ObjDataBase.DtParametros.Rows.Add(@"@Deduccion", "18", ObjDeduccion.Deduccion);
            Ejecutar(ref ObjDeduccion);
        }

        public void IndexRD(ref ClsDeduccion ObjDeduccion)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "Deducciones",
                NombreSP = "dbo.SP_Deducciones_IndexRD",
                Scalar = false
            };

            bIndex = true;
            ObjDataBase.DtParametros.Rows.Add(@"@Deduccion", "18", ObjDeduccion.Deduccion);
            Ejecutar(ref ObjDeduccion);
        }
        #endregion

        #region CRUD Aportaciones
        public void Create(ref ClsDeduccion ObjDeduccion)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "Deducciones",
                NombreSP = "dbo.SP_Deducciones_Create",
                Scalar = false
            };

            ObjDataBase.DtParametros.Rows.Add(@"@Deduccion", "18", ObjDeduccion.Deduccion);
            ObjDataBase.DtParametros.Rows.Add(@"@Descripcion", "18", ObjDeduccion.Descripcion);
            ObjDataBase.DtParametros.Rows.Add(@"@Activo", "1", ObjDeduccion.Activo);

            Ejecutar(ref ObjDeduccion);
        }

        public void Read(ref ClsDeduccion ObjDeduccion)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "Deducciones",
                NombreSP = "dbo.SP_Deducciones_Read",
                Scalar = false
            };

            bIndex = false;
            ObjDataBase.DtParametros.Rows.Add(@"@IdDeduccion", "4", ObjDeduccion.IdDeduccion);
            Ejecutar(ref ObjDeduccion);
        }

        public void ReadRepetido(ref ClsDeduccion ObjDeduccion)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "Deducciones",
                NombreSP = "dbo.SP_Deducciones_ReadRepetido",
                Scalar = false
            };

            bIndex = false;
            ObjDataBase.DtParametros.Rows.Add(@"@Deduccion", "18", ObjDeduccion.Deduccion);
            Ejecutar(ref ObjDeduccion);
        }

        public void Update(ref ClsDeduccion ObjDeduccion)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "Deducciones",
                NombreSP = "dbo.SP_Deducciones_Update",
                Scalar = true
            };

            ObjDataBase.DtParametros.Rows.Add(@"@IdDeduccion", "4", ObjDeduccion.IdDeduccion);
            ObjDataBase.DtParametros.Rows.Add(@"@Deduccion", "18", ObjDeduccion.Deduccion);
            ObjDataBase.DtParametros.Rows.Add(@"@Descripcion", "18", ObjDeduccion.Descripcion);
            ObjDataBase.DtParametros.Rows.Add(@"@Activo", "1", ObjDeduccion.Activo);

            Ejecutar(ref ObjDeduccion);
        }

        public void UpdateActivo(ref ClsDeduccion ObjDeduccion)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "Deducciones",
                NombreSP = "dbo.SP_Deducciones_UpdateActivo",
                Scalar = true
            };

            ObjDataBase.DtParametros.Rows.Add(@"@IdDeduccion", "4", ObjDeduccion.IdDeduccion);
            ObjDataBase.DtParametros.Rows.Add(@"@Activo", "1", ObjDeduccion.Activo);

            Ejecutar(ref ObjDeduccion);
        }

        public void Delete(ref ClsDeduccion ObjDeduccion)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "Deducciones",
                NombreSP = "dbo.SP_Deducciones_Delete",
                Scalar = true
            };

            ObjDataBase.DtParametros.Rows.Add(@"@IdDeduccion", "4", ObjDeduccion.IdDeduccion);

            Ejecutar(ref ObjDeduccion);
        }
        #endregion

        #region Metodos Privados
        private void Ejecutar(ref ClsDeduccion ObjDeduccion)
        {
            ObjDataBase.CRUD(ref ObjDataBase);

            if (ObjDataBase.MensajeErrorDB == null)
            {
                if (ObjDataBase.Scalar)
                {
                    ObjDeduccion.ValorEscalar = ObjDataBase.ValorScalar;
                }
                else
                {
                    ObjDeduccion.DtResultados = ObjDataBase.DsResultados.Tables[0];
                    if (ObjDeduccion.DtResultados.Rows.Count == 1 && bIndex == false)
                    {
                        foreach (DataRow dr in ObjDeduccion.DtResultados.Rows)
                        {
                            try
                            {
                                ObjDeduccion.IdDeduccion = Convert.ToByte(dr["IdDeduccion"].ToString());
                                ObjDeduccion.Deduccion = dr["Deduccion"].ToString();
                                ObjDeduccion.Descripcion = dr["Descripcion"].ToString();
                                ObjDeduccion.Activo = Convert.ToBoolean(dr["Activo"].ToString());
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
                ObjDeduccion.MsjError = ObjDataBase.MensajeErrorDB;
            }
        }
        #endregion
    }
}
