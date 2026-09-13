using FluentAssertions;
using NUnit.Framework;
using BigLion.Domain.Entities;
using BigLion.Domain.ValueObjects;

namespace BigLion.Domain.UnitTests.Entity;
public class VisionTest
{
    [Test]
    public void CreateVisionObjectShouldBeOK()
    {
        var eye = new Vision(1, "77777777", 1, Eye.Normal, Eye.Normal, "สายตาปกติ")
        {
            VA_Right_Value = "20/20",
            VA_Left_Value = "20/20",
            PH_Right_Value = null,
            PH_Left_Value = null,

            ColorBlind = null,
            PressureLeft = null,
            PressureRight = null,
            Vision3D = null,
            Squint = null,
            VisualField = null,
            RetinaLeft = null,
            RetinaRight = null,
            ResultNote = null,
        };

        eye.Should().NotBeNull();
        eye.CheckupId.Should().Be(1);
        eye.VisitNumber.Should().Be("77777777");
        eye.CheckupItemId.Should().Be(1);

        eye.VA_Right_Value.Should().Be("20/20");
        eye.VA_Left_Value.Should().Be("20/20");
        eye.PH_Right_Value.Should().BeNull();
        eye.PH_Left_Value.Should().BeNull();

        eye.VisionRightResult.Should().Be(Eye.Normal);
        eye.VisionLeftResult.Should().Be(Eye.Normal);
        eye.ColorBlind.Should().BeNull();
        eye.PressureLeft.Should().BeNull();
        eye.PressureRight.Should().BeNull();
        eye.Vision3D.Should().BeNull();
        eye.Squint.Should().BeNull();
        eye.VisualField.Should().BeNull();
        eye.RetinaLeft.Should().BeNull();
        eye.RetinaRight.Should().BeNull();
        eye.ResultNote.Should().BeNull();
    }
}
