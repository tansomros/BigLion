using FluentAssertions;
using NUnit.Framework;
using BigLion.Domain.Entities;
using BigLion.Domain.ValueObjects;
namespace BigLion.Domain.UnitTests.Entity;
public class CompanyTests
{
    [Test]
    public void CreateCompanyObjectShouldBeOk()
    {
        var company = new Company("โรงพยาบาลมหาวิทยาลัยเทคโนโลยีสุรนารี", StatusFlag.Active)
        {
            AddressNo = "111 ถนนมหาวิทยาลัย",
            SubDistrictId = "300101",
            DistrictId = "3001",
            ProvinceId = "30",
            ZipCode = "30000"
        };

        company.Should().NotBeNull();
        company.AddressNo.Should().Be("111 ถนนมหาวิทยาลัย");
        company.SubDistrictId.Should().Be("300101");
        company.DistrictId.Should().Be("3001");
        company.ProvinceId.Should().Be("30");
        company.ZipCode.Should().Be("30000");
        company.IsActive.Should().Be(true);
    }
}
