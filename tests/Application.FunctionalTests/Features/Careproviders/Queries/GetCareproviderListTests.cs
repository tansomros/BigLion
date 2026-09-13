using BigLion.Application.Features.CareProviders.Queries.Get;
using BigLion.Application.FunctionalTests.Features._Shared;
using static BigLion.Application.FunctionalTests.Testing;

namespace BigLion.Application.FunctionalTests.Features.Careproviders.Queries;

public class GetCareProviderListTests : BaseTestFixture
{
    /// ทดสอบ: ดึงรายชื่อผู้ให้บริการเมื่อมีข้อมูล ควรคืนรายการที่ไม่ว่างเปล่า
    [Test]
    public async Task GetList_WhenDataExists_ShouldReturnNonEmptyList()
    {
        RunAsDefaultUser();
        await TestDataFactory.CreateTestCareproviderAsync();

        var result = await SendAsync(new GetCareProviderListQuery());

        result.Should().NotBeNull();
        result.CareProviders.Should().NotBeEmpty();
    }

    /// ทดสอบ: ดึงรายชื่อผู้ให้บริการเมื่อไม่มีข้อมูล ควรคืนรายการว่างเปล่า
    [Test]
    public async Task GetList_WhenNoData_ShouldReturnEmptyList()
    {
        RunAsDefaultUser();

        var result = await SendAsync(new GetCareProviderListQuery());

        result.Should().NotBeNull();
        result.CareProviders.Should().BeEmpty();
    }
}
