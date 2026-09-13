using BigLion.Application.Features.CareProviders.Queries.Get;
using BigLion.Application.FunctionalTests.Features._Shared;
using static BigLion.Application.FunctionalTests.Testing;

namespace BigLion.Application.FunctionalTests.Features.Careproviders.Queries;

public class GetCareProviderTests : BaseTestFixture
{
    /// ทดสอบ: ค้นหาผู้ให้บริการด้วย Id ที่มีอยู่ ควรคืนข้อมูลที่ถูกต้อง
    [Test]
    public async Task Get_ExistingId_ShouldReturnViewModel()
    {
        RunAsDefaultUser();
        var id = await TestDataFactory.CreateTestCareproviderAsync();

        var result = await SendAsync(new GetCareProviderQuery { Id = id });

        result.Should().NotBeNull();
        result.Id.Should().Be(id);
    }

    /// ทดสอบ: ค้นหาผู้ให้บริการด้วย Id ที่ไม่มีในระบบ ควร throw NotFoundException
    [Test]
    public async Task Get_NonExistingId_ShouldThrowNotFoundException()
    {
        RunAsDefaultUser();

        await FluentActions.Invoking(() => SendAsync(new GetCareProviderQuery { Id = 99999 }))
            .Should().ThrowAsync<BigLion.Application.Exceptions.NotFoundException>();
    }
}
