using System.Data;

namespace Entidades.Usuario
{
    public class ClsFraccEstilo
    {
        #region Variables Privadas
        private string _u_IdEstilo, _u_ModCode, _u_ModDesc, _u_CodigoFraccion, _u_NameFraccion, _idEstilo, _bNombre, _programa;
        private int _u_IdFraccion, _idFraccion, _cantidad;
        private double _tiempo, _costo, _costoMuestra;

        //Atributos de manejo de la base de datos
        private string _msjError, _valorEscalar;
        private DataTable _dtResultados;
        #endregion

        #region Variables Publicas
        public string U_IdEstilo { get => _u_IdEstilo; set => _u_IdEstilo = value; }
        public string U_ModCode { get => _u_ModCode; set => _u_ModCode = value; }
        public string U_CodigoFraccion { get => _u_CodigoFraccion; set => _u_CodigoFraccion = value; }
        public string U_NameFraccion { get => _u_NameFraccion; set => _u_NameFraccion = value; }
        public int U_IdFraccion { get => _u_IdFraccion; set => _u_IdFraccion = value; }
        public string MsjError { get => _msjError; set => _msjError = value; }
        public string ValorEscalar { get => _valorEscalar; set => _valorEscalar = value; }
        public DataTable DtResultados { get => _dtResultados; set => _dtResultados = value; }
        public string IdEstilo { get => _idEstilo; set => _idEstilo = value; }
        public int IdFraccion { get => _idFraccion; set => _idFraccion = value; }
        public string U_ModDesc { get => _u_ModDesc; set => _u_ModDesc = value; }
        public int Cantidad { get => _cantidad; set => _cantidad = value; }
        public string BNombre { get => _bNombre; set => _bNombre = value; }
        public double Tiempo { get => _tiempo; set => _tiempo = value; }
        public double Costo { get => _costo; set => _costo = value; }
        public double CostoMuestra { get => _costoMuestra; set => _costoMuestra = value; }
        public string Programa { get => _programa; set => _programa = value; }
        #endregion
    }
}
