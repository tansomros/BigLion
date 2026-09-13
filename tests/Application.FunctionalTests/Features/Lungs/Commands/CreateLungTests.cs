using BigLion.Application.Features.Lungs.Commands.Create;
using BigLion.Application.FunctionalTests.Features._Shared;
using BigLion.Domain.Entities;
using static BigLion.Application.FunctionalTests.Testing;

namespace BigLion.Application.FunctionalTests.Features.Lungs.Commands;

public class CreateLungTests : BaseTestFixture
{
    /// ทดสอบ: สร้างผลตรวจปอดใหม่ ควรคืนค่า Id ที่มากกว่า 0
    [Test]
    public async Task Create_WithValidData_ShouldReturnPositiveId()
    {
        RunAsDefaultUser();
        var prereqs = await TestDataFactory.SeedFullCheckupPrerequisitesAsync();

        var command = new CreateLungCommand
        {
            CheckupId = prereqs.CheckupId,
            VisitNumber = prereqs.VisitNumber,
            CheckupItemId = prereqs.CheckupItemId,
            ResultAbnormal = "Normal"
        };

        var result = await SendAsync(command);
        result.Should().BeGreaterThan(0);
    }
}
