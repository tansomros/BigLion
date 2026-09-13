using BigLion.Application.Features.Companies.Commands.Create;
using BigLion.Application.Features.Companies.Queries.Get;
using static BigLion.Application.FunctionalTests.Testing;

namespace BigLion.Application.FunctionalTests.Features.Companies.Queries;

public class GetCompanyByIdTests : BaseTestFixture
{
    /// ทดสอบ: ค้นหาบริษัทด้วย Id ที่มีอยู่ ควรคืนข้อมูล ViewModel ที่ถูกต้อง
    [Test]
    public async Task Get_ExistingCompany_ShouldReturnViewModel()
    {
        RunAsDefaultUser();

        var id = await SendAsync(new CreateCompanyCommand
        {
            Name = "บริษัท ค้นหา จำกัด",
            AddressNo = "123",
            IsActive = true
        });

        var result = await SendAsync(new GetCompanyByIdQuery { Id = id });

        result.Should().NotBeNull();
        result.Name.Should().Be("บริษัท ค้นหา จำกัด");
        result.AddressNo.Should().Be("123");
        result.IsActive.Should().BeTrue();
    }

    /// ทดสอบ: ค้นหาบริษัทด้วย Id ที่ไม่มีในระบบ ควร throw NotFoundException
    [Test]
    public async Task Get_NonExistingCompany_ShouldThrowNotFoundException()
    {
        RunAsDefaultUser();

        await FluentActions.Invoking(() => SendAsync(new GetCompanyByIdQuery { Id = 99999 }))
            .Should().ThrowAsync<BigLion.Application.Exceptions.NotFoundException>();
    }
}
