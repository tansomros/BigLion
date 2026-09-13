using FluentValidation;
using Microsoft.EntityFrameworkCore;
using BigLion.Application.Common.Interfaces;

namespace BigLion.Application.Features.Companies.Commands.Update
{
    public class UpdateCompanyCommandValidator : AbstractValidator<UpdateCompanyCommand>
    {
        private readonly IBigLionDatabaseContext _context;
        public UpdateCompanyCommandValidator(IBigLionDatabaseContext context)
        {
            _context = context;

            RuleFor(x => x.Id).NotEmpty()
                .WithMessage("Id ไม่สามารถเป็นค่าว่างได้")
                .NotNull().WithMessage("โปรดระบุ Id")
                .MustAsync(BeExistAsync).WithMessage("ไม่พบข้อมูล");
        }

        public async Task<bool> BeExistAsync(int id, CancellationToken cancellationToken)
        {
            var company = await _context
                .Company
                .AsNoTracking()
                .FirstOrDefaultAsync(c => c.Id == id, cancellationToken);

            return company != null;
        }
    }
}
