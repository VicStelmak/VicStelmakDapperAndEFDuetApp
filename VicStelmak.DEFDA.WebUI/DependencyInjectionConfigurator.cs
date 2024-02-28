using Blazored.Modal;
using Mapster;
using MapsterMapper;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using System.Reflection;
using VicStelmak.DEFDA.Application;
using VicStelmak.DEFDA.Application.Interfaces_Dapper;
using VicStelmak.DEFDA.Application.Interfaces_EntityFramework;
using VicStelmak.DEFDA.Application.Services_EntityFramework;
using VicStelmak.DEFDA.Infrastructure.DataAccess;
using VicStelmak.DEFDA.Infrastructure.DataAccess.Repositories;
using VicStelmak.DEFDA.Infrastructure.DataAccess.Repositories_Dapper;
using VicStelmak.DEFDA.WebUI.Data;

namespace VicStelmak.DEFDA.WebUI
{
    internal static class DependencyInjectionConfigurator
    {
        internal static IServiceCollection AddApplicationDependencies(this IServiceCollection services)
        {
            var mapperConfiguration = TypeAdapterConfig.GlobalSettings;
            mapperConfiguration.Scan(Assembly.GetExecutingAssembly());
            
            services.AddMediatR(config => config.RegisterServicesFromAssemblyContaining<MediatREntrypoint>());
            services.AddSingleton(mapperConfiguration);
            services.AddSingleton<IMapper, ServiceMapper>();

            return services;
        }

        internal static IServiceCollection AddInfrastructureDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionStringDapper = configuration.GetConnectionString("DapperDbConnection") ??
                throw new InvalidOperationException("Connection string 'DapperDbConnection' not found.");
            var connectionStringEf = configuration.GetConnectionString("EFDbConnection") ??
                throw new InvalidOperationException("Connection string 'EFDbConnection' not found.");

            services.AddDbContextFactory<RentalDbContextEf>(options =>
                options.UseMySql(connectionStringEf, new MySqlServerVersion(new Version(8, 2, 0)), mySqlOptions =>
                {
                    mySqlOptions.SchemaBehavior(MySqlSchemaBehavior.Ignore);
                    mySqlOptions.MigrationsAssembly(typeof(RentalDbContextEf).Assembly.FullName);
                }
            ));

            services.AddSingleton<ISqlDbAccessDapper>(s => new SqlDbAccessDapper(connectionStringDapper));
            services.AddSingleton<IAddressRepositoryDapper, AddressRepositoryDapper>();
            services.AddSingleton<IEmailAddressRepositoryDapper, EmailAddressRepositoryDapper>();
            services.AddSingleton<ILeaseholderRepositoryDapper, LeaseholderRepositoryDapper>();
            services.AddScoped<ILeaseholderRepositoryEf, LeaseholderRepositoryEf>();
            services.AddScoped<ILeaseholderServiceEf, LeaseholderServiceEf>();
            services.AddScoped<IEmailAddressRepositoryEf, EmailAddressRepositoryEf>();
            services.AddScoped<IEmailAddressServiceEf, EmailAddressServiceEf>();
            services.AddScoped<IAddressRepositoryEf, AddressRepositoryEF>();
            services.AddScoped<IAddressServiceEf, AddressServiceEf>();

            return services;
        }

        internal static IServiceCollection AddPresentationDependencies(this IServiceCollection services)
        {
            // Add services to the container.
            services.AddBlazoredModal();
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddSingleton<WeatherForecastService>();

            return services;
        }
    }
}
