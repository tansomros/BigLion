using BigLion.Application.Common.Interfaces;
using BigLion.Application.Common.Security;
using BigLion.Domain.Entities;

namespace BigLion.Application.Features.Systems.Commands;
[Authorize(Policy = BigLionPolicies.AllowAnonymous)]
public class PrefixDataInitializerCommand : IRequest<Unit> { }
public class PrefixDataInitializerCommandHandler : IRequestHandler<PrefixDataInitializerCommand, Unit>
{
    private readonly IBigLionDatabaseContext _context;

    public PrefixDataInitializerCommandHandler(IBigLionDatabaseContext BigLionDatabaseContext)
    {
        _context = BigLionDatabaseContext;
    }

    public async Task<Unit> Handle(PrefixDataInitializerCommand request, CancellationToken cancellationToken)
    {
        await SeedPrefixs(cancellationToken); 
        return Unit.Value;
    }

    private async Task SeedPrefixs(CancellationToken cancellationToken)
    {
        if (await _context.Prefixs.AnyAsync(cancellationToken))
        {
            return;
        }

        var Prefix = new[]
        {
            new Prefix(1,"นาย"),
            new Prefix(2,"นาง"),          
            new Prefix(3,"นางสาว"), 
        };

        await _context.Prefixs.AddRangeAsync(Prefix, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);
    }     
} 
