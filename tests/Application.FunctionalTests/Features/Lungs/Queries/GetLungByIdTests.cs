using BigLion.Application.Features.Lungs.Queries.Get;
using BigLion.Application.FunctionalTests.Features._Shared;
using BigLion.Domain.Entities;

using static BigLion.Application.FunctionalTests.Testing;

namespace BigLion.Application.FunctionalTests.Features.Lungs.Queries;

public class GetLungByIdTests : BaseTestFixture
{
    /// <summary>
    /// ทดสอบ: ค้นหารายการ Lung ด้วย Id ที่มีอยู่ ควรคืนข้อมูลที่ถูกต้อง
    /// </summary>
    [Test]
    public async Task Get_ExistingLung_ShouldReturnViewModel()
    {
        RunAsDefaultUser();
        var prereqs = await TestDataFactory.SeedFullCheckupPrerequisitesAsync();

        var lungId = await TestDataFactory.CreateTestLungAsync(
            prereqs.CheckupId, prereqs.VisitNumber, prereqs.CheckupItemId);

        var result = await SendAsync(new GetLungByIdQuery { Id = lungId });

        result.Should().NotBeNull();
    }

    /// <summary>
    /// ทดสอบ: ค้นหารายการ Lung ด้วย Id ที่ไม่มีอยู่ ควร throw NotFoundException
    /// </summary>
    [Test]
    public async Task Get_NonExistingLung_ShouldThrowNotFoundException()
    {
        RunAsDefaultUser();

        await FluentActions.Invoking(() => SendAsync(new GetLungByIdQuery { Id = 99999 }))
            .Should().ThrowAsync<BigLion.Application.Exceptions.NotFoundException>();
    }
}
