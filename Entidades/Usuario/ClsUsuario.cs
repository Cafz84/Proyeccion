using System;
using System.Data;

namespace Entidades.Usuario
{
    public class ClsUsuario
    {

        #region Atributos privados

        private byte _idUsuario;
        private string _nombre, _apellido1, _apellido2;
        private DateTime _fechaNacimiento;
        private bool _estado;

        //Atributos de manejo de la base de datos
        private string _msjError, _valorEscalar;
        private DataTable _dtResultados;

        #endregion

        #region Atributos publicos

        public byte IdUsuario { get => _idUsuario; set => _idUsuario = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido1 { get => _apellido1; set => _apellido1 = value; }
        public string Apellido2 { get => _apellido2; set => _apellido2 = value; }
        public DateTime FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }
        public bool Estado { get => _estado; set => _estado = value; }
        public string MsjError { get => _msjError; set => _msjError = value; }
        public string ValorEscalar { get => _valorEscalar; set => _valorEscalar = value; }
        public DataTable DtResultados { get => _dtResultados; set => _dtResultados = value; }

        #endregion

    }
}
