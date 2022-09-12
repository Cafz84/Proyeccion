using AccesoDatos.DataBase;
using Entidades.Usuario;
using System;
using System.Data;

namespace LogicaNegocio.Usuario
{
    public class ClsAvanceLn
    {
        #region Variables Privadas
        private ClsDataBase ObjDataBase = null;
        private string Log;
        private bool bIndex;
        #endregion

        #region Metodos Index
        public void Index(ref ClsAvance ObjAvance)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "Avance",
                NombreSP = "dbo.SP_Avance_Index",
                Scalar = false
            };

            bIndex = true;
            ObjDataBase.DtParametros.Rows.Add(@"@Avance", "18", ObjAvance.Avance);
            Ejecutar(ref ObjAvance);
        }

        public void IndexArea(ref ClsAvance ObjAvance)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "Avance",
                NombreSP = "dbo.SP_Avance_IndexArea",
                Scalar = false
            };

            bIndex = true;
            ObjDataBase.DtParametros.Rows.Add(@"@Area", "15", ObjAvance.Area);
            Ejecutar(ref ObjAvance);
        }
        #endregion

        #region CRUD Avance
        public void Create(ref ClsAvance ObjAvance)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "Avance",
                NombreSP = "dbo.SP_Avance_Create",
                Scalar = false
            };

            ObjDataBase.DtParametros.Rows.Add(@"@Id", "9", ObjAvance.Id);
            ObjDataBase.DtParametros.Rows.Add(@"@Area", "15", ObjAvance.Area);
            ObjDataBase.DtParametros.Rows.Add(@"@Avance", "18", ObjAvance.Avance);
            ObjDataBase.DtParametros.Rows.Add(@"@Descripcion", "18", ObjAvance.Descripcion);

            Ejecutar(ref ObjAvance);
        }

        public void Read(ref ClsAvance ObjAvance)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "Avance",
                NombreSP = "dbo.SP_Avance_Read",
                Scalar = false
            };

            bIndex = false;
            ObjDataBase.DtParametros.Rows.Add(@"@Id", "9", ObjAvance.Id);
            ObjDataBase.DtParametros.Rows.Add(@"@Area", "15", ObjAvance.Area);
            Ejecutar(ref ObjAvance);
        }

        public void Update(ref ClsAvance ObjAvance)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "Avance",
                NombreSP = "dbo.SP_Avance_Update",
                Scalar = true
            };

            ObjDataBase.DtParametros.Rows.Add(@"@Id", "9", ObjAvance.Id);
            ObjDataBase.DtParametros.Rows.Add(@"@Area", "15", ObjAvance.Area);
            ObjDataBase.DtParametros.Rows.Add(@"@Avance", "18", ObjAvance.Avance);
            ObjDataBase.DtParametros.Rows.Add(@"@Descripcion", "18", ObjAvance.Descripcion);

            Ejecutar(ref ObjAvance);
        }

        public void Delete(ref ClsAvance ObjAvance)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "Avance",
                NombreSP = "dbo.SP_Avance_Delete",
                Scalar = true
            };

            ObjDataBase.DtParametros.Rows.Add(@"@Id", "9", ObjAvance.Id);
            ObjDataBase.DtParametros.Rows.Add(@"@Area", "15", ObjAvance.Area);

            Ejecutar(ref ObjAvance);
        }
        #endregion

        #region Metodos Privados
        private void Ejecutar(ref ClsAvance ObjAvance)
        {
            ObjDataBase.CRUD(ref ObjDataBase);

            if (ObjDataBase.MensajeErrorDB == null)
            {
                if (ObjDataBase.Scalar)
                {
                    ObjAvance.ValorEscalar = ObjDataBase.ValorScalar;
                }
                else
                {
                    ObjAvance.DtResultados = ObjDataBase.DsResultados.Tables[0];
                    if (ObjAvance.DtResultados.Rows.Count == 1 && bIndex == false)
                    {
                        foreach (DataRow dr in ObjAvance.DtResultados.Rows)
                        {
                            try
                            {
                                ObjAvance.Id = Convert.ToSingle(dr["Id"].ToString());
                                ObjAvance.Area = Convert.ToChar(dr["Area"].ToString());
                                ObjAvance.Avance = dr["Avance"].ToString();
                                ObjAvance.Descripcion = dr["Descripcion"].ToString();
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
                ObjAvance.MsjError = ObjDataBase.MensajeErrorDB;
            }
        }
        #endregion
    }
}
