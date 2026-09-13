using BigLion.Domain.ValueObjects;

namespace BigLion.Domain.Entities;

public class Report : BaseEntity
{
    public int CheckupId { get; set; }
    public virtual Checkup? Checkup { get; set; }
    public string VisitNumber { get; set; }
    public string HospitalNumber { get; set; }
    /// <summary>
    /// อายุ เป็น ปี จนถึงวันเข้ารับบริการ
    /// </summary>
    public int? AgeCheckup { get; set; }
    /// <summary>
    /// อายุ เป็น ปี เดือน วัน จนถึงวันเข้ารับบริการ
    /// </summary>
    public string? AgeTextCheckup { get; set; }

    public int PatientId { get; set; }
    public virtual Patient? Patient { get; set; }

    /// <summary>
    /// วันที่รับบริการ นำข้อมูลมาจากตาราง ovst คอลัม vstdate ซึ่งเป็น DateOnly
    /// </summary>
    public DateOnly VisitDate { get; set; }

    /// <summary>
    /// เวลาที่มารับบริการ นำข้อมูลมาจากตาราง ovst คอลัม vsttime ซึ่งเป็น TimeOnly
    /// </summary>
    public string VisitTime { get; set; }

    /// <summary>
    /// ประเภทการตรวจสุขภาพ
    /// </summary>
    public int CheckupTypeId { get; set; }
    public virtual CheckupType? CheckupType { get; set; }

    /// <summary>
    /// แพทย์ผู้ตรวจร่างกาย
    /// </summary>
    public string?  PhysicalExaminationBy { get; set; }

   /// <summary>
    /// แพทย์ผู้สรุปผล
    /// </summary> 
    public string? ConclusionBy { get; set; }

    /// <summary>
    /// สรุปผลการตรวจจากแพทย์
    /// </summary>
    public string? Conclusion { get; set; } 

    /// <summary>
    /// ชื่อสิทธิ์การรักษา ใช้ชื่อสิทธิ์ของผู้รับบริการจาก HOSxP เลย
    /// </summary>
    public string PayorName { get; set; }

    /// <summary>
    /// ไอดี โปรแกรมตรวจสุขภาพ จากตาราง ckup_prog คอลัม ckup_prog_id ใน HOSxP
    /// </summary>
    public int PackageId { get; set; }

    /// <summary>
    /// ชื่อโปรแกรมตรวจสุขภาพ จากตาราง ckup_prog คอลัม ckup_prog_name ใน HOSxP
    /// </summary>
    public string PackageName { get; set; }   

    /// <summary>
    /// น้ำหนัก (กิโลกรัม)
    /// </summary>
    public double Weight { get; set; }

    /// <summary>
    /// ส่วนสูง (เซ็นติเมตร)
    /// </summary>
    public double Height { get; set; }

    /// <summary>
    /// อุณหภูมิร่างกาย (องศาเซลเซียส)
    /// </summary>
    public double Temperature { get; set; }

    /// <summary>
    /// อัตราการเต้นของหัวใจ - ชีพจร (ครั้งต่อนาที)
    /// </summary>
    public int? PulseRate { get; set; }

    /// <summary>
    /// ความดันโลหิตตัวหน้า (mm/Hg)
    /// </summary>
    public int? SystolicBloodPresure { get; set; }

    /// <summary>
    /// ความดันโลหิตตัวหลัง (mm/Hg)
    /// </summary>
    public int? DiastolicBloodPresure { get; set; }

    /// <summary>
    /// อัตราการหายใจ (ต่อนาที)
    /// </summary>
    public int? RespiratoryRate { get; set; }

    /// <summary>
    /// สรุปผลการตรวจร่างกาย
    /// </summary>
    public string? PhysicalExaminationConclusion { get; set; }

    /// <summary>
    /// สรุปผล Lab
    /// </summary>
    public string? LabResultConclusion { get; set; }

    /// <summary>
    /// สรุปผล Xray
    /// </summary>
    public string? XrayResultConclusion { get; set; }

    /// <summary>
    /// สรุปผลแลบพิเศษอื่นๆ
    /// </summary>
    public string? SpecialConclusion { get; set; }

    public string? BmiReport { get; set; }
    public string? BpReport { get; set; } 
    public string? HbReport { get; set; }
    public string? WbcReport { get; set; }
    public string? PlateletReport { get; set; }
    public string? CbcReport { get; set; }
    public string? FbsReport { get; set; }
    public string? LipidReport { get; set; }
    public string? UricReport { get; set; }
    public string? RenalReport { get; set; }
    public string? LiverReport { get; set; }
    public string? HepatitisReport { get; set; }
    public string? ThyroidReport { get; set; }
    public string? ImmunologyReport { get; set; }
    public string? VisionReport { get; set; }
    public string? AudiogramReport { get; set; }
    public string? DentalReport { get; set; }
    public string? LungReport { get; set; }   
    public string? UrineReport { get; set; }
    public string? StoolReport { get; set; }
   
    public LabReport? Wbc { get; set; }
    /// <summary>
    /// FBS Group
    /// </summary>
    public LabReport? Fbs { get; set; }
    /// <summary>
    /// ระดับไขมันในเลือด (Lipid Profile) LP Group
    /// </summary>
    public LabReport? Lipid { get; set; }
    /// <summary>
    /// RFT	การทำงานของไต (Renal Function)
    /// </summary>
    public LabReport? Renal { get; set; }
    /// <summary>
    /// LFT	การทำงานของตับ (Liver Function)
    /// </summary>
    public LabReport? Liver { get; set; }
    /// <summary>
    /// UA	การตรวจปัสสาวะ (Urine Analysis)
    /// </summary>
    public LabReport? Urine { get; set; }
    /// <summary>
    /// ST	Stool Examination
    /// </summary>
    public LabReport? Stool { get; set; }
    /// <summary>
    /// SP	Special Test and Other Lab
    /// </summary>
    public LabReport? OtherLab { get; set; }

    //public ICollection<Lab> Labs { get; set; }
    //public ICollection<Xray> Xrays { get; set; }
    //public ICollection<Vision> Visions { get; set; }
    //public ICollection<Audiogram> Audiograms { get; set; }
    //public ICollection<Lung> Lungs { get; set; }
    //public ICollection<PhysicalExamination> PhysicalExams { get; set; }
    //public ICollection<SpecialTest> SpecialTests { get; set; }

    public Report(int checkupId, string visitNumber, string hospitalNumber, int? ageCheckup, string? ageTextCheckup, int patientId, Patient? patient, DateOnly visitDate, string visitTime, int checkupTypeId, CheckupType checkupType, string? physicalExaminationBy, string? conclusionBy, string? conclusion, string payorName, int packageId, string packageName, double weight, double height, double temperature, int? pulseRate, int? systolicBloodPresure, int? diastolicBloodPresure, int? respiratoryRate, string? physicalExaminationConclusion, string? labResultConclusion, string? xrayResultConclusion, string? specialConclusion, string? bmiReport, string? bpReport,string? visionReport, string? audiogramReport,string? dentalReport, string? lungReport, string? hbReport, string? wbcReport, string? plateletReport, string? cbcReport, string? fbsReport, string? lipidReport, string? uricReport, string? renalReport, string? liverReport, string? hepatitisReport, string? thyroidReport, string? immunologyReport, string? urineReport, string? stoolReport, LabReport? wbc, LabReport? fbs, LabReport? lipid, LabReport? renal, LabReport? liver, LabReport? urine, LabReport? stool, LabReport? otherLab)
    {
        CheckupId = checkupId;
        VisitNumber = visitNumber;
        HospitalNumber = hospitalNumber;
        AgeCheckup = ageCheckup;
        AgeTextCheckup = ageTextCheckup;
        PatientId = patientId;
        Patient = patient;
        VisitDate = visitDate;
        VisitTime = visitTime;
        CheckupTypeId = checkupTypeId;
        CheckupType = checkupType;
        PhysicalExaminationBy = physicalExaminationBy;
        ConclusionBy = conclusionBy;
        Conclusion = conclusion;
        PayorName = payorName;
        PackageId = packageId;
        PackageName = packageName;
        Weight = weight;
        Height = height;
        Temperature = temperature;
        PulseRate = pulseRate;
        SystolicBloodPresure = systolicBloodPresure;
        DiastolicBloodPresure = diastolicBloodPresure;
        RespiratoryRate = respiratoryRate;
        PhysicalExaminationConclusion = physicalExaminationConclusion;
        LabResultConclusion = labResultConclusion;
        XrayResultConclusion = xrayResultConclusion;
        SpecialConclusion = specialConclusion;
        BmiReport = bmiReport;
        BpReport = bpReport;
        VisionReport = visionReport;
        AudiogramReport = audiogramReport;
        DentalReport = dentalReport;
        LungReport = lungReport;
        HbReport = hbReport;
        WbcReport = wbcReport;
        PlateletReport = plateletReport;
        CbcReport = cbcReport;
        FbsReport = fbsReport;
        LipidReport = lipidReport;
        UricReport = uricReport;
        RenalReport = renalReport;
        LiverReport = liverReport;
        HepatitisReport = hepatitisReport;
        ThyroidReport = thyroidReport;
        ImmunologyReport = immunologyReport;
        UrineReport = urineReport;
        StoolReport = stoolReport;
        Wbc = wbc;
        Fbs = fbs;
        Lipid = lipid;
        Renal = renal;
        Liver = liver;
        Urine = urine;
        Stool = stool;
        OtherLab = otherLab;
        //Labs = [];
        //Xrays = [];
        //Visions = [];
        //Audiograms = [];
        //Lungs = [];
        //PhysicalExams = [];
        //SpecialTests = [];
    }

    public Report(
        int checkupId,
        string visitNumber,
        string hospitalNumber,
        DateOnly visitDate,
        string visitTime,
        int checkupTypeId,
        string payorName,
        int packageId,
        string packageName)
    { 
        CheckupId = checkupId;
        HospitalNumber = hospitalNumber;
        VisitNumber = visitNumber;
        VisitDate = visitDate;
        VisitTime = visitTime;
        CheckupTypeId = checkupTypeId;
        PayorName = payorName;
        PackageId = packageId;
        PackageName = packageName;

        Wbc = null;
        Fbs = null;
        Lipid = null;
        Renal = null;
        Liver = null;
        Urine = null;
        Stool = null;
        OtherLab = null;

        //Labs = [];
        //Xrays = [];
        //Visions = [];
        //Audiograms = [];
        //Lungs = [];
        //PhysicalExams = [];
        //SpecialTests = [];
    }
}
