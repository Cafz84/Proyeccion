using System.Data;

namespace Entidades.Usuario
{
    public class ClsRUsuarioAvance
    {
        #region Variables Privadas
        private int _userId, _cambioUserId;
        private char? _area, _cambioArea;
        private float _avanceId, _cambioAvanceId;
        private string _avance, _usuario;

        //Atributos de manejo de base de datos
        private string _msjError, _valorEscalar;
        private DataTable dtResultados;
        #endregion

        #region Variables Privadas
        public int UserId { get => _userId; set => _userId = value; }
        public char? Area { get => _area; set => _area = value; }
        public float AvanceId { get => _avanceId; set => _avanceId = value; }
        public string MsjError { get => _msjError; set => _msjError = value; }
        public string ValorEscalar { get => _valorEscalar; set => _valorEscalar = value; }
        public DataTable DtResultados { get => dtResultados; set => dtResultados = value; }
        public string Avance { get => _avance; set => _avance = value; }
        public string Usuario { get => _usuario; set => _usuario = value; }
        public int CambioUserId { get => _cambioUserId; set => _cambioUserId = value; }
        public char? CambioArea { get => _cambioArea; set => _cambioArea = value; }
        public float CambioAvanceId { get => _cambioAvanceId; set => _cambioAvanceId = value; }
        #endregion
    }
}
