using BigLion.Application.Features.RecommendationTemplates.Commands.Update;
using BigLion.Application.FunctionalTests.Features._Shared;
using BigLion.Domain.Entities;
using static BigLion.Application.FunctionalTests.Testing;

namespace BigLion.Application.FunctionalTests.Features.RecommendationTemplates.Commands;

public class UpdateRecommendationTemplateTests : BaseTestFixture
{
    /// ทดสอบ: อัปเดตเทมเพลตคำแนะนำที่มีอยู่ ควรบันทึกข้อมูลใหม่สำเร็จ
    [Test]
    public async Task Update_Existing_ShouldUpdateText()
    {
        RunAsDefaultUser();
        var id = await TestDataFactory.CreateTestRecommendationTemplateAsync("ข้อความเดิม");

        await SendAsync(new UpdateRecommendationTemplateCommand { Id = id, Text = "ข้อความใหม่" });

        var updated = await FindAsync<RecommendationTemplate>(id);
        updated.Should().NotBeNull();
        updated!.Text.Should().Be("ข้อความใหม่");
    }

    /// ทดสอบ: อัปเดตเทมเพลตที่ไม่มีในระบบ ควร throw NotFoundException
    [Test]
    public async Task Update_NonExisting_ShouldThrowNotFoundException()
    {
        RunAsDefaultUser();

        await FluentActions.Invoking(() => SendAsync(new UpdateRecommendationTemplateCommand
            { Id = 99999, Text = "X" }))
            .Should().ThrowAsync<BigLion.Application.Exceptions.NotFoundException>();
    }
}
