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
        private string Log;
        #endregion

        #region Metodo Index
        public void Index(ref ClsDepartamento ObjDepartamento)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "DB_BasePruebas",
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
                NombreDB = "DB_BasePruebas",
                NombreTabla = "Departamento",
                NombreSP = "dbo.SP_CargarDepartamento",
                Scalar = false
            };

            CargarListaDepto(ref ObjDepartamento);
        }

        #endregion

        #region CRUD Departamento
        public void Create(ref ClsDepartamento ObjDepartamento)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "DB_BasePruebas",
                NombreTabla = "Departamento",
                NombreSP = "dbo.SP_Departamento_Create",
                Scalar = false
            };

            ObjDataBase.DtParametros.Rows.Add(@"@Name", "18", ObjDepartamento.Name);
            ObjDataBase.DtParametros.Rows.Add(@"@Remarks", "18", ObjDepartamento.Remarks);
            ObjDataBase.DtParametros.Rows.Add(@"@Activo", "1", ObjDepartamento.Activo);
            ObjDataBase.DtParametros.Rows.Add(@"@Costo", "10", ObjDepartamento.Costo);

            Ejecutar(ref ObjDepartamento);
        }

        public void Read(ref ClsDepartamento ObjDepartamento)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "DB_BasePruebas",
                NombreTabla = "Departamento",
                NombreSP = "dbo.SP_Departamento_Read",
                Scalar = false
            };

            ObjDataBase.DtParametros.Rows.Add(@"@DeptoId", "4", ObjDepartamento.DeptoId);

            Ejecutar(ref ObjDepartamento);
        }

        public void Update(ref ClsDepartamento ObjDepartamento)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "DB_BasePruebas",
                NombreTabla = "Departamento",
                NombreSP = "dbo.SP_Departamento_Update",
                Scalar = true
            };

            ObjDataBase.DtParametros.Rows.Add(@"@DeptoId", "4", ObjDepartamento.DeptoId);
            ObjDataBase.DtParametros.Rows.Add(@"@Name", "18", ObjDepartamento.Name);
            ObjDataBase.DtParametros.Rows.Add(@"@Remarks", "18", ObjDepartamento.Remarks);
            ObjDataBase.DtParametros.Rows.Add(@"@Activo", "1", ObjDepartamento.Activo);
            ObjDataBase.DtParametros.Rows.Add(@"@Costo", "10", ObjDepartamento.Costo);

            Ejecutar(ref ObjDepartamento);
        }

        public void UpdateActivo(ref ClsDepartamento ObjDepartamento)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "DB_BasePruebas",
                NombreTabla = "Departamento",
                NombreSP = "dbo.SP_Departamento_UpdateActivo",
                Scalar = true
            };

            ObjDataBase.DtParametros.Rows.Add(@"@DeptoId", "4", ObjDepartamento.DeptoId);
            ObjDataBase.DtParametros.Rows.Add(@"@Activo", "1", ObjDepartamento.Activo);

            Ejecutar(ref ObjDepartamento);
        }

        public void Delete(ref ClsDepartamento ObjDepartamento)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreDB = "DB_BasePruebas",
                NombreTabla = "Area",
                NombreSP = "dbo.SP_Departamento_Delete",
                Scalar = true
            };

            ObjDataBase.DtParametros.Rows.Add(@"@DeptoId", "4", ObjDepartamento.DeptoId);

            Ejecutar(ref ObjDepartamento);
        }
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
                            try
                            {
                                ObjDepartamento.DeptoId = Convert.ToByte(dr["DeptoId"].ToString());
                                ObjDepartamento.Name = dr["Name"].ToString();
                                ObjDepartamento.Remarks = dr["Remarks"].ToString();
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
                    ObjDepartamento.DtResultados.Rows.Add(ObjDepartamento.DtResultados.Rows.Count + 1, "Nuevo Departamento");
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
