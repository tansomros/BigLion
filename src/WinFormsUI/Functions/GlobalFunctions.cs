using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Text;
using DevExpress.XtraGrid.Views.Grid;
using Microsoft.VisualBasic;
using SUTH.HealthCheckup.Domain.Enums;

namespace SUTH.HealthCheckup.WinFormsUI.Functions
{
    public static class GlobalFunctions
    {

        public static string ProviderPath {  get; set; }    

        public static string ObjectQualifier { get; set; }    

        public static string DatabaseOwner { get; set; }
        public static string ModuleQualifier { get; set; }

        public static DataTable dt = new DataTable();

        #region "Database Functions"

        public static string GetFullyQualifiedName(string name)
        {
            return DatabaseOwner + ObjectQualifier + ModuleQualifier + name;
        }

        public static bool chkFileExist(string FileRptPath)
        {
            FileInfo F = new FileInfo(FileRptPath);
            return F.Exists;
        }

        public static void SetControlFocus(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }


        //Public Sub BindDataToCombo(ByVal cbo As ComboBox, ByVal dt As DataSet, ByVal displayFld As String, ByVal valueFld As String, Optional ByVal currRow As Integer = 0)
        //    With cbo
        //        .DataSource = dt
        //        .DisplayMember = displayFld
        //        .ValueMember = valueFld
        //        .SelectedIndex = currRow
        //    End With
        //End Sub

        public static string PrepareFieldLenght(string Field_Value, int Field_Length)
        {
            string result = "";
            string tmp_value = "";
            if (Field_Value != null)
            {
                result = Field_Value;
                if (Field_Length > 0 & Field_Value.Length > Field_Length)
                {
                    int CountChar = 0;
                    string str = null;
                    int i = 0;
                    i = 0;
                    tmp_value = Field_Value.Substring(0, Field_Length);
                    result = tmp_value;
                    for (i = 0; i <= tmp_value.Length - 1; i++)
                    {
                        str = tmp_value.Substring(i, 1);
                        if (str == "'")
                        {
                            CountChar += 1;
                        }
                    }
                    if (!(CountChar % 2 == 0))
                    {
                        i = tmp_value.Length - 1;
                        while (i >= 0)
                        {
                            str = tmp_value.Substring(i, 1);
                            if (str == "'")
                            {
                                result = tmp_value.Substring(0, i);
                                break;
                            }
                            i -= 1;
                        }
                    }
                }
            }
            return result;
        }
        public static string PrepareSqlValue(string Field_Value)
        {
            string result = "";
            if (Field_Value != null)
            {
                if (Field_Value.Trim().Length > 0)
                {
                    result = Field_Value.Replace("'", "''");
                }
            }
            return result;
        }

        public static string ReverseSqlValue(string Field_Value)
        {
            string result = "";
            if (Field_Value != null)
            {
                if (Field_Value.Trim().Length > 0)
                {
                    result = Field_Value.Replace("''", "'");
                }
            }
            return result;
        }

        public static string setTimeFormat(string strTime, bool f_millisec = false)
        {
            string strReturn = null;
            if (strTime.Length < 6)
            {
                strTime = strTime.PadLeft(6, '0');
            }
            if (f_millisec)
            {
                strReturn = strTime.Substring(0, 2) + ":" + strTime.Substring(2, 2) + ":" + strTime.Substring(4, 2);
            }
            else
            {
                strReturn = strTime.Substring(0, 2) + ":" + strTime.Substring(2, 2);
            }
            return strReturn;
        }

        #endregion



        #region "StringExpression"
        public static string Left(this string value, int maxLength)
        {
            if (string.IsNullOrEmpty(value)) return value;
            maxLength = Math.Abs(maxLength);

            return value.Length <= maxLength ? value : value.Substring(0, maxLength)
                   ;
        }
        public static string Right(this string value, int length)
        {
            if (string.IsNullOrEmpty(value)) return string.Empty;

            return value.Length <= length ? value : value.Substring(value.Length - length);
        }

        public static string Mid(this string value, int startindex, int length)
        {
            if (string.IsNullOrEmpty(value))
            {
                return string.Empty;
            }
            else
            {
                return value.Substring(startindex, length);
            }



        }


        #endregion


        #region "Genaral Function"



        public static string Boolean2ActiveStatus(bool pValue)
        {

            if (pValue == true)
            {
                return "A";
            }
            else
            {
                return "D";
            }
        }

        public static bool ActiveStatus2Boolean(string pValue)
        {

            if (pValue == "A")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static string SexTH2SexENGCode(string pValue)
        {
            if (pValue == "ชาย")
            {
                return "M";
            }
            else
            {
                return "F";
            }
        }

        public static int Boolean2Decimal(bool pValue)
        {

            if (pValue == true)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public static bool Decimal2Boolean(int pValue)
        {
            if (pValue == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static string DisplayAbnormalTXT(string pValue)
        {
            if (!string.IsNullOrEmpty(string.Concat(pValue)))
            {
                if (string.Concat(pValue) == "ปกติ")
                {
                    return ExamResult.Normal.Value;
                }
                else if (string.Concat(pValue) == "ผิดปกติ")
                {
                    return ExamResult.Abnormal.Value;
                }
                else
                {
                    return string.Concat(pValue);
                }
            }
            else
            {
                return ExamResult.Normal.Value;
            }
        }
        public static string DisplayYesOrNoTXT(string pValue)
        {
            if (!string.IsNullOrEmpty(string.Concat(pValue)))
            {
                if (string.Concat(pValue) == "ปกติ" | string.Concat(pValue) == ExamResult.Normal.Value)
                {
                    return "Y";
                }
                else if (string.Concat(pValue) == "ผิดปกติ" | string.Concat(pValue) == ExamResult.Abnormal.Value)
                {
                    return "N";
                }
                else
                {
                    return string.Concat(pValue);
                }
            }
            else
            {
                return "Y";
            }
        }
        //public static string DisplayYN2NormalTXT(string pValue)
        //{
        //    if (!string.IsNullOrEmpty(string.Concat(pValue)))
        //    {
        //        if (string.Concat(pValue) == "Y")
        //        {
        //            return "Normal";
        //        }
        //        else if (string.Concat(pValue) == "N")
        //        {
        //            return "Abnormal";
        //        }
        //        else
        //        {
        //            return "Abnormal";
        //        }
        //    }
        //    else
        //    {
        //        return "Normal";
        //    }
        //}

        public static string ConvertTrueToYes(bool pValue)
        {
            if (!string.IsNullOrEmpty(string.Concat(pValue)))
            {
                if (pValue == true)
                {
                    return "Y";
                }
                else if (pValue == false)
                {
                    return "N";
                }
                else
                {
                    return "";
                }
            }
            else
            {
                return "";
            }
        }
        public static string ConvertTrueToNo(bool pValue)
        {
            if (!string.IsNullOrEmpty(string.Concat(pValue)))
            {
                if (pValue == true)
                {
                    return "N";
                }
                else if (pValue == false)
                {
                    return "Y";
                }
                else
                {
                    return "";
                }
            }
            else
            {
                return "";
            }
        }

        public static string ConvertTrueToNormal(bool pValue)
        {
            if (!string.IsNullOrEmpty(string.Concat(pValue)))
            {
                if (pValue == true)
                {
                    return ExamResult.Normal.Value;
                }
                else if (pValue == false)
                {
                    return ExamResult.Abnormal.Value;
                }
                else
                {
                    return "";
                }
            }
            else
            {
                return "";
            }
        }
        public static string ConvertTrueToAbNormal(bool pValue)
        {
            if (!string.IsNullOrEmpty(string.Concat(pValue)))
            {
                if (pValue == true)
                {
                    return ExamResult.Abnormal.Value;
                }
                else if (pValue == false)
                {
                    return ExamResult.Normal.Value;
                }
                else
                {
                    return "";
                }
            }
            else
            {
                return "";
            }
        }

        public static string ConvertYN2NormalTXT(string pValue)
        {
            if (!string.IsNullOrEmpty(string.Concat(pValue)))
            {
                if (string.Concat(pValue) == "Y")
                {
                    return ExamResult.Normal.Value;
                }
                else if (string.Concat(pValue) == "N")
                {
                    return ExamResult.Abnormal.Value;
                }
                else
                {
                    return "";
                }
            }
            else
            {
                return "";
            }
        }


        public static string DisplayYN2NormalTXTGA(string pValue)
        {
            if (!string.IsNullOrEmpty(string.Concat(pValue)))
            {
                if (string.Concat(pValue) == "N")
                {
                    return "N";
                }
                else if (string.Concat(pValue) == "Y")
                {
                    return "Y";
                }
                else if (string.Concat(pValue) == "W")
                {
                    return "";
                }
                else
                {
                    return "";
                }
            }
            else
            {
                return "";
            }
        }

        public static string DisplayAbnormal2NormalTXT(string pValue)
        {
            switch (pValue)
            {
                case "N":
                case "-":
                    return ExamResult.Normal.Value;
                case "Y":
                    return ExamResult.Abnormal.Value;
                case "H":
                case "L":
                    return ExamResult.Abnormal.Value;
                default:
                    return ExamResult.Normal.Value;
            }
        }

        public static string DisplayXrayYNTXT(string pValue)
        {
            if (string.Concat(pValue) == "N")
            {
                return XrayResult.Normal.Value;
            }
            else if (string.Concat(pValue) == "Y")
            {
                return XrayResult.Abnormal.Value;
            }
            else
            {
                return pValue;
            }
        }

        public static string DisplayXrayYNTXT2(string pValue)
        {
            if (string.Concat(pValue) == "N")
            {
                return XrayResult.Normal.Value;
            }
            else if (string.Concat(pValue) == "Y")
            {
                return XrayResult.Abnormal.Value;
            }
            else if (string.Concat(pValue) == XrayResult.WaitForSpecialist.Value)
            {
                return XrayResult.WaitForSpecialist.Value;
            }
            else
            {
                return "";
            }
        }

        public static string ConvertXRAYLabResultTXT(string pValue)
        {
            if (string.Concat(pValue) == ExamResult.Abnormal.Value)
            {
                return "Y";
            }
            else if (string.Concat(pValue) == ExamResult.Normal.Value)
            {
                return "N";
            }
            else
            {
                return pValue;
            }
        }


        public static string ParseDate(string sDate, string sKey)
        {
            string[] str = Array.Empty<string>();
            int dY = 0;

            if (sKey == "-")
            {
                str = sDate.Split("-".ToCharArray());
            }
            else if (sKey == "/")
            {
                str = sDate.Split("/".ToCharArray());
            }
            dY = DateTime.Now.Date.Year - StrNull2Zero(string.Concat(str[2]));

            if (dY < 0)
            {
                dY = Convert.ToInt32(str[2]) - 543;
            }
            else
            {
                dY = Convert.ToInt32(str[2]);
            }
            sDate = str[0] + "/" + str[0] + "/" + dY;
            return sDate;
        }

        public static string ParseDateToSQL(string sDate, string sKey)
        {
            string[] str = Array.Empty<string>();
            int dY = 0;

            if (sKey == "-")
            {
                str = sDate.Split("-".ToCharArray());
            }
            else if (sKey == "/")
            {
                str = sDate.Split("/".ToCharArray());
            }

            dY = DateTime.Now.Date.Year - Convert.ToInt32(str[2]);
            if (dY < 0)
            {
                dY = Convert.ToInt32(str[2]) - 543;
            }
            else
            {
                dY = Convert.ToInt32(str[2]);
            }
            sDate = dY + "-" + str[0] + "-" + str[0];
            return sDate;
        }


        public static string ConvertDateToString(DateTime Adate)
        {
            string functionReturnValue = null;
            string[] strDate = new string[3];
            strDate[0] = Convert.ToString(Adate.Day);
            strDate[1] = Convert.ToString(Adate.Month);
            strDate[2] = Convert.ToString(Adate.Year);

            functionReturnValue = strDate[0] + "/" + strDate[1] + "/" + Convert.ToInt32(strDate[2]) + 543;

            return functionReturnValue;

        }

        public static string ConvertFormateDate(DateTime Adate)
        {
            string functionReturnValue = null;
            string[] strDate = new string[3];
            strDate[0] = Convert.ToString(Adate.Day);
            strDate[0] = Convert.ToString(Adate.Month);
            strDate[2] = Convert.ToString(Adate.Year);

            functionReturnValue = strDate[0] + "/" + strDate[0] + "/" + strDate[2];

            return functionReturnValue;

        }


        public static string changStringToDate(string Adate)
        {
            string functionReturnValue = null;
            string[] strDate = new string[4];
            strDate = Adate.Split("-".ToCharArray());
            functionReturnValue = strDate[0] + "/" + strDate[0] + "/" + Convert.ToInt32(strDate[2]);
            //+ 543
            return functionReturnValue;
        }

        public static bool IsNumeric(string input)
        {
            int test;
            return int.TryParse(input, out test);
        }

        public static string DBNull2StrDash(object str)
        {
            if (str == DBNull.Value)
            {
                return "-";
            }
            else if (str == null)
            {
                return "-";
            }
            else
            {
                return string.Concat(str);
            }
        }
        public static int StrNull2Zero(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return 0;
            }
            else
            {
                if (!IsNumeric(str))
                {
                    return 0;
                }
                else
                {
                    return Convert.ToInt32(str);
                }
            }
        }

        public static long StrNull2Long(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return 0;
            }
            else
            {
                if (!IsNumeric(str))
                {
                    return 0;
                }
                else
                {
                    return Convert.ToInt64(str);
                }
            }
        }


        public static double Str2Double(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return 0;
            }
            else
            {
                if (!IsNumeric(str))
                {
                    return 0;
                }
                else
                {
                    return Convert.ToDouble(str);
                }
            }
        }

        public static string FomateTXTDisplay(string str)
        {
            if (!string.IsNullOrEmpty(str))
            {
                return Strings.Left(str, 1).ToUpper() + Strings.Right(str, Strings.Len(str) - 1).ToLower();
            }
            else
            {
                return "";
            }
        }

        public static string Zero2StrNull(object str)
        {
            if (Information.IsDBNull(str))
            {
                return "";
            }
            else
            {
                if (string.Concat(str) == "0")
                {
                    return "";
                }
                else
                {
                    return string.Concat(str);
                }

            }
        }

        public static string DBNull2Str(object str)
        {
            if (Information.IsDBNull(str))
            {
                return "";
            }
            else
            {
                return string.Concat(str);
            }
        }
        public static int DBNull2Zero(object str)
        {
            if (Information.IsDBNull(str))
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(str);
            }
        }

        public static long DBNull2Lng(object str)
        {
            if (Information.IsDBNull(str))
            {
                return 0;
            }
            else
            {
                if (Strings.Len(str) != 0 & Information.IsNumeric(str))
                {
                    return Convert.ToInt64(str);
                }
                else
                {
                    return 0;
                }
            }
        }
        public static double DBNull2Dbl(object str)
        {
            if (Information.IsDBNull(str))
            {
                return 0;
            }
            else if (string.Concat(str) == "")
            {
                return 0;
            }
            else
            {
                return Convert.ToDouble(str);
            }
        }



        public const int ScriptTimeout = 60;
        // second

        public const int SessionTimeout = 20;
        // minute

        public const double MAXPERPAGE = 30;
        // record(s) display per page.

        public static bool CheckPersonalID(string uid)
        {
            int IntID = Convert.ToInt32(uid.Substring(0, 1)) * 13 + Convert.ToInt32(uid.Substring(1, 1)) * 12 + Convert.ToInt32(uid.Substring(2, 1)) * 11 + Convert.ToInt32(uid.Substring(3, 1)) * 10 + Convert.ToInt32(uid.Substring(4, 1)) * 9 + Convert.ToInt32(uid.Substring(5, 1)) * 8 + Convert.ToInt32(uid.Substring(6, 1)) * 7 + Convert.ToInt32(uid.Substring(7, 1)) * 6 + Convert.ToInt32(uid.Substring(8, 1)) * 5 + Convert.ToInt32(uid.Substring(9, 1)) * 4 + Convert.ToInt32(uid.Substring(10, 1)) * 3 + Convert.ToInt32(uid.Substring(11, 1)) * 2;
            int LastID = IntID % 11;
            if (LastID == 0)
            {
                LastID = 1;
            }
            else if (LastID == 1)
            {
                LastID = 0;
            }
            else
            {
                LastID = 11 - LastID;
            }
            return Convert.ToInt32(uid.Substring(12, 1)) == LastID;
        }

        public static string FormatPersonalID(string uid)
        {
            string IDformat = "";
            IDformat = uid.Substring(0, 1) + " ";
            IDformat = IDformat + uid.Substring(1, 1) + uid.Substring(2, 1) + uid.Substring(3, 1) + uid.Substring(4, 1) + " ";
            IDformat = IDformat + uid.Substring(5, 1) + uid.Substring(6, 1) + uid.Substring(7, 1) + uid.Substring(8, 1) + uid.Substring(9, 1) + " ";
            IDformat = IDformat + uid.Substring(10, 1) + uid.Substring(11, 1) + " ";
            IDformat = IDformat + uid.Substring(12, 1);
            return IDformat;
        }


        public static bool ShowMenu(string p, string permission)
        {
            if (permission.Contains(p))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string toThaiNumber(string num)
        {
            string tmp = "";
            int i = 0;


            for (i = 0; i <= num.Length; i++)
            {
                if (num.Substring(i, 1) == "0")
                {
                    tmp += "๐";
                }
                else if (num.Substring(i, 1) == "1")
                {
                    tmp += "๑";
                }
                else if (num.Substring(i, 1) == "2")
                {
                    tmp += "๒";
                }
                else if (num.Substring(i, 1) == "3")
                {
                    tmp += "๓";
                }
                else if (num.Substring(i, 1) == "4")
                {
                    tmp += "๔";
                }
                else if (num.Substring(i, 1) == "5")
                {
                    tmp += "๕";
                }
                else if (num.Substring(i, 1) == "6")
                {
                    tmp += "๖";
                }
                else if (num.Substring(i, 1) == "7")
                {
                    tmp += "๗";
                }
                else if (num.Substring(i, 1) == "8")
                {
                    tmp += "๘";
                }
                else if (num.Substring(i, 1) == "9")
                {
                    tmp += "๙";
                }
                else
                {
                    tmp += num.Substring(i, 1);
                }

            }
            return tmp;
        }

        //Convert DB string date to normal string date
        #region  "DateTime Format"

        public static string ConvertDate2DB(DateTime strDate, string th_or_en)
        {
            int y, m, d;

            if (th_or_en.Trim().ToLower() == "en") y = getYearEng(strDate.Year);
            else if (th_or_en.Trim().ToLower() == "th") y = getYearThai(strDate.Year);
            else y = getYearEng(strDate.Year);


            m = strDate.Month;
            d = strDate.Day;
            return m.ToString("00") + "/" + d.ToString("00") + "/" + y.ToString("0000");
        }

        public static string ConvertDate2DBFormatString(DateTime strDate, string th_or_en)

        {
            int y, m, d;

            if (th_or_en.Trim().ToLower() == "en") y = getYearEng(strDate.Year);
            else if (th_or_en.Trim().ToLower() == "th") y = getYearThai(strDate.Year);
            else y = getYearEng(strDate.Year);

            m = strDate.Month;
            d = strDate.Day;

            return y.ToString("0000") + "-" + m.ToString("00") + "-" + d.ToString("00");
        }


        public static string ConvertStrDate2DBFormat(string strDate)
        {
            int y, m, d;
            string[] ArrDate = new string[3];
            ArrDate[0] = "";
            ArrDate[1] = "";
            ArrDate[2] = "";
            y = 0;
            m = 0;
            d = 0;
            strDate = strDate.Left(10);

            if (strDate.Length == 10)
            {
                ArrDate = strDate.ToString().Split('/');
                d = Convert.ToInt32(ArrDate[0]);
                m = Convert.ToInt32(ArrDate[1]);
                y = Convert.ToInt32(ArrDate[2]);

                if (y > 2500)
                {
                    y = y - 543;
                }

            }

            return y.ToString("0000") + "-" + m.ToString("00") + "-" + d.ToString("00");

        }

        public static string ConvertDate2DBString(DateTime dt)
        {
            string y = "";
            string d = "";
            string m = "";
            d = dt.Day.ToString();
            m = dt.Month.ToString();

            while (d.Length < 2)
            {
                d = "0" + d;

            }

            while (m.Length < 2)
            {
                m = "0" + m;

            }

            if (dt.Year < 2500)
            {
                y = (dt.Year + 543).ToString();
            }
            else
            {
                y = dt.Year.ToString();
            }

            return y + m + d;
        }
        public static string ConvertStrDate2DBString(string dt)
        {

            if (!string.IsNullOrEmpty(dt))
            {
                string y = "";
                string d = "";
                string m = "";

                string[] str = null;
                str = Strings.Split(dt, "/");

                d = str[0].ToString();
                m = str[0].ToString();


                while (d.Length < 2)
                {
                    d = "0" + d;
                }

                while (m.Length < 2)
                {
                    m = "0" + m;
                }

                if (Convert.ToInt32(str[2]) < 2500)
                {
                    y = (Convert.ToInt32(str[2]) + 543).ToString();
                }
                else
                {
                    y = str[2];
                }

                return y + m + d;
            }
            else
            {
                return "0";
            }
        }
        public static string ConvertStrDate2DateQueryString(string dt)
        {

            if (!string.IsNullOrEmpty(dt))
            {
                string y = "";
                string d = "";
                string m = "";

                string[] str = null;
                str = Strings.Split(dt.Left(10), "/");

                d = str[0].ToString();
                m = str[1].ToString();

                while (d.Length < 2)
                {
                    d = "0" + d;
                }

                while (m.Length < 2)
                {
                    m = "0" + m;
                }

                if (Convert.ToInt32(str[2]) > 2300)
                {
                    y = (Convert.ToInt32(str[2]) - 543).ToString();
                }
                else
                {
                    y = str[2];
                }

                return y + "-" + m + "-" + d; // + " 00:00:00";

            }
            else
            {
                return "";
            }
        }
        public static string ConvertStrDate2ShortDateQueryString(string dt)
        {

            if (!string.IsNullOrEmpty(dt))
            {
                string y = "";
                string d = "";
                string m = "";

                string[] str = null;
                str = Strings.Split(dt, "/");

                d = str[0].ToString();
                m = str[0].ToString();

                while (d.Length < 2)
                {
                    d = "0" + d;
                }

                while (m.Length < 2)
                {
                    m = "0" + m;
                }

                if (Convert.ToInt32(str[2]) > 2300)
                {
                    y = (Convert.ToInt32(str[2]) - 543).ToString();
                }
                else
                {
                    y = str[2];
                }

                return m + "/" + d + "/" + y;

            }
            else
            {
                return "";
            }
        }
        public static string DisplayFullDateTH(DateTime dt)
        {
            string y = "";
            string d1 = "";
            string d2 = "";
            string m = "";

            switch (dt.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    d1 = "อาทิตย์";
                    break;
                case DayOfWeek.Monday:
                    d1 = "จันทร์";
                    break;
                case DayOfWeek.Tuesday:
                    d1 = "อังคาร";
                    break;
                case DayOfWeek.Wednesday:
                    d1 = "พุธ";
                    break;
                case DayOfWeek.Thursday:
                    d1 = "พฤหัสบดี";
                    break;
                case DayOfWeek.Friday:
                    d1 = "ศุกร์";
                    break;
                case DayOfWeek.Saturday:
                    d1 = "เสาร์";

                    break;
            }

            d2 = dt.Day.ToString();

            switch (dt.Month)
            {
                case 1:
                    m = "มกราคม";
                    break;
                case 2:
                    m = "กุมภาพันธ์";
                    break;
                case 3:
                    m = "มีนาคม";
                    break;
                case 4:
                    m = "เมษายน";
                    break;
                case 5:
                    m = "พฤษภาคม";
                    break;
                case 6:
                    m = "มิถุนายน";
                    break;
                case 7:
                    m = "กรกฎาคม";
                    break;
                case 8:
                    m = "สิงหาคม";
                    break;
                case 9:
                    m = "กันยายน";
                    break;
                case 10:
                    m = "ตุลาคม";
                    break;
                case 11:
                    m = "พฤศจิกายน";
                    break;
                case 12:
                    m = "ธันวาคม";
                    break;
            }

            if (dt.Year < 2500)
            {
                y = (dt.Year + 543).ToString();
            }
            else
            {
                y = dt.Year.ToString();
            }

            return "วัน" + d1 + "ที่ " + d2 + " " + m + " พ.ศ. " + y;

        }

        public static string DisplayFullDateTHwithoutDOW(DateTime dt)
        {
            string y = "";
            string d2 = "";
            string m = "";
            d2 = dt.Day.ToString();

            switch (dt.Month)
            {
                case 1:
                    m = "มกราคม";
                    break;
                case 2:
                    m = "กุมภาพันธ์";
                    break;
                case 3:
                    m = "มีนาคม";
                    break;
                case 4:
                    m = "เมษายน";
                    break;
                case 5:
                    m = "พฤษภาคม";
                    break;
                case 6:
                    m = "มิถุนายน";
                    break;
                case 7:
                    m = "กรกฎาคม";
                    break;
                case 8:
                    m = "สิงหาคม";
                    break;
                case 9:
                    m = "กันยายน";
                    break;
                case 10:
                    m = "ตุลาคม";
                    break;
                case 11:
                    m = "พฤศจิกายน";
                    break;
                case 12:
                    m = "ธันวาคม";
                    break;
            }

            if (dt.Year < 2500)
            {
                y = (dt.Year + 543).ToString();
            }
            else
            {
                y = dt.Year.ToString();
            }

            return "วันที่  " + d2 + "   เดือน  " + m + "   พ.ศ. " + y;
        }

        public static string DisplayDateTH(DateTime dt)
        {
            string y = "";
            string d2 = "";
            string m = "";
            d2 = dt.Day.ToString();
            switch (dt.Month)
            {
                case 1:
                    m = "มกราคม";
                    break;
                case 2:
                    m = "กุมภาพันธ์";
                    break;
                case 3:
                    m = "มีนาคม";
                    break;
                case 4:
                    m = "เมษายน";
                    break;
                case 5:
                    m = "พฤษภาคม";
                    break;
                case 6:
                    m = "มิถุนายน";
                    break;
                case 7:
                    m = "กรกฎาคม";
                    break;
                case 8:
                    m = "สิงหาคม";
                    break;
                case 9:
                    m = "กันยายน";
                    break;
                case 10:
                    m = "ตุลาคม";
                    break;
                case 11:
                    m = "พฤศจิกายน";
                    break;
                case 12:
                    m = "ธันวาคม";
                    break;
            }

            if (dt.Year < 2500)
            {
                y = (dt.Year + 543).ToString();
            }
            else
            {
                y = dt.Year.ToString();
            }

            return d2 + " " + m + " " + y;
        }

        #endregion

        public static string Convert2LetterNo(string dt)
        {
            string y = "";
            string i = "";
            y = dt.Substring(0, 4);
            i = dt.Substring(4, 3);

            return Convert.ToInt32(i) + "/" + y;
        }

        public static string DisplayStr2DateTH(string dt)
        {
            string y = "";
            string d2 = "";
            string m = "";
            d2 = Convert.ToInt32(dt.Substring(6, 2)).ToString();
            if (d2 == "0")
            {
                d2 = "";
            }

            m = Convert.ToInt32(dt.Substring(4, 2)).ToString();

            switch (m)
            {
                case "0":
                    m = "";
                    break;
                case "1":
                    m = "มกราคม";
                    break;
                case "2":
                    m = "กุมภาพันธ์";
                    break;
                case "3":
                    m = "มีนาคม";
                    break;
                case "4":
                    m = "เมษายน";
                    break;
                case "5":
                    m = "พฤษภาคม";
                    break;
                case "6":
                    m = "มิถุนายน";
                    break;
                case "7":
                    m = "กรกฎาคม";
                    break;
                case "8":
                    m = "สิงหาคม";
                    break;
                case "9":
                    m = "กันยายน";
                    break;
                case "10":
                    m = "ตุลาคม";
                    break;
                case "11":
                    m = "พฤศจิกายน";
                    break;
                case "12":
                    m = "ธันวาคม";
                    break;
            }

            y = dt.Substring(0, 4);

            return d2 + " " + m + " " + y;

        }

        public static string DisplayMiniDateTH(DateTime dt)
        {
            string y = "";
            string d2 = "";
            string m = "";
            d2 = dt.Day.ToString();

            switch (dt.Month)
            {
                case 1:
                    m = "ม.ค.";
                    break;
                case 2:
                    m = "ก.พ.";
                    break;
                case 3:
                    m = "มี.ค.";
                    break;
                case 4:
                    m = "เม.ย.";
                    break;
                case 5:
                    m = "พ.ค.";
                    break;
                case 6:
                    m = "มิ.ค.";
                    break;
                case 7:
                    m = "ก.ค.";
                    break;
                case 8:
                    m = "ส.ค.";
                    break;
                case 9:
                    m = "ก.ย.";
                    break;
                case 10:
                    m = "ต.ค.";
                    break;
                case 11:
                    m = "พ.ย.";
                    break;
                case 12:
                    m = "ธ.ค.";
                    break;
            }

            if (dt.Year < 2500)
            {
                y = (dt.Year + 543).ToString();
            }
            else
            {
                y = dt.Year.ToString();
            }

            return d2 + " " + m + " " + y;

        }

        public static string DisplayShortDateTH(DateTime dt)
        {
            string y = "";
            string d = "";
            string m = "";
            d = dt.Day.ToString();
            m = dt.Month.ToString();

            while (d.Length < 2)
            {
                d = "0" + d;

            }

            while (m.Length < 2)
            {
                m = "0" + m;

            }
            if (dt.Year < 2500)
            {
                y = (dt.Year + 543).ToString();
            }
            else
            {
                y = dt.Year.ToString();
            }
            return d + "/" + m + "/" + y;
        }

        public static string DisplayShortDateEN(DateTime dt)
        {
            string y = "";
            string d = "";
            string m = "";

            d = dt.Day.ToString();
            m = dt.Month.ToString();

            while (d.Length < 2)
            {
                d = "0" + d;

            }

            while (m.Length < 2)
            {
                m = "0" + m;

            }
            y = dt.Year.ToString();
            return d + "/" + m + "/" + y;
        }

        public static string DisplayStr2ShortDateEN(string dt)
        {
            string dd = dt.Substring(6, 2);
            string mm = dt.Substring(4, 2);
            string yy = dt.Substring(0, 4);

            while (dd.Length < 2)
            {
                dd = "0" + dd;

            }

            while (mm.Length < 2)
            {
                mm = "0" + mm;

            }

            return dd + "/" + mm + "/" + yy;
        }

        public static string DisplayStr2ShortDateTH(string dt)
        {
            if (!string.IsNullOrEmpty(dt))
            {
                string dd = dt.Substring(0, 2);
                string mm = dt.Substring(3, 2);
                string yy = dt.Substring(6, 4);

                while (dd.Length < 2)
                {
                    dd = "0" + dd;

                }

                while (mm.Length < 2)
                {
                    mm = "0" + mm;

                }
                //if (Convert.ToInt32(yy) < 2500)
                //{
                //    yy = (Convert.ToInt32(yy) + 543).ToString();
                //}

                return dd + "/" + mm + "/" + yy;
            }
            else
            {
                return "";
            }

        }

        public static string DisplayTime(DateTime dt)
        {
            string m = null;
            string h = null;
            h = dt.Hour.ToString();
            m = dt.Minute.ToString();

            while (m.Length < 2)
            {
                m = "0" + m;

            }
            return h + "." + m + " \u0019.";
        }

        public static string DisplayPhone(string s)
        {
            if (s.Length == 9)
            {
                if (s.Substring(0, 2) == "02")
                {
                    return s.Substring(0, 2) + "-" + s.Substring(2, 3) + "-" + s.Substring(5, 4);
                }
                else
                {
                    return s.Substring(0, 3) + "-" + s.Substring(3, 3) + "-" + s.Substring(6, 3);
                }
            }
            if (s.Length == 10)
            {
                return s.Substring(0, 3) + "-" + s.Substring(3, 3) + "-" + s.Substring(6, 4);
            }
            return s;
        }

        public static string DisplayDay(DateTime dt)
        {
            string d = "";
            d = dt.Day.ToString();
            return d;
        }
        public static string DisplayNumber2Month(int pM)
        {
            string m = "";
            switch (pM)
            {
                case 1:
                    m = "มกราคม";
                    break;
                case 2:
                    m = "กุมภาพันธ์";
                    break;
                case 3:
                    m = "มีนาคม";
                    break;
                case 4:
                    m = "เมษายน";
                    break;
                case 5:
                    m = "พฤษภาคม";
                    break;
                case 6:
                    m = "มิถุนายน";
                    break;
                case 7:
                    m = "กรกฎาคม";
                    break;
                case 8:
                    m = "สิงหาคม";
                    break;
                case 9:
                    m = "กันยายน";
                    break;
                case 10:
                    m = "ตุลาคม";
                    break;
                case 11:
                    m = "พฤศจิกายน";
                    break;
                case 12:
                    m = "ธันวาคม";
                    break;
            }

            return m;
        }
        public static string DisplayMonth(DateTime dt)
        {
            string m = "";
            switch (dt.Month)
            {
                case 1:
                    m = "มกราคม";
                    break;
                case 2:
                    m = "กุมภาพันธ์";
                    break;
                case 3:
                    m = "มีนาคม";
                    break;
                case 4:
                    m = "เมษายน";
                    break;
                case 5:
                    m = "พฤษภาคม";
                    break;
                case 6:
                    m = "มิถุนายน";
                    break;
                case 7:
                    m = "กรกฎาคม";
                    break;
                case 8:
                    m = "สิงหาคม";
                    break;
                case 9:
                    m = "กันยายน";
                    break;
                case 10:
                    m = "ตุลาคม";
                    break;
                case 11:
                    m = "พฤศจิกายน";
                    break;
                case 12:
                    m = "ธันวาคม";
                    break;
            }

            return m;
        }

        public static string DisplayYear(DateTime dt)
        {
            string y = "";

            if (dt.Year < 2500)
            {
                y = (dt.Year + 543).ToString();
            }
            else
            {
                y = dt.Year.ToString();
            }

            return y;
        }

        public static string ChkNull(string str)
        {
            if (!string.IsNullOrEmpty(str))
            {
                return " " + str;
            }
            else
            {
                return " -";
            }
        }


        public static string TRcolor(int row)
        {
            string tr = "";
            if (row % 2 != 0)
            {
                tr = "<tr onMouseOver=\\\"this.bgColor='#DDDDDD';\\\" onMouseOut=\\\"this.bgColor='#FFFFFF';\\\">";
            }
            else
            {
                tr = "<tr onMouseOver=\\\"this.bgColor='#DDDDDD';\\\" onMouseOut=\\\"this.bgColor='#FFFFFF';\\\">";
            }
            return tr;
        }


        public static string NavigateURL(string pageID, params string[] AdditionalParameters)
        {
            string str = "";
            int i;

            for (i = 0; i <= AdditionalParameters.Length - 1; i++)
            {
                if (i % 2 == 0)
                {
                    str += "&" + AdditionalParameters[i] + "=";
                }
                else
                {
                    str += AdditionalParameters[i];
                }

            }

            return pageID + "?x=1" + str;

        }

        public static int getYearEng(int y)
        {
            if (y > GlobalVariables.MAX_ENG_YEAR)
            {
                y -= 543;
            }
            return y;
        }
        public static int getYearThai(int y)
        {
            if (y < GlobalVariables.MAX_ENG_YEAR)
            {
                y += 543;
            }
            return y;
        }

        public static bool IsInstallPrinter()
        {
            bool functionReturnValue = false;
            functionReturnValue = false;
            if (GlobalVariables.prDoc.PrinterSettings.PrinterName == "<no default printer>")
            {
                functionReturnValue = false;
            }
            else
            {
                functionReturnValue = true;
            }
            return functionReturnValue;
        }
        public static string setDateFormat(string strDate)
        {
            string functionReturnValue = null;
            int strYear = 0;
            switch (strDate.Trim().Length)
            {
                case 8:
                    strYear = Convert.ToInt32(strDate.Left(4));
                    if (strYear < 2500)
                    {
                        strYear = strYear + 543;
                    }

                    functionReturnValue = strDate.Right(2) + "/" + strDate.Mid(5, 2) + "/" + strYear;

                    break;
                case 12:
                    strYear = Convert.ToInt32(strDate.Left(4));

                    if (strYear < 2500)
                    {
                        strYear = strYear + 543;
                    }

                    functionReturnValue = strDate.Mid(7, 2) + "/" + strDate.Mid(5, 2) + "/" + strYear + "@" + strDate.Mid(9, 2) + ":" + strDate.Right(2);
                    break;
                default:
                    functionReturnValue = "";

                    break;
            }
            return functionReturnValue;

        }


        #endregion

        #region "Convert Function"
        public static int CheckBox2Int(bool objChk)
        {
            if (objChk == true)
            {
                return 1;
            }
            else if (objChk == false)
            {
                return 0;
            }
            else
            {
                return 0;
            }
        }
        public static bool Int2CheckBoxState(int objChk)
        {
            if (objChk == 1)
            {
                return true;
            }
            else if (objChk == 0)
            {
                return false;
            }
            else
            {
                return false;
            }
        }
        #endregion



        #region "check Data Value"
             

        public static double StrNull2Dbl(string str)
        {
            if (str == "")
            {
                return 0;
            }
            else
            {
                return Convert.ToDouble(str);
            }
        }


        public static string ConvertStrDate2DMY(string dt)
        {

            if (!string.IsNullOrEmpty(dt))
            {
                string y = "";
                string d = "";
                string m = "";

                string[] str = null;
                str = dt.Split('/');

                d = str[0].ToString();
                m = str[1].ToString();

                while (d.Length < 2)
                {
                    d = "0" + d;
                }

                while (m.Length < 2)
                {
                    m = "0" + m;
                }

                if (Convert.ToInt32(str[2].Left(4)) > 2300)
                {
                    y = str[2].Left(4);
                }
                else
                {
                    y = (Convert.ToInt32(str[2].Left(4)) + 543).ToString();
                }

                return d + "/" + m + "/" + y;

            }
            else
            {
                return "";
            }
        }



        public static DateTime ConvertStrDate2DateFormat(string dt)
        {

            if (!string.IsNullOrEmpty(dt))
            {
                string y = "";
                string d = "";
                string m = "";

                string[] str = null;
                str = dt.Split('/');

                d = str[0];
                m = str[1];


                while (d.Length < 2)
                {
                    d = "0" + d;
                }

                while (m.Length < 2)
                {
                    m = "0" + m;
                }
                str[2] = str[2].Left(4);

                if (Convert.ToInt32(str[2]) > 2500)
                {
                    y = (Convert.ToInt32(str[2]) - 543).ToString();
                }
                else
                {
                    y = str[2];
                }

                return Convert.ToDateTime(d + "/" + m + "/" + y);
            }
            else
            {
                return DateTime.Now.Date;
            }
        }

        public static DateTime ConvertStrDate2DateFormat29(string dt)
        {

            if (!string.IsNullOrEmpty(dt))
            {
                string y = "";
                string d = "";
                string m = "";

                string[] str = null;
                str = dt.Split('/');

                d = str[0];
                m = str[1];


                while (d.Length < 2)
                {
                    d = "0" + d;
                }

                while (m.Length < 2)
                {
                    m = "0" + m;
                }
                str[2] = str[2].Left(4);

                if (Convert.ToInt32(str[2]) > 2500)
                {
                    y = Convert.ToInt32(str[2]).ToString();
                }
                else
                {
                    y = str[2];
                }

                return Convert.ToDateTime(d + "/" + m + "/" + y);
            }
            else
            {
                return DateTime.Now.Date;
            }
        }


        public static string ConvertDateToStringDateFormat29(DateTime Adate)
        {
            string[] strDate = new string[3];
            strDate[0] = Convert.ToString(Adate.Day);
            strDate[1] = Convert.ToString(Adate.Month);
            strDate[2] = Convert.ToString(Adate.Year);

            if (Convert.ToInt32(strDate[2]) > 2500)
            {
                strDate[2] = (Convert.ToInt32(strDate[2]) - 543).ToString();
            }
            else if (Convert.ToInt32(strDate[2]) < 2500)
            {
                strDate[2] = Convert.ToInt32(strDate[2]).ToString();
            }

            return strDate[1] + "/" + strDate[0] + "/" + Convert.ToInt32(strDate[2]);



        }



        #endregion


        //public static DialogResult MessageBox(string message,MessageBoxIcon messageBoxIcon)
        //{
        //    DialogResult result;
        //    using (frmMessage msg = new frmMessage(message, messageBoxIcon))
        //        result = msg.ShowDialog();
        //    return result;
        //}
        //public static DialogResult MessageBox(string message, MessageBoxButtons buttons,MessageBoxIcon messageBoxIcon)
        //{
        //    DialogResult result;
        //    using (frmMessage msg = new frmMessage(message,buttons,messageBoxIcon))
        //        result = msg.ShowDialog();
        //    return result;
        //}
        public static void CheckOpenedForm(Form f)
        {
            FormCollection fc = Application.OpenForms;
            foreach (Form frm in f.MdiChildren)
            {
                frm.Close();
            }
        }
        public static void CopyToClipboard(GridView view)
        {
            Clipboard.SetText(view.GetFocusedDisplayText());
        }
        //public static IEnumerable<Control> ClearData(Control container)
        //{
        //    List<Control> controlList = new List<Control>();
        //    foreach (Control ctrl in container.Controls)
        //    {
        //        controlList.AddRange(ClearData(ctrl));
        //        if(ctrl is TextBox)
        //        {
        //            if (ctrl.Text != "0")
        //                ctrl.Text = string.Empty;
        //        }
        //        if (ctrl is ComboBox)
        //        {
        //            ctrl.Text = null;
        //        }
        //        if (ctrl is DevComponents.DotNetBar.Controls.ComboBoxEx)
        //        {
        //            (ctrl as DevComponents.DotNetBar.Controls.ComboBoxEx).SelectedIndex = -1;
        //        }
        //        if (ctrl is DevExpress.XtraEditors.LookUpEdit)
        //        {
        //            (ctrl as DevExpress.XtraEditors.LookUpEdit).EditValue = null;
        //        }
        //        if (ctrl is DevExpress.XtraEditors.SpinEdit)
        //        {
        //            (ctrl as DevExpress.XtraEditors.SpinEdit).Value = 0;
        //        }
        //        if(ctrl is CheckBox)
        //        {
        //            (ctrl as CheckBox).Checked = false;
        //        }
        //        if (ctrl is DevExpress.XtraEditors.RadioGroup)
        //            (ctrl as DevExpress.XtraEditors.RadioGroup).SelectedIndex = -1;
        //    }
        //    return controlList;
        //}
        public static void SetGridviewColorStyle(DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
                if (e.RowHandle % 2 == 0)
                {
                    //e.Appearance.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");
                    e.Appearance.BackColor = ColorTranslator.FromHtml("#FFF7EC");
                }
                else
                {
                    //e.Appearance.BackColor = System.Drawing.ColorTranslator.FromHtml("#fffafa");
                    e.Appearance.BackColor = ColorTranslator.FromHtml("#F5F5FD");
                }
        }
        public static string RemoveDuplicateWords(string v)
        {
            // 1
            // Keep track of words found in this Dictionary.
            var d = new Dictionary<string, bool>();

            // 2
            // Build up string into this StringBuilder.
            StringBuilder b = new StringBuilder();

            // 3
            // Split the input and handle spaces and punctuation.
            string[] a = v.Split(new char[] { ' ', ',', ';', '.', ']' },
                StringSplitOptions.RemoveEmptyEntries);

            // 4
            // Loop over each word
            foreach (string current in a)
            {
                // 5
                // Lowercase each word
                string lower = current.ToLower();

                // 6
                // If we haven't already encountered the word,
                // append it to the result.
                if (!d.ContainsKey(lower))
                {
                    b.Append(current).Append(']');
                    d.Add(lower, true);
                }
            }
            // 7
            // Return the duplicate words removed
            return b.ToString().Trim();
        }
        public static string GetCheckedListBoxValue(DevExpress.XtraEditors.CheckedListBoxControl ctrl)
        {
            string result = "";
            for (int i = 0; i < ctrl.ItemCount; i++)
            {
                if (ctrl.GetItemChecked(i))
                    result += ctrl.GetItemValue(i) + ",";
            }
            try
            {
                result = result.Substring(0, result.Length - 1);
            }
            catch { result = ""; }
            return result;
        }
        public static void SetCheckListEdit(DevExpress.XtraEditors.CheckedListBoxControl checkcontrol, string values)
        {
            try
            {
                string accessright = RemoveDuplicateWords(values);

                for (int index = 0; index < checkcontrol.ItemCount; index++)
                {
                    checkcontrol.SetItemChecked(index, false);
                }
                string[] arr = accessright.Split(new[] { ' ', ',', ';', '.', ']' });
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    for (int j = 0; j < checkcontrol.ItemCount; j++)
                    {
                        if (checkcontrol.GetItemValue(j).ToString() == arr[i].Substring(0).ToString())
                        {
                            checkcontrol.SetItemChecked(j, true);
                        }
                    }
                }
            }
            catch { }
        }
        public static bool CheckDuplicateInGridview(DevExpress.XtraGrid.Views.Grid.GridView view,int ColumnIndex,string Value)
        {
            bool result = false; 
               for(int i =0;i < view.RowCount;i++)
                {
                if (view.GetRowCellValue(i, view.Columns[ColumnIndex]).ToString() == Value)
                    result = true;
                }
            return result;
        }

        #region Convert
        public static DataTable ListToDataTable<T>(List<T> list)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in list)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;
        }
        public static int? ConvertToInt32WithNull(object value)
        {
            try
            {
                if (string.IsNullOrEmpty(value.ToString()))
                    return null;
                else
                    return Convert.ToInt32(value);
            }
            catch
            {
                return 0;
            }
        }
        public static long ConvertToInt64(object value)
        {
            try
            {
                return Convert.ToInt64(value);
            }
            catch
            {
                return 0;
            }
        }
        public static long? ConvertToInt64WithNull(object value)
        {
            try
            {
                if (string.IsNullOrEmpty(value.ToString()))
                    return null;
                else
                    return Convert.ToInt64(value);
            }
            catch
            {
                return 0;
            }
        }
        public static decimal ConvertToIntDecimal(object value)
        {
            try
            {
                return Convert.ToDecimal(value);
            }
            catch
            {
                return 0;
            }
        }
        public static DateTime? ConvertToDateTime(object value)
        {
            try
            {
                return Convert.ToDateTime(value);
            }
            catch
            {
                return null;
            }
        }
        #endregion
    }
    public class ExportFile
    {
        public static void Excel(DevExpress.XtraGrid.GridControl Ctrl)
        {
            try
            {
                using (SaveFileDialog saveDialog = new SaveFileDialog())
                {
                    saveDialog.Filter = "Excel (2007)(.xlsx)|*.xlsx|Excel (2003) (.xls)|*.xls";
                    if (saveDialog.ShowDialog() != DialogResult.Cancel)
                    {
                        var advOptions = new DevExpress.XtraPrinting.XlsxExportOptionsEx();                   
                        string exportFilePath = saveDialog.FileName;
                        string fileExtenstion = new FileInfo(exportFilePath).Extension;

                        switch (fileExtenstion)
                        {
                            case ".xls":
                                Ctrl.ExportToXls(exportFilePath);
                                break;
                            case ".xlsx":
                                Ctrl.ExportToXlsx(exportFilePath,advOptions);
                                break;
                            default:
                                break;
                        }

                        if (File.Exists(exportFilePath))
                        {
                            try
                            {
                                //Try to open the file and let windows decide how to open it.
                                Process.Start(exportFilePath);
                            }
                            catch
                            {
                                string msg = "The file could not be opened." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                                MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            string msg = "The file could not be saved." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                            MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }        
        public static void PDF(DevExpress.XtraGrid.GridControl Ctrl)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Pdf File (.pdf)|*.pdf";
                if (saveDialog.ShowDialog() != DialogResult.Cancel)
                {
                    string exportFilePath = saveDialog.FileName;
                    string fileExtenstion = new FileInfo(exportFilePath).Extension;

                    switch (fileExtenstion)
                    {
                        case ".pdf":
                            Ctrl.ExportToPdf(exportFilePath);
                            break;
                        default:
                            break;
                    }

                    if (File.Exists(exportFilePath))
                    {
                        try
                        {
                            //Try to open the file and let windows decide how to open it.
                            Process.Start(exportFilePath);
                        }
                        catch
                        {
                            string msg = "The file could not be opened." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                            MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        string msg = "The file could not be saved." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                        MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }        
    }


    public class DataFuctionControllers
    {
        public static bool IsDate(object argo) //ตรวจสอบข้อมูลประเภท Date
        {
            try
            {
                DateTime dt = DateTime.Parse(string.Concat(argo));
                if (dt != DateTime.MinValue && dt != DateTime.MaxValue)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
        }
        public static bool IsNumeric(object argo) //ตรวจสอบข้อมูลปรเภท ตัวเลข
        {
            try
            {
                double result = double.Parse(string.Concat(argo));
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool ClearControl(Control Ctrl)
        {
            while (Ctrl.Controls.Count > 0)
            {
                foreach (UserControl u in Ctrl.Controls)
                {
                    u.Dispose();
                }
            }
            return true;
        }
        public static bool FileNameExtensions(string FileName, string FileType)
        {
            return FileName != null && FileName.EndsWith("." + FileType, StringComparison.Ordinal);
        }

        public static string space(int number)
        {
            string strSpace = "";
            for (int i = 0; i < number; i++)
            {
                strSpace += " ";
            }
            return strSpace;
        }

       

    }

}
