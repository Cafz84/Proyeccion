using System.Data;

namespace Entidades.Usuario
{
    public class ClsArea
    {
        #region Atributos Privados
        private int _areaId;
        private string _area, _descripcion;
        private bool _activo;

        //Atributos de manejo de la base de datos
        private string _msjError, _valorEscalar;
        private DataTable _dtResultados;
        #endregion

        #region Atributos Publicos
        public int AreaId { get => _areaId; set => _areaId = value; }
        public string Area { get => _area; set => _area = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public string MsjError { get => _msjError; set => _msjError = value; }
        public string ValorEscalar { get => _valorEscalar; set => _valorEscalar = value; }
        public DataTable DtResultados { get => _dtResultados; set => _dtResultados = value; }
        public bool Activo { get => _activo; set => _activo = value; }
        #endregion
    }
}
