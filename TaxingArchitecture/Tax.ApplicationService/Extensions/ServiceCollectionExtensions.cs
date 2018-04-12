using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Tax.DependenceInjection;

namespace Tax.ApplicationService.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddDependencyInjectionCustom(this IServiceCollection services, IConfiguration configuration)
        {
            Container.RegisterServices(services);
        }
    }
}