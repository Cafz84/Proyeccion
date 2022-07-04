using System.Data;

namespace Entidades.Usuario
{
    public class ClsGrupo
    {
        #region Variables Privadas
        private int _grupoDId;
        private string _grupo, _descripcion, _empleados;
        private bool _activo;

        //Atributos de manejo de la base de datos
        private string _msjError, _valorEscalar;
        private DataTable _dtResultados;
        #endregion

        #region Variables Publicas
        public int GrupoDId { get => _grupoDId; set => _grupoDId = value; }
        public string Grupo { get => _grupo; set => _grupo = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public bool Activo { get => _activo; set => _activo = value; }
        public string MsjError { get => _msjError; set => _msjError = value; }
        public string ValorEscalar { get => _valorEscalar; set => _valorEscalar = value; }
        public DataTable DtResultados { get => _dtResultados; set => _dtResultados = value; }
        public string Empleados { get => _empleados; set => _empleados = value; }
        #endregion
    }
}
