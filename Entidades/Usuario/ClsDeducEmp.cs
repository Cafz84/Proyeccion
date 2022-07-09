using System.Data;

namespace Entidades.Usuario
{
    public class ClsDeducEmp
    {
        #region Variables Privadas
        private int _u_IdDeduccion, _u_EmpId, _u_Semana;
        private float _costo;

        //Atributos de manejo de la base de datos
        private string _msjError, _valorEscalar;
        private DataTable _dtResultados;
        #endregion

        #region Variables Publicas
        public int U_IdDeduccion { get => _u_IdDeduccion; set => _u_IdDeduccion = value; }
        public int U_EmpId { get => _u_EmpId; set => _u_EmpId = value; }
        public int U_Semana { get => _u_Semana; set => _u_Semana = value; }
        public float Costo { get => _costo; set => _costo = value; }
        public string MsjError { get => _msjError; set => _msjError = value; }
        public string ValorEscalar { get => _valorEscalar; set => _valorEscalar = value; }
        public DataTable DtResultados { get => _dtResultados; set => _dtResultados = value; }
        #endregion
    }
}
