
using DigiHub.Application.Common.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace DigiHub.Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DigiHubDBContext>(options =>
                    options.UseSqlServer(
                        configuration.GetConnectionString("DigiHubConnection"),
                        b => b.MigrationsAssembly(typeof(DigiHubDBContext).Assembly.FullName)));

            services.AddScoped<IDigiHubDBContext>(provider => provider.GetService<DigiHubDBContext>());
            return services;
        }
    }
}
