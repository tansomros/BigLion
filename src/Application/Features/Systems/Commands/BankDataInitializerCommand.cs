using BigLion.Application.Common.Interfaces;
using BigLion.Domain.Entities;

namespace BigLion.Application.Features.Systems.Commands;
public class BankDataInitializerCommand : IRequest<Unit> { }
public class BankDataInitializerCommandHandler : IRequestHandler<BankDataInitializerCommand, Unit>
{
    private readonly IBigLionDatabaseContext _context;

    public BankDataInitializerCommandHandler(IBigLionDatabaseContext BigLionDatabaseContext)
    {
        _context = BigLionDatabaseContext;
    }

    public async Task<Unit> Handle(BankDataInitializerCommand request, CancellationToken cancellationToken)
    {
        await SeedBanks(cancellationToken); 
        return Unit.Value;
    }

    private async Task SeedBanks(CancellationToken cancellationToken)
    {
        if (await _context.Banks.AnyAsync(cancellationToken))
        {
            return;
        }

        var Bank = new[]
        {           
            new Bank(1,"BBL","ธนาคารกรุงเทพ"),
            new Bank(2,"KTB","ธนาคารกรุงไทย"),
            new Bank(3,"BAY","ธนาคารกรุงศรีอยุธยา"),
            new Bank(4,"KBANK","ธนาคารกสิกรไทย"),
            new Bank(5,"TTB","ธนาคารทหารไทยธนชาต"),
            new Bank(6,"SCB","ธนาคารไทยพาณิชย์"),
            new Bank(7,"GSB","ธนาคารออมสิน"),
        };

        await _context.Banks.AddRangeAsync(Bank, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);
    }
     
}
