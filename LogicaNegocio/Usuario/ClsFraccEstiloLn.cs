using AccesoDatos.DataBase;
using Entidades.Usuario;
using System;
using System.Data;

namespace LogicaNegocio.Usuario
{
    public class ClsFraccEstiloLn
    {
        #region Variables privadas
        private ClsDataBase ObjDataBase = null;
        #endregion

        #region Metodo Index
        public void Index(ref ClsFraccEstilo ObjFraccEstilo)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "DB_BasePruebas",
                NombreTabla = "FraccxEstilo",
                NombreSP = "[dbo].[SP_FraccxEstilo_Index]",
                Scalar = false
            };

            Ejecutar(ref ObjFraccEstilo);
        }
        #endregion

        #region CRUD Empleado
        public void Create(ref ClsFraccEstilo ObjFraccEstilo)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "DB_BasePruebas",
                NombreTabla = "FraccxEstilo",
                NombreSP = "[dbo].[SP_FraccxEstilo_Create]",
                Scalar = true
            };

            ObjDataBase.DtParametros.Rows.Add(@"@U_IdEstilo", "18", ObjFraccEstilo.U_IdEstilo);
            ObjDataBase.DtParametros.Rows.Add(@"@U_IdFraccion", "4", ObjFraccEstilo.U_IdFraccion);
            ObjDataBase.DtParametros.Rows.Add(@"@U_ModCode", "18", ObjFraccEstilo.U_ModCode);
            ObjDataBase.DtParametros.Rows.Add(@"@U_ModDesc", "18", ObjFraccEstilo.U_ModDesc);
            ObjDataBase.DtParametros.Rows.Add(@"@U_CodigoFraccion", "18", ObjFraccEstilo.U_CodigoFraccion);
            ObjDataBase.DtParametros.Rows.Add(@"@U_NameFraccion", "18", ObjFraccEstilo.U_NameFraccion);
            ObjDataBase.DtParametros.Rows.Add(@"@Cantidad", "4", ObjFraccEstilo.Cantidad);

            Ejecutar(ref ObjFraccEstilo);
        }

        public void Read(ref ClsFraccEstilo ObjFraccEstilo)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "DB_BasePruebas",
                NombreTabla = "FraccxEstilo",
                NombreSP = "[dbo].[SP_FraccxEstilo_Read]",
                Scalar = false
            };

            ObjDataBase.DtParametros.Rows.Add(@"@U_IdEstilo", "18", ObjFraccEstilo.U_IdEstilo);
            ObjDataBase.DtParametros.Rows.Add(@"@U_IdFraccion", "4", ObjFraccEstilo.U_IdFraccion);
            Ejecutar(ref ObjFraccEstilo);
        }

        public void ReadEstilo(ref ClsFraccEstilo ObjFraccEstilo)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "DB_BasePruebas",
                NombreTabla = "FraccxEstilo",
                NombreSP = "[dbo].[SP_FraccxEstilo_ReadEstilo]",
                Scalar = false
            };

            ObjDataBase.DtParametros.Rows.Add(@"@U_ModDesc", "18", ObjFraccEstilo.U_ModDesc);
            EjecutarReadEstilo(ref ObjFraccEstilo);
        }

        public void ReadMuestra(ref ClsFraccEstilo ObjFraccEstilo)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "DB_BasePruebas",
                NombreTabla = "FraccxEstilo",
                NombreSP = "[dbo].[SP_FraccxEstilo_ReadMuestra]",
                Scalar = false
            };

            ObjDataBase.DtParametros.Rows.Add(@"@U_ModDesc", "18", ObjFraccEstilo.U_ModDesc);
            EjecutarReadEstilo(ref ObjFraccEstilo);
        }

        public void Update(ref ClsFraccEstilo ObjFraccEstilo)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "DB_BasePruebas",
                NombreTabla = "FraccxEstilo",
                NombreSP = "[dbo].[SP_FraccxEstilo_Update]",
                Scalar = true
            };

            ObjDataBase.DtParametros.Rows.Add(@"@IdEstilo", "18", ObjFraccEstilo.IdEstilo);
            ObjDataBase.DtParametros.Rows.Add(@"@IdFraccion", "4", ObjFraccEstilo.IdFraccion);
            ObjDataBase.DtParametros.Rows.Add(@"@U_IdEstilo", "18", ObjFraccEstilo.U_IdEstilo);
            ObjDataBase.DtParametros.Rows.Add(@"@U_IdFraccion", "4", ObjFraccEstilo.U_IdFraccion);
            ObjDataBase.DtParametros.Rows.Add(@"@U_ModCode", "18", ObjFraccEstilo.U_ModCode);
            ObjDataBase.DtParametros.Rows.Add(@"@U_ModDesc", "18", ObjFraccEstilo.U_ModDesc);
            ObjDataBase.DtParametros.Rows.Add(@"@U_CodigoFraccion", "18", ObjFraccEstilo.U_CodigoFraccion);
            ObjDataBase.DtParametros.Rows.Add(@"@U_NameFraccion", "18", ObjFraccEstilo.U_NameFraccion);
            ObjDataBase.DtParametros.Rows.Add(@"@Cantidad", "4", ObjFraccEstilo.Cantidad);
            Ejecutar(ref ObjFraccEstilo);
        }

        public void Delete(ref ClsFraccEstilo ObjFraccEstilo)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "DB_BasePruebas",
                NombreTabla = "FraccxEstilo",
                NombreSP = "[dbo].[SP_FraccxEstilo_Delete]",
                Scalar = true
            };

            ObjDataBase.DtParametros.Rows.Add(@"@U_IdEstilo", "18", ObjFraccEstilo.U_IdEstilo);
            ObjDataBase.DtParametros.Rows.Add(@"@U_IdFraccion", "4", ObjFraccEstilo.U_IdFraccion);
            Ejecutar(ref ObjFraccEstilo);
        }
        #endregion

        #region Metodos privados
        private void Ejecutar(ref ClsFraccEstilo ObjFraccEstilo)
        {
            ObjDataBase.CRUD(ref ObjDataBase);

            if (ObjDataBase.MensajeErrorDB == null)
            {
                if (ObjDataBase.Scalar)
                {
                    ObjFraccEstilo.ValorEscalar = ObjDataBase.ValorScalar;
                }
                else
                {
                    ObjFraccEstilo.DtResultados = ObjDataBase.DsResultados.Tables[0];
                    if (ObjFraccEstilo.DtResultados.Rows.Count == 1)
                    {
                        foreach (DataRow dr in ObjFraccEstilo.DtResultados.Rows)
                        {
                            ObjFraccEstilo.U_IdEstilo = dr["U_IdEstilo"].ToString();
                            ObjFraccEstilo.U_IdFraccion = Convert.ToInt16(dr["U_IdFraccion"].ToString());
                            ObjFraccEstilo.U_ModCode = dr["U_ModCode"].ToString();
                            ObjFraccEstilo.U_ModDesc = dr["Estilo"].ToString();
                            ObjFraccEstilo.U_CodigoFraccion = dr["U_CodigoFraccion"].ToString();
                            ObjFraccEstilo.U_NameFraccion = dr["Fraccion"].ToString();
                            ObjFraccEstilo.Cantidad = Convert.ToInt16(dr["Cantidad"].ToString());
                        }
                    }
                }
            }
            else
            {
                ObjFraccEstilo.MsjError = ObjDataBase.MensajeErrorDB;
            }
        }

        private void EjecutarReadEstilo(ref ClsFraccEstilo ObjFraccEstilo)
        {
            ObjDataBase.CRUD(ref ObjDataBase);

            if (ObjDataBase.MensajeErrorDB == null)
            {
                if (ObjDataBase.Scalar)
                {
                    ObjFraccEstilo.ValorEscalar = ObjDataBase.ValorScalar;
                }
                else
                {
                    ObjFraccEstilo.DtResultados = ObjDataBase.DsResultados.Tables[0];
                    if (ObjFraccEstilo.DtResultados.Rows.Count == 1)
                    {
                        foreach (DataRow dr in ObjFraccEstilo.DtResultados.Rows)
                        {
                            ObjFraccEstilo.U_IdFraccion = Convert.ToInt16(dr["Id"].ToString());
                            ObjFraccEstilo.U_NameFraccion = dr["Fraccion"].ToString();
                            ObjFraccEstilo.Cantidad = Convert.ToInt16(dr["Cantidad"].ToString());
                        }
                    }
                }
            }
            else
            {
                ObjFraccEstilo.MsjError = ObjDataBase.MensajeErrorDB;
            }
        }
        #endregion
    }
}
