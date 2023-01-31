using ControlePedido.Infrastructure.EntityModels.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControlePedido.Infrastructure.EntityModels.Mappings
{
    public partial class ItemPedidoMapping : IEntityTypeConfiguration<ItemPedido>
    {

        public void Configure(EntityTypeBuilder<ItemPedido> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(c => c.Nome)
            .IsRequired()
            .HasColumnType("varchar(100)");

            builder.ToTable("ITEM_PEDIDO");
        }

    }
}
