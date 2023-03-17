using System.Data;

namespace Entidades.Usuario
{
    public class ClsPermisosUsers
    {
        #region Variables Privadas
        private int _u_UserId;
        private bool _pUsuario, _pEscaneo, _pEmpleados, _pFracciones, _pCapturaDestajo, _pFraccEstilo, _pRevDestajo, _pAvances, _pLoteo, _pUAvances, _pRepAvances;

        //Atributos de manejo de la base de datos
        private string _msjError, _valorEscalar;
        private DataTable _dtResultados;
        #endregion

        #region Variables Publicas
        public int U_UserId { get => _u_UserId; set => _u_UserId = value; }
        public bool PUsuario { get => _pUsuario; set => _pUsuario = value; }
        public bool PEscaneo { get => _pEscaneo; set => _pEscaneo = value; }
        public bool PEmpleados { get => _pEmpleados; set => _pEmpleados = value; }
        public bool PFracciones { get => _pFracciones; set => _pFracciones = value; }
        public bool PCapturaDestajo { get => _pCapturaDestajo; set => _pCapturaDestajo = value; }
        public bool PFraccEstilo { get => _pFraccEstilo; set => _pFraccEstilo = value; }
        public bool PRevDestajo { get => _pRevDestajo; set => _pRevDestajo = value; }
        public bool PAvances { get => _pAvances; set => _pAvances = value; }
        public string MsjError { get => _msjError; set => _msjError = value; }
        public string ValorEscalar { get => _valorEscalar; set => _valorEscalar = value; }
        public DataTable DtResultados { get => _dtResultados; set => _dtResultados = value; }
        public bool PLoteo { get => _pLoteo; set => _pLoteo = value; }
        public bool PUAvances { get => _pUAvances; set => _pUAvances = value; }
        public bool PRepAvances { get => _pRepAvances; set => _pRepAvances = value; }
        #endregion
    }
}
