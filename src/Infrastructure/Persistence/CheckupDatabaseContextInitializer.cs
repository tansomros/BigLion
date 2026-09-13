using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using BigLion.Application.Features.Systems.Commands;

namespace BigLion.Infrastructure.Persistence
{
    public class CheckupDatabaseContextInitializer
    {
        private readonly ILogger<CheckupDatabaseContext> _logger;
        private readonly CheckupDatabaseContext _context;

        public CheckupDatabaseContextInitializer(ILogger<CheckupDatabaseContext> logger, CheckupDatabaseContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task MigrationAsync()
        {
            try
            {
                if (_context.Database.GetPendingMigrations().Any())
                {
                    await _context.Database.MigrateAsync();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occured while initializing the database.");
                throw;
            }
        }

        public async Task SeedDataAsync(IServiceScope scope)
        {
            try
            {
                var services = scope.ServiceProvider;
                var mediator = services.GetRequiredService<IMediator>();
                await mediator.Send(new ThaiProvinceDataInitializerCommand());
                await mediator.Send(new CheckupClassDataInitializerCommand());
                await mediator.Send(new CheckupGroupDataInitializerCommand());
                await mediator.Send(new CheckupTypeDataInitializerCommand());
                await mediator.Send(new CheckupItemDataInitializerCommand());
                await mediator.Send(new HearingHertzDataInitializerCommand());
                await mediator.Send(new RecommendationTemplateInitializerCommand());
                // [Obsolete] ReferenceGroup/ReferenceValue ถูกแทนที่ด้วย SmartEnum ใน Domain.Enums แล้ว
                // ดู LookupRegistry.cs สำหรับการใช้งานแบบใหม่
                // await mediator.Send(new ReferenceGroupDataInitializerCommand());
                // await mediator.Send(new ReferenceValueDataInitializerCommand());
                await mediator.Send(new RecommendationDataInitializerCommand());
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occured while initializing the database.");
                throw;
            }
        }
    }
}
