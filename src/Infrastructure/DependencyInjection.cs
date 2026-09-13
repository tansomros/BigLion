using BigLion.Infrastructure.Identity;
using BigLion.Infrastructure.Persistence;
using BigLion.Infrastructure.Persistence.Interceptors;
using BigLion.Infrastructure.Services;
using BigLion.Application.Common.Interfaces;
using BigLion.Application.Identity.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Npgsql;
using IIdentityService = BigLion.Application.Identity.Interfaces.IIdentityService;

namespace BigLion.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddBigLionInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<AuditableEntitySaveChangesInterceptors>();

        // enable json store
        var dataSourceBuilder = new NpgsqlDataSourceBuilder(configuration.GetConnectionString("BigLionDatabase"));
        dataSourceBuilder.EnableDynamicJson();
        var dataSource = dataSourceBuilder.Build();
        services.AddDbContext<BigLionDatabaseContext>(options => options.UseNpgsql(dataSource));
        //services.AddScoped(provider => (Application.Common.Interfaces.IBigLionDatabaseContext)provider.GetRequiredService<Persistence.BigLionDatabaseContext>());
        services.AddScoped<IBigLionDatabaseContext>(provider =>
    provider.GetRequiredService<BigLionDatabaseContext>());
        services.AddScoped<BigLionDatabaseContextInitializer>();

        services.AddScoped<IIdentityService, IdentityService>();
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IPasswordHasher, PasswordHasher>();    
        services.AddScoped<IJwtTokenService, JwtTokenService>();    
        services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));

        services.AddTransient<IDateTime, DateTimeService>();
        return services;
    }
}
