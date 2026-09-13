using BigLion.Application.Features.CareProviders.Queries.Get;
using BigLion.Application.FunctionalTests.Features._Shared;
using static BigLion.Application.FunctionalTests.Testing;

namespace BigLion.Application.FunctionalTests.Features.Careproviders.Queries;

public class GetCareProviderByTypeTests : BaseTestFixture
{
    /// ทดสอบ: ค้นหาผู้ให้บริการตามประเภท ควรคืนเฉพาะผู้ให้บริการประเภทนั้น
    [Test]
    public async Task GetByType_WithMatchingType_ShouldReturnFilteredList()
    {
        RunAsDefaultUser();
        await TestDataFactory.CreateTestCareproviderAsync(typeId: 1);
        await TestDataFactory.CreateTestCareproviderAsync(typeId: 2);

        var result = await SendAsync(new GetCareProviderByTypeQuery { CareProviderTypeId = 1 });

        result.Should().NotBeNull();
        result.CareProviders.Should().NotBeEmpty();
        result.CareProviders.Should().OnlyContain(c => c.CareproviderTypeId == 1);
    }

    /// ทดสอบ: ค้นหาผู้ให้บริการตามประเภทที่ไม่มี ควรคืนรายการว่างเปล่า
    [Test]
    public async Task GetByType_WithNoMatch_ShouldReturnEmptyList()
    {
        RunAsDefaultUser();

        var result = await SendAsync(new GetCareProviderByTypeQuery { CareProviderTypeId = 999 });

        result.Should().NotBeNull();
        result.CareProviders.Should().BeEmpty();
    }
}
