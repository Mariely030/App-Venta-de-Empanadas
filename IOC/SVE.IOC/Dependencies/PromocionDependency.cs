using Microsoft.Extensions.DependencyInjection;
using SVE.Application.Interfaces;
using SVE.Application.Services;
using SVE.Infrastructure.SVE.Persistence.Interfaces;
using SVE.Infrastructure.SVE.Persistence.Repositories;

namespace SVE.IOC
{
    public static class PromocionDependency
    {
        public static void AddPromocionDependencies(this IServiceCollection services)
        {
            services.AddScoped<IPromocionService, PromocionService>();
            services.AddScoped<IPromocionRepository, PromocionRepository>();
        }
    }
}
