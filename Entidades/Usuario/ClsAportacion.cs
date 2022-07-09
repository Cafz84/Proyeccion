using System.Data;

namespace Entidades.Usuario
{
    public class ClsAportacion
    {
        #region Variables Privadas
        private int _idAportacion;
        private string _aportacion, _descripcion;
        private bool _activo;

        //Atributos de manejo de la base de datos
        private string _msjError, _valorEscalar;
        private DataTable _dtResultados;
        #endregion

        #region Variables Publicas
        public int IdAportacion { get => _idAportacion; set => _idAportacion = value; }
        public string Aportacion { get => _aportacion; set => _aportacion = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public bool Activo { get => _activo; set => _activo = value; }
        public string MsjError { get => _msjError; set => _msjError = value; }
        public string ValorEscalar { get => _valorEscalar; set => _valorEscalar = value; }
        public DataTable DtResultados { get => _dtResultados; set => _dtResultados = value; }
        #endregion
    }
}
