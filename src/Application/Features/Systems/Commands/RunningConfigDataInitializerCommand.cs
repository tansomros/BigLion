using BigLion.Application.Common.Interfaces;
using BigLion.Application.Common.Security;
using BigLion.Domain.Entities;

namespace BigLion.Application.Features.Systems.Commands;
[Authorize(Policy = BigLionPolicies.AllowAnonymous)]
public class RunningConfigDataInitializerCommand : IRequest<Unit> { }
public class RunningConfigDataInitializerCommandHandler : IRequestHandler<RunningConfigDataInitializerCommand, Unit>
{
    private readonly IBigLionDatabaseContext _context;

    public RunningConfigDataInitializerCommandHandler(IBigLionDatabaseContext BigLionDatabaseContext)
    {
        _context = BigLionDatabaseContext;
    }

    public async Task<Unit> Handle(RunningConfigDataInitializerCommand request, CancellationToken cancellationToken)
    {
        await SeedRunningConfigs(cancellationToken); 
        return Unit.Value;
    }

    private async Task SeedRunningConfigs(CancellationToken cancellationToken)
    {
        if (await _context.RunningConfigs.AnyAsync(cancellationToken))
        {
            return;
        }

        var RunningConfig = new[]
        {
            new RunningConfig("C","รหัสลูกค้า",true,false,4),
            new RunningConfig("F","โรงงาน",true,false,2),
            new RunningConfig("K","เลขที่ใบเสร็จรับเงิน",true,true,5),
        };

        await _context.RunningConfigs.AddRangeAsync(RunningConfig, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);
    }     
} 
