using ControlePedido.Domain.v1.DTOs.Request;
using ControlePedido.Domain.v1.DTOs.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlePedido.Domain.v1.Interfaces.Repositories
{
    public interface IItemPedidoRepository
    {
        public void InsertItemPedido(InsertItemPedidoRequest ItemPedido);
        public int RemoveItemPedido(int idItemPedido);

    }
}
