using ControlePedido.Domain.v1.DTOs.Response;
using ControlePedido.Infrastructure.EntityModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlePedido.Domain.v1.Interfaces.Repositories
{
    public interface IPedidoRepository
    {
        public int InsertPedido(int idCliente);
        public bool RemovePedido(int idPedido);
        public IEnumerable<ItensGroupedResponse> GetItemPedidosByPedidoId(int pedidoId);
        public IEnumerable<ItemPedido> GetAllItemsFromPedido(int PedidoId);
    }
}
