using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace SomonesToDoListApp.Services.RegisterServices
{
    public static class Extensions
    {
        public static IServiceCollection RegisterApplicationServices(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
