using BigLion.Application.Features.HearingHertzs.Commands.Delete;
using BigLion.Application.FunctionalTests.Features._Shared;
using BigLion.Domain.Entities;
using static BigLion.Application.FunctionalTests.Testing;

namespace BigLion.Application.FunctionalTests.Features.HearingHertzs.Commands;

public class DeleteHearingHertzTests : BaseTestFixture
{
    /// ทดสอบ: ลบความถี่การได้ยินที่มีอยู่ ควรลบออกจากฐานข้อมูลสำเร็จ
    [Test]
    public async Task Delete_ExistingHertz_ShouldRemoveFromDatabase()
    {
        RunAsDefaultUser();
        var id = await TestDataFactory.CreateTestHearingHertzAsync(2000);

        await SendAsync(new DeleteHearingHertzCommand { Id = id });

        var deleted = await FindAsync<HearingHertz>(id);
        deleted.Should().BeNull();
    }

    /// ทดสอบ: ลบความถี่การได้ยินที่ไม่มีในระบบ ควร throw NotFoundException
    [Test]
    public async Task Delete_NonExisting_ShouldThrowNotFoundException()
    {
        RunAsDefaultUser();

        await FluentActions.Invoking(() => SendAsync(new DeleteHearingHertzCommand { Id = 99999 }))
            .Should().ThrowAsync<BigLion.Application.Exceptions.NotFoundException>();
    }
}
