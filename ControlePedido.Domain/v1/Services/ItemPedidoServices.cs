using Cinema.Domain.Utils;
using ControlePedido.Domain.v1.DTOs.Request;
using ControlePedido.Domain.v1.Interfaces.Repositories;
using ControlePedido.Domain.v1.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ControlePedido.Domain.v1.Services
{
    public class ItemPedidoServices : IItemPedidoServices
    {
        private readonly IItemPedidoRepository _ItemPedidoRepository;
        private readonly IPedidoRepository _PedidoRepository;

        public ItemPedidoServices(IItemPedidoRepository ItemPedidoRepository, IPedidoRepository PedidoRepository)
        {
            _ItemPedidoRepository = ItemPedidoRepository;
            _PedidoRepository = PedidoRepository;
        }

        public APIMessage InsertItemPedido(InsertItemPedidoRequest pedido)
        {
            if(pedido == null) return new APIMessage(HttpStatusCode.BadRequest, "Informe um pedido");
            if(pedido.Nome.Trim().Length == 0) new APIMessage(HttpStatusCode.BadRequest, pedido,"Informe um nome para o pedido");

            _ItemPedidoRepository.InsertItemPedido(pedido);
            return new APIMessage(HttpStatusCode.OK, pedido);
        }

        public APIMessage RemoveItemPedido(int idItemPedido)
        {        
            int pedidoId = _ItemPedidoRepository.RemoveItemPedido(idItemPedido);
            var _items = _PedidoRepository.GetAllItemsFromPedido(pedidoId);
            if (_items.Count() == 0)
            {
                _PedidoRepository.RemovePedido(pedidoId);
            }
            return new APIMessage(HttpStatusCode.OK, true);
        }


    }
}
