using System.Data;

namespace Entidades.Usuario
{
    public class ClsAvance
    {
        #region Variables privadas
        private float _id;
        private char _area;
        private string _avance, _descripcion;

        //Atributos de manejo de la base de datos
        private string _msjError, _valorEscalar;
        private DataTable _dtResultados;
        #endregion

        #region Variables Publicas
        public float Id { get => _id; set => _id = value; }
        public char Area { get => _area; set => _area = value; }
        public string Avance { get => _avance; set => _avance = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public string MsjError { get => _msjError; set => _msjError = value; }
        public string ValorEscalar { get => _valorEscalar; set => _valorEscalar = value; }
        public DataTable DtResultados { get => _dtResultados; set => _dtResultados = value; }
        #endregion
    }
}
