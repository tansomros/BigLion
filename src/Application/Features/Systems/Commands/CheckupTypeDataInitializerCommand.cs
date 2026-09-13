using BigLion.Application.Common.Interfaces;
using BigLion.Application.Common.Security;
using BigLion.Domain.Entities;

namespace BigLion.Application.Features.Systems.Commands;
[Authorize(Policy = HealthCheckupPolicies.AllowAnonymous)]
public class CheckupTypeDataInitializerCommand : IRequest<Unit> { }
public class CheckupTypeDataInitializerCommandHandler : IRequestHandler<CheckupTypeDataInitializerCommand, Unit>
{
    private readonly ICheckupDatabaseContext _context;

    public CheckupTypeDataInitializerCommandHandler(ICheckupDatabaseContext checkupDatabaseContext)
    {
        _context = checkupDatabaseContext;
    }

    public async Task<Unit> Handle(CheckupTypeDataInitializerCommand request, CancellationToken cancellationToken)
    {
        await SeedCheckupTypes(cancellationToken); 
        return Unit.Value;
    }

    private async Task SeedCheckupTypes(CancellationToken cancellationToken)
    {
        if (await _context.CheckupTypes.AnyAsync(cancellationToken))
        {
            return;
        }

        var checkupType = new[]
        {
            new CheckupType(1,"ตรวจสุขภาพก่อนเข้างาน","ตรวจสุขภาพก่อนเข้างาน"),
            new CheckupType(2,"ตรวจสุขภาพประจำปี","ตรวจสุขภาพประจำปี"),          
            new CheckupType(3,"ตรวจสุขภาพทั่วไป","ตรวจสุขภาพทั่วไป"),
            new CheckupType(4,"ตรวจก่อนเข้าเรียน","ตรวจก่อนเข้าเรียน")
        };

        await _context.CheckupTypes.AddRangeAsync(checkupType, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);
    }     
} 
