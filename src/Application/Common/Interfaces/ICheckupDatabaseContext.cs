using Microsoft.EntityFrameworkCore.Infrastructure;
using BigLion.Domain.Entities;

#pragma warning disable CS0618
namespace BigLion.Application.Common.Interfaces
{
    public interface ICheckupDatabaseContext
    {
        DatabaseFacade Database { get; }
        DbSet<Audiogram> Audiograms { get; }
        DbSet<BodyComposition> BodyCompositions { get; }
        DbSet<Dental> Dentals { get; }
        DbSet<CareProvider> CareProviders { get; }
        DbSet<Checkup> Checkups { get; }
        DbSet<CheckupClass> CheckupClasses { get; }
        DbSet<CheckupGroup> CheckupGroups { get; }
        DbSet<CheckupType> CheckupTypes { get; }
        DbSet<CheckupItem> CheckupItems { get; }
        DbSet<Company> Company { get; }
        DbSet<District> Districts { get; }
        DbSet<HearingHertz> HearingHertzs { get; }
        DbSet<Hearing> Hearings { get; }
        DbSet<Lab> Labs { get; }
        DbSet<Lung> Lungs { get; }
        DbSet<Patient> Patients { get; }
        DbSet<PhysicalExamination> PhysicalExams { get; }
        DbSet<Province> Provinces { get; }
        DbSet<Recommendation> Recommendations { get; }
        DbSet<RecommendationTemplate> RecommendationTemplates { get; }
        DbSet<SpecialTest> SpecialTests { get; }
        DbSet<SubDistrict> SubDistricts { get; }
        DbSet<Vision> Visions { get; }
        DbSet<Xray> Xrays { get; }
        DbSet<ReferenceGroup> ReferenceGroups { get; }
        DbSet<ReferenceValue> ReferenceValues { get; }
        DbSet<Report> Reports { get; }
        DbSet<ReportTemplate> ReportTemplate { get; }
        DbSet<ReportTemplateDetail> ReportTemplateDetail { get; }
        DbSet<ReportGroup> ReportGroup { get; }
        DbSet<RoleReportTemplate> RoleReportTemplate { get; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        int SaveChanges();
    }
}
