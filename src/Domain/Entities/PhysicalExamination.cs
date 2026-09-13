namespace BigLion.Domain.Entities
{
    /// <summary>
    /// ผลการตรวจร่างกาย
    /// </summary>
    public class PhysicalExamination : BaseEntity
    {     
        public int CheckupId { get; set; }
        public virtual Checkup? Checkup { get; set; }
        public string VisitNumber { get; set; }
        public int CheckupItemId { get; set; }
        public CheckupItem CheckupItem { get; set; } = null!;

        public string? Ga { get; set; }
        public string? Heent { get; set; }
        public string? Mouth { get; set; }
        public string? Lymph { get; set; }
        public string? Thyroid { get; set; }  
        public string? Chest { get; set; }
        public string? Heart { get; set; }      
        public string? Abdomen { get; set; }    
        public string? Ext { get; set; }
        public string? Skin { get; set; }
        public string? Other { get; set; }

        public string? GaText { get; set; }
        public string? HeentText { get; set; }
        public string? MouthText { get; set; }
        public string? LymphText { get; set; }
        public string? ThyroidText { get; set; }
        public string? ChestText { get; set; }
        public string? HeartText { get; set; }
        public string? AbdomenText { get; set; }
        public string? ExtText { get; set; }
        public string? SkinText { get; set; }
        public string? OtherText { get; set; }

        public PhysicalExamination(
            string visitNumber,int checkupId,int checkupItemId,
            string? ga = null,
            string? heent = null,
            string? mouth = null,
            string? lymph = null,
            string? thyroid = null,
            string? chest = null,
            string? heart = null,
            string? abdomen = null, 
            string? ext = null,
            string? skin = null,
            string? other = null,
            string? gaText = null,
            string? heentText = null,
            string? mouthText = null,
            string? lymphText = null,
            string? thyroidText = null,
            string? chestText = null,
            string? heartText = null,
            string? abdomenText = null,
            string? extText = null,
            string? skinText = null,
            string? otherText = null
        )
        {
            VisitNumber = visitNumber;
            CheckupId = checkupId;
            CheckupItemId = checkupItemId;
            Ga = ga;
            Heent = heent;
            Mouth = heart;
            Chest = chest;
            Lymph = lymph;
            Thyroid = thyroid;
            Chest = chest;
            Heart = heart;
            Abdomen = abdomen;
            Ext = ext;
            Skin = skin;
            Other = other;
            GaText = gaText;
            HeentText = heentText;
            HeartText = heartText;
            ChestText = chestText;
            HeartText = heartText;
            LymphText = lymphText;
            ThyroidText = thyroidText;
            AbdomenText = abdomenText;
            MouthText = mouthText;
            ExtText = extText;
            SkinText = skinText;
            OtherText = otherText; 
        }         
    }
}
