using System.Data;

namespace Entidades.Usuario
{
    public class ClsTablasSAP
    {
        #region Variables Privadas
        private string _code, _u_ModCode, _u_ModDesc;

        //Atributos de manejo de la base de datos
        private string _msjError, _valorEscalar;
        private DataTable _dtResultados;
        #endregion

        #region Variables Publicas
        public string Code { get => _code; set => _code = value; }
        public string U_ModCode { get => _u_ModCode; set => _u_ModCode = value; }
        public string U_ModDesc { get => _u_ModDesc; set => _u_ModDesc = value; }
        public string MsjError { get => _msjError; set => _msjError = value; }
        public string ValorEscalar { get => _valorEscalar; set => _valorEscalar = value; }
        public DataTable DtResultados { get => _dtResultados; set => _dtResultados = value; }
        #endregion
    }
}
