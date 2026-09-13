using BigLion.Application.Features.SpecialTests.Commands.Create;
using BigLion.Application.FunctionalTests.Features._Shared;
using BigLion.Domain.Entities;
using static BigLion.Application.FunctionalTests.Testing;

namespace BigLion.Application.FunctionalTests.Features.SpecialTests.Commands;

public class CreateSpecialTestTests : BaseTestFixture
{
    /// ทดสอบ: สร้างผลตรวจพิเศษใหม่ ควรคืนค่า Id ที่มากกว่า 0
    [Test]
    public async Task Create_WithValidData_ShouldReturnPositiveId()
    {
        RunAsDefaultUser();
        var prereqs = await TestDataFactory.SeedFullCheckupPrerequisitesAsync();

        var command = new CreateSpecialTestCommand
        {
            CheckupId = prereqs.CheckupId,
            VisitNumber = prereqs.VisitNumber,
            CheckupItemId = prereqs.CheckupItemId
        };

        var result = await SendAsync(command);
        result.Should().BeGreaterThan(0);
    }
}
