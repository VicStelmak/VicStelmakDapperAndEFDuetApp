using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using VicStelmak.DEFDA.Application.Interfaces;
using VicStelmak.DEFDA.Application.Services;
using VicStelmak.DEFDA.Infrastructure.DataAccess;
using VicStelmak.DEFDA.Infrastructure.DataAccess.Repositories;

namespace VicStelmak.DEFDA.Infrastructure
{
    public static class DIContainersConfigurator
    {
        public static IServiceCollection ConfigureDependencyInjection(this
            IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("EFDbConnection") ??
                throw new InvalidOperationException("Connection string 'EFDbConnection' not found.");

            services.AddDbContextFactory<RentalDbContext>(options =>
                options.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 33)), mySqlOptions =>
                {
                    mySqlOptions.SchemaBehavior(MySqlSchemaBehavior.Ignore);
                    mySqlOptions.MigrationsAssembly(typeof(RentalDbContext).Assembly.FullName);
                }
            ));

            services.AddSingleton<IDbAccess, DbAccess>();
            services.AddScoped<ILeaseholderRepository, LeaseholderRepository>();
            services.AddScoped<ILeaseholderService, LeaseholderService>();
            services.AddScoped<IEmailAddressRepository, EmailAddressRepository>();
            services.AddScoped<IEmailAddressService, EmailAddressService>();
            services.AddScoped<IAddressRepository, AddressRepository>();
            services.AddScoped<IAddressService, AddressService>();

            return services;
        }
    }
}

