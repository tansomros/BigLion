using BigLion.Application.Common.Interfaces;
using BigLion.Application.Exceptions;
using BigLion.Domain.Entities;

namespace BigLion.Application.Features.Xrays.Commands.Delete;

public record DeleteXrayCommand : IRequest<Unit>
{
    public required int Id { get; set; }
}

public class DeleteXrayCommandHandler : IRequestHandler<DeleteXrayCommand, Unit>
{
    private readonly ICheckupDatabaseContext _context;

    public DeleteXrayCommandHandler(ICheckupDatabaseContext context)
    {
        _context = context;
    }

    public async Task<Unit> Handle(DeleteXrayCommand request, CancellationToken cancellationToken)
    {
        var xray = await _context.Xrays.FirstOrDefaultAsync(s => s.Id == request.Id, cancellationToken)
            ?? throw new NotFoundException(nameof(Xray), request.Id);

        _context.Xrays.Remove(xray);
        await _context.SaveChangesAsync(cancellationToken);
        return Unit.Value;
    }
}
