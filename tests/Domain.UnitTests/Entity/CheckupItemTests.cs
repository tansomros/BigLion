using FluentAssertions;
using NUnit.Framework;
using BigLion.Domain.Entities;
using BigLion.Domain.ValueObjects;
namespace BigLion.Domain.UnitTests.Entity;
public class CheckupItemTests
{
    [Test]
    public void CreateCheckupItemObjectShouldBeOk()
    {
        var item = new CheckupItem(11, "GA01", "", "สติสัมปชัญญะ/Level Of Consciousne", "สติสัมปชัญญะ/Level Of Consciousne", 2, 1, "", "", 0, true)
        {
            LabItemCode = null,
            Description = "สติสัมปชัญญะ/Level Of Consciousne",
            CumulativeName = null,
            CumulativeGroup = null,
            CheckupGroupId = 2,
            Sort = 1,
            IsActive = StatusFlag.Active,
        };

        item.Code.Should().Be("GA01");
        item.DisplayName.Should().Be("สติสัมปชัญญะ/Level Of Consciousne");
        item.IsActive.Should().Be(true);
        item.IsDisplayPrint.Should().Be(true);
    }
}
