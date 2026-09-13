using BigLion.Application.Common.Interfaces;
using BigLion.Domain.Entities;

namespace BigLion.Application.Features.Systems.Commands;
public class CheckupGroupDataInitializerCommand : IRequest<Unit> { }
public class CheckupGroupDataInitializerCommandHandler : IRequestHandler<CheckupGroupDataInitializerCommand, Unit>
{
    private readonly ICheckupDatabaseContext _context;

    public CheckupGroupDataInitializerCommandHandler(ICheckupDatabaseContext checkupDatabaseContext)
    {
        _context = checkupDatabaseContext;
    }

    public async Task<Unit> Handle(CheckupGroupDataInitializerCommand request, CancellationToken cancellationToken)
    {
        await SeedCheckupGroups(cancellationToken); 
        return Unit.Value;
    }

    private async Task SeedCheckupGroups(CancellationToken cancellationToken)
    {
        if (await _context.CheckupGroups.AnyAsync(cancellationToken))
        {
            return;
        }

        var checkupGroup = new[]
        {
             new CheckupGroup(1,"VS","Vital signs",1,1),
             new CheckupGroup(2,"GA","General Apprearance",2,2),
             new CheckupGroup(3,"VA","Vision Screening",3,3),
             new CheckupGroup(4,"AU","Audiogram",4,4),
             new CheckupGroup(5,"Lung","ความจุปอด",5,5),
             new CheckupGroup(6,"HCT","ความเข้มข้นของเลือด",6,6),
             new CheckupGroup(7,"WBC","จำนวนเม็ดเลือดขาวและแยกชนิด",6,7),
             new CheckupGroup(8,"CBC","Complete Blood Count",6,8),
             new CheckupGroup(9,"PLC","เกล็ดเลือด (Platelet Count)",6,9),
             new CheckupGroup(10,"FBS","ระดับน้ำตาลในเลือด",7,10),
             new CheckupGroup(11,"LP","ระดับไขมันในเลือด (Lipid Profile)",7,11),
             new CheckupGroup(12,"UR","ระดับกรดยูริค (Uric Acid)",7,12),
             new CheckupGroup(13,"RFT","การทำงานของไต (Renal Function)",7,13),
             new CheckupGroup(14,"LFT","การทำงานของตับ (Liver Function)",7,14),
             new CheckupGroup(15,"BC","Blood Chemistry",7,15),
             new CheckupGroup(16,"UA","การตรวจปัสสาวะ (Urine Analysis)",8,16),
             new CheckupGroup(17,"ST","Stool Examination",9,17),
             new CheckupGroup(18,"LM","Stool Culture and Sensitivity",10,18),
             new CheckupGroup(19,"SP","Special Test and Other Lab",11,19),
             new CheckupGroup(20,"TX","การตรวจสารพิษในเลือด",11,20),
             new CheckupGroup(21,"HB","การตรวจหาเชื้อ-ภูมิคุ้มกันต่อไวรัสตับอักเสบ ชนิด บี",11,21),
             new CheckupGroup(22,"TSH","การตรวจหาระดับไทรอยด์ในเลือด",11,22),
             new CheckupGroup(23,"CA","การตรวจหามะเร็งและสารบ่งชี้มะเร็ง  (Cancer Marker)",11,23),
             new CheckupGroup(24,"X","X-ray",12,24),
             new CheckupGroup(25,"O","การตรวจเฉพาะด้านอื่นๆ",13,25),
             new CheckupGroup(26,"W","การตรวจภายใน/สูติ-นารีเวช",14,26),
             new CheckupGroup(27,"CD","Confidential",15,27),
             new CheckupGroup(28,"BCA","การตรวจวัดมวลร่างกาย (Body Composition)",16,2),
             new CheckupGroup(29,"DENT","การตรวจสุขภาพช่องปาก",17,1),

        };

        await _context.CheckupGroups.AddRangeAsync(checkupGroup, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);
    }
     
}
