using FluentAssertions;
using NUnit.Framework;
using BigLion.Domain.Entities;
using BigLion.Domain.ValueObjects;

namespace BigLion.Domain.UnitTests.Entity;
public class LungTests
{
    [Test]
    public void CreateLungObjectShouldBeOK()
    {
        var lung = new Lung(1, "77777777", 1, StatusResult.Normal)
        {
            Fvc = 100,
            Fvc_Rate = 80,
            Fev1 = 50,
            Fev1_Rate = 50,
            ResultAbnormal = StatusResult.IsAbnormal,
            RestrictionAbnormal = StatusResult.IsAbnormal,
            RestrictionLevel = LungLevel.Mild,
            ObstructionAbnormal = StatusResult.IsAbnormal,
            ObstructionLevel = LungLevel.Mild,
            CombineAbnormal = StatusResult.IsAbnormal,
        };

        lung.Should().NotBeNull();
        lung.CheckupId.Should().Be(1);
        lung.VisitNumber.Should().Be("77777777");
        lung.CheckupItemId.Should().Be(1);
        lung.Fvc.Should().Be(100);
        lung.Fvc_Rate.Should().Be(80);
        lung.Fev1.Should().Be(50);
        lung.Fev1_Rate.Should().Be(50);
        lung.ResultAbnormal.Should().Be("Y");
        lung.RestrictionAbnormal.Should().Be("Y");
        lung.RestrictionLevel.Should().Be(LungLevel.Mild);
        lung.ObstructionAbnormal.Should().Be("Y");
        lung.ObstructionLevel.Should().Be(LungLevel.Mild);
        lung.CombineAbnormal.Should().Be("Y");
    }
}
