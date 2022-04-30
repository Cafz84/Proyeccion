using AccesoDatos.DataBase;
using Entidades.Usuario;
using System;
using System.Data;
using System.Linq;

namespace LogicaNegocio.Usuario
{
    public class ClsPuestoLn
    {
        #region Variables Privadas
        private ClsDataBase ObjDataBase = null;
        #endregion

        #region Metodo Index
        public void Index(ref ClsPuesto ObjPuesto)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreTabla = "Puesto",
                NombreSP = "dbo.SP_Puesto_Index",
                Scalar = false
            };

            Ejecutar(ref ObjPuesto);
        }

        public void CargarCbPuesto(ref ClsPuesto ObjPuesto)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreTabla = "Puesto",
                NombreSP = "dbo.SP_CargarPuesto",
                Scalar = false
            };

            CargarListaPuesto(ref ObjPuesto);
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
                    if (ObjPuesto.DtResultados.Rows.Count == 1)
                    {
                        foreach (DataRow dr in ObjPuesto.DtResultados.Rows)
                        {
                            ObjPuesto.PuestoId = Convert.ToByte(dr["PuestoId"].ToString());
                            ObjPuesto.Puesto = dr["Puesto"].ToString();
                            ObjPuesto.Descripcion = dr["Descripcion"].ToString();
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
