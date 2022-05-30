using System.Data;

namespace Entidades.Usuario
{
    public class ClsTipoEscaneo
    {
        #region Atributos Privados

        private int _tipoId;
        private string _nombre, _descripcion;
        private bool _activo;

        //Atributos de manejo de la base de datos
        private string _msjError, _valorEscalar;
        private DataTable _dtResultados;

        #endregion

        #region Atributos Publicos

        public int TipoId { get => _tipoId; set => _tipoId = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public bool Activo { get => _activo; set => _activo = value; }
        public string MsjError { get => _msjError; set => _msjError = value; }
        public string ValorEscalar { get => _valorEscalar; set => _valorEscalar = value; }
        public DataTable DtResultados { get => _dtResultados; set => _dtResultados = value; }

        #endregion
    }
}
