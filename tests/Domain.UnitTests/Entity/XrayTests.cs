using FluentAssertions;
using NUnit.Framework;
using BigLion.Domain.Entities;

namespace BigLion.Domain.UnitTests.Entity;
public class XrayTests
{
    [Test]
    public void CreateXrayObjectShouldBeOK()
    {
        var xray = new Xray(1, "77777777", 1, "ปกติ", "test", "XN001");

        xray.Should().NotBeNull();
        xray.CheckupId.Should().Be(1);
        xray.VisitNumber.Should().Be("77777777");
        xray.CheckupItemId.Should().Be(1);
        xray.ResultValue.Should().Be("ปกติ");
        xray.ReportText.Should().Be("test");
        xray.AccessionNumber.Should().Be("XN001");
    }
}
