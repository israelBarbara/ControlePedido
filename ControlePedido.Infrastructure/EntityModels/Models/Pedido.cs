using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControlePedido.Infrastructure.EntityModels.Models
{
    public partial class Pedido
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int NumPedido { get; set; }
        public DateTime DataCriacao { get; set; }

        public IEnumerable<ItemPedido> ItemPedidos { get; set; }

        //ef relation
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

    }
}
