using BigLion.Application.Common.Interfaces;
using BigLion.Application.Common.Mappings;
using BigLion.Application.Common.Models;
using BigLion.Application.Features.Xrays.ViewModel;

namespace BigLion.Application.Features.Xrays.Queries.Get;

public record SearchXrayQuery : IRequest<PaginatedList<XrayViewModel>>
{
    /// <summary>
    /// คำค้น
    /// </summary>
    public required string KeyWord { get; set; }

    /// <summary>
    /// หน้าของข้อมูลเป็นเลขจำนวนเต็ม
    /// </summary>
    public required int Page { get; set; } = 1;

    /// <summary>
    /// จำนวนของข้อมูลที่ต้องการเป็นเลขจำนวนเต็ม
    /// </summary>
    public required int Length { get; set; } = 10;

}

public class SearchXrayQueryHandler : IRequestHandler<SearchXrayQuery, PaginatedList<XrayViewModel>>
{
    private readonly IMapper _mapper;
    private readonly ICheckupDatabaseContext _context;

    public SearchXrayQueryHandler(ICheckupDatabaseContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<PaginatedList<XrayViewModel>> Handle(SearchXrayQuery request, CancellationToken cancellationToken)
    {
        return await _context.Xrays
                .AsNoTracking()
                .Where(e => e.VisitNumber.Contains(request.KeyWord))
                .ProjectTo<XrayViewModel>(_mapper.ConfigurationProvider)
                .PaginatedListAsync(request.Page, request.Length, cancellationToken: cancellationToken);
    }
}
