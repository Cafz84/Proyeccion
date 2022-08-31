using System;
using System.Data;

namespace Entidades.Usuario
{
    public class ClsAvances
    {
        #region Variables Privadas
        private string _uCodigo, _tiempo, _usuario, _estilo, _color;
        private char? _area;
        private int _uUserId, _uAvanceId;
        private DateTime _fAvance;

        //Atributos de manejo de la base de datos
        private string _msjError, _valorEscalar;
        private DataTable _dtResultados;
        #endregion

        #region Variables Publicas
        public string UCodigo { get => _uCodigo; set => _uCodigo = value; }
        public string Tiempo { get => _tiempo; set => _tiempo = value; }
        public string Usuario { get => _usuario; set => _usuario = value; }
        public string Estilo { get => _estilo; set => _estilo = value; }
        public string Color { get => _color; set => _color = value; }
        public char? Area { get => _area; set => _area = value; }
        public int UUserId { get => _uUserId; set => _uUserId = value; }
        public int UAvanceId { get => _uAvanceId; set => _uAvanceId = value; }
        public DateTime FAvance { get => _fAvance; set => _fAvance = value; }
        public string MsjError { get => _msjError; set => _msjError = value; }
        public string ValorEscalar { get => _valorEscalar; set => _valorEscalar = value; }
        public DataTable DtResultados { get => _dtResultados; set => _dtResultados = value; }
        #endregion
    }
}
