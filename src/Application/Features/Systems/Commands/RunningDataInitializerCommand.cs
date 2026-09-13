using BigLion.Application.Common.Interfaces;
using BigLion.Application.Common.Security;
using BigLion.Domain.Entities;

namespace BigLion.Application.Features.Systems.Commands;
[Authorize(Policy = BigLionPolicies.AllowAnonymous)]
public class RunningDataInitializerCommand : IRequest<Unit> { }
public class RunningDataInitializerCommandHandler : IRequestHandler<RunningDataInitializerCommand, Unit>
{
    private readonly IBigLionDatabaseContext _context;

    public RunningDataInitializerCommandHandler(IBigLionDatabaseContext BigLionDatabaseContext)
    {
        _context = BigLionDatabaseContext;
    }

    public async Task<Unit> Handle(RunningDataInitializerCommand request, CancellationToken cancellationToken)
    {
        await SeedRunnings(cancellationToken); 
        return Unit.Value;
    }

    private async Task SeedRunnings(CancellationToken cancellationToken)
    {
        if (await _context.Runnings.AnyAsync(cancellationToken))
        {
            return;
        }

        var Running = new[]
        {
            new Running("C",0,0),
            new Running("F",0,0),
            new Running("K",69,0),
        };

        await _context.Runnings.AddRangeAsync(Running, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);
    }     
} 
