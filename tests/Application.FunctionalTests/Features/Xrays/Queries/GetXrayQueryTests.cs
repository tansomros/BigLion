using BigLion.Application.Features.Xrays.Queries.Get;
using BigLion.Application.FunctionalTests.Features._Shared;
using BigLion.Domain.Entities;

using static BigLion.Application.FunctionalTests.Testing;

namespace BigLion.Application.FunctionalTests.Features.Xrays.Queries;

public class GetXrayQueryTests : BaseTestFixture
{
    /// <summary>
    /// ทดสอบ: ค้นหารายการ Xray ด้วย VisitNumber ที่มีอยู่ ควรคืนข้อมูลที่ถูกต้อง
    /// </summary>
    [Test]
    public async Task Get_ExistingXray_ShouldReturnViewModel()
    {
        RunAsDefaultUser();
        var prereqs = await TestDataFactory.SeedFullCheckupPrerequisitesAsync();

        await TestDataFactory.CreateTestXrayAsync(
            prereqs.CheckupId, prereqs.VisitNumber, prereqs.CheckupItemId);

        var result = await SendAsync(new GetXrayQuery { VisitNumber = prereqs.VisitNumber });

        result.Should().NotBeNull();
    }

    /// <summary>
    /// ทดสอบ: ค้นหารายการ Xray ด้วย VisitNumber ที่ไม่มีอยู่ ควร throw NotFoundException
    /// </summary>
    [Test]
    public async Task Get_NonExistingXray_ShouldThrowNotFoundException()
    {
        RunAsDefaultUser();

        await FluentActions.Invoking(() => SendAsync(new GetXrayQuery { VisitNumber = "VN_NOT_EXIST" }))
            .Should().ThrowAsync<BigLion.Application.Exceptions.NotFoundException>();
    }
}
