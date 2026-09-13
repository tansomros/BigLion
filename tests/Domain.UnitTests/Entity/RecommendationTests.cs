using FluentAssertions;
using NUnit.Framework;
using BigLion.Domain.Entities;
using BigLion.Domain.ValueObjects;

namespace BigLion.Domain.UnitTests.Entity;
public class RecommendationTests
{
    [Test]
    public void CreateRecommendationObjectShouldBeOk()
    {
        var rcm = new Recommendation(
            "I09002",
            "Hepatitis B surface Antigen (Quantitative)",
            CompareRule.Equal,
            "",
            "Positive",
            0,
            0,
            "พบเชื้อไวรัสตับอักเสบบี",
            "HBsAg Found",
            "แนะนำปรึกษาแพทย์",
            "Consult a doctor.",
            null,
            null);

        rcm.Should().NotBeNull();
        rcm.Code.Should().Be("I09002");
        rcm.Name.Should().Be("Hepatitis B surface Antigen (Quantitative)");
        rcm.CheckType.Should().Be("E");
        rcm.SexCode.Should().Be("");
        rcm.CompareValue.Should().Be("Positive");
        rcm.LowValue.Should().Be(0);
        rcm.HighValue.Should().Be(0);
        rcm.ConclusionTh.Should().Be("พบเชื้อไวรัสตับอักเสบบี");
        rcm.ConclusionEn.Should().Be("HBsAg Found");
        rcm.RecommendTh.Should().Be("แนะนำปรึกษาแพทย์");
        rcm.RecommendEn.Should().Be("Consult a doctor.");
        rcm.ActiveFrom.Should().BeNull();
        rcm.ActiveTo.Should().BeNull();


    }
}
