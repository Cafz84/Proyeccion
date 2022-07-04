using System.Data;

namespace Entidades.Usuario
{
    public class ClsRGrupoEmpleado
    {
        #region Variables Privadas
        private int _u_GrupoId, _u_EmpId, _c_GrupoId, _c_EmpId;
        private string _grupo;
        private float _porcentaje;

        //Atributos de manejo de la base de datos
        private string _msjError, _valorEscalar;
        private DataTable _dtResultados;
        #endregion

        #region Variables Publicas
        public int U_GrupoId { get => _u_GrupoId; set => _u_GrupoId = value; }
        public int U_EmpId { get => _u_EmpId; set => _u_EmpId = value; }
        public int C_GrupoId { get => _c_GrupoId; set => _c_GrupoId = value; }
        public int C_EmpId { get => _c_EmpId; set => _c_EmpId = value; }
        public string MsjError { get => _msjError; set => _msjError = value; }
        public string ValorEscalar { get => _valorEscalar; set => _valorEscalar = value; }
        public DataTable DtResultados { get => _dtResultados; set => _dtResultados = value; }
        public string Grupo { get => _grupo; set => _grupo = value; }
        public float Porcentaje { get => _porcentaje; set => _porcentaje = value; }
        #endregion
    }
}
