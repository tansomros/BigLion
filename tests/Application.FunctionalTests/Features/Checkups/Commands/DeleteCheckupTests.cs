using BigLion.Application.Features.Checkups.Commands.Delete;
using BigLion.Application.FunctionalTests.Features._Shared;
using BigLion.Domain.Entities;
using static BigLion.Application.FunctionalTests.Testing;

namespace BigLion.Application.FunctionalTests.Features.Checkups.Commands;

public class DeleteCheckupTests : BaseTestFixture
{
    /// ทดสอบ: ลบรายการตรวจสุขภาพที่มีอยู่ ควรลบออกจากฐานข้อมูลสำเร็จ
    [Test]
    public async Task Delete_ExistingCheckup_ShouldRemoveFromDatabase()
    {
        RunAsDefaultUser();
        var prereqs = await TestDataFactory.SeedFullCheckupPrerequisitesAsync();

        await SendAsync(new DeleteCheckupCommand { Id = prereqs.CheckupId });

        var deleted = await FindAsync<Checkup>(prereqs.CheckupId);
        deleted.Should().BeNull();
    }

    /// ทดสอบ: ลบรายการตรวจที่ไม่มีในระบบ ควร throw NotFoundException
    [Test]
    public async Task Delete_NonExisting_ShouldThrowNotFoundException()
    {
        RunAsDefaultUser();

        await FluentActions.Invoking(() => SendAsync(new DeleteCheckupCommand { Id = 99999 }))
            .Should().ThrowAsync<BigLion.Application.Exceptions.NotFoundException>();
    }
}
