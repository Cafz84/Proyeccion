using AccesoDatos.DataBase;
using Entidades.Usuario;
using System;
using System.Data;

namespace LogicaNegocio.Usuario
{
    public class ClsAportFijoLn
    {
        #region Variables Privadas
        private ClsDataBase ObjDataBase = null;
        private string Log;
        private bool bIndex;
        #endregion

        #region Metodo Index
        public void Index(ref ClsAportFijo ObjAportFijo)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "DB_BasePruebas",
                NombreTabla = "AportFija",
                NombreSP = "dbo.SP_AportFija_Index",
                Scalar = false
            };

            bIndex = true;
            ObjDataBase.DtParametros.Rows.Add(@"@U_EmpId", "4", ObjAportFijo.U_EmpId);
            Ejecutar(ref ObjAportFijo);
        }
        #endregion

        #region CRUD Aportaciones
        public void Create(ref ClsAportFijo ObjAportFijo)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "DB_BasePruebas",
                NombreTabla = "AportFija",
                NombreSP = "dbo.SP_AportFija_Create",
                Scalar = false
            };

            ObjDataBase.DtParametros.Rows.Add(@"@U_EmpId", "4", ObjAportFijo.U_EmpId);
            ObjDataBase.DtParametros.Rows.Add(@"@U_IdAportacion", "4", ObjAportFijo.U_IdAportacion);
            ObjDataBase.DtParametros.Rows.Add(@"@Costo", "9", ObjAportFijo.Costo);

            Ejecutar(ref ObjAportFijo);
        }

        public void Read(ref ClsAportFijo ObjAportFijo)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "DB_BasePruebas",
                NombreTabla = "AportFija",
                NombreSP = "dbo.SP_AportFija_Read",
                Scalar = false
            };

            bIndex = false;
            ObjDataBase.DtParametros.Rows.Add(@"@U_EmpId", "4", ObjAportFijo.U_EmpId);
            ObjDataBase.DtParametros.Rows.Add(@"@U_IdAportacion", "4", ObjAportFijo.U_IdAportacion);
            Ejecutar(ref ObjAportFijo);
        }

        public void Update(ref ClsAportFijo ObjAportFijo)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "DB_BasePruebas",
                NombreTabla = "AportFija",
                NombreSP = "dbo.SP_AportFija_Update",
                Scalar = true
            };

            ObjDataBase.DtParametros.Rows.Add(@"@U_EmpId", "4", ObjAportFijo.U_EmpId);
            ObjDataBase.DtParametros.Rows.Add(@"@U_IdAportacion", "4", ObjAportFijo.U_IdAportacion);
            ObjDataBase.DtParametros.Rows.Add(@"@Costo", "9", ObjAportFijo.Costo);

            Ejecutar(ref ObjAportFijo);
        }

        public void Delete(ref ClsAportFijo ObjAportFijo)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "DB_BasePruebas",
                NombreTabla = "AportFija",
                NombreSP = "dbo.SP_AportFija_Delete",
                Scalar = true
            };

            ObjDataBase.DtParametros.Rows.Add(@"@U_EmpId", "4", ObjAportFijo.U_EmpId);
            ObjDataBase.DtParametros.Rows.Add(@"@U_IdAportacion", "4", ObjAportFijo.U_IdAportacion);
            Ejecutar(ref ObjAportFijo);
        }
        #endregion

        #region Metodos Privados
        private void Ejecutar(ref ClsAportFijo ObjAportFijo)
        {
            ObjDataBase.CRUD(ref ObjDataBase);

            if (ObjDataBase.MensajeErrorDB == null)
            {
                if (ObjDataBase.Scalar)
                {
                    ObjAportFijo.ValorEscalar = ObjDataBase.ValorScalar;
                }
                else
                {
                    ObjAportFijo.DtResultados = ObjDataBase.DsResultados.Tables[0];
                    if (ObjAportFijo.DtResultados.Rows.Count == 1 && bIndex == false)
                    {
                        foreach (DataRow dr in ObjAportFijo.DtResultados.Rows)
                        {
                            try
                            {
                                ObjAportFijo.U_EmpId = Convert.ToByte(dr["U_EmpId"].ToString());
                                ObjAportFijo.U_IdAportacion = Convert.ToByte(dr["U_IdAportacion"].ToString());
                                ObjAportFijo.Costo = Convert.ToSingle(dr["Costo"].ToString());
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
                ObjAportFijo.MsjError = ObjDataBase.MensajeErrorDB;
            }
        }
        #endregion
    }
}
