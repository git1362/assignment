using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SomonesToDoListApp.Infrastrcuture.Persistence;
using SomonesToDoListApp.Infrastrcuture.Persistence.Repositories;
using SomonesToDoListApp.Services.Contracts;

namespace SomonesToDoListApp.Infrastrcuture.RegisterServices
{
    public static class Extensions
    {
        public static IServiceCollection RegisterInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<SomeonesToDoListContext>(options => {
                options.UseSqlServer(
                    configuration.GetConnectionString("SomeonesToDoListConnectionString"),
                    x => x.MigrationsAssembly("SomonesToDoListApp.Infrastrcuture"));
            });

            services.AddScoped(typeof(IAsyncRepository<>), typeof(Repository<>));
            services.AddScoped<ITodoRepository, TodoRepository>();
            return services;
        }
    }
}
