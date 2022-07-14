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
        private string log;
        private bool bindex;
        #endregion

        #region Metodo Index
        public void Index(ref ClsFraccEstilo ObjFraccEstilo)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "FraccxEstilo",
                NombreSP = "[dbo].[SP_FraccxEstilo_Index]",
                Scalar = false
            };

            ObjDataBase.DtParametros.Rows.Add(@"@Estilo", "18", ObjFraccEstilo.U_ModDesc);
            ObjDataBase.DtParametros.Rows.Add(@"@Fraccion", "18", ObjFraccEstilo.U_NameFraccion);
            bindex = true;
            Ejecutar(ref ObjFraccEstilo);
        }
        #endregion

        #region CRUD Empleado
        public void Create(ref ClsFraccEstilo ObjFraccEstilo)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
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
            ObjDataBase.DtParametros.Rows.Add(@"@Tiempo", "10", ObjFraccEstilo.Tiempo);
            ObjDataBase.DtParametros.Rows.Add(@"@Costo", "10", ObjFraccEstilo.Costo);
            ObjDataBase.DtParametros.Rows.Add(@"@CostoMuestra", "10", ObjFraccEstilo.CostoMuestra);

            Ejecutar(ref ObjFraccEstilo);
        }

        public void Read(ref ClsFraccEstilo ObjFraccEstilo)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "FraccxEstilo",
                NombreSP = "[dbo].[SP_FraccxEstilo_Read]",
                Scalar = false
            };

            bindex = false;
            ObjDataBase.DtParametros.Rows.Add(@"@U_IdEstilo", "18", ObjFraccEstilo.U_IdEstilo);
            ObjDataBase.DtParametros.Rows.Add(@"@U_IdFraccion", "4", ObjFraccEstilo.U_IdFraccion);
            Ejecutar(ref ObjFraccEstilo);
        }

        public void ReadEstilo(ref ClsFraccEstilo ObjFraccEstilo)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "FraccxEstilo",
                NombreSP = "[dbo].[SP_FraccxEstilo_ReadEstilo]",
                Scalar = false
            };

            bindex = true;
            ObjDataBase.DtParametros.Rows.Add(@"@U_ModDesc", "18", ObjFraccEstilo.U_ModDesc);
            ObjDataBase.DtParametros.Rows.Add(@"@BNombre", "18", ObjFraccEstilo.BNombre);
            ObjDataBase.DtParametros.Rows.Add(@"@Programa", "18", ObjFraccEstilo.Programa);
            Ejecutar(ref ObjFraccEstilo);
        }

        public void ReadMuestra(ref ClsFraccEstilo ObjFraccEstilo)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "FraccxEstilo",
                NombreSP = "[dbo].[SP_FraccxEstilo_ReadMuestra]",
                Scalar = false
            };

            bindex = true;
            ObjDataBase.DtParametros.Rows.Add(@"@U_ModDesc", "18", ObjFraccEstilo.U_ModDesc);
            Ejecutar(ref ObjFraccEstilo);
        }

        public void ReadBNombre(ref ClsFraccEstilo ObjFraccEstilo)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "FraccxEstilo",
                NombreSP = "[dbo].[SP_FraccxEstilo_ReadEstiloBNombre]",
                Scalar = false
            };

            ObjDataBase.DtParametros.Rows.Add(@"@BNombre", "18", ObjFraccEstilo.BNombre);
            ObjDataBase.DtParametros.Rows.Add(@"@U_ModDesc", "18", ObjFraccEstilo.U_ModDesc);
            Ejecutar(ref ObjFraccEstilo);
        }

        public void Update(ref ClsFraccEstilo ObjFraccEstilo)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
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
            ObjDataBase.DtParametros.Rows.Add(@"@Tiempo", "10", ObjFraccEstilo.Tiempo);
            ObjDataBase.DtParametros.Rows.Add(@"@Costo", "10", ObjFraccEstilo.Costo);
            ObjDataBase.DtParametros.Rows.Add(@"@CostoMuestra", "10", ObjFraccEstilo.CostoMuestra);
            Ejecutar(ref ObjFraccEstilo);
        }

        public void Delete(ref ClsFraccEstilo ObjFraccEstilo)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
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
                    if (ObjFraccEstilo.DtResultados.Rows.Count == 1 && bindex == false)
                    {
                        try
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
                                ObjFraccEstilo.Tiempo = Convert.ToDouble(dr["Tiempo"].ToString());
                                ObjFraccEstilo.Costo = Convert.ToDouble(dr["Costo"].ToString());
                                ObjFraccEstilo.CostoMuestra = Convert.ToDouble(dr["CostoMuestra"].ToString());
                            }
                        }
                        catch(Exception e)
                        {
                            log = e.ToString();
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
