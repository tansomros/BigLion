using BigLion.Application.Features.Visions.Commands.Create;
using BigLion.Application.FunctionalTests.Features._Shared;
using BigLion.Domain.Entities;
using static BigLion.Application.FunctionalTests.Testing;

namespace BigLion.Application.FunctionalTests.Features.Visions.Commands;

public class CreateVisionTests : BaseTestFixture
{
    /// ทดสอบ: สร้างผลตรวจสายตาใหม่ด้วยข้อมูลที่ถูกต้อง ควรคืนค่า Id ที่มากกว่า 0
    [Test]
    public async Task Create_WithValidData_ShouldReturnPositiveId()
    {
        RunAsDefaultUser();
        var prereqs = await TestDataFactory.SeedFullCheckupPrerequisitesAsync();

        var command = new CreateVisionCommand
        {
            CheckupId = prereqs.CheckupId,
            VisitNumber = prereqs.VisitNumber,
            CheckupItemId = prereqs.CheckupItemId,
            VisionRightResult = "20/20",
            VisionLeftResult = "20/25",
            IsActive = true
        };

        var result = await SendAsync(command);
        result.Should().BeGreaterThan(0);
    }

    /// ทดสอบ: สร้างผลตรวจสายตาแล้วตรวจสอบข้อมูลที่บันทึก
    [Test]
    public async Task Create_WithValidData_ShouldPersistEntity()
    {
        RunAsDefaultUser();
        var prereqs = await TestDataFactory.SeedFullCheckupPrerequisitesAsync();

        var id = await SendAsync(new CreateVisionCommand
        {
            CheckupId = prereqs.CheckupId,
            VisitNumber = prereqs.VisitNumber,
            CheckupItemId = prereqs.CheckupItemId,
            VisionRightResult = "20/20",
            VisionLeftResult = "20/20",
            IsActive = true
        });

        var entity = await FindAsync<Vision>(id);
        entity.Should().NotBeNull();
        entity!.VisionRightResult.Should().Be("20/20");
    }
}
