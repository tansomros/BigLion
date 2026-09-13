using BigLion.Application.Common.Interfaces;
using BigLion.Application.Exceptions;

namespace BigLion.Application.Features.Companies.Commands.Delete;

public record DeleteCompanyCommand : IRequest<Unit>
{
    public int Id { get; set; }
}

public class DeleteCompanyCommandHandler : IRequestHandler<DeleteCompanyCommand, Unit>
{
    private readonly IBigLionDatabaseContext _context;

    public DeleteCompanyCommandHandler(IBigLionDatabaseContext context)
    {
        _context = context;
    }

    public async Task<Unit> Handle(DeleteCompanyCommand request, CancellationToken cancellationToken)
    {

        var entity = await _context.Company
                .FirstOrDefaultAsync(e => e.Id == request.Id, cancellationToken);

        if (entity == null)
        {
            throw new NotFoundException(nameof(Companies), request.Id);
        }

        _context.Company.Remove(entity);
        await _context.SaveChangesAsync(cancellationToken);
        return Unit.Value;

    }
}

public class DeleteCompanyCommandValidator : AbstractValidator<DeleteCompanyCommand>
{
    private readonly IBigLionDatabaseContext _context;
    public DeleteCompanyCommandValidator(IBigLionDatabaseContext context)
    {
        _context = context;

        RuleFor(x => x.Id).NotEmpty().WithMessage("Id ไม่สามารถเป็นค่าว่างได้").NotNull().WithMessage("โปรดระบุ Id");
    }
}
