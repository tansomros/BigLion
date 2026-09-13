using BigLion.Domain.ValueObjects;

namespace BigLion.Domain.Entities;
/// <summary>
/// ข้อมูลตรวจสุขภาพ
/// </summary>
public class Checkup : BaseEntity
{
    /// <summary>
    /// id, ckup_ovst.ckup_ovst_id int4
    /// </summary>
    public int CheckupVisitId { get; set; }

    /// <summary>
    /// Visit Number From HosXP 8 digits
    /// </summary>
    public string VisitNumber { get; set; }

    public string HospitalNumber { get; set; }
    /// <summary>
    /// อายุ เป็น ปี จนถึงวันเข้ารับบริการ
    /// </summary>
    public int? AgeCheckup {  get; set; }
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
    public TimeOnly VisitTime { get; set; }  

    /// <summary>
    /// ประเภทการตรวจสุขภาพ
    /// </summary>
    public int CheckupTypeId { get; set; }
    public virtual CheckupType? CheckupType { get; set; }

    /// <summary>
    /// สถานะ Pending/InProgrdss/Complete
    /// </summary>
    public int Status { get; set; }

    /// <summary>
    /// วันที่บันทึกข้อมูล
    /// </summary>
    public DateTime? SaveDate { get; set; }

    /// <summary>
    /// สถานะยืนยันและปิดรายการแล้ว
    /// </summary>
    public bool IsFinalized { get; set; }
    /// <summary>
    /// วันที่ยืนยันและปิดรายการ
    /// </summary>
    public DateTime? FinalizedDate { get; set; }

    /// <summary>
    /// แพทย์ผู้ตรวจร่างกาย
    /// </summary>
    public int? PhysicalExaminationById { get; set; }
    public virtual CareProvider? PhysicalExaminationBy { get; set; }

    /// <summary>
    /// สรุปผลการตรวจจากแพทย์
    /// </summary>
    public string? Conclusion { get; set; }

    /// <summary>
    /// แพทย์ผู้สรุปผล
    /// </summary>
    public int? ConclusionById { get; set; }
    public virtual CareProvider? ConclusionBy { get; set; }

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
    /// สถานะการออกผล Lab
    /// </summary>
    public bool IsLabResultReady { get; set; }

    /// <summary>
    /// สถานะการออกผล Xray
    /// </summary>
    public bool IsXrayResultReady { get; set; }

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
  /// รอบเอว
  /// </summary>
  public double Waist { get; set; }
    /// <summary>
    /// รอบสะโพก
    /// </summary>
    public double Hips { get; set; }
  

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

    /// <summary>
    /// visit หลัก กรณีใน 1 วันทีการเปิดมากกว่า 1 visit
    /// </summary>
    public bool IsMain { get; set; } = true;  

    public bool? IsSmoking { get; set; }
    public string? SmokingRemark { get; set; }
    public bool? IsAlcohol { get; set; }
    public string? AlcoholRemark {get;set;}

    public int? CompanyId { get; set; }
    public virtual Company? Company { get; set; }

    public List<string> LabOrder { get; set; }
    public List<string> XrayOrder { get; set; }
    public List<string> ServiceOrder { get; set; }

    public FinalReport? FinalReport { get; set; }
    public ICollection<BodyComposition> BodyCompositions { get; set; }
    public ICollection<Lab> Labs { get; set; }
    public ICollection<Xray> Xrays { get; set; }
    public ICollection<Vision> Visions { get; set; }
    public ICollection<Audiogram> Audiograms { get; set; }
    public ICollection<Lung> Lungs { get; set; }
    public ICollection<Dental> Dentals { get; set; }
    public ICollection<PhysicalExamination> PhysicalExams { get; set; }
    public ICollection<SpecialTest> SpecialTests { get; set; }

    /// <summary>
    /// กำหนดค่าตั้งต้นที่จำเป็นของข้อมูล การตรวจสุขภาพ
    /// </summary>
    /// <param name="checkupVisitId">ไอดี เก็บ ไอดีของตาราง ckup_ovst.ckup_ovst_id</param>
    /// <param name="visitNumber">เลขที่การมารับบริการ เลข 12 หลัก</param>
    /// <param name="hospitalNumber">เลขที่ผู้รับบริการ HN 8 หลัก</param>
    /// <param name="visitDate">วันที่การมารับบริการ</param>
    /// <param name="visitTime">เวลาที่มารับบริการ</param>
    /// <param name="checkupTypeId">ประเภทการตรวจสุขภาพ</param>
    /// <param name="payorName">ชื่อสิทธิ์การรักษา</param>
    /// <param name="packageId">ไอดี โปรแกรมตรวจสุขภาพ</param>
    /// <param name="packageName">ชื่อโปรแกรมตรวจสุขภาพ</param>
    public Checkup(
        int checkupVisitId,
        string visitNumber,
        string hospitalNumber,
        DateOnly visitDate,
        TimeOnly visitTime,
        int checkupTypeId,
        string payorName,
        int packageId,
        string packageName)
    {
        IsMain = true;
        CheckupVisitId = checkupVisitId;
        HospitalNumber = hospitalNumber;
        VisitNumber = visitNumber;
        VisitDate = visitDate;
        VisitTime = visitTime;
        CheckupTypeId = checkupTypeId;
        PayorName = payorName;
        PackageId = packageId;
        PackageName = packageName;

        BodyCompositions = [];
        Labs = [];
        Xrays = [];
        Visions = [];
        Audiograms = [];
        Lungs = [];
        Dentals = [];
        PhysicalExams = [];
        SpecialTests = [];
        FinalReport = null;
        LabOrder = [];
        XrayOrder = [];
        ServiceOrder = [];
    }
}
