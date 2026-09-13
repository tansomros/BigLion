using System.Runtime.Intrinsics.Arm;
using BigLion.Application.Common.Interfaces;
using BigLion.Domain.Entities;

namespace BigLion.Application.Features.Systems.Commands;
public class OrganizationDataInitializerCommand : IRequest<Unit> { }
public class OrganizationDataInitializerCommandHandler : IRequestHandler<OrganizationDataInitializerCommand, Unit>
{
    private readonly IBigLionDatabaseContext _context;

    public OrganizationDataInitializerCommandHandler(IBigLionDatabaseContext BigLionDatabaseContext)
    {
        _context = BigLionDatabaseContext;
    }

    public async Task<Unit> Handle(OrganizationDataInitializerCommand request, CancellationToken cancellationToken)
    {
        await SeedOrganizations(cancellationToken); 
        return Unit.Value;
    }

    private async Task SeedOrganizations(CancellationToken cancellationToken)
    {
        if (await _context.Organizations.AnyAsync(cancellationToken))
        {
            return;
        }

        var Organization = new[]
        {
             new Organization(1,"KDP","TH","ฅนดงพุ","1234567890","37/4","14","","ด่านขุนทด","ด่านขุนทด","นครราชสีมา","30210","088-5826767","086-2653911","","","BigLionlogo.jpg","NHFNseFKYJY="),
        };

        await _context.Organizations.AddRangeAsync(Organization, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);
    }
     
}
