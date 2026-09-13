namespace BigLion.Application.Common.Interfaces
{
    public interface IHosxpDatabaseContext
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
