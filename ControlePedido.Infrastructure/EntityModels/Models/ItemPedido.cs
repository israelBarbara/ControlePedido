using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControlePedido.Infrastructure.EntityModels.Models
{
    public partial class ItemPedido
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal ValorUnitario { get; set; }

        //ef relation
        public int PedidoId { get; set; }
        public Pedido Pedido { get; set; }

    }
}
