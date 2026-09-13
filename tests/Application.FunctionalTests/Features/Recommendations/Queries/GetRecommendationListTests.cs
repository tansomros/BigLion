using BigLion.Application.Features.Recommendations.Queries.Get;
using BigLion.Application.FunctionalTests.Features._Shared;
using static BigLion.Application.FunctionalTests.Testing;

namespace BigLion.Application.FunctionalTests.Features.Recommendations.Queries;

public class GetRecommendationListTests : BaseTestFixture
{
    /// ทดสอบ: ดึงรายการคำแนะนำทั้งหมดเมื่อมีข้อมูล ควรคืนรายการที่ไม่ว่างเปล่า
    [Test]
    public async Task GetList_WhenDataExists_ShouldReturnNonEmptyList()
    {
        RunAsDefaultUser();
        await TestDataFactory.CreateTestRecommendationAsync();

        var result = await SendAsync(new GetRecommendationListQuery());

        result.Should().NotBeNull();
        result.Recommendations.Should().NotBeEmpty();
    }

    /// ทดสอบ: ดึงรายการคำแนะนำเมื่อไม่มีข้อมูล ควรคืนรายการว่างเปล่า
    [Test]
    public async Task GetList_WhenNoData_ShouldReturnEmptyList()
    {
        RunAsDefaultUser();

        var result = await SendAsync(new GetRecommendationListQuery());

        result.Should().NotBeNull();
        result.Recommendations.Should().BeEmpty();
    }
}
