using System;
using System.Data;

namespace Entidades.Usuario
{
    public class ClsDestajo
    {
        #region Variables Privadas
        private int _uEmpId, _uFraccId, _uCantidadFE, _semana, _cEmpId, _cFraccId, _cSemana;
        private string _uEstilo, _programa, _uColor, _nombre, _cEstilo, _cPrograma;
        private float _cantidad, _pago, _uFracCosto, _pagado, _restante;
        private DateTime _fechaCaptura;

        //Atributos de manejo de la base de datos
        private string _msjError, _valorEscalar;
        private DataTable _dtResultados;
        #endregion

        #region Variables Publicas
        public int UEmpId { get => _uEmpId; set => _uEmpId = value; }
        public int UFraccId { get => _uFraccId; set => _uFraccId = value; }
        public int UCantidadFE { get => _uCantidadFE; set => _uCantidadFE = value; }
        public int Semana { get => _semana; set => _semana = value; }
        public string UEstilo { get => _uEstilo; set => _uEstilo = value; }
        public string Programa { get => _programa; set => _programa = value; }
        public string UColor { get => _uColor; set => _uColor = value; }
        public float Cantidad { get => _cantidad; set => _cantidad = value; }
        public float Pago { get => _pago; set => _pago = value; }
        public float UFracCosto { get => _uFracCosto; set => _uFracCosto = value; }
        public DateTime FechaCaptura { get => _fechaCaptura; set => _fechaCaptura = value; }
        public string MsjError { get => _msjError; set => _msjError = value; }
        public string ValorEscalar { get => _valorEscalar; set => _valorEscalar = value; }
        public DataTable DtResultados { get => _dtResultados; set => _dtResultados = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public float Pagado { get => _pagado; set => _pagado = value; }
        public float Restante { get => _restante; set => _restante = value; }
        public int CEmpId { get => _cEmpId; set => _cEmpId = value; }
        public int CFraccId { get => _cFraccId; set => _cFraccId = value; }
        public int CSemana { get => _cSemana; set => _cSemana = value; }
        public string CEstilo { get => _cEstilo; set => _cEstilo = value; }
        public string CPrograma { get => _cPrograma; set => _cPrograma = value; }
        #endregion
    }
}
