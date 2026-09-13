using BigLion.Application.Features.Lungs.Commands.Delete;
using BigLion.Application.FunctionalTests.Features._Shared;
using BigLion.Domain.Entities;
using static BigLion.Application.FunctionalTests.Testing;

namespace BigLion.Application.FunctionalTests.Features.Lungs.Commands;

public class DeleteLungTests : BaseTestFixture
{
    /// ทดสอบ: ลบผลตรวจปอดที่มีอยู่ ควรลบสำเร็จ
    [Test]
    public async Task Delete_Existing_ShouldRemoveFromDatabase()
    {
        RunAsDefaultUser();
        var prereqs = await TestDataFactory.SeedFullCheckupPrerequisitesAsync();
        var id = await TestDataFactory.CreateTestLungAsync(prereqs.CheckupId, prereqs.VisitNumber, prereqs.CheckupItemId);

        await SendAsync(new DeleteLungCommand { Id = id });

        var deleted = await FindAsync<Lung>(id);
        deleted.Should().BeNull();
    }

    /// ทดสอบ: ลบผลตรวจปอดที่ไม่มี ควร throw NotFoundException
    [Test]
    public async Task Delete_NonExisting_ShouldThrowNotFoundException()
    {
        RunAsDefaultUser();

        await FluentActions.Invoking(() => SendAsync(new DeleteLungCommand { Id = 99999 }))
            .Should().ThrowAsync<BigLion.Application.Exceptions.NotFoundException>();
    }
}
