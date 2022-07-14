using AccesoDatos.DataBase;
using Entidades.Usuario;
using System;
using System.Data;

namespace LogicaNegocio.Usuario
{
    public class ClsPuestoLn
    {
        #region Variables Privadas
        private ClsDataBase ObjDataBase = null;
        private string Log;
        private bool bIndex;
        #endregion

        #region Metodo Index
        public void Index(ref ClsPuesto ObjPuesto)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "Puesto",
                NombreSP = "dbo.SP_Puesto_Index",
                Scalar = false
            };

            bIndex = true;
            ObjDataBase.DtParametros.Rows.Add(@"@Puesto", "18", ObjPuesto.Puesto);
            Ejecutar(ref ObjPuesto);
        }

        public void CargarCbPuesto(ref ClsPuesto ObjPuesto)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "Puesto",
                NombreSP = "dbo.SP_CargarPuesto",
                Scalar = false
            };

            CargarListaPuesto(ref ObjPuesto);
        }
        #endregion

        #region CRUD Puesto
        public void Create(ref ClsPuesto ObjPuesto)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "Puesto",
                NombreSP = "dbo.SP_Puesto_Create",
                Scalar = false
            };

            ObjDataBase.DtParametros.Rows.Add(@"@Puesto", "18", ObjPuesto.Puesto);
            ObjDataBase.DtParametros.Rows.Add(@"@Descripcion", "18", ObjPuesto.Descripcion);
            ObjDataBase.DtParametros.Rows.Add(@"@Activo", "1", ObjPuesto.Activo);

            Ejecutar(ref ObjPuesto);
        }

        public void Read(ref ClsPuesto ObjPuesto)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "Puesto",
                NombreSP = "dbo.SP_Puesto_Read",
                Scalar = false
            };

            bIndex = false;
            ObjDataBase.DtParametros.Rows.Add(@"@PuestoId", "4", ObjPuesto.PuestoId);

            Ejecutar(ref ObjPuesto);
        }

        public void ReadRepetido(ref ClsPuesto ObjPuesto)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "Puesto",
                NombreSP = "dbo.SP_Puesto_ReadRepetido",
                Scalar = false
            };

            bIndex = false;
            ObjDataBase.DtParametros.Rows.Add(@"@Puesto", "18", ObjPuesto.Puesto);

            Ejecutar(ref ObjPuesto);
        }

        public void Update(ref ClsPuesto ObjPuesto)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "Puesto",
                NombreSP = "dbo.SP_Puesto_Update",
                Scalar = true
            };

            ObjDataBase.DtParametros.Rows.Add(@"@PuestoId", "4", ObjPuesto.PuestoId);
            ObjDataBase.DtParametros.Rows.Add(@"@Puesto", "18", ObjPuesto.Puesto);
            ObjDataBase.DtParametros.Rows.Add(@"@Descripcion", "18", ObjPuesto.Descripcion);
            ObjDataBase.DtParametros.Rows.Add(@"@Activo", "1", ObjPuesto.Activo);

            Ejecutar(ref ObjPuesto);
        }

        public void UpdateActivo(ref ClsPuesto ObjPuesto)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "Puesto",
                NombreSP = "dbo.SP_Puesto_UpdateActivo",
                Scalar = true
            };

            ObjDataBase.DtParametros.Rows.Add(@"@PuestoId", "4", ObjPuesto.PuestoId);
            ObjDataBase.DtParametros.Rows.Add(@"@Activo", "1", ObjPuesto.Activo);

            Ejecutar(ref ObjPuesto);
        }

        public void Delete(ref ClsPuesto ObjPuesto)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "ERPLavoraziones_Monnaaci",
                NombreTabla = "Puesto",
                NombreSP = "dbo.SP_Puesto_Delete",
                Scalar = true
            };

            ObjDataBase.DtParametros.Rows.Add(@"@PuestoId", "4", ObjPuesto.PuestoId);

            Ejecutar(ref ObjPuesto);
        }
        #endregion

        #region Metodos Privados
        private void Ejecutar(ref ClsPuesto ObjPuesto)
        {
            ObjDataBase.CRUD(ref ObjDataBase);

            if (ObjDataBase.MensajeErrorDB == null)
            {
                if (ObjDataBase.Scalar)
                {
                    ObjPuesto.ValorEscalar = ObjDataBase.ValorScalar;
                }
                else
                {
                    ObjPuesto.DtResultados = ObjDataBase.DsResultados.Tables[0];
                    if (ObjPuesto.DtResultados.Rows.Count == 1 && bIndex == false)
                    {
                        foreach (DataRow dr in ObjPuesto.DtResultados.Rows)
                        {
                            try
                            {
                                ObjPuesto.PuestoId = Convert.ToByte(dr["PuestoId"].ToString());
                                ObjPuesto.Puesto = dr["Puesto"].ToString();
                                ObjPuesto.Descripcion = dr["Descripcion"].ToString();
                            }
                            catch(Exception ex)
                            {
                                Log = ex.ToString();
                            }
                        }
                    }
                }
            }
            else
            {
                ObjPuesto.MsjError = ObjDataBase.MensajeErrorDB;
            }
        }

        private void CargarListaPuesto(ref ClsPuesto ObjPuesto)
        {
            ObjDataBase.CRUD(ref ObjDataBase);

            if (ObjDataBase.MensajeErrorDB == null)
            {
                if (ObjDataBase.Scalar)
                {
                    ObjPuesto.ValorEscalar = ObjDataBase.ValorScalar;
                }
                else
                {
                    ObjPuesto.DtResultados = ObjDataBase.DsResultados.Tables[0];
                    if (ObjPuesto.DtResultados.Rows.Count == 1)
                    {
                        foreach (DataRow dr in ObjPuesto.DtResultados.Rows)
                        {
                            ObjPuesto.PuestoId = Convert.ToByte(dr["PuestoId"].ToString());
                            ObjPuesto.Puesto = dr["Puesto"].ToString();
                        }
                    }
                    ObjPuesto.DtResultados.Rows.Add(ObjPuesto.DtResultados.Rows.Count + 1, "Nuevo Puesto");
                }
            }
            else
            {
                ObjPuesto.MsjError = ObjDataBase.MensajeErrorDB;
            }
        }
        #endregion
    }
}
