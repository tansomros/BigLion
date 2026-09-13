using BigLion.Application.Common.Interfaces;
using BigLion.Application.Features.Users.ViewModel;

namespace BigLion.Application.Features.Users.Queries.Get;

public record GetUserLoginQuery : IRequest<UserListViewModel>
{
    public required string Username { get; set; }
    public required string Password { get; set; }
}

public class GetUserListWithClassQueryHandler : IRequestHandler<GetUserLoginQuery, UserListViewModel>
{
    private readonly IMapper _mapper;
    private readonly IBigLionDatabaseContext _context;

    public GetUserListWithClassQueryHandler(IBigLionDatabaseContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<UserListViewModel> Handle(GetUserLoginQuery request, CancellationToken cancellationToken)
    {
        var Users = await _context.Users
            .AsNoTracking()            
            .Where(l => l.Username == request.Username && l.PasswordHash== request.Password)
            .ToListAsync(cancellationToken);
                
        var UserList = _mapper.Map<List<UserViewModel>>(Users);

        return new UserListViewModel() { Users = UserList };
    }
}
