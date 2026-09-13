using BigLion.Application.Features.RecommendationTemplates.Commands.Delete;
using BigLion.Application.FunctionalTests.Features._Shared;
using BigLion.Domain.Entities;
using static BigLion.Application.FunctionalTests.Testing;

namespace BigLion.Application.FunctionalTests.Features.RecommendationTemplates.Commands;

public class DeleteRecommendationTemplateTests : BaseTestFixture
{
    /// ทดสอบ: ลบเทมเพลตคำแนะนำที่มีอยู่ ควรลบออกจากฐานข้อมูลสำเร็จ
    [Test]
    public async Task Delete_Existing_ShouldRemoveFromDatabase()
    {
        RunAsDefaultUser();
        var id = await TestDataFactory.CreateTestRecommendationTemplateAsync();

        await SendAsync(new DeleteRecommendationTemplateCommand { Id = id });

        var deleted = await FindAsync<RecommendationTemplate>(id);
        deleted.Should().BeNull();
    }

    /// ทดสอบ: ลบเทมเพลตที่ไม่มีในระบบ ควร throw NotFoundException
    [Test]
    public async Task Delete_NonExisting_ShouldThrowNotFoundException()
    {
        RunAsDefaultUser();

        await FluentActions.Invoking(() => SendAsync(new DeleteRecommendationTemplateCommand { Id = 99999 }))
            .Should().ThrowAsync<BigLion.Application.Exceptions.NotFoundException>();
    }
}
