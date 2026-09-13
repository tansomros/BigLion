using BigLion.Application.Common.Interfaces;
using BigLion.Application.Common.Security;
using BigLion.Domain.Entities;

namespace BigLion.Application.Features.Systems.Commands;
[Authorize(Policy = BigLionPolicies.AllowAnonymous)]
public class CaneTypeDataInitializerCommand : IRequest<Unit> { }
public class CaneTypeDataInitializerCommandHandler : IRequestHandler<CaneTypeDataInitializerCommand, Unit>
{
    private readonly IBigLionDatabaseContext _context;

    public CaneTypeDataInitializerCommandHandler(IBigLionDatabaseContext BigLionDatabaseContext)
    {
        _context = BigLionDatabaseContext;
    }

    public async Task<Unit> Handle(CaneTypeDataInitializerCommand request, CancellationToken cancellationToken)
    {
        await SeedCaneTypes(cancellationToken); 
        return Unit.Value;
    }

    private async Task SeedCaneTypes(CancellationToken cancellationToken)
    {
        if (await _context.CaneTypes.AnyAsync(cancellationToken))
        {
            return;
        }

        var CaneType = new[]
        {
            new CaneType("อ้อยสด"),
            new CaneType("อ้อยไฟไหม้"),
        };

        await _context.CaneTypes.AddRangeAsync(CaneType, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);
    }     
} 
