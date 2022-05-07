using System.Data;

namespace Entidades.Usuario
{
    public class ClsEstado
    {
        #region Atriburos Privados
        private string _code, _country, _name, _gNRECode, _gSTCode;
        private int _userSing, _eCode;
        private char? _gSTIsUT;

        //Atributos de manejo de la base de datos
        private string _msjError, _valorEscalar;
        private DataTable _dtResultados;
        #endregion

        #region Atributos Publicos
        public string Code { get => _code; set => _code = value; }
        public string Country { get => _country; set => _country = value; }
        public string Name { get => _name; set => _name = value; }
        public string GNRECode { get => _gNRECode; set => _gNRECode = value; }
        public string GSTCode { get => _gSTCode; set => _gSTCode = value; }
        public int UserSing { get => _userSing; set => _userSing = value; }
        public int ECode { get => _eCode; set => _eCode = value; }
        public char? GSTIsUT { get => _gSTIsUT; set => _gSTIsUT = value; }
        public string MsjError { get => _msjError; set => _msjError = value; }
        public string ValorEscalar { get => _valorEscalar; set => _valorEscalar = value; }
        public DataTable DtResultados { get => _dtResultados; set => _dtResultados = value; }
        #endregion
    }
}
