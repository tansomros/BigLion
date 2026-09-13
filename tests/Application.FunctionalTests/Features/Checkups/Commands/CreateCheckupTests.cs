using BigLion.Application.Features.Checkups.Commands.Create;
using BigLion.Application.FunctionalTests.Features._Shared;
using BigLion.Domain.Entities;
using static BigLion.Application.FunctionalTests.Testing;

namespace BigLion.Application.FunctionalTests.Features.Checkups.Commands;

public class CreateCheckupTests : BaseTestFixture
{
    /// ทดสอบ: สร้างรายการตรวจสุขภาพใหม่ด้วยข้อมูลที่ถูกต้อง ควรคืนค่า Id ที่มากกว่า 0
    [Test]
    public async Task Create_WithValidData_ShouldReturnPositiveId()
    {
        RunAsDefaultUser();
        var prereqs = await TestDataFactory.SeedFullCheckupPrerequisitesAsync();

        var command = new CreateCheckupCommand
        {
            CheckupVisitId = 88001,
            VisitNumber = "VN88000001",
            HospitalNumber = "HN88001",
            VisitDate = DateOnly.FromDateTime(DateTime.Now),
            VisitTime = TimeOnly.FromDateTime(DateTime.Now),
            CheckupTypeId = prereqs.CheckupTypeId,
            PayorName = "สิทธิ์ทดสอบ",
            PackageId = 1,
            PackageName = "แพ็คเกจทดสอบ",
            PatientId = prereqs.PatientId,
            LabOrder = new List<string>(),
            XrayOrder = new List<string>(),
            ServiceOrder = new List<string>(),
            Weight = 70,
            Height = 170,
            Temperature = 36.5,
            Waist = 80
        };

        var result = await SendAsync(command);
        result.Should().BeGreaterThan(0);
    }

    /// ทดสอบ: สร้างรายการตรวจสุขภาพแล้วตรวจสอบข้อมูลที่บันทึก
    [Test]
    public async Task Create_WithValidData_ShouldPersistEntity()
    {
        RunAsDefaultUser();
        var prereqs = await TestDataFactory.SeedFullCheckupPrerequisitesAsync();

        var id = await SendAsync(new CreateCheckupCommand
        {
            CheckupVisitId = 88002,
            VisitNumber = "VN88000002",
            HospitalNumber = "HN88002",
            VisitDate = DateOnly.FromDateTime(DateTime.Now),
            VisitTime = TimeOnly.FromDateTime(DateTime.Now),
            CheckupTypeId = prereqs.CheckupTypeId,
            PayorName = "สิทธิ์",
            PackageId = 1,
            PackageName = "แพ็คเกจ",
            PatientId = prereqs.PatientId,
            LabOrder = new List<string>(),
            XrayOrder = new List<string>(),
            ServiceOrder = new List<string>(),
            Weight = 70,
            Height = 170,
            Temperature = 36.5,
            Waist = 80
        });

        var entity = await FindAsync<Checkup>(id);
        entity.Should().NotBeNull();
        entity!.VisitNumber.Should().Be("VN88000002");
    }
}
