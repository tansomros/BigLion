using BigLion.Application.Common.Interfaces;
using BigLion.Application.Features.Companies.ViewModels;

namespace BigLion.Application.Features.Companies.Queries.Get;

public class GetCompanyListQuery : IRequest<CompanyListViewModel>
{

}

public class GetCompanyListQueryHandler : IRequestHandler<GetCompanyListQuery, CompanyListViewModel>
{
    private readonly IBigLionDatabaseContext _context;
    private readonly IMapper _mapper;

    public GetCompanyListQueryHandler(IBigLionDatabaseContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<CompanyListViewModel> Handle(GetCompanyListQuery request, CancellationToken cancellationToken)
    {
        var companies = await _context.Company.AsNoTracking().ToListAsync(cancellationToken);
        var companyList = _mapper.Map<List<CompanyViewModel>>(companies);
        return new CompanyListViewModel()
        {
            Companies = companyList,
        };
    }
}
