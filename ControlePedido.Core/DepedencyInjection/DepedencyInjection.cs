using ControlePedido.Domain.v1.Interfaces.Repositories;
using ControlePedido.Domain.v1.Interfaces.Services;
using ControlePedido.Domain.v1.Repositories;
using ControlePedido.Domain.v1.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlePedido.Core.DepedencyInjection
{
    public static class DepedencyInjection
    {
        public static void ResolveDepedencyInjection(this IServiceCollection services)
        {
            services.AddScoped<IClienteServices, ClienteServices>();
            services.AddScoped<IItemPedidoServices, ItemPedidoServices>();
            services.AddScoped<IPedidoServices, PedidoServices>();

            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IItemPedidoRepository, ItemPedidoRepository>();
            services.AddScoped<IPedidoRepository, PedidoRepository>();

        }

    }
}
