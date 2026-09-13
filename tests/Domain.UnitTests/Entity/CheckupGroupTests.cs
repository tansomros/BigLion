using FluentAssertions;
using NUnit.Framework;
using BigLion.Domain.Entities;
namespace BigLion.Domain.UnitTests.Entity;
public class CheckupGroupTests
{
    [Test]
    public void CreateCheckupGroupObjectShouldBeOk()
    {
        var checkupgroup = new CheckupGroup(1, "GA", "General Apprearance",2,1)
        {
            Sort = 1
        };

        checkupgroup.Code.Should().Be("GA");
        checkupgroup.Name.Should().Be("General Apprearance");
        checkupgroup.Sort.Should().Be(1);
    }
}
