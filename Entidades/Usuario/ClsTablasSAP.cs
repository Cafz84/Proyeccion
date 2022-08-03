using System.Data;

namespace Entidades.Usuario
{
    public class ClsTablasSAP
    {
        #region Variables Privadas
        private string _code, _u_ModCode, _u_ModDesc;

        //Atributos para Etiqueta se toman tambien programa, estilo y color de la busqueda de programa
        private int _ordenFabricacion, _pedido, _cantidad;
        private char _estatus;
        private string _pO, _codEstilo, _codColor, _talla, _itemNo, _codBarra, _horma, _genero;

        //Atributos para Busqueda de Programa y su cantidad
        private string _programa, _estilo, _color;
        private decimal _cantPedido;

        //Atributos de manejo de la base de datos
        private string _msjError, _valorEscalar;
        private DataTable _dtResultados, _dtTallaCtd;
        #endregion

        #region Variables Publicas
        public string Code { get => _code; set => _code = value; }
        public string U_ModCode { get => _u_ModCode; set => _u_ModCode = value; }
        public string U_ModDesc { get => _u_ModDesc; set => _u_ModDesc = value; }
        public string MsjError { get => _msjError; set => _msjError = value; }
        public string ValorEscalar { get => _valorEscalar; set => _valorEscalar = value; }
        public DataTable DtResultados { get => _dtResultados; set => _dtResultados = value; }
        public string Programa { get => _programa; set => _programa = value; }
        public string Estilo { get => _estilo; set => _estilo = value; }
        public decimal CantPedido { get => _cantPedido; set => _cantPedido = value; }
        public string Color { get => _color; set => _color = value; }
        public int OrdenFabricacion { get => _ordenFabricacion; set => _ordenFabricacion = value; }
        public int Pedido { get => _pedido; set => _pedido = value; }
        public int Cantidad { get => _cantidad; set => _cantidad = value; }
        public char Estatus { get => _estatus; set => _estatus = value; }
        public string PO { get => _pO; set => _pO = value; }
        public string CodEstilo { get => _codEstilo; set => _codEstilo = value; }
        public string CodColor { get => _codColor; set => _codColor = value; }
        public string Talla { get => _talla; set => _talla = value; }
        public string ItemNo { get => _itemNo; set => _itemNo = value; }
        public string CodBarra { get => _codBarra; set => _codBarra = value; }
        public string Horma { get => _horma; set => _horma = value; }
        public string Genero { get => _genero; set => _genero = value; }
        public DataTable DtTallaCtd { get => _dtTallaCtd; set => _dtTallaCtd = value; }
        #endregion
    }
}
