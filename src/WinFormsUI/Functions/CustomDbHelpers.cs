using DevExpress.XtraCharts.Native;
using Newtonsoft.Json;
using Npgsql;
using SUTH.HealthCheckup.WinFormsUI.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace SUTH.HealthCheckup.WinFormsUI.Functions.CustomDatabase
{
    public class CustomReportHelpers
    {
        public static class FingerScan
        {
            const string _fingerscanConnectionString = "Server=fingerscan.suth.go.th;UID=fingerscan;PASSWORD=fingerscan;Database=fingerscan;";
            public static DataTable GetFingerScanListByDate(string StartDate,string EndDate)
            {
                string sql = $@"SELECT DISTINCT
  U.SSN AS UserId,
  U.NAME AS UserName,
  CONVERT(DATE,C.CHECKTIME) AS ScanedDate,
  CONVERT(VARCHAR(5),C.CHECKTIME, 108) AS ScanedTime,
  C.CHECKTYPE AS PeriodType,
  CASE WHEN C.CHECKTYPE = 'I' THEN 'IN' ELSE 'OUT'  END AS PeriodTypeName,
  M.MachineAlias AS MachineName,
  CASE WHEN  CAST(C.CHECKTIME AS TIME) BETWEEN '00:00:00' AND '12:00:00' THEN 'เช้า' ELSE 'บ่าย' END PeriodTime
FROM CHECKINOUT C
INNER JOIN USERINFO U on U.USERID = C.USERID
INNER JOIN Machines M on C.SENSORID = M.MachineNumber
WHERE C.CHECKTIME BETWEEN '{StartDate} 00:00:00' AND '{EndDate} 23:59:59' 
ORDER BY ScanedDate DESC,UserId,PeriodType";

                return Execute(sql);
            }
            public static DataTable GetFingerScanByUserId(string UserId)
            {
                string sql = $@"SELECT DISTINCT
  U.SSN AS UserId,
  U.NAME AS UserName,
  CONVERT(DATE,C.CHECKTIME) AS ScanedDate,
  CONVERT(VARCHAR(5),C.CHECKTIME, 108) AS ScanedTime,
  C.CHECKTYPE AS PeriodType,
  CASE WHEN C.CHECKTYPE = 'I' THEN 'IN' ELSE 'OUT'  END AS PeriodTypeName,
  M.MachineAlias AS MachineName,
  CASE WHEN  CAST(C.CHECKTIME AS TIME) BETWEEN '00:00:00' AND '12:00:00' THEN 'เช้า' ELSE 'บ่าย' END PeriodTime
FROM CHECKINOUT C
INNER JOIN USERINFO U on U.USERID = C.USERID
INNER JOIN Machines M on C.SENSORID = M.MachineNumber
WHERE U.SSN = '{UserId}' 
AND C.CHECKTIME BETWEEN DATEADD(DAY,-45, GETDATE()) AND GETDATE()
ORDER BY ScanedDate DESC,PeriodType";
                return Execute(sql);
            }
            private static DataTable Execute(string commandText)
            {
                using (SqlConnection conn = new SqlConnection(_fingerscanConnectionString))
                {
                    conn.Open();

                    using (SqlDataAdapter da = new SqlDataAdapter(commandText, conn))
                    {
                        da.SelectCommand.CommandTimeout = 0;
                        DataSet ds = new DataSet();
                        da.Fill(ds, "FingerScan");
                        return ds.Tables[0];
                    }
                }
            }
        }
        public static class Checkup
        {
            public static DataTable FromSql(string commandText, List<CustomReportParameter> parammeters)
            {
                DataTable table = new DataTable();
                foreach (var param in parammeters)
                {
                    if (commandText.Contains("dblink"))
                        commandText = commandText.Replace("@INV", "host=172.100.50.229 port=6432 user=suthos password=suthos@123 dbname=suthinvdb2");
                    commandText = commandText.Replace(param.Name, param.Value.ToString());
                }
                return PostgreSQL_ExecuteToTable(commandText, "Host=localhost;Port=5432;Database=Checkup;Username=suth;Password=suth;");
            }
        }
        public static class SUTHos
        {
            public static DataTable FromSql(string commandText, List<CustomReportParameter> parammeters)
            {
                DataTable table = new DataTable();
                foreach (var param in parammeters)
                {
                    if (commandText.Contains("dblink"))
                        commandText = commandText.Replace("@INV", "host=172.100.50.229 port=6432 user=suthos password=suthos@123 dbname=suthinvdb2");
                    commandText = commandText.Replace(param.Name, param.Value.ToString());
                }
                return PostgreSQL_ExecuteToTable(commandText, "Host=eclaimdb.suth.go.th;Database=suthos;Username=suthos;Password=suthos;");
            }
        }
        public static class HOSxP
        {
            public static DataTable FromSql(string commandText, List<CustomReportParameter> parammeters)
            {
                commandText = "SET CLIENT_ENCODING TO 'UTF8';\n\r" + BindingCommandParameters(commandText, parammeters);
                return PostgreSQL_ExecuteToTable(commandText, "Host=hosxp-conn.suth.go.th;Port=6432;Username=suthos;Password=suthos@123;Database=suthdb;");
            }
            public static List<dynamic> FromSql(string commandText)
            {
                try
                {
                    commandText = "SET CLIENT_ENCODING TO 'UTF8';\n\r" + commandText;
                    var table = PostgreSQL_ExecuteToTable(commandText, "Host=hosxp-conn.suth.go.th;Port=6432;Username=suthos;Password=suthos@123;Database=suthdb;");
                    string js = JsonConvert.SerializeObject(table);
                    return JsonConvert.DeserializeObject<List<dynamic>>(js);
                }
                catch
                {
                    return null;
                }
            }
        }
        public static class HOSxPInventory
        {
            public static DataTable FromSql(string commandText, List<CustomReportParameter> parammeters)
            {
                commandText = "SET CLIENT_ENCODING TO 'UTF8';\n\r" + BindingCommandParameters(commandText, parammeters);
                return PostgreSQL_ExecuteToTable(commandText, "Host=172.100.50.229;Port=6432;Username=suthos;Password=suthos@123;Database=suthinvdb2;");
            }
        }
        public static class Queue
        {
            public static DataTable FromSql(string commandText, List<CustomReportParameter> parammeters)
            {
                DataTable table = new DataTable();
                if (parammeters != null)
                {
                    foreach (var param in parammeters)
                    {
                        commandText = commandText.Replace(param.Name, param.Value.ToString());
                    }
                }
                return PostgreSQL_ExecuteToTable(commandText, "Host=172.100.50.201;Username = suthos; Password = suthos; Database = smart-queue;timeout=5;Pooling=false;");
            }
        }
        public static class Claim
        {
            public static DataTable FromSql(string commandText, List<CustomReportParameter> parammeters)
            {
                return PostgreSQL_ExecuteToTable(BindingCommandParameters(commandText,parammeters), "Host=eclaimdb.suth.go.th;Username = claim; Password = claim@suth; Database = suth-claim;timeout=5;Pooling=false;");
            }
        }
        public static class Backbone
        {
            public static DataTable FromSql(string commandText, List<CustomReportParameter> parammeters)
            {
                return MSSQL_ExecuteToTable(BindingCommandParameters(commandText, parammeters), "Server=172.100.50.211;UID=suthdev;PASSWORD=suth@dev;Database=SUTH_BACKBONE;");
            }
        }
        public static class RxScan
        {
            public static DataTable FromSql(string commandText, List<CustomReportParameter> parammeters)
            {
                return MSSQL_ExecuteToTable(BindingCommandParameters(commandText, parammeters), "Server=172.100.50.211;UID=suthdev;PASSWORD=suth@dev;Database=RxScan;");
            }
        }
        public static class BackOffice
        {
            public static DataTable FromSql(string commandText, List<CustomReportParameter> parammeters)
            {
                return MSSQL_ExecuteToTable(BindingCommandParameters(commandText, parammeters), "Server=backoffice.suth.go.th;UID=bit;PASSWORD=bitbit;Database=HOSXP;");
            }
        }
        public static class iPath
        {
            public static DataTable FromSql(string commandText, List<CustomReportParameter> parammeters)
            {
                return MSSQL_ExecuteToTable(BindingCommandParameters(commandText, parammeters), "Server=ipath.suth.go.th;UID=sa;PASSWORD=P@ssword;Database=iPATH_SUTH;");
            }
        }


        public static class HOSxP_Prod
        {
            private static string _connectString { get; } = "Host=172.100.50.221;Database=suthdb;Username=hatairat.su;Password=556064@it06;Port=6432;";
            //"Host=172.100.50.241;Port=5432;Username=hatairat.su;Password=556064@it06;Database=suthdb_datatest;";
            //"Host=172.100.50.221;Database=suthdb;Username=hatairat.su;Password=556064@it06;Port=6432;";
            //private static List<string> columnName = new List<string>();
            //private static List<string> param = new List<string>();
            public static string GetHosGuid()
            {
                string value = "";
                using (var con = new NpgsqlConnection(_connectString))
                {
                    con.Open();
                    using (var cmd = new NpgsqlCommand("select uuid_generate_v4()", con))
                    {
                        cmd.CommandText = "SET client_encoding = 'utf8';\n " + cmd.CommandText;
                        var reader = cmd.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        value = dt.Rows[0][0].ToString();
                    }
                }
                return value;
            }
            public static string GetNewHn(string cid)
            {
                string value = "";
                using (var con = new NpgsqlConnection(_connectString))
                {
                    con.Open();
                    using (var cmd = new NpgsqlCommand($"select get_newhn('{System.Environment.MachineName}-{cid}') as cc", con))
                    {
                        cmd.CommandText = "SET client_encoding = 'utf8';\n " + cmd.CommandText;
                        var reader = cmd.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        value = dt.Rows[0][0].ToString();
                    }
                }
                return value;
            }

            public static string GetSerial(string name)
            {
                string value = "";
                using (var con = new NpgsqlConnection(_connectString))
                {
                    con.Open();
                    using (var cmd = new NpgsqlCommand($"select get_serialnumber {name}", con))
                    {
                        cmd.CommandText = "SET client_encoding = 'utf8';\n " + cmd.CommandText;
                        var reader = cmd.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        value = dt.Rows[0][0].ToString();
                    }
                }
                return value;
            }
            //public static bool CreatePatients(CreatePatientDto entities)
            //{
            //    using (NpgsqlConnection conn = new NpgsqlConnection(_connectString))
            //    {
            //        conn.Open();
            //        using (NpgsqlTransaction tran = conn.BeginTransaction(IsolationLevel.Serializable))
            //        {
            //            try
            //            {
            //                string script = CommandBuildString<Patient>();
            //                foreach (var item in entities.PatientList)
            //                {
            //                    using (var cmd = new NpgsqlCommand(script, conn, tran))
            //                    {
            //                        foreach (var p in item.GetType().GetProperties())
            //                        {
            //                            cmd.Parameters.AddWithValue(string.Format("@{0}", p.Name), p.GetValue(item) == null ? DBNull.Value : p.GetValue(item));
            //                        }
            //                         cmd.ExecuteNonQuery();
            //                    }
            //                }

            //                script = CommandBuildString<ptcardno>();
            //                foreach (var item in entities.PatientCardNoList)
            //                {
            //                    using (var cmd = new NpgsqlCommand(script, conn, tran))
            //                    {
            //                        foreach (var p in item.GetType().GetProperties())
            //                        {
            //                            cmd.Parameters.AddWithValue(string.Format("@{0}", p.Name), p.GetValue(item) == null ? DBNull.Value : p.GetValue(item));
            //                        }
            //                         cmd.ExecuteNonQuery();
            //                    }
            //                }

            //                script = CommandBuildString<patient_eng>();
            //                foreach (var item in entities.PatientNameEngList)
            //                {
            //                    using (var cmd = new NpgsqlCommand(script, conn, tran))
            //                    {
            //                        foreach (var p in item.GetType().GetProperties())
            //                        {
            //                            cmd.Parameters.AddWithValue(string.Format("@{0}", p.Name), p.GetValue(item) == null ? DBNull.Value : p.GetValue(item));
            //                        }
            //                         cmd.ExecuteNonQuery();
            //                    }
            //                }

            //                script = CommandBuildString<patient_regiment>();
            //                foreach (var item in entities.PatientRegimentList)
            //                {
            //                    using (var cmd = new NpgsqlCommand(script, conn, tran))
            //                    {
            //                        foreach (var p in item.GetType().GetProperties())
            //                        {
            //                            cmd.Parameters.AddWithValue(string.Format("@{0}", p.Name), p.GetValue(item) == null ? DBNull.Value : p.GetValue(item));
            //                        }
            //                         cmd.ExecuteNonQuery();
            //                    }
            //                }

            //                tran.Commit();
            //                return true;
            //            }
            //            catch (Exception ex)
            //            {
            //                Console.WriteLine(ex.Message);
            //                tran.Rollback();
            //                return false;
            //            }
            //        }
            //    }
            //}
            //public static int DeleteBookHn()
            //{
            //    using (NpgsqlConnection conn = new NpgsqlConnection(_connectString))
            //    {
            //        conn.Open();
            //        string sql = $"DELETE FROM hnlock WHERE onlineid LIKE '{System.Environment.MachineName}%'";
            //        using (var cmd = new NpgsqlCommand(sql, conn))
            //        {
            //           return cmd.ExecuteNonQuery();
            //        }
            //    }
            //}
            private static string CommandBuildString<T>()
            {
                List<string> columnName = new List<string>();
                List<string> param = new List<string>();
                System.ComponentModel.PropertyDescriptorCollection properties = System.ComponentModel.TypeDescriptor.GetProperties(typeof(T));
                foreach (System.ComponentModel.PropertyDescriptor prop in properties)
                {
                    columnName.Add(prop.Name);
                    param.Add(string.Format("@{0}", prop.Name));
                }
                var script = "SET client_encoding = 'utf8';\n " + string.Format("INSERT INTO {0} ({1}) VALUES ({2});", typeof(T).Name.ToLower(), string.Join(",", columnName), string.Join(",", param));
                return script;
            }
        }
        //public static DataTable MSSQL_GetDataBackBoneResult(string commandText, List<CustomReportParameter> parammeters)
        //{
        //    foreach (var param in parammeters)
        //    {
        //        commandText = commandText.Replace(param.Name, param.Value.ToString());
        //    }
        //    using (SqlConnection conn = new SqlConnection("Server=172.100.50.211;UID=suthdev;PASSWORD=suth@dev;Database=SUTH_BACKBONE;"))
        //    {
        //        conn.Open();

        //        using (SqlDataAdapter da = new SqlDataAdapter(commandText, conn))
        //        {
        //            da.SelectCommand.CommandTimeout = 0;
        //            DataSet ds = new DataSet();
        //            da.Fill(ds, "CustomReport");
        //            return ds.Tables[0];
        //        }
        //    }
        //}
        //public static DataTable MSSQL_GetDataRxScanResult(string commandText, List<CustomReportParameter> parammeters)
        //{
        //    foreach (var param in parammeters)
        //    {
        //        commandText = commandText.Replace(param.Name, param.Value.ToString());
        //    }
        //    using (SqlConnection conn = new SqlConnection("Server=172.100.50.211;UID=suthdev;PASSWORD=suth@dev;Database=RxScan;"))
        //    {
        //        conn.Open();

        //        using (SqlDataAdapter da = new SqlDataAdapter(commandText, conn))
        //        {
        //            da.SelectCommand.CommandTimeout = 0;
        //            DataSet ds = new DataSet();
        //            da.Fill(ds, "CustomReport");
        //            return ds.Tables[0];
        //        }
        //    }
        //}        
        //public static DataTable NpgSQL_GetDataSUTHosResult(string commandText, List<CustomReportParameter> parammeters)
        //{
        //    DataTable table = new DataTable();
        //    foreach (var param in parammeters)
        //    {
        //        if (commandText.Contains("dblink"))
        //            commandText = commandText.Replace("@INV", "host=172.100.50.229 port=6432 user=suthos password=suthos@123 dbname=suthinvdb2");
        //        commandText = commandText.Replace(param.Name, param.Value.ToString());
        //    }
        //    return PostgreSQL_ExcecuteToTable(commandText, "Host=eclaimdb.suth.go.th;Database=suthos;Username=suthos;Password=suthos;");
        //}
        //public static DataTable NpgSQL_GetDataHosxpResult(string commandText, List<CustomReportParameter> parammeters)
        //{
        //    DataTable table = new DataTable();
        //    commandText = "SET CLIENT_ENCODING TO 'UTF8';\n\r" + commandText;
        //    foreach (var param in parammeters)
        //    {
        //        commandText = commandText.Replace(param.Name, param.Value.ToString());
        //    }
        //    return PostgreSQL_ExcecuteToTable(commandText, "Host=hosxp-conn.suth.go.th;Port=6432;Username=suthos;Password=suthos@123;Database=suthdb;");
        //}
        //public static DataTable NpgSQL_GetDataHOSxPInventoryResult(string commandText, List<CustomReportParameter> parammeters)
        //{
        //    DataTable table = new DataTable();
        //    commandText = "SET CLIENT_ENCODING TO 'UTF8';\n\r" + commandText;
        //    foreach (var param in parammeters)
        //    {
        //        commandText = commandText.Replace(param.Name, param.Value.ToString());
        //    }
        //    return PostgreSQL_ExcecuteToTable(commandText, "Host=172.100.50.229;Port=6432;Username=suthos;Password=suthos@123;Database=suthinvdb2;");
        //}
        //public static DataTable NpgSQL_GetDataClaimResult(string commandText, List<CustomReportParameter> parammeters)
        //{
        //    DataTable table = new DataTable();
        //    foreach (var param in parammeters)
        //    {
        //        commandText = commandText.Replace(param.Name, param.Value.ToString());
        //    }
        //    return PostgreSQL_ExcecuteToTable(commandText, "Host=eclaimdb.suth.go.th;Username = claim; Password = claim@suth; Database = claimdb;timeout=5;Pooling=false;");
        //}

        private static string BindingCommandParameters(string commandText, List<CustomReportParameter> parammeters)
        {
            if (parammeters != null)
            {
                foreach (var param in parammeters)
                {
                    commandText = commandText.Replace(param.Name, (param.Value??"").ToString());
                }
            }
            return commandText;
        }
        private static DataTable PostgreSQL_ExecuteToTable(string commandText, string connecttionString)
        {
            DataTable table = new DataTable();
            using (NpgsqlConnection conn = new NpgsqlConnection(connecttionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(commandText, conn))
                {
                    var reader = cmd.ExecuteReader();
                    if (!reader.HasRows)
                        return null;
                    table.Load(reader);
                    return table;
                }
            }
        }
        private static DataTable MSSQL_ExecuteToTable(string commandText, string connecttionString)
        {
            using (SqlConnection conn = new SqlConnection(connecttionString))
            {
                conn.Open();

                using (SqlDataAdapter da = new SqlDataAdapter(commandText, conn))
                {
                    da.SelectCommand.CommandTimeout = 0;
                    DataSet ds = new DataSet();
                    da.Fill(ds, "CustomReport");
                    return ds.Tables[0];
                }
            }
        }
    }
}
