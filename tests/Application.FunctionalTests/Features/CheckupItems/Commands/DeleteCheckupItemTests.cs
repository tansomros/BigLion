using BigLion.Application.Features.CheckupItems.Commands.Delete;
using BigLion.Application.FunctionalTests.Features._Shared;
using BigLion.Domain.Entities;
using static BigLion.Application.FunctionalTests.Testing;

namespace BigLion.Application.FunctionalTests.Features.CheckupItems.Commands;

public class DeleteCheckupItemTests : BaseTestFixture
{
    /// ทดสอบ: ลบรายการตรวจที่มีอยู่ ควรลบออกจากฐานข้อมูลสำเร็จ
    [Test]
    public async Task Delete_ExistingItem_ShouldRemoveFromDatabase()
    {
        RunAsDefaultUser();
        var classId = await TestDataFactory.CreateTestCheckupClassAsync();
        var groupId = await TestDataFactory.CreateTestCheckupGroupAsync(classId);
        var itemId = await TestDataFactory.CreateTestCheckupItemAsync(groupId);

        await SendAsync(new DeleteCheckupItemCommand { Id = itemId });

        var deleted = await FindAsync<CheckupItem>(itemId);
        deleted.Should().BeNull();
    }

    /// ทดสอบ: ลบรายการตรวจที่ไม่มีในระบบ ควร throw NotFoundException
    [Test]
    public async Task Delete_NonExisting_ShouldThrowNotFoundException()
    {
        RunAsDefaultUser();

        await FluentActions.Invoking(() => SendAsync(new DeleteCheckupItemCommand { Id = 99999 }))
            .Should().ThrowAsync<BigLion.Application.Exceptions.NotFoundException>();
    }
}
