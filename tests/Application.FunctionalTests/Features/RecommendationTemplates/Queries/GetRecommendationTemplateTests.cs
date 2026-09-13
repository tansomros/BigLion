using BigLion.Application.Features.RecommendationTemplates.Commands.Create;
using BigLion.Application.Features.RecommendationTemplates.Queries.Get;

using static BigLion.Application.FunctionalTests.Testing;

namespace BigLion.Application.FunctionalTests.Features.RecommendationTemplates.Queries;

public class GetRecommendationTemplateTests : BaseTestFixture
{
    /// <summary>
    /// ทดสอบ: ค้นหาเทมเพลตคำแนะนำด้วย Id ที่มีอยู่ ควรคืนข้อมูล ViewModel ที่ถูกต้อง
    /// </summary>
    [Test]
    public async Task Get_ExistingTemplate_ShouldReturnViewModel()
    {
        RunAsDefaultUser();

        var id = await SendAsync(new CreateRecommendationTemplateCommand { Text = "คำแนะนำค้นหา" });

        var result = await SendAsync(new GetRecommendationTemplateQuery { Id = id });

        result.Should().NotBeNull();
        result.Text.Should().Be("คำแนะนำค้นหา");
    }

    /// <summary>
    /// ทดสอบ: ค้นหาเทมเพลตคำแนะนำด้วย Id ที่ไม่มีอยู่ ควร throw NotFoundException
    /// </summary>
    [Test]
    public async Task Get_NonExistingTemplate_ShouldThrowNotFoundException()
    {
        RunAsDefaultUser();

        await FluentActions.Invoking(() => SendAsync(new GetRecommendationTemplateQuery { Id = 99999 }))
            .Should().ThrowAsync<BigLion.Application.Exceptions.NotFoundException>();
    }
}
