using System.Data;

namespace Entidades.Usuario
{
    public class ClsCiudad
    {
        #region Atriburos Privados
        private string _code, _estado, _name;

        //Atributos de manejo de la base de datos
        private string _msjError, _valorEscalar;
        private DataTable _dtResultados;
        #endregion

        #region Atributos Publicos
        public string Code { get => _code; set => _code = value; }
        public string Estado { get => _estado; set => _estado = value; }
        public string Name { get => _name; set => _name = value; }
        public string MsjError { get => _msjError; set => _msjError = value; }
        public string ValorEscalar { get => _valorEscalar; set => _valorEscalar = value; }
        public DataTable DtResultados { get => _dtResultados; set => _dtResultados = value; }
        #endregion
    }
}
