using BigLion.Application.Features.Checkups.Queries;
using BigLion.Application.FunctionalTests.Features._Shared;
using static BigLion.Application.FunctionalTests.Testing;

namespace BigLion.Application.FunctionalTests.Features.Checkups.Queries;

public class GetCheckupTests : BaseTestFixture
{
    /// ทดสอบ: ค้นหารายการตรวจสุขภาพด้วย Id ที่มีอยู่ ควรคืนข้อมูลที่ถูกต้อง
    [Test]
    public async Task Get_ExistingId_ShouldReturnViewModel()
    {
        RunAsDefaultUser();
        var prereqs = await TestDataFactory.SeedFullCheckupPrerequisitesAsync();

        var result = await SendAsync(new GetCheckupQuery { Id = prereqs.CheckupId });

        result.Should().NotBeNull();
        result.Id.Should().Be(prereqs.CheckupId);
    }

    /// ทดสอบ: ค้นหารายการตรวจด้วย Id ที่ไม่มี ควร throw NotFoundException
    [Test]
    public async Task Get_NonExisting_ShouldThrowNotFoundException()
    {
        RunAsDefaultUser();

        await FluentActions.Invoking(() => SendAsync(new GetCheckupQuery { Id = 99999 }))
            .Should().ThrowAsync<BigLion.Application.Exceptions.NotFoundException>();
    }
}
