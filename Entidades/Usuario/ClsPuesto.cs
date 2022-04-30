using System.Data;

namespace Entidades.Usuario
{
    public class ClsPuesto
    {
        #region Atributos Privados
        private int _puestoId;
        private string _puesto, _descripcion;

        //Atributos de manejo de la base de datos
        private string _msjError, _valorEscalar;
        private DataTable _dtResultados;
        #endregion

        #region Atributos Publicos
        public int PuestoId { get => _puestoId; set => _puestoId = value; }
        public string Puesto { get => _puesto; set => _puesto = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public string MsjError { get => _msjError; set => _msjError = value; }
        public string ValorEscalar { get => _valorEscalar; set => _valorEscalar = value; }
        public DataTable DtResultados { get => _dtResultados; set => _dtResultados = value; }
        #endregion
    }
}
