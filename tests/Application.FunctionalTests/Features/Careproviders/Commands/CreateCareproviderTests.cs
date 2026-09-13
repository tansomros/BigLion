using BigLion.Application.Features.CareProviders.Commands.Create;
using BigLion.Domain.Entities;
using static BigLion.Application.FunctionalTests.Testing;
using ValidationException = BigLion.Application.Exceptions.ValidationException;

namespace BigLion.Application.FunctionalTests.Features.Careproviders.Commands;

public class CreateCareProviderTests : BaseTestFixture
{
    /// ทดสอบ: สร้างผู้ให้บริการใหม่ด้วยข้อมูลที่ถูกต้อง ควรคืนค่า Id ที่มากกว่า 0
    [Test]
    public async Task Create_WithValidData_ShouldReturnPositiveId()
    {
        RunAsDefaultUser();

        var command = new CreateCareProviderCommand
        {
            Code = "DR001",
            NameTH = "นพ.ทดสอบ ระบบ",
            NameEN = "Dr. Test System",
            LicenseNo = "12345",
            CareproviderType = 1
        };

        var result = await SendAsync(command);

        result.Should().BeGreaterThan(0);
    }

    /// ทดสอบ: สร้างผู้ให้บริการแล้วตรวจสอบว่าข้อมูลถูกบันทึกอย่างถูกต้อง
    [Test]
    public async Task Create_WithValidData_ShouldPersistEntity()
    {
        RunAsDefaultUser();

        var command = new CreateCareProviderCommand
        {
            Code = "DR002",
            NameTH = "พญ.ทดสอบ สอง",
            CareproviderType = 2
        };

        var id = await SendAsync(command);

        var entity = await FindAsync<CareProvider>(id);
        entity.Should().NotBeNull();
        entity!.Code.Should().Be("DR002");
        entity.FullNameThai.Should().Be("พญ.ทดสอบ สอง");
        entity.CareProviderTypeId.Should().Be(2);
    }

    /// ทดสอบ: สร้างผู้ให้บริการโดยไม่ระบุรหัส ควร throw ValidationException
    [Test]
    public async Task Create_WithNullCode_ShouldThrowValidationException()
    {
        RunAsDefaultUser();

        var command = new CreateCareProviderCommand
        {
            Code = null!,
            NameTH = "ทดสอบ",
            CareproviderType = 1
        };

        var act = () => SendAsync(command);
        (await act.Should().ThrowAsync<ValidationException>())
            .Which.Errors.Should().ContainKey("Code")
            .WhoseValue.Should().Contain("รหัส ต้องไม่ว่าง");
    }
}
