using Microsoft.Extensions.DependencyInjection;
using SVE.Application.Interfaces;
using SVE.Application.Services;
using SVE.Infrastructure.SVE.Persistence.Interfaces;
using SVE.Infrastructure.SVE.Persistence.Repositories;

namespace SVE.IOC
{
    public static class PedidoDependency
    {
        public static void AddPedidoDependencies(this IServiceCollection services)
        {
            services.AddScoped<IPedidoService, PedidoService>();
            services.AddScoped<IPedidoRepository, PedidoRepository>();
        }
    }
}
