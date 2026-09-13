using FluentAssertions;
using NUnit.Framework;
using BigLion.Domain.Entities;
using BigLion.Domain.ValueObjects;

namespace BigLion.Domain.UnitTests.Entity;
public class CareProviderTests
{
    [Test]
    public void CreateCareProviderInstanceDefaultContructorShouldBeOk()
    {
        var careprovider = new CareProvider("000", "ทดสอบ บุคลากรทางการแพทยN", CareProviderType.DOCTOR);
        careprovider.Should().NotBe(null);
        careprovider.IsActive.Should().Be(false);
        careprovider.FullNameEnglish.Should().Be(null);
    }

    [Test]
    public void CreateCareProviderNonEnglishNameShouldBeOk()
    {
        var careprovider = new CareProvider("000", "ทดสอบ บุคลากรทางการแพทยN", CareProviderType.STAFF);
        careprovider.Should().NotBe(null);
        careprovider.IsActive.Should().Be(false);
        careprovider.FullNameEnglish.Should().BeNull();
        careprovider.LicenseNo.Should().BeNull();
        careprovider.PositionName.Should().BeNull();
    }
}
