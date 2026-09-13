using BigLion.Domain.Entities;
using BigLion.Application.Common.Interfaces;
using BigLion.Application.Exceptions;
using BigLion.Application.Features.Companies.ViewModels;

namespace BigLion.Application.Features.Companies.Queries.Get;

public record GetCompanyByIdQuery : IRequest<CompanyViewModel>
{
    public required int Id { get; set; }
}

public class GetCompanyByIdQueryHandler : IRequestHandler<GetCompanyByIdQuery, CompanyViewModel>
{
    private readonly IMapper _mapper;
    private readonly IBigLionDatabaseContext _context;

    public GetCompanyByIdQueryHandler(IBigLionDatabaseContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<CompanyViewModel> Handle(GetCompanyByIdQuery request, CancellationToken cancellationToken)
    {
        var company = await _context.Company.FirstOrDefaultAsync(d => d.Id == request.Id, cancellationToken)
            ?? throw new NotFoundException(nameof(Company), request.Id);

        return _mapper.Map<CompanyViewModel>(company);
    }
}
