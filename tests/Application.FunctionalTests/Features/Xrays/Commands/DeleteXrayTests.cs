using BigLion.Application.Features.Xrays.Commands.Delete;
using BigLion.Application.FunctionalTests.Features._Shared;
using BigLion.Domain.Entities;
using static BigLion.Application.FunctionalTests.Testing;

namespace BigLion.Application.FunctionalTests.Features.Xrays.Commands;

public class DeleteXrayTests : BaseTestFixture
{
    /// ทดสอบ: ลบผล X-ray ที่มีอยู่ ควรลบสำเร็จ
    [Test]
    public async Task Delete_Existing_ShouldRemoveFromDatabase()
    {
        RunAsDefaultUser();
        var prereqs = await TestDataFactory.SeedFullCheckupPrerequisitesAsync();
        var id = await TestDataFactory.CreateTestXrayAsync(prereqs.CheckupId, prereqs.VisitNumber, prereqs.CheckupItemId);

        await SendAsync(new DeleteXrayCommand { Id = id });

        var deleted = await FindAsync<Xray>(id);
        deleted.Should().BeNull();
    }

    /// ทดสอบ: ลบผล X-ray ที่ไม่มีในระบบ ควร throw NotFoundException
    [Test]
    public async Task Delete_NonExisting_ShouldThrowNotFoundException()
    {
        RunAsDefaultUser();

        await FluentActions.Invoking(() => SendAsync(new DeleteXrayCommand { Id = 99999 }))
            .Should().ThrowAsync<BigLion.Application.Exceptions.NotFoundException>();
    }
}
