using BigLion.Application.Features.Audiograms.Commands.Create;
using BigLion.Application.FunctionalTests.Features._Shared;
using BigLion.Domain.Entities;
using static BigLion.Application.FunctionalTests.Testing;

namespace BigLion.Application.FunctionalTests.Features.Audiograms.Commands;

public class CreateAudiogramTests : BaseTestFixture
{
    /// ทดสอบ: สร้างผลการได้ยินใหม่ด้วยข้อมูลที่ถูกต้อง ควรคืนค่า Id ที่มากกว่า 0
    [Test]
    public async Task Create_WithValidData_ShouldReturnPositiveId()
    {
        RunAsDefaultUser();
        var prereqs = await TestDataFactory.SeedFullCheckupPrerequisitesAsync();

        var command = new CreateAudiogramCommand
        {
            CheckupId = prereqs.CheckupId,
            VisitNumber = prereqs.VisitNumber,
            CheckupItemId = prereqs.CheckupItemId,
            LeftResult = "ปกติ",
            RightResult = "ปกติ",
            ResultNote = "ปกติ",
            LeftNote = "ปกติ",
            RightNote = "ปกติ"
        };

        var result = await SendAsync(command);
        result.Should().BeGreaterThan(0);
    }

    /// ทดสอบ: สร้างผลการได้ยินแล้วตรวจสอบข้อมูลที่บันทึก
    [Test]
    public async Task Create_WithValidData_ShouldPersistEntity()
    {
        RunAsDefaultUser();
        var prereqs = await TestDataFactory.SeedFullCheckupPrerequisitesAsync();

        var id = await SendAsync(new CreateAudiogramCommand
        {
            CheckupId = prereqs.CheckupId,
            VisitNumber = prereqs.VisitNumber,
            CheckupItemId = prereqs.CheckupItemId,
            LeftResult = "ปกติ",
            RightResult = "ผิดปกติ",
            ResultNote = "ข้างขวาผิดปกติ",
            LeftNote = "ปกติ",
            RightNote = "ผิดปกติ"
        });

        var entity = await FindAsync<Audiogram>(id);
        entity.Should().NotBeNull();
    }
}
