using System;
using System.Data;

namespace Entidades.Usuario
{
    public class ClsEmpleado
    {

        #region Atributos privados
       
        private int _empID, _type, _manager, _userId, _salesPrson, _status, _termReason, _position, _atcEntry, _vacPreYear, _vacCurYear,
            _logInstanc, _sTDCode, _bPLId;
        private short _dept, _branch, _nChildren, _userSing, _userSing2;
        private string _lastName, _firstName, _middleName, _jobTitle, _workStreet, _workCity, _workCounty, _workBlock, _workZip, _workContr,
            _workState, _officeTel, _officeExt, _mobile, _pager, _homeTel, _fax, _email, _bankCode, _bankBranch, _bankBranNo, _bankAcount,
            _homeStreet, _homeBlock, _homeZip, _homeCity, _homeCounty, _homeCountr, _homeState, _brthCountr, _govID, _citizenshp, _passportNo,
            _picture, _remark, _attachment, _salaryCurr, _empCostCur, _workBuild, _homeBuild, _addrTypeW, _addrTypeH, _streetNoW,
            _streetNoH, _costCenter, _companyNum, _munKey, _taxClass, _inTaxLiabi, _emTaxCCode, _relPartner, _exemptUnit, _addiUnit, _taxOName,
            _taxONum, _heaInsName, _heaInsCode, _heaInsType, _sInsurNum, _statusOfP, _statusOfE, _bCodeDateV, _fNameSP, _surnameSP, _persGroup,
            _jTCode, _extEmpNo, _birthPlace, _pymMeth, _exemptCurr, _addiCurr, _fatherName, _cPF, _cRC, _uFCRC, _iDType, _manualNUM, _passIssuer,
            _qualCode, _bPLink, _u_ARGNS_OperCode, _u_ARGNS_Shift;
        private char _sex, _salaryUnit, _empCostUnt, _martStatus, _dispMidNam, _namePos, _dispComma, debBAOwner, _contResp, _repLegal, _dirfDeclar,
            _active, _pRWebAccss, _prePRWeb;
        private DateTime _startDate, _termDate, _birthDate, _passportEx, _updateDate, _passIssue;
        private double _salary, _emplCost, _exemptAmnt, _addiAmnt, _sueldoBase, _sueldoLimite;

        //Atributos de manejo de la base de datos
        private string _msjError, _valorEscalar;
        private DataTable _dtResultados;

        #endregion

        #region Atributos publicos

        public int EmpID { get => _empID; set => _empID = value; }
        public int Type { get => _type; set => _type = value; }
        public int Manager { get => _manager; set => _manager = value; }
        public int UserId { get => _userId; set => _userId = value; }
        public int SalesPrson { get => _salesPrson; set => _salesPrson = value; }
        public int Status { get => _status; set => _status = value; }
        public int TermReason { get => _termReason; set => _termReason = value; }
        public int Position { get => _position; set => _position = value; }
        public int AtcEntry { get => _atcEntry; set => _atcEntry = value; }
        public int VacPreYear { get => _vacPreYear; set => _vacPreYear = value; }
        public int VacCurYear { get => _vacCurYear; set => _vacCurYear = value; }
        public int LogInstanc { get => _logInstanc; set => _logInstanc = value; }
        public int STDCode { get => _sTDCode; set => _sTDCode = value; }
        public int BPLId { get => _bPLId; set => _bPLId = value; }
        public short Dept { get => _dept; set => _dept = value; }
        public short Branch { get => _branch; set => _branch = value; }
        public short NChildren { get => _nChildren; set => _nChildren = value; }
        public short UserSing { get => _userSing; set => _userSing = value; }
        public short UserSing2 { get => _userSing2; set => _userSing2 = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string MiddleName { get => _middleName; set => _middleName = value; }
        public string JobTitle { get => _jobTitle; set => _jobTitle = value; }
        public string WorkStreet { get => _workStreet; set => _workStreet = value; }
        public string WorkCity { get => _workCity; set => _workCity = value; }
        public string WorkCounty { get => _workCounty; set => _workCounty = value; }
        public string WorkBlock { get => _workBlock; set => _workBlock = value; }
        public string WorkZip { get => _workZip; set => _workZip = value; }
        public string WorkContr { get => _workContr; set => _workContr = value; }
        public string WorkState { get => _workState; set => _workState = value; }
        public string OfficeTel { get => _officeTel; set => _officeTel = value; }
        public string OfficeExt { get => _officeExt; set => _officeExt = value; }
        public string Mobile { get => _mobile; set => _mobile = value; }
        public string Pager { get => _pager; set => _pager = value; }
        public string HomeTel { get => _homeTel; set => _homeTel = value; }
        public string Fax { get => _fax; set => _fax = value; }
        public string Email { get => _email; set => _email = value; }
        public string BankCode { get => _bankCode; set => _bankCode = value; }
        public string BankBranch { get => _bankBranch; set => _bankBranch = value; }
        public string BankBranNo { get => _bankBranNo; set => _bankBranNo = value; }
        public string BankAcount { get => _bankAcount; set => _bankAcount = value; }
        public string HomeStreet { get => _homeStreet; set => _homeStreet = value; }
        public string HomeBlock { get => _homeBlock; set => _homeBlock = value; }
        public string HomeZip { get => _homeZip; set => _homeZip = value; }
        public string HomeCity { get => _homeCity; set => _homeCity = value; }
        public string HomeCounty { get => _homeCounty; set => _homeCounty = value; }
        public string HomeCountr { get => _homeCountr; set => _homeCountr = value; }
        public string HomeState { get => _homeState; set => _homeState = value; }
        public string BrthCountr { get => _brthCountr; set => _brthCountr = value; }
        public string GovID { get => _govID; set => _govID = value; }
        public string Citizenshp { get => _citizenshp; set => _citizenshp = value; }
        public string PassportNo { get => _passportNo; set => _passportNo = value; }
        public string Picture { get => _picture; set => _picture = value; }
        public string Remark { get => _remark; set => _remark = value; }
        public string Attachment { get => _attachment; set => _attachment = value; }
        public string SalaryCurr { get => _salaryCurr; set => _salaryCurr = value; }
        public string EmpCostCur { get => _empCostCur; set => _empCostCur = value; }
        public string WorkBuild { get => _workBuild; set => _workBuild = value; }
        public string HomeBuild { get => _homeBuild; set => _homeBuild = value; }
        public string AddrTypeW { get => _addrTypeW; set => _addrTypeW = value; }
        public string AddrTypeH { get => _addrTypeH; set => _addrTypeH = value; }
        public string StreetNoW { get => _streetNoW; set => _streetNoW = value; }
        public string StreetNoH { get => _streetNoH; set => _streetNoH = value; }
        public string CostCenter { get => _costCenter; set => _costCenter = value; }
        public string CompanyNum { get => _companyNum; set => _companyNum = value; }
        public string MunKey { get => _munKey; set => _munKey = value; }
        public string TaxClass { get => _taxClass; set => _taxClass = value; }
        public string InTaxLiabi { get => _inTaxLiabi; set => _inTaxLiabi = value; }
        public string EmTaxCCode { get => _emTaxCCode; set => _emTaxCCode = value; }
        public string RelPartner { get => _relPartner; set => _relPartner = value; }
        public string ExemptUnit { get => _exemptUnit; set => _exemptUnit = value; }
        public string AddiUnit { get => _addiUnit; set => _addiUnit = value; }
        public string TaxOName { get => _taxOName; set => _taxOName = value; }
        public string TaxONum { get => _taxONum; set => _taxONum = value; }
        public string HeaInsName { get => _heaInsName; set => _heaInsName = value; }
        public string HeaInsCode { get => _heaInsCode; set => _heaInsCode = value; }
        public string HeaInsType { get => _heaInsType; set => _heaInsType = value; }
        public string SInsurNum { get => _sInsurNum; set => _sInsurNum = value; }
        public string StatusOfP { get => _statusOfP; set => _statusOfP = value; }
        public string StatusOfE { get => _statusOfE; set => _statusOfE = value; }
        public string BCodeDateV { get => _bCodeDateV; set => _bCodeDateV = value; }
        public string FNameSP { get => _fNameSP; set => _fNameSP = value; }
        public string SurnameSP { get => _surnameSP; set => _surnameSP = value; }
        public string PersGroup { get => _persGroup; set => _persGroup = value; }
        public string JTCode { get => _jTCode; set => _jTCode = value; }
        public string ExtEmpNo { get => _extEmpNo; set => _extEmpNo = value; }
        public string BirthPlace { get => _birthPlace; set => _birthPlace = value; }
        public string PymMeth { get => _pymMeth; set => _pymMeth = value; }
        public string ExemptCurr { get => _exemptCurr; set => _exemptCurr = value; }
        public string AddiCurr { get => _addiCurr; set => _addiCurr = value; }
        public string FatherName { get => _fatherName; set => _fatherName = value; }
        public string CPF { get => _cPF; set => _cPF = value; }
        public string CRC { get => _cRC; set => _cRC = value; }
        public string UFCRC { get => _uFCRC; set => _uFCRC = value; }
        public string IDType { get => _iDType; set => _iDType = value; }
        public string ManualNUM { get => _manualNUM; set => _manualNUM = value; }
        public string PassIssuer { get => _passIssuer; set => _passIssuer = value; }
        public string QualCode { get => _qualCode; set => _qualCode = value; }
        public string BPLink { get => _bPLink; set => _bPLink = value; }
        public string U_ARGNS_OperCode { get => _u_ARGNS_OperCode; set => _u_ARGNS_OperCode = value; }
        public string U_ARGNS_Shift { get => _u_ARGNS_Shift; set => _u_ARGNS_Shift = value; }
        public char Sex { get => _sex; set => _sex = value; }
        public char SalaryUnit { get => _salaryUnit; set => _salaryUnit = value; }
        public char EmpCostUnt { get => _empCostUnt; set => _empCostUnt = value; }
        public char MartStatus { get => _martStatus; set => _martStatus = value; }
        public char DispMidNam { get => _dispMidNam; set => _dispMidNam = value; }
        public char NamePos { get => _namePos; set => _namePos = value; }
        public char DispComma { get => _dispComma; set => _dispComma = value; }
        public char DebBAOwner { get => debBAOwner; set => debBAOwner = value; }
        public char ContResp { get => _contResp; set => _contResp = value; }
        public char RepLegal { get => _repLegal; set => _repLegal = value; }
        public char DirfDeclar { get => _dirfDeclar; set => _dirfDeclar = value; }
        public char Active { get => _active; set => _active = value; }
        public char PRWebAccss { get => _pRWebAccss; set => _pRWebAccss = value; }
        public char PrePRWeb { get => _prePRWeb; set => _prePRWeb = value; }
        public DateTime StartDate { get => _startDate; set => _startDate = value; }
        public DateTime TermDate { get => _termDate; set => _termDate = value; }
        public DateTime BirthDate { get => _birthDate; set => _birthDate = value; }
        public DateTime PassportEx { get => _passportEx; set => _passportEx = value; }
        public DateTime UpdateDate { get => _updateDate; set => _updateDate = value; }
        public DateTime PassIssue { get => _passIssue; set => _passIssue = value; }
        public double Salary { get => _salary; set => _salary = value; }
        public double EmplCost { get => _emplCost; set => _emplCost = value; }
        public double ExemptAmnt { get => _exemptAmnt; set => _exemptAmnt = value; }
        public double AddiAmnt { get => _addiAmnt; set => _addiAmnt = value; }
        public string MsjError { get => _msjError; set => _msjError = value; }
        public string ValorEscalar { get => _valorEscalar; set => _valorEscalar = value; }
        public DataTable DtResultados { get => _dtResultados; set => _dtResultados = value; }
        public double SueldoBase { get => _sueldoBase; set => _sueldoBase = value; }
        public double SueldoLimite { get => _sueldoLimite; set => _sueldoLimite = value; }

        #endregion
    }
}
