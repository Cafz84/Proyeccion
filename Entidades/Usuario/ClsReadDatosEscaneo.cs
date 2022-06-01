using System.Data;

namespace Entidades.Usuario
{
    public class ClsReadDatosEscaneo
    {
        #region Variables Privadas
        private string _ordenProduccion, _pO, _u_Argns_Mod, _estilo, _u_Argns_Col, _color, _uSA, _itemNo, _codigo, _genero;
        private int _ordenFrabricacion, _pedido;
        private char _estatus;
        private double _cantidad;

        //Atributos de manejo de la base de datos
        private string _msjError, _valorEscalar;
        private DataTable _dtResultados;
        #endregion

        #region Variables Publicas
        public string OrdenProduccion { get => _ordenProduccion; set => _ordenProduccion = value; }
        public string PO { get => _pO; set => _pO = value; }
        public string U_Argns_Mod { get => _u_Argns_Mod; set => _u_Argns_Mod = value; }
        public string Estilo { get => _estilo; set => _estilo = value; }
        public string U_Argns_Col { get => _u_Argns_Col; set => _u_Argns_Col = value; }
        public string Color { get => _color; set => _color = value; }
        public string USA { get => _uSA; set => _uSA = value; }
        public string ItemNo { get => _itemNo; set => _itemNo = value; }
        public string Codigo { get => _codigo; set => _codigo = value; }
        public string Genero { get => _genero; set => _genero = value; }
        public int OrdenFrabricacion { get => _ordenFrabricacion; set => _ordenFrabricacion = value; }
        public int Pedido { get => _pedido; set => _pedido = value; }
        public char Estatus { get => _estatus; set => _estatus = value; }
        public double Cantidad { get => _cantidad; set => _cantidad = value; }
        public string MsjError { get => _msjError; set => _msjError = value; }
        public string ValorEscalar { get => _valorEscalar; set => _valorEscalar = value; }
        public DataTable DtResultados { get => _dtResultados; set => _dtResultados = value; }
        #endregion
    }
}
