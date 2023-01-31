using ControlePedido.Infrastructure.EntityModels.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControlePedido.Infrastructure
{
    public partial class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public IEnumerable<Pedido> Pedidos { get; set; }
    }
}