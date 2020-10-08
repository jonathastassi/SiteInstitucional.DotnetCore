
using Microsoft.Extensions.DependencyInjection;
using SiteInstitucional.Application;
using SiteInstitucional.Domain;
using SiteInstitucional.Infra;

namespace SiteInstitucional.Mvc
{
    public static class DatabaseExtensions
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IPortfolioRepository, PortfolioRepository>();
            services.AddScoped<IPortfolioAppService, PortfolioAppService>();
        }
    }
}
