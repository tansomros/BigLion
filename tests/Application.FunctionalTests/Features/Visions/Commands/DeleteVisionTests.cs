using BigLion.Application.Features.Visions.Commands.Delete;
using BigLion.Application.FunctionalTests.Features._Shared;
using BigLion.Domain.Entities;
using static BigLion.Application.FunctionalTests.Testing;

namespace BigLion.Application.FunctionalTests.Features.Visions.Commands;

public class DeleteVisionTests : BaseTestFixture
{
    /// ทดสอบ: ลบผลตรวจสายตาที่มีอยู่ ควรลบสำเร็จ
    [Test]
    public async Task Delete_Existing_ShouldRemoveFromDatabase()
    {
        RunAsDefaultUser();
        var prereqs = await TestDataFactory.SeedFullCheckupPrerequisitesAsync();
        var id = await TestDataFactory.CreateTestVisionAsync(prereqs.CheckupId, prereqs.VisitNumber, prereqs.CheckupItemId);

        await SendAsync(new DeleteVisionCommand { Id = id });

        var deleted = await FindAsync<Vision>(id);
        deleted.Should().BeNull();
    }

    /// ทดสอบ: ลบผลตรวจสายตาที่ไม่มี ควร throw NotFoundException
    [Test]
    public async Task Delete_NonExisting_ShouldThrowNotFoundException()
    {
        RunAsDefaultUser();

        await FluentActions.Invoking(() => SendAsync(new DeleteVisionCommand { Id = 99999 }))
            .Should().ThrowAsync<BigLion.Application.Exceptions.NotFoundException>();
    }
}
