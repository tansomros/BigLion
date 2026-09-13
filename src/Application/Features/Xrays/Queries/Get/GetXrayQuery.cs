using BigLion.Application.Common.Interfaces;
using BigLion.Application.Exceptions;
using BigLion.Application.Features.Xrays.ViewModel;
using BigLion.Domain.Entities;

namespace BigLion.Application.Features.Xrays.Queries.Get;

public record GetXrayQuery : IRequest<XrayViewModel>
{
    public required string VisitNumber { get; set; }
}

public class GetXrayQueryHandler : IRequestHandler<GetXrayQuery, XrayViewModel>
{
    private readonly ICheckupDatabaseContext _context;
    private readonly IMapper _mapper;

    public GetXrayQueryHandler(ICheckupDatabaseContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<XrayViewModel> Handle(GetXrayQuery request, CancellationToken cancellationToken)
    {

        var specialTest = await _context.Xrays
            .AsNoTracking()
            .Include(c => c.CheckupItem)
            .ThenInclude(item => item.CheckupGroup)
            .ThenInclude(group => group.CheckupClass)
            .AsNoTracking()
            .FirstOrDefaultAsync(s => s.VisitNumber == request.VisitNumber, cancellationToken)
            ?? throw new NotFoundException(nameof(Xray), request.VisitNumber);


        var model = _mapper.Map<XrayViewModel>(specialTest);
        return model;
    }
}
