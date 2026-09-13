using BigLion.Application.Features.CareProviders.Commands.Update;
using BigLion.Application.FunctionalTests.Features._Shared;
using BigLion.Domain.Entities;
using static BigLion.Application.FunctionalTests.Testing;

namespace BigLion.Application.FunctionalTests.Features.Careproviders.Commands;

public class UpsertCareProviderTests : BaseTestFixture
{
    /// ทดสอบ: อัปเดตผู้ให้บริการที่มีอยู่ผ่าน Upsert ควรอัปเดตข้อมูลสำเร็จ
    [Test]
    public async Task Upsert_ExistingByCode_ShouldUpdate()
    {
        RunAsDefaultUser();
        await TestDataFactory.CreateTestCareproviderAsync();

        var careproviders = await QueryAsync<CareProvider>(c => c.IsActive);
        var existing = careproviders.First();

        var command = new UpsertLatestUpdateProviderForWorkerCommand
        {
            UpsertProviders = new List<UpsertProviderCommand>
            {
                new()
                {
                    Code = existing.Code,
                    FullNameThai = "ชื่อใหม่จาก Worker",
                    CareProviderTypeId = 1
                }
            }
        };

        await SendAsync(command);

        var updated = await QueryAsync<CareProvider>(c => c.Code == existing.Code);
        updated.Should().ContainSingle();
        updated.First().FullNameThai.Should().Be("ชื่อใหม่จาก Worker");
    }

    /// ทดสอบ: เพิ่มผู้ให้บริการใหม่ผ่าน Upsert เมื่อยังไม่มีรหัสนี้ในระบบ
    [Test]
    public async Task Upsert_NewCode_ShouldInsert()
    {
        RunAsDefaultUser();

        var command = new UpsertLatestUpdateProviderForWorkerCommand
        {
            UpsertProviders = new List<UpsertProviderCommand>
            {
                new()
                {
                    Code = "NEW001",
                    FullNameThai = "แพทย์ใหม่",
                    CareProviderTypeId = 1
                }
            }
        };

        await SendAsync(command);

        var inserted = await QueryAsync<CareProvider>(c => c.Code == "NEW001");
        inserted.Should().ContainSingle();
    }
}
