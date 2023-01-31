using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlePedido.Domain.v1.DTOs.Request
{
    public class RemoveItemPedidoRequest
    {
        public int ItemPedidoId { get; set; }   
        public int PedidoId { get; set; }   

    }
}
