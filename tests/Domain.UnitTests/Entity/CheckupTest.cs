using FluentAssertions;
using NUnit.Framework;
using BigLion.Domain.Entities;
using BigLion.Domain.ValueObjects;

namespace BigLion.Domain.UnitTests.Entity;
public class CheckupTest
{
    [Test]
    public void CreateVisitObjectShouldBeOK()
    {
        var checkup = new Checkup(1,"12154", "77777777",DateOnly.FromDateTime( Convert.ToDateTime(DateTime.Now.Date)), TimeOnly.FromDateTime(Convert.ToDateTime(DateTime.Now)), 1,"ปกส.รพ.มทส.", 1,"SUT 1 ชายอายุไม่เกิน 35 ปี")
        {
            SaveDate = null,
            Status = 1,
            PhysicalExaminationById = 1,
            ConclusionById = 1,
            IsLabResultReady = true,
            IsXrayResultReady = true,
            Weight = 65,
            Height = 170,
            Temperature = 34.5,
            PulseRate = 98,
            SystolicBloodPresure=80,
            DiastolicBloodPresure=120,
            RespiratoryRate=20,
            PhysicalExaminationConclusion  = "",
            XrayResultConclusion = "",
            SpecialConclusion = "",
            LabResultConclusion = "",
            Conclusion = "",            
            IsMain = true
        };

        checkup.Should().NotBeNull();
        checkup.CheckupVisitId.Should().Be(1);
        checkup.VisitNumber.Should().Be("12154");
        checkup.HospitalNumber.Should().Be("77777777");
        //visit.VisitDate.Should().Be(Convert.ToDateTime(DateTime.Now));
        //result.ResultTime.Should().Be(TimeOnly.FromDateTime(Convert.ToDateTime(DateTime.Now)));
        checkup.PayorName.Should().Be("ปกส.รพ.มทส.");
        checkup.PackageId.Should().Be(1);
        checkup.IsLabResultReady.Should().Be(true);
        checkup.SaveDate.Should().BeNull();
        checkup.Status.Should().Be(StatusFlag.Completed);
        checkup.ConclusionById.Should().Be(1);
        checkup.PhysicalExaminationById.Should().Be(1);
        checkup.IsXrayResultReady.Should().Be(true);
        checkup.Weight.Should().Be(65);
        checkup.Height.Should().Be(170);
        checkup.Temperature.Should().Be(34.5);
        checkup.PulseRate.Should().Be(98);
        checkup.SystolicBloodPresure.Should().Be(80);
        checkup.DiastolicBloodPresure.Should().Be(120);
        checkup.RespiratoryRate.Should().Be(20);
        checkup.PhysicalExaminationConclusion.Should().Be("");
        checkup.XrayResultConclusion.Should().Be("");
        checkup.SpecialConclusion.Should().Be("");
        checkup.Conclusion.Should().Be("");
        checkup.IsMain.Should().Be(true);
    }
}
