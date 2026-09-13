using BigLion.Application.Common.Interfaces;
using BigLion.Application.Exceptions;
using BigLion.Domain.Entities;

namespace BigLion.Application.Features.Users.Commands.Delete;

public record DeleteUserCommand : IRequest<Unit>
{
    public required int Id { get; set; }
}

public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand, Unit>
{
    private readonly IBigLionDatabaseContext _context;

    public DeleteUserCommandHandler(IBigLionDatabaseContext context)
    {
        _context = context;
    }

    public async Task<Unit> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
    {
        var User = await _context.Users.FirstOrDefaultAsync(s => s.Id == request.Id, cancellationToken)
            ?? throw new NotFoundException(nameof(Users), request.Id);

        _context.Users.Remove(User);
        await _context.SaveChangesAsync(cancellationToken);
        return Unit.Value;
    }
}
