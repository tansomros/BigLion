using BigLion.Application.Common.Interfaces;
using BigLion.Domain.Entities;

namespace BigLion.Application.Features.Companies.Commands.Update;
public class UpsertLatestUpdateCompanyForWorkerCommand : IRequest<Unit>
{
    public required List<UpsertCompanyCommand> UpsertCompanys { get; set; }
}

public class UpsertCompanyCommand
{
    
    public int HosId { get; set; }  
    public required string Name { get; set; }
    public string? AddressNo { get; set; } = null!;
    public string? SubDistrictId { get; set; } = null!;
    public string? DistrictId { get; set; } = null!;
    public string? ProvinceId { get; set; } = null!;
    public string? ZipCode { get; set; } = null!;
}

public class UpsertLatestUpdateCompanyForWorkerCommandHandler(ICheckupDatabaseContext context) 
    : IRequestHandler<UpsertLatestUpdateCompanyForWorkerCommand, Unit>
{
    private readonly ICheckupDatabaseContext _context = context;

    public async Task<Unit> Handle(UpsertLatestUpdateCompanyForWorkerCommand request, CancellationToken cancellationToken)
    {
        var companyList = new List<Company>();
        foreach (var item in request.UpsertCompanys)
        {
            var company = await _context.Company.FirstOrDefaultAsync(
                c => c.HosId == item.HosId, cancellationToken);

            if (company != null)
            {
                company.HosId = item.HosId;
                company.Name = item.Name;
                company.AddressNo = item.AddressNo;
                company.SubDistrictId = item.SubDistrictId;
                company.DistrictId = item.DistrictId;
                company.ProvinceId = item.ProvinceId;
                company.ZipCode = item.ZipCode;          
                company.IsActive = true;

                _context.Company.Update(company);
                await _context.SaveChangesAsync(cancellationToken);
            }
            else
            {
                companyList.Add(
                    new Company(item.Name, true)
                    {
                        HosId = item.HosId,
                        Name = item.Name,
                        AddressNo = item.AddressNo,
                        SubDistrictId = item.SubDistrictId,
                        DistrictId = item.DistrictId,   
                        ProvinceId = item.ProvinceId,
                        ZipCode = item.ZipCode,
                    });
            }
        }

        if(companyList.Count != 0)
        {
            await _context.Company.AddRangeAsync(companyList, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
        }

        return Unit.Value;
    }
}
