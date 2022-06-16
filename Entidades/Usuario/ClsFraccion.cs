using System;
using System.Data;

namespace Entidades.Usuario
{
    public class ClsFraccion
    {
        #region Variables Privadas
        private int _fraccionId;
        private string _codigo, _name, _descripcion;
        private bool _activo;
        private double _costo, _tiempo;
        private float _costoMuestra;

        //Atributos de manejo de la base de datos
        private string _msjError, _valorEscalar;
        private DataTable _dtResultados;
        #endregion

        #region Variables Publicas
        public int FraccionId { get => _fraccionId; set => _fraccionId = value; }
        public string Codigo { get => _codigo; set => _codigo = value; }
        public string Name { get => _name; set => _name = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public bool Activo { get => _activo; set => _activo = value; }
        public double Costo { get => _costo; set => _costo = value; }
        public double Tiempo { get => _tiempo; set => _tiempo = value; }
        public string MsjError { get => _msjError; set => _msjError = value; }
        public string ValorEscalar { get => _valorEscalar; set => _valorEscalar = value; }
        public DataTable DtResultados { get => _dtResultados; set => _dtResultados = value; }
        public float CostoMuestra { get => _costoMuestra; set => _costoMuestra = value; }
        #endregion
    }
}
