using System.Data;

namespace Entidades.Usuario
{
    public class ClsPais
    {
        #region Atributos privados
        private string _code, _name, _reportCode, _vallDomAcct, _uICCode, _cntCodNum, _siscomex;
        private int _addrFormat, _userSing, _taxIdDigts, _bnkCodDgts, _bnkBchDgts, _bnkActDgts, _bnkCtKDgts;
        private char? _isEC, _vallban, _isBlackLst, _isIntraS, _eAEU;

        //Atributos de manejo de la base de datos
        private string _msjError, _valorEscalar;
        private DataTable _dtResultados;
        #endregion

        #region Atributos publicos
        public string Code { get => _code; set => _code = value; }
        public string Name { get => _name; set => _name = value; }
        public string ReportCode { get => _reportCode; set => _reportCode = value; }
        public string VallDomAcct { get => _vallDomAcct; set => _vallDomAcct = value; }
        public string UICCode { get => _uICCode; set => _uICCode = value; }
        public string CntCodNum { get => _cntCodNum; set => _cntCodNum = value; }
        public string Siscomex { get => _siscomex; set => _siscomex = value; }
        public int AddrFormat { get => _addrFormat; set => _addrFormat = value; }
        public int UserSing { get => _userSing; set => _userSing = value; }
        public int TaxIdDigts { get => _taxIdDigts; set => _taxIdDigts = value; }
        public int BnkCodDgts { get => _bnkCodDgts; set => _bnkCodDgts = value; }
        public int BnkBchDgts { get => _bnkBchDgts; set => _bnkBchDgts = value; }
        public int BnkActDgts { get => _bnkActDgts; set => _bnkActDgts = value; }
        public int BnkCtKDgts { get => _bnkCtKDgts; set => _bnkCtKDgts = value; }
        public char? IsEC { get => _isEC; set => _isEC = value; }
        public char? Vallban { get => _vallban; set => _vallban = value; }
        public char? IsBlackLst { get => _isBlackLst; set => _isBlackLst = value; }
        public char? IsIntraS { get => _isIntraS; set => _isIntraS = value; }
        public char? EAEU { get => _eAEU; set => _eAEU = value; }
        public string MsjError { get => _msjError; set => _msjError = value; }
        public string ValorEscalar { get => _valorEscalar; set => _valorEscalar = value; }
        public DataTable DtResultados { get => _dtResultados; set => _dtResultados = value; }
        #endregion
    }
}
