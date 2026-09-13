using BigLion.Application.Features.Visions.Queries.Get;
using BigLion.Application.FunctionalTests.Features._Shared;
using BigLion.Domain.Entities;

using static BigLion.Application.FunctionalTests.Testing;

namespace BigLion.Application.FunctionalTests.Features.Visions.Queries;

public class GetVisionByIdTests : BaseTestFixture
{
    /// <summary>
    /// ทดสอบ: ค้นหารายการ Vision ด้วย Id ที่มีอยู่ ควรคืนข้อมูลที่ถูกต้อง
    /// </summary>
    [Test]
    public async Task Get_ExistingVision_ShouldReturnViewModel()
    {
        RunAsDefaultUser();
        var prereqs = await TestDataFactory.SeedFullCheckupPrerequisitesAsync();

        var visionId = await TestDataFactory.CreateTestVisionAsync(
            prereqs.CheckupId, prereqs.VisitNumber, prereqs.CheckupItemId);

        var result = await SendAsync(new GetVisionByIdQuery { Id = visionId });

        result.Should().NotBeNull();
    }

    /// <summary>
    /// ทดสอบ: ค้นหารายการ Vision ด้วย Id ที่ไม่มีอยู่ ควร throw NotFoundException
    /// </summary>
    [Test]
    public async Task Get_NonExistingVision_ShouldThrowNotFoundException()
    {
        RunAsDefaultUser();

        await FluentActions.Invoking(() => SendAsync(new GetVisionByIdQuery { Id = 99999 }))
            .Should().ThrowAsync<BigLion.Application.Exceptions.NotFoundException>();
    }
}
