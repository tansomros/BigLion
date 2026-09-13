using BigLion.Application.Features.CheckupGroups.Commands.Create;
using BigLion.Application.FunctionalTests.Features._Shared;
using BigLion.Domain.Entities;
using static BigLion.Application.FunctionalTests.Testing;

namespace BigLion.Application.FunctionalTests.Features.CheckupGroups.Commands;

public class CreateCheckupGroupTests : BaseTestFixture
{
    /// ทดสอบ: สร้างกลุ่มการตรวจใหม่ด้วยข้อมูลที่ถูกต้อง ควรคืนค่า Id
    [Test]
    public async Task Create_WithValidData_ShouldReturnId()
    {
        RunAsDefaultUser();
        var classId = await TestDataFactory.CreateTestCheckupClassAsync();

        var command = new CreateCheckupGroupCommand
        {
            Id = 9001,
            Code = "CBC",
            Name = "Complete Blood Count",
            ClassId = classId,
            Sort = 1
        };

        var result = await SendAsync(command);
        result.Should().Be(9001);
    }

    /// ทดสอบ: สร้างกลุ่มการตรวจแล้วตรวจสอบข้อมูลที่บันทึก
    [Test]
    public async Task Create_WithValidData_ShouldPersistEntity()
    {
        RunAsDefaultUser();
        var classId = await TestDataFactory.CreateTestCheckupClassAsync();

        var id = await SendAsync(new CreateCheckupGroupCommand
        {
            Id = 9002,
            Code = "FBS",
            Name = "Fasting Blood Sugar",
            ClassId = classId,
            Sort = 2
        });

        var entity = await FindAsync<CheckupGroup>(id);
        entity.Should().NotBeNull();
        entity!.Code.Should().Be("FBS");
    }
}
