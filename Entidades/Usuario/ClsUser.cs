using System.Data;

namespace Entidades.Usuario
{
    public class ClsUser
    {
        #region Atributos privados
        private byte _userId;
        private int _idMax;
        private string _loginName, _password, _firstName, _lastName, _position, _email, _nombre;

        //Atributos de manejo de la base de datos
        private string _msjError, _valorEscalar;
        private DataTable _dtResultados;
        #endregion

        #region Atributos publicos
        public byte UserId { get => _userId; set => _userId = value; }
        public string LoginName { get => _loginName; set => _loginName = value; }
        public string Password { get => _password; set => _password = value; }
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public string Position { get => _position; set => _position = value; }
        public string Email { get => _email; set => _email = value; }
        public string MsjError { get => _msjError; set => _msjError = value; }
        public string ValorEscalar { get => _valorEscalar; set => _valorEscalar = value; }
        public DataTable DtResultados { get => _dtResultados; set => _dtResultados = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public int IdMax { get => _idMax; set => _idMax = value; }
        #endregion
    }
}
