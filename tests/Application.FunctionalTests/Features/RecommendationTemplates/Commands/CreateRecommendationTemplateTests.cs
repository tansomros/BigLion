using BigLion.Application.Features.RecommendationTemplates.Commands.Create;
using BigLion.Domain.Entities;
using static BigLion.Application.FunctionalTests.Testing;

namespace BigLion.Application.FunctionalTests.Features.RecommendationTemplates.Commands;

public class CreateRecommendationTemplateTests : BaseTestFixture
{
    /// ทดสอบ: สร้างเทมเพลตคำแนะนำใหม่ด้วยข้อมูลที่ถูกต้อง ควรคืนค่า Id ที่มากกว่า 0
    [Test]
    public async Task Create_WithValidData_ShouldReturnPositiveId()
    {
        RunAsDefaultUser();

        var command = new CreateRecommendationTemplateCommand { Text = "ควรตรวจสุขภาพประจำปี" };

        var result = await SendAsync(command);
        result.Should().BeGreaterThan(0);
    }

    /// ทดสอบ: สร้างเทมเพลตคำแนะนำแล้วตรวจสอบข้อมูลที่บันทึก
    [Test]
    public async Task Create_WithValidData_ShouldPersistEntity()
    {
        RunAsDefaultUser();

        var id = await SendAsync(new CreateRecommendationTemplateCommand { Text = "งดอาหารไขมันสูง" });

        var entity = await FindAsync<RecommendationTemplate>(id);
        entity.Should().NotBeNull();
        entity!.Text.Should().Be("งดอาหารไขมันสูง");
    }
}
