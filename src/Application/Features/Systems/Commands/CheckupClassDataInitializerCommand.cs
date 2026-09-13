using BigLion.Application.Common.Interfaces;
using BigLion.Domain.Entities;

namespace BigLion.Application.Features.Systems.Commands;
public class CheckupClassDataInitializerCommand : IRequest<Unit> { }
public class CheckupClassDataInitializerCommandHandler : IRequestHandler<CheckupClassDataInitializerCommand, Unit>
{
    private readonly ICheckupDatabaseContext _context;

    public CheckupClassDataInitializerCommandHandler(ICheckupDatabaseContext checkupDatabaseContext)
    {
        _context = checkupDatabaseContext;
    }

    public async Task<Unit> Handle(CheckupClassDataInitializerCommand request, CancellationToken cancellationToken)
    {
        await SeedCheckupClasses(cancellationToken); 
        return Unit.Value;
    }

    private async Task SeedCheckupClasses(CancellationToken cancellationToken)
    {
        if (await _context.CheckupClasses.AnyAsync(cancellationToken))
        {
            return;
        }

        var CheckupClass = new[]
        {
            new CheckupClass(1,"VS","Vital signs",1),
            new CheckupClass(2,"GA","General Apprearance",2),
            new CheckupClass(3,"VA","Vision Screening",3),
            new CheckupClass(4,"AU","Audiogram",4),
            new CheckupClass(5,"Lung","ความจุดปอด",5),
            new CheckupClass(6,"CBC","CBC",6),
            new CheckupClass(7,"BC","Blood Chemistry",7),
            new CheckupClass(8,"UA","การตรวจปัสสาวะ (Urine Analysis)",8),
            new CheckupClass(9,"ST","Stool Examination",9),
            new CheckupClass(10,"LM","Stool Culture and Sensitivity",10),
            new CheckupClass(11,"SP","Special Test and Other Lab",11),
            new CheckupClass(12,"X","X-ray",12),
            new CheckupClass(13,"O","การตรวจเฉพาะทางด้านอื่นๆ",13),
            new CheckupClass(14,"W","การตรวจภายใน/สูติ-นารีเวช",14),
            new CheckupClass(15,"CD","Confidential",15),
            new CheckupClass(16,"BCA","การตรวจวัดมวลร่างกาย (Body Composition)",16),
            new CheckupClass(17,"DENT","การตรวจสุขภาพช่องปาก",17),
        };

        await _context.CheckupClasses.AddRangeAsync(CheckupClass, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);
    }
     
}
