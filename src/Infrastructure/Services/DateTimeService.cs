using BigLion.Application.Common.Interfaces;

namespace BigLion.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTimeOffset Now => DateTimeOffset.UtcNow;
    }
}
