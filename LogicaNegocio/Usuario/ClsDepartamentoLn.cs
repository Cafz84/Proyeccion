using AccesoDatos.DataBase;
using Entidades.Usuario;
using System;
using System.Data;

namespace LogicaNegocio.Usuario
{
    public class ClsDepartamentoLn
    {
        #region Variables Privadas
        private ClsDataBase ObjDataBase = null;
        #endregion

        #region Metodo Index
        public void Index(ref ClsDepartamento ObjDepartamento)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreTabla = "Departamento",
                NombreSP = "dbo.SP_Departamento_Index",
                Scalar = false
            };

            Ejecutar(ref ObjDepartamento);
        }

        public void CargarCbDepto(ref ClsDepartamento ObjDepartamento)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreTabla = "Departamento",
                NombreSP = "dbo.SP_CargarDepartamento",
                Scalar = false
            };

            CargarListaDepto(ref ObjDepartamento);
        }

        #endregion

        #region CRUD Departamento

        #endregion

        #region Metodos Privados
        private void Ejecutar(ref ClsDepartamento ObjDepartamento)
        {
            ObjDataBase.CRUD(ref ObjDataBase);

            if (ObjDataBase.MensajeErrorDB == null)
            {
                if (ObjDataBase.Scalar)
                {
                    ObjDepartamento.ValorEscalar = ObjDataBase.ValorScalar;
                }
                else
                {
                    ObjDepartamento.DtResultados = ObjDataBase.DsResultados.Tables[0];
                    if (ObjDepartamento.DtResultados.Rows.Count == 1)
                    {
                        foreach (DataRow dr in ObjDepartamento.DtResultados.Rows)
                        {
                            ObjDepartamento.DeptoId = Convert.ToByte(dr["DeptoId"].ToString());
                            ObjDepartamento.Name = dr["Name"].ToString();
                            ObjDepartamento.Remarks = dr["Remarks"].ToString();
                        }
                    }
                }
            }
            else
            {
                ObjDepartamento.MsjError = ObjDataBase.MensajeErrorDB;
            }
        }

        private void CargarListaDepto(ref ClsDepartamento ObjDepartamento)
        {
            ObjDataBase.CRUD(ref ObjDataBase);

            if (ObjDataBase.MensajeErrorDB == null)
            {
                if (ObjDataBase.Scalar)
                {
                    ObjDepartamento.ValorEscalar = ObjDataBase.ValorScalar;
                }
                else
                {
                    ObjDepartamento.DtResultados = ObjDataBase.DsResultados.Tables[0];
                    if (ObjDepartamento.DtResultados.Rows.Count == 1)
                    {
                        foreach (DataRow dr in ObjDepartamento.DtResultados.Rows)
                        {
                            ObjDepartamento.DeptoId = Convert.ToByte(dr["DeptoId"].ToString());
                            ObjDepartamento.Name = dr["Name"].ToString();
                        }
                    }
                    ObjDepartamento.DtResultados.Rows.Add(ObjDepartamento.DtResultados.Rows.Count + 1, "Nuevo Depto.");
                }
            }
            else
            {
                ObjDepartamento.MsjError = ObjDataBase.MensajeErrorDB;
            }
        }
        #endregion
    }
}
