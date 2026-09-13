using FluentAssertions;
using NUnit.Framework;
using BigLion.Domain.Entities;
namespace BigLion.Domain.UnitTests.Entity;
public class CheckupTypeTests
{
    [Test]
    public void CreateCheckupTypeObjectShouldBeOk()
    {
        var checkuptype = new CheckupType(1,"ตรวจสุขภาพประจำปี", "ตรวจสุขภาพประจำปี");
        checkuptype.Name.Should().Be("ตรวจสุขภาพประจำปี");
        checkuptype.Description.Should().Be("ตรวจสุขภาพประจำปี"); 
    }
}
