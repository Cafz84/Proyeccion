﻿using System;
using System.Data;
using System.Data.SqlClient;

namespace AccesoDatos.DataBase
{
    public class ClsDataBase
    {

        #region Variables privadas

        private SqlConnection _objSqlConnection; //Permite crear la conexion con la BD
        private SqlDataAdapter _objSqlDataAdapter; //Permite hacer lectura de datos se utila para SELECT
        private SqlCommand _objSqlCommand; //Permite enviar comandos para CREAR, ACTUALIZAR Y BORRAR informacion en la BD
        private DataSet _dsResultados; //Permite resivir los valores en una lista de tablas generadas de una consulta SELECT
        private DataTable _dtParametros; //Nos va a permitir mandar los paramaetros a nuestros procedimientos almacenados en la BD
        private string _nombreTabla, _nombreSP, _mensajeErrorDB, _valorScalar, _nombreDB;
        private bool _scalar; //Se utiliza en caso de necesitar que al ejecutar un procedimiento se realize alguna accione, solo se regres numero

        #endregion

        #region Variables publicas

        public SqlConnection ObjSqlConnection { get => _objSqlConnection; set => _objSqlConnection = value; }
        public SqlDataAdapter ObjSqlDataAdapter { get => _objSqlDataAdapter; set => _objSqlDataAdapter = value; }
        public SqlCommand ObjSqlCommand { get => _objSqlCommand; set => _objSqlCommand = value; }
        public DataSet DsResultados { get => _dsResultados; set => _dsResultados = value; }
        public DataTable DtParametros { get => _dtParametros; set => _dtParametros = value; }
        public string NombreTabla { get => _nombreTabla; set => _nombreTabla = value; }
        public string NombreSP { get => _nombreSP; set => _nombreSP = value; }
        public string MensajeErrorDB { get => _mensajeErrorDB; set => _mensajeErrorDB = value; }
        public string ValorScalar { get => _valorScalar; set => _valorScalar = value; }
        public string NombreDB { get => _nombreDB; set => _nombreDB = value; }
        public bool Scalar { get => _scalar; set => _scalar = value; }
        public object DBnull { get; private set; }

        #endregion

        #region Constructores

        public ClsDataBase()
        {
            DtParametros = new DataTable("SpParametros");
            DtParametros.Columns.Add("Nombre");
            DtParametros.Columns.Add("TipoDato");
            DtParametros.Columns.Add("Valor");
        }

        #endregion

        #region Metodos privados

        private void CrearConexionBaseDatos(ref ClsDataBase ObjDataBase)
        {
            switch (ObjDataBase.NombreDB)
            {
                case "DB_BasePruebas":
                    ObjDataBase.ObjSqlConnection = new SqlConnection(Properties.Settings.Default.cadenaConeccion_DB_BasePruebas);
                    break;
                case "Lavoraziones_Monnaaci_P":
                    ObjDataBase.ObjSqlConnection = new SqlConnection(Properties.Settings.Default.cadenaConeccion_Lavoraciones_Monnaaci_p);
                    break;
                case "Pruebas_Lavoraziones":
                    ObjDataBase.ObjSqlConnection = new SqlConnection(Properties.Settings.Default.cadenaConeccion_Pruebas_Lavoraziones);
                    break;
                case "ERPLavoraziones_Monnaaci":
                    ObjDataBase.ObjSqlConnection = new SqlConnection(Properties.Settings.Default.cadenaConeccion_ERPLavoraziones_Monnaaci);
                    break;
                default:
                    break;
            }
        }

        private void ValidarConexionBaseDatos(ref ClsDataBase ObjDataBase)
        {
            if(ObjDataBase.ObjSqlConnection.State == ConnectionState.Closed)
            {
                ObjDataBase.ObjSqlConnection.Open();
            }
            else
            {
                ObjDataBase.ObjSqlConnection.Close();
                ObjDataBase.ObjSqlConnection.Dispose();
            }
        }

        private void AgregarParametrosBaseDatos(ref ClsDataBase ObjDataBase)
        {
            if (ObjDataBase.DtParametros != null)
            {
                SqlDbType TipoDatoSQL = new SqlDbType();

                foreach (DataRow dt in ObjDataBase.DtParametros.Rows)
                {
                    switch (dt[1])
                    {
                        case "1":
                            TipoDatoSQL = SqlDbType.Bit;
                            break;
                        case "2":
                            TipoDatoSQL = SqlDbType.TinyInt;
                            break;
                        case "3":
                            TipoDatoSQL = SqlDbType.SmallInt;
                            break;
                        case "4":
                            TipoDatoSQL = SqlDbType.Int;
                            break;
                        case "5":
                            TipoDatoSQL = SqlDbType.BigInt;
                            break;
                        case "6":
                            TipoDatoSQL = SqlDbType.Decimal;
                            break;
                        case "7":
                            TipoDatoSQL = SqlDbType.SmallMoney;
                            break;
                        case "8":
                            TipoDatoSQL = SqlDbType.Money;
                            break;
                        case "9":
                            TipoDatoSQL = SqlDbType.Float;
                            break;
                        case "10":
                            TipoDatoSQL = SqlDbType.Real;
                            break;
                        case "11":
                            TipoDatoSQL = SqlDbType.Date;
                            break;
                        case "12":
                            TipoDatoSQL = SqlDbType.Time;
                            break;
                        case "13":
                            TipoDatoSQL = SqlDbType.SmallDateTime;
                            break;
                        case "14":
                            TipoDatoSQL = SqlDbType.DateTime;
                            break;
                        case "15":
                            TipoDatoSQL = SqlDbType.Char;
                            break;
                        case "16":
                            TipoDatoSQL = SqlDbType.NChar;
                            break;
                        case "17":
                            TipoDatoSQL = SqlDbType.VarChar;
                            break;
                        case "18":
                            TipoDatoSQL = SqlDbType.NVarChar;
                            break;
                        default:
                            break;
                    }

                    if (ObjDataBase.Scalar)
                    {
                        if (string.IsNullOrEmpty(dt[2].ToString()))
                        {
                            ObjDataBase.ObjSqlCommand.Parameters.Add(dt[0].ToString(), TipoDatoSQL).Value= DBNull.Value;
                        }
                        else
                        {
                            ObjDataBase.ObjSqlCommand.Parameters.Add(dt[0].ToString(), TipoDatoSQL).Value = dt[2].ToString();
                        }
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(dt[2].ToString()))
                        {
                            ObjDataBase.ObjSqlDataAdapter.SelectCommand.Parameters.Add(dt[0].ToString(), TipoDatoSQL).Value = DBNull.Value;
                        }
                        else
                        {
                            ObjDataBase.ObjSqlDataAdapter.SelectCommand.Parameters.Add(dt[0].ToString(), TipoDatoSQL).Value = dt[2].ToString();
                        }
                    }

                }
            }
        }

        private void PrepararConexionBaseDatos(ref ClsDataBase ObjDataBase)
        {
            CrearConexionBaseDatos(ref ObjDataBase);
            ValidarConexionBaseDatos(ref ObjDataBase);
        }

        private void EjecutarDataAdapter(ref ClsDataBase ObjDataBase)
        {
            try
            {
                PrepararConexionBaseDatos(ref ObjDataBase);

                ObjDataBase.ObjSqlDataAdapter = new SqlDataAdapter(ObjDataBase.NombreSP, ObjDataBase.ObjSqlConnection);
                ObjDataBase.ObjSqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                AgregarParametrosBaseDatos(ref ObjDataBase);
                ObjDataBase.DsResultados=new DataSet();
                ObjDataBase.ObjSqlDataAdapter.Fill(ObjDataBase.DsResultados, ObjDataBase.NombreTabla);

            }
            catch (Exception ex)
            {
                ObjDataBase.MensajeErrorDB = ex.Message.ToString();
            }
            finally
            {
                if (ObjDataBase.ObjSqlConnection.State == ConnectionState.Open)
                {
                    ValidarConexionBaseDatos(ref ObjDataBase);
                }
            }
        }

        private void EjecutarCommand(ref ClsDataBase ObjDataBase)
        {
            try
            {
                PrepararConexionBaseDatos(ref ObjDataBase);
                ObjDataBase.ObjSqlCommand = new SqlCommand(ObjDataBase.NombreSP, ObjDataBase.ObjSqlConnection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                AgregarParametrosBaseDatos(ref ObjDataBase);

                if (ObjDataBase.Scalar)
                {
                    ObjDataBase.ValorScalar = ObjDataBase.ObjSqlCommand.ExecuteScalar().ToString().Trim();
                }
                else
                {
                    ObjDataBase.ObjSqlCommand.ExecuteNonQuery();
                }
            }
            catch   (Exception ex)
            {
                ObjDataBase.MensajeErrorDB = ex.Message.ToString();
            }
            finally
            {
                if (ObjDataBase.ObjSqlConnection.State == ConnectionState.Open)
                {
                    ValidarConexionBaseDatos(ref ObjDataBase);
                }
            }
        }

        #endregion

        #region Metodos publicos

        public void CRUD(ref ClsDataBase ObjDataBase)
        {
            if (ObjDataBase.Scalar)
            {
                EjecutarCommand(ref ObjDataBase);
            }
            else
            {
                EjecutarDataAdapter(ref ObjDataBase);
            }
        }

        #endregion

    }
}
