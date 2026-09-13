using BigLion.Application.Features.Reports.Commands;
using BigLion.Application.FunctionalTests.Features._Shared;
using BigLion.Domain.Entities;
using static BigLion.Application.FunctionalTests.Testing;

namespace BigLion.Application.FunctionalTests.Features.Reports.Commands;

public class CreateReportTests : BaseTestFixture
{
    /// ทดสอบ: สร้างรายงานสรุปผลตรวจใหม่ ควรคืนค่า Id ที่มากกว่า 0
    [Test]
    public async Task Create_WithValidData_ShouldReturnPositiveId()
    {
        RunAsDefaultUser();
        var prereqs = await TestDataFactory.SeedFullCheckupPrerequisitesAsync();

        var command = new CreateReportCommand
        {
            CheckupId = prereqs.CheckupId,
            VisitNumber = prereqs.VisitNumber,
            CheckupItemId = prereqs.CheckupItemId,
            PatientId = prereqs.PatientId,
            CheckupVisitId = prereqs.CheckupId,
            HospitalNumber = "HN001",
            VisitDate = DateOnly.FromDateTime(DateTime.Now),
            VisitTime = "08:00",
            CheckupTypeId = prereqs.CheckupTypeId,
            PayorName = "Test",
            PackageId = 1,
            PackageName = "Package"
        };

        var result = await SendAsync(command);
        result.Should().BeGreaterThan(0);
    }

    /// ทดสอบ: สร้างรายงานแล้วตรวจสอบข้อมูลที่บันทึก
    [Test]
    public async Task Create_WithValidData_ShouldPersistEntity()
    {
        RunAsDefaultUser();
        var prereqs = await TestDataFactory.SeedFullCheckupPrerequisitesAsync();

        var id = await SendAsync(new CreateReportCommand
        {
            CheckupId = prereqs.CheckupId,
            VisitNumber = prereqs.VisitNumber,
            CheckupItemId = prereqs.CheckupItemId,
            PatientId = prereqs.PatientId,
            CheckupVisitId = prereqs.CheckupId,
            HospitalNumber = "HN002",
            VisitDate = DateOnly.FromDateTime(DateTime.Now),
            VisitTime = "09:00",
            CheckupTypeId = prereqs.CheckupTypeId,
            PayorName = "Test",
            PackageId = 1,
            PackageName = "Package"
        });

        var entity = await FindAsync<Report>(id);
        entity.Should().NotBeNull();
        entity!.VisitNumber.Should().Be(prereqs.VisitNumber);
    }
}
