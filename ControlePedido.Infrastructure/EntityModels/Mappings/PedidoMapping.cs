using ControlePedido.Infrastructure.EntityModels.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlePedido.Infrastructure.EntityModels.Mappings
{
    public class PedidoMapping : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(x => x.Id);


            //1:N Cliente para N Pedidos

            builder.HasMany(f => f.ItemPedidos)
            .WithOne(p => p.Pedido)
            .HasForeignKey(p => p.PedidoId);

            builder.ToTable("PEDIDO");
        }
    }
}
