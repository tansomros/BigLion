
using System.Data;
using System.Drawing.Printing;
using System.Globalization;

namespace SUTH.HealthCheckup.WinFormsUI.Functions
{ 
    public enum LabStatus
    {
        WaitResult,
        PartialResult,
        Ok
    }
    public enum XRayStatus
    {
        WaitResult,
        Ok
    }
    public  class GlobalVariables
    {
      
        #region "Definitoin Parameter"

        public static bool f_debug;
        public static int MAX_ENG_YEAR = 2024;
        public static string STR_LANGUAGE = "th";
        public static string SQL = "";
        public static string SQLwhere = "";
        public static bool has_data = false;

        public static DateTimeFormatInfo dtfInfo;

        public static bool pointDup = false;

        public string ConnectionString = "";
        public string ConnectionStringHIS = "";

        private const string ProviderType = "data";
        private const string ModuleQualifier = "SUTH_";  

        public static int num;

        public static DataSet ds = new DataSet();
        public static DataRow currentRow = null;


        public static string ReportFormula = "";
        public static string ReportName = "";
        public static string ReportTitle = "";
        public static bool actionPrint = true;
        public static bool viewClose = false;

        public static string ReportPath = "Reports/";
        public static string Reportskey = "";
        public static string FagRPT = "";
        public static string RPTKEY = "";
        public static string RPTMODE = ""; 


        public static string[] RPTParameter;

        public static string Datakey = "";
        public static int gLocationUID;
        public static int gServiceUID;
        public static int gWithDrawUID;
        public static string gPatientHN;
        public static long gPatientUID;
        public static long gPatientVisitUID;

        public static long gResultComponentUID;


        public static bool gAudiogram;
        public static bool gIsAudiogram;

        public static string gUserUID;
        public static string gUsername;
        
        public static bool UserAuthorized;       
        public static string ActionFlag = "";
        public static string[] ReportParameter;
        public static PrintDocument prDoc = new PrintDocument();

        public static PrintDialog prDlg = new PrintDialog();
        public static bool isAutholize = false;
        public static string UserLogin = "";
        public static bool IsConfidential;

        public static bool IsLABConfidential = false;

        public static string HN = "";
        public static int prmID;
        //public static string VisitDate;
        public static string RequestDate;
        public static long PatientUID;
        public static long PatientVisitUID;
        public static string PatientVisitUIDList;
        public static long ResultConponentUID;
        public static int CtrlWidth;
        public static string EyeScreen;
        public static string FootScreen;
        public static string PatientVisitUIDByEach;
        public static string PatientVisitUIDByScanDocAfter;
        public static string PatientVNByEach;
        public static string PatientVisitDate;
        public static string activeFlag = "";
        public static string Hostname = "";
        public static string IPAddress = "";
        public static int PatientMedicationFormUID;
        public static int FormUID;
        //public static int MedicationFormUID;
        public static int gAnswerUID;
        public static string gAnswerScore;
        public static string gAnswerCoefficientScore;

        public static int UserID;
     
        #region "Card Type"

        public const string CARD_TYPE_NEW_VALUE = "1";
        public const string CARD_TYPE_NEW_NAME = "บันทึกให้กู้ยืมเงิน";

        public const string CARD_TYPE_PLUS_VALUE = "2";

        public const string CARD_TYPE_PLUS_NAME = "บันทึกให้กู้ยืมเงิน(เพิ่ม)";
        public const string CARD_TYPE_PAYAMOUNT_VALUE = "3";

        public const string CARD_TYPE_PAYAMOUNT_NAME = "รับคืนเงินต้น+ดอกเบี้ย";
        public const string CARD_TYPE_PAYLOAN_VALUE = "4";

        public const string CARD_TYPE_PAYLOAN_NAME = "รับคืนเงินต้น";
        public const string CARD_TYPE_PAYINT_VALUE = "5";

        public const string CARD_TYPE_PAYINT_NAME = "รับดอกเบี้ย";
        public const string CARD_TYPE_RETURNINT_VALUE = "6";

        public const string CARD_TYPE_RETURNINT_NAME = "จ่ายคืนดอกเบี้ย";
        public const string CARD_TYPE_PCLREINT_VALUE = "7";

        public const string CARD_TYPE_PCLREINT_NAME = "รับคืนเงินต้น+จ่ายคืนดอกเบี้ย";
        public const string CARD_TYPE_TRANSINT_VALUE = "8";

        public const string CARD_TYPE_TRANSINT_NAME = "บันทึกดอกเบี้ยโอน";

        public const string PAY_TYPE_NONE_VALUE = "";

        public const string PAY_TYPE_NONE_NAME = "";
        public const string PAY_TYPE_CASH_VALUE = "C";

        public const string PAY_TYPE_CASH_NAME = "เงินสด";
        public const string PAY_TYPE_TRANS_VALUE = "T";

        public const string PAY_TYPE_TRANS_NAME = "โอน";


        public const string SUBBOOK_TYPE_NEW_ACCID = "501-000";
        public const string SUBBOOK_TYPE_PLUS_ACCID = "501-000";
        public const string SUBBOOK_TYPE_PAY_ACCID = "501-000";
        public const string SUBBOOK_TYPE_INT_ACCID = "601-000";
        public const string SUBBOOK_TYPE_REINT_ACCID = "601-000";
        public const string SUBBOOK_TYPE_TRANS_ACCID = "601-000";

        public const string SUBBOOK_TYPE_RECVTRANS_ACCID = "701-000";
        public const string SUBBOOK_TYPE_NEW_NAME = "จ่ายเงินกู้";
        public const string SUBBOOK_TYPE_PLUS_NAME = "จ่ายเงินกู้เพิ่ม";
        public const string SUBBOOK_TYPE_PAY_NAME = "รับเงินต้น";
        public const string SUBBOOK_TYPE_INT_NAME = "รับดอกเบี้ย";

        public const string SUBBOOK_TYPE_REINT_NAME = "คืนดอกเบี้ย";

        #endregion



        #endregion

        #region "Const_Data"
        public const string ACTTYPE_LOG = "LOGIN";
        public const string ACTTYPE_ADD = "ADD";
        public const string ACTTYPE_UPD = "UPDATE";
        public const string ACTTYPE_DEL = "DELETE";
        public const string ACTTYPE_FND = "FIND";

        public const string ACTTYPE_FGT = "FORGOT PASS";
        public const string CFG_STARTDATE = "STARTDATE";
        public const string CFG_ENDDATE = "ENDDATE";

        public const string CFG_MAXLOCATION = "MAXLOCATION";
        #endregion

        public static Form _MAINFORM { get; set; }
    }
}
