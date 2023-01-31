using ControlePedido.Infrastructure.EntityModels.Models;
using Microsoft.EntityFrameworkCore;
namespace ControlePedido.Infrastructure
{
    public class ControlePedidoContext :DbContext
    {

        public ControlePedidoContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<ItemPedido> ItemPedido { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //se esquecer de mapear algum campo do tipo string no banco vira como varchar(100) como default, e nao varchar(max)
            foreach (var property in modelBuilder.Model.GetEntityTypes()
                    .SelectMany(e => e.GetProperties()
                    .Where(p => p.ClrType == typeof(string))))
                property.SetColumnType("varchar(100)");

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ControlePedidoContext).Assembly);

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys())) relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;
            base.OnModelCreating(modelBuilder);
        }


    }
}