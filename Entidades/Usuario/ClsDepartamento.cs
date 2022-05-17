using System.Data;

namespace Entidades.Usuario
{
    public class ClsDepartamento
    {
        #region Abributos Privados
        private int _deptoId;
        private string _name, _remarks;
        private bool _activo;
        private double _costo;

        //Atributos de manejo de la base de datos
        private string _msjError, _valorEscalar;
        private DataTable _dtResultados;
        #endregion

        #region Abributos Publicos
        public int DeptoId { get => _deptoId; set => _deptoId = value; }
        public string Name { get => _name; set => _name = value; }
        public string Remarks { get => _remarks; set => _remarks = value; }
        public string MsjError { get => _msjError; set => _msjError = value; }
        public string ValorEscalar { get => _valorEscalar; set => _valorEscalar = value; }
        public DataTable DtResultados { get => _dtResultados; set => _dtResultados = value; }
        public bool Activo { get => _activo; set => _activo = value; }
        public double Costo { get => _costo; set => _costo = value; }
        #endregion
    }
}
