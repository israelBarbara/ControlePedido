using Cinema.Domain.Utils;
using ControlePedido.Domain.v1.DTOs.Request;
using ControlePedido.Domain.v1.DTOs.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlePedido.Domain.v1.Interfaces.Services
{
    public interface IItemPedidoServices
    {
        public APIMessage InsertItemPedido(InsertItemPedidoRequest pedido);

        public APIMessage RemoveItemPedido(int idItemPedido);

    }
}
