using FluentAssertions;
using NUnit.Framework;
using BigLion.Domain.Entities;

namespace BigLion.Domain.UnitTests.Entity;
public class AudiogramTests
{
    [Test]
    public void CreateAudiogramObjectShouldBeOk()
    {
        var ear = new Audiogram(1, "77777777", 1, "ปกติ", "ปกติ", "ปกติ", "หูซ้ายปกติ", "หูขวาปกติ");

        ear.Should().NotBeNull();
        ear.CheckupId.Should().Be(1);
        ear.VisitNumber.Should().Be("77777777");
        ear.CheckupItemId.Should().Be(1);
        ear.LeftResult.Should().Be("ปกติ");
        ear.RightResult.Should().Be("ปกติ");
        ear.ResultNote.Should().Be("ปกติ");
        ear.LeftNote.Should().Be("หูซ้ายปกติ");
        ear.RightNote.Should().Be("หูขวาปกติ");
        ear.Hearings.Should().NotBeNull();
        ear.Hearings.Should().BeEmpty();
    }

    [Test]
    public void CreateHearingObjectShouldBeOk()
    {
        var ear = new Hearing(1, 500, 10, 15);

        ear.Should().NotBeNull();
        ear.AudiogramId.Should().Be(1);
        ear.Hertz.Should().Be(500);
        ear.LeftHz.Should().Be(10);
        ear.RightHz.Should().Be(15);
    }
}
