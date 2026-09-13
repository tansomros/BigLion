using BigLion.Application.Features.Audiograms.Commands.Delete;
using BigLion.Application.FunctionalTests.Features._Shared;
using BigLion.Domain.Entities;
using static BigLion.Application.FunctionalTests.Testing;

namespace BigLion.Application.FunctionalTests.Features.Audiograms.Commands;

public class DeleteAudiogramTests : BaseTestFixture
{
    /// ทดสอบ: ลบผลการได้ยินที่มีอยู่ ควรลบสำเร็จ
    [Test]
    public async Task Delete_Existing_ShouldRemoveFromDatabase()
    {
        RunAsDefaultUser();
        var prereqs = await TestDataFactory.SeedFullCheckupPrerequisitesAsync();
        var id = await TestDataFactory.CreateTestAudiogramAsync(prereqs.CheckupId, prereqs.CheckupItemId, prereqs.VisitNumber);

        await SendAsync(new DeleteAudiogramCommand { Id = id });

        var deleted = await FindAsync<Audiogram>(id);
        deleted.Should().BeNull();
    }

    /// ทดสอบ: ลบผลการได้ยินที่ไม่มี ควร throw NotFoundException
    [Test]
    public async Task Delete_NonExisting_ShouldThrowNotFoundException()
    {
        RunAsDefaultUser();

        await FluentActions.Invoking(() => SendAsync(new DeleteAudiogramCommand { Id = 99999 }))
            .Should().ThrowAsync<BigLion.Application.Exceptions.NotFoundException>();
    }
}
