using BigLion.Infrastructure.Persistence.Interceptors;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using BigLion.Application.Common.Interfaces;
using BigLion.Domain.Entities;

#pragma warning disable CS0618 // ReferenceGroup/ReferenceValue ยังคง DbSet ไว้ แต่ถูกแทนที่ด้วย SmartEnum แล้ว
namespace BigLion.Infrastructure.Persistence
{
    public class CheckupDatabaseContext : DbContext, ICheckupDatabaseContext
    {
        private readonly AuditableEntitySaveChangesInterceptors _auditableEntitySaveChangesInterceptors;

        public override DatabaseFacade Database { get; }
        public DbSet<Audiogram> Audiograms => Set<Audiogram>();
        public DbSet<BodyComposition> BodyCompositions => Set<BodyComposition>();
        public DbSet<Dental> Dentals => Set<Dental>();
        public DbSet<CareProvider> CareProviders => Set<CareProvider>();
        public DbSet<Checkup> Checkups => Set<Checkup>();
        public DbSet<CheckupClass> CheckupClasses => Set<CheckupClass>();
        public DbSet<CheckupGroup> CheckupGroups => Set<CheckupGroup>();
        public DbSet<CheckupType> CheckupTypes => Set<CheckupType>();
        public DbSet<CheckupItem> CheckupItems => Set<CheckupItem>();
        public DbSet<Company> Company => Set<Company>();
        public DbSet<District> Districts => Set<District>();
        public DbSet<Hearing> Hearings => Set<Hearing>();
        public DbSet<HearingHertz> HearingHertzs => Set<HearingHertz>();
        public DbSet<Lab> Labs => Set<Lab>();
        public DbSet<Lung> Lungs => Set<Lung>();
        public DbSet<Patient> Patients => Set<Patient>();
        public DbSet<PhysicalExamination> PhysicalExams => Set<PhysicalExamination>();
        public DbSet<Province> Provinces => Set<Province>();
        public DbSet<Recommendation> Recommendations => Set<Recommendation>();
        public DbSet<RecommendationTemplate> RecommendationTemplates => Set<RecommendationTemplate>();
        public DbSet<SpecialTest> SpecialTests => Set<SpecialTest>();
        public DbSet<SubDistrict> SubDistricts => Set<SubDistrict>();
        public DbSet<Vision> Visions => Set<Vision>();
        public DbSet<Xray> Xrays => Set<Xray>();
        public DbSet<ReferenceGroup> ReferenceGroups => Set<ReferenceGroup>();
        public DbSet<ReferenceValue> ReferenceValues => Set<ReferenceValue>();
        public DbSet<Report> Reports => Set<Report>();

        #region Report Template
        public DbSet<ReportTemplate> ReportTemplate => Set<ReportTemplate>();
        public DbSet<ReportTemplateDetail> ReportTemplateDetail => Set<ReportTemplateDetail>();
        public DbSet<ReportGroup> ReportGroup => Set<ReportGroup>();
        public DbSet<RoleReportTemplate> RoleReportTemplate => Set<RoleReportTemplate>();
        #endregion

        public CheckupDatabaseContext(DbContextOptions<CheckupDatabaseContext> options)
            : base(options)
        {
            Database = base.Database;
        }

        public CheckupDatabaseContext(
            DbContextOptions<CheckupDatabaseContext> options,
            AuditableEntitySaveChangesInterceptors auditableEntitySaveChangesInterceptors)
            : base(options)
        {
            Database = base.Database;
            _auditableEntitySaveChangesInterceptors = auditableEntitySaveChangesInterceptors;
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            return base.SaveChangesAsync(cancellationToken);
        }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CheckupDatabaseContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.AddInterceptors(_auditableEntitySaveChangesInterceptors);
        }
    }
}
