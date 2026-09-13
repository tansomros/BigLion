using BigLion.Application.Features.SpecialTests.Commands.Delete;
using BigLion.Application.FunctionalTests.Features._Shared;
using BigLion.Domain.Entities;
using static BigLion.Application.FunctionalTests.Testing;

namespace BigLion.Application.FunctionalTests.Features.SpecialTests.Commands;

public class DeleteSpecialTestTests : BaseTestFixture
{
    /// ทดสอบ: ลบผลตรวจพิเศษที่มีอยู่ ควรลบสำเร็จ
    [Test]
    public async Task Delete_Existing_ShouldRemoveFromDatabase()
    {
        RunAsDefaultUser();
        var prereqs = await TestDataFactory.SeedFullCheckupPrerequisitesAsync();
        var id = await TestDataFactory.CreateTestSpecialTestAsync(prereqs.CheckupId, prereqs.VisitNumber, prereqs.CheckupItemId);

        await SendAsync(new DeleteSpecialTestCommand { Id = id });

        var deleted = await FindAsync<SpecialTest>(id);
        deleted.Should().BeNull();
    }

    /// ทดสอบ: ลบผลตรวจพิเศษที่ไม่มี ควร throw NotFoundException
    [Test]
    public async Task Delete_NonExisting_ShouldThrowNotFoundException()
    {
        RunAsDefaultUser();

        await FluentActions.Invoking(() => SendAsync(new DeleteSpecialTestCommand { Id = 99999 }))
            .Should().ThrowAsync<BigLion.Application.Exceptions.NotFoundException>();
    }
}
