using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using VicStelmak.DEFDA.Application.Interfaces_Dapper;
using VicStelmak.DEFDA.Application.Interfaces_EntityFramework;
using VicStelmak.DEFDA.Application.Services_Dapper;
using VicStelmak.DEFDA.Application.Services_EntityFramework;
using VicStelmak.DEFDA.Infrastructure.DataAccess;
using VicStelmak.DEFDA.Infrastructure.DataAccess.Repositories;
using VicStelmak.DEFDA.Infrastructure.DataAccess.Repositories_Dapper;

namespace VicStelmak.DEFDA.Infrastructure
{
    public static class DIContainersConfigurator
    {
        public static IServiceCollection ConfigureDependencyInjection(this IServiceCollection services, IConfiguration configuration)
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
            services.AddSingleton<IAddressServiceDapper, AddressServiceDapper>();
            services.AddSingleton<IEmailAddressRepositoryDapper, EmailAddressRepositoryDapper>();
            services.AddSingleton<IEmailAddressServiceDapper, EmailAddressServiceDapper>();
            services.AddSingleton<ILeaseholderRepositoryDapper, LeaseholderRepositoryDapper>();
            services.AddSingleton<ILeaseholderServiceDapper, LeaseholderServiceDapper>();
            services.AddScoped<ILeaseholderRepositoryEf, LeaseholderRepositoryEf>();
            services.AddScoped<ILeaseholderServiceEf, LeaseholderServiceEf>();
            services.AddScoped<IEmailAddressRepositoryEf, EmailAddressRepositoryEf>();
            services.AddScoped<IEmailAddressServiceEf, EmailAddressServiceEf>();
            services.AddScoped<IAddressRepositoryEf, AddressRepositoryEF>();
            services.AddScoped<IAddressServiceEf, AddressServiceEf>();

            return services;
        }
    }
}

