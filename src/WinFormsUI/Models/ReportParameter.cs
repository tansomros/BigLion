namespace SUTH.HealthCheckup.WinFormsUI.Models
{
    public class ReportParameter
    {
        string id;
        string paramName;
        string paramDescription;
        string ctrlType;
        string valueField;
        string displayField;
        string sql;

        public ReportParameter(string paramName,string paramDescription,string ctrlType,string ValueField,string DisplayField,string Sql)
        {
            this.paramName = paramName;
            this.paramDescription = paramDescription;
            this.ctrlType = ctrlType;
            valueField = ValueField;
            displayField = DisplayField;
            sql = Sql;
        }
        public ReportParameter(string id,string paramName, string paramDescription, string ctrlType, string ValueField, string DisplayField, string Sql)
        {
            this.id = id;
            this.paramName = paramName;
            this.paramDescription = paramDescription;
            this.ctrlType = ctrlType;
            valueField = ValueField;
            displayField = DisplayField;
            sql = Sql;
        }
        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        public string ParameterName
        {
            get { return paramName; }
            set { paramName = value; }
        }
        public string ParameterDesc
        {
            get { return paramDescription; }
            set { paramDescription = value; }
        }
        public string ControlType
        {
            get { return ctrlType; }
            set { ctrlType = value; }
        }
        public string ValueField
        {
            get { return valueField; }
            set { valueField = value; }
        }
        public string DisplayField
        {
            get { return displayField; }
            set { displayField = value; }
        }
        public string SQL
        {
            get { return sql; }
            set { sql = value; }
        }
    }
}
