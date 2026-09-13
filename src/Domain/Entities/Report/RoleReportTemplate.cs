using System.Collections.Generic;

namespace BigLion.Domain.Entities.Report
{
    public class RoleReportTemplate: BaseEntity

    {
        public required string RoleName { get; set; }
        public List<int> ReportTemplateList { get; set; }
        public string? CreateUser { get; set; }
        public string? ModifiedUser { get; set; }
        public RoleReportTemplate(string roleName)
        {
            RoleName = roleName;
            ReportTemplateList = [];
        }
    }
}
