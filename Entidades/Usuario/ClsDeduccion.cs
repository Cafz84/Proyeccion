using System.Data;

namespace Entidades.Usuario
{
    public class ClsDeduccion
    {
        #region Variables Privadas
        private int _idDeduccion;
        private string _deduccion, _descripcion;
        private bool _activo;

        //Atributos de manejo de la base de datos
        private string _msjError, _valorEscalar;
        private DataTable _dtResultados;
        #endregion

        #region Variables Publicas
        public int IdDeduccion { get => _idDeduccion; set => _idDeduccion = value; }
        public string Deduccion { get => _deduccion; set => _deduccion = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public bool Activo { get => _activo; set => _activo = value; }
        public string MsjError { get => _msjError; set => _msjError = value; }
        public string ValorEscalar { get => _valorEscalar; set => _valorEscalar = value; }
        public DataTable DtResultados { get => _dtResultados; set => _dtResultados = value; }
        #endregion
    }
}
