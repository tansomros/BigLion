namespace BigLion.Domain.Entities;
public class RecommendationTemplate : BaseEntity
{
    public string Text { get; set; }

    public RecommendationTemplate(string text)
    {
        Text = text;
    }
}
