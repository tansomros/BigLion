using BigLion.Application.Common.Interfaces;

namespace BigLion.Application.Features.Companies.Commands.Create
{
    public class CreateCompanyCommandValidator : AbstractValidator<CreateCompanyCommand>
    {
        private readonly IBigLionDatabaseContext _context;
        public  CreateCompanyCommandValidator(IBigLionDatabaseContext context)
        {
            _context = context;

            RuleFor(p => p.CompanyCode)
                    .NotEmpty().WithMessage("CompanyCode ต้องไม่ว่าง")
                    .NotNull().WithMessage("โปรดระบุ CompanyCode");
          
        }
    }
}
