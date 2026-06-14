using Microsoft.Extensions.DependencyInjection;

namespace ITHunterview.Service.Config
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            // Register repositories and use cases here
            return services;
        }
    }
}
