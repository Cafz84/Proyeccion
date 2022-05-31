using System;
using System.Data;

namespace Entidades.Usuario
{
    public class ClsEscaneo
    {
        #region Variables Privadas
        private int _programa, _cantidad, _nCajaEmbarque, _nEscaneoXCaja, _nEmbarque;
        private string _escaneo, _area, _selecc, _pO, _itemCode, _cod_Modelo, _modelo, _cod_Color, _color, _punto, _error;
        private DateTime _fechaAlta;

        //Atributos de manejo de la base de datos
        private string _msjError, _valorEscalar;
        private DataTable _dtResultados;
        #endregion

        #region Variables Publicas
        public int Programa { get => _programa; set => _programa = value; }
        public int Cantidad { get => _cantidad; set => _cantidad = value; }
        public int NCajaEmbarque { get => _nCajaEmbarque; set => _nCajaEmbarque = value; }
        public string Escaneo { get => _escaneo; set => _escaneo = value; }
        public string Area { get => _area; set => _area = value; }
        public string Selecc { get => _selecc; set => _selecc = value; }
        public string PO { get => _pO; set => _pO = value; }
        public string ItemCode { get => _itemCode; set => _itemCode = value; }
        public string Cod_Modelo { get => _cod_Modelo; set => _cod_Modelo = value; }
        public string Modelo { get => _modelo; set => _modelo = value; }
        public string Cod_Color { get => _cod_Color; set => _cod_Color = value; }
        public string Color { get => _color; set => _color = value; }
        public string Punto { get => _punto; set => _punto = value; }
        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }
        public string MsjError { get => _msjError; set => _msjError = value; }
        public string ValorEscalar { get => _valorEscalar; set => _valorEscalar = value; }
        public DataTable DtResultados { get => _dtResultados; set => _dtResultados = value; }
        public string Error { get => _error; set => _error = value; }
        public int NEscaneoXCaja { get => _nEscaneoXCaja; set => _nEscaneoXCaja = value; }
        public int NEmbarque { get => _nEmbarque; set => _nEmbarque = value; }
        #endregion
    }
}
