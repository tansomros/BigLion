using BigLion.Application.Features.Recommendations.Commands.Delete;
using BigLion.Application.FunctionalTests.Features._Shared;
using BigLion.Domain.Entities;
using static BigLion.Application.FunctionalTests.Testing;

namespace BigLion.Application.FunctionalTests.Features.Recommendations.Commands;

public class DeleteRecommendationTests : BaseTestFixture
{
    /// ทดสอบ: ลบคำแนะนำที่มีอยู่ ควรลบออกจากฐานข้อมูลสำเร็จ
    [Test]
    public async Task Delete_ExistingRecommendation_ShouldRemoveFromDatabase()
    {
        RunAsDefaultUser();
        var id = await TestDataFactory.CreateTestRecommendationAsync();

        await SendAsync(new DeleteRecommendationCommand { Id = id });

        var deleted = await FindAsync<Recommendation>(id);
        deleted.Should().BeNull();
    }

    /// ทดสอบ: ลบคำแนะนำที่ไม่มีในระบบ ควร throw NotFoundException
    [Test]
    public async Task Delete_NonExisting_ShouldThrowNotFoundException()
    {
        RunAsDefaultUser();

        await FluentActions.Invoking(() => SendAsync(new DeleteRecommendationCommand { Id = 99999 }))
            .Should().ThrowAsync<BigLion.Application.Exceptions.NotFoundException>();
    }
}
