using BigLion.Application.Common.Interfaces;
using BigLion.Domain.Entities;

namespace BigLion.Application.Features.Systems.Commands;
public class HearingHertzDataInitializerCommand : IRequest<Unit> { }
public class HearingHertzDataInitializerCommandHandler : IRequestHandler<HearingHertzDataInitializerCommand, Unit>
{
    private readonly ICheckupDatabaseContext _context;

    public HearingHertzDataInitializerCommandHandler(ICheckupDatabaseContext checkupDatabaseContext)
    {
        _context = checkupDatabaseContext;
    }

    public async Task<Unit> Handle(HearingHertzDataInitializerCommand request, CancellationToken cancellationToken)
    {
        await SeedHearingHertzs(cancellationToken);
        return Unit.Value;
    }

    private async Task SeedHearingHertzs(CancellationToken cancellationToken)
    {
        if (await _context.HearingHertzs.AnyAsync(cancellationToken))
        {
            return;
        }

        var hearingHertz = new[]
        {
            new HearingHertz(250),
            new HearingHertz(500),
            new HearingHertz(1000),
            new HearingHertz(2000),
            new HearingHertz(3000),
            new HearingHertz(4000),
            new HearingHertz(6000),
            new HearingHertz(8000)
        };

        await _context.HearingHertzs.AddRangeAsync(hearingHertz, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);
    }

}
