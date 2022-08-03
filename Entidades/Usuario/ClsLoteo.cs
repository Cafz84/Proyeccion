using System;
using System.Data;

namespace Entidades.Usuario
{
    public class ClsLoteo
    {
        #region Variables Privadas
        private string _codLote, _impLote, _area, _estilo, _color, _horma, _info;
        private char _tipoLote;
        private DateTime _fLote, _fEmbarque;
        private int _programa, _cantPrograma, _cantLote, _tLotes, _nLote, _t5, _t55, _t6, _t65, _t7, _t75, _t8, _t85, _t9, _t95, _t10, _t105;
        private int _t11, _t115, _t12, _t13, _t14, _t15, _t16, _t17, _t28, _t30, _t32, _t34, _t36, _t38, _t40, _t42, _t44, _t46, _tL, _tM, _tS;
        private int _tX, _tXL, tXS;

        //Atributos de manejo de la base de datos
        private string _msjError, _valorEscalar;
        private DataTable _dtResultados;
        #endregion

        #region Variables Publicas
        public string CodLote { get => _codLote; set => _codLote = value; }
        public string ImpLote { get => _impLote; set => _impLote = value; }
        public string Area { get => _area; set => _area = value; }
        public string Estilo { get => _estilo; set => _estilo = value; }
        public string Color { get => _color; set => _color = value; }
        public string Horma { get => _horma; set => _horma = value; }
        public string Info { get => _info; set => _info = value; }
        public char TipoLote { get => _tipoLote; set => _tipoLote = value; }
        public DateTime FLote { get => _fLote; set => _fLote = value; }
        public DateTime FEmbarque { get => _fEmbarque; set => _fEmbarque = value; }
        public int Programa { get => _programa; set => _programa = value; }
        public int CantPrograma { get => _cantPrograma; set => _cantPrograma = value; }
        public int CantLote { get => _cantLote; set => _cantLote = value; }
        public int TLotes { get => _tLotes; set => _tLotes = value; }
        public int NLote { get => _nLote; set => _nLote = value; }
        public int T5 { get => _t5; set => _t5 = value; }
        public int T55 { get => _t55; set => _t55 = value; }
        public int T6 { get => _t6; set => _t6 = value; }
        public int T65 { get => _t65; set => _t65 = value; }
        public int T7 { get => _t7; set => _t7 = value; }
        public int T75 { get => _t75; set => _t75 = value; }
        public int T8 { get => _t8; set => _t8 = value; }
        public int T85 { get => _t85; set => _t85 = value; }
        public int T9 { get => _t9; set => _t9 = value; }
        public int T95 { get => _t95; set => _t95 = value; }
        public int T10 { get => _t10; set => _t10 = value; }
        public int T105 { get => _t105; set => _t105 = value; }
        public int T11 { get => _t11; set => _t11 = value; }
        public int T115 { get => _t115; set => _t115 = value; }
        public int T12 { get => _t12; set => _t12 = value; }
        public int T13 { get => _t13; set => _t13 = value; }
        public int T14 { get => _t14; set => _t14 = value; }
        public int T15 { get => _t15; set => _t15 = value; }
        public int T16 { get => _t16; set => _t16 = value; }
        public int T17 { get => _t17; set => _t17 = value; }
        public int T28 { get => _t28; set => _t28 = value; }
        public int T30 { get => _t30; set => _t30 = value; }
        public int T32 { get => _t32; set => _t32 = value; }
        public int T34 { get => _t34; set => _t34 = value; }
        public int T36 { get => _t36; set => _t36 = value; }
        public int T38 { get => _t38; set => _t38 = value; }
        public int T40 { get => _t40; set => _t40 = value; }
        public int T42 { get => _t42; set => _t42 = value; }
        public int T44 { get => _t44; set => _t44 = value; }
        public int T46 { get => _t46; set => _t46 = value; }
        public int TL { get => _tL; set => _tL = value; }
        public int TM { get => _tM; set => _tM = value; }
        public int TS { get => _tS; set => _tS = value; }
        public int TX { get => _tX; set => _tX = value; }
        public int TXL { get => _tXL; set => _tXL = value; }
        public int TXS { get => tXS; set => tXS = value; }
        public string MsjError { get => _msjError; set => _msjError = value; }
        public string ValorEscalar { get => _valorEscalar; set => _valorEscalar = value; }
        public DataTable DtResultados { get => _dtResultados; set => _dtResultados = value; }
        #endregion
    }
}
