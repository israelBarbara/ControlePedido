using Cinema.Domain.Utils;
using ControlePedido.Domain.v1.DTOs.Request;
using ControlePedido.Domain.v1.Interfaces.Repositories;
using ControlePedido.Domain.v1.Interfaces.Services;
using ControlePedido.Domain.v1.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ControlePedido.Domain.v1.Services
{
    public class PedidoServices : IPedidoServices
    {

        private readonly IPedidoRepository _PedidoRepository;
        private readonly IItemPedidoRepository _ItemPedidoRepository;

        public PedidoServices(IPedidoRepository PedidoRepository, IItemPedidoRepository ItemPedidoRepository)
        {
            _PedidoRepository = PedidoRepository;
            _ItemPedidoRepository = ItemPedidoRepository;
        }


        public APIMessage GetItensPedidoByPedido(int pedidoId)
        {
            var _itens = _PedidoRepository.GetItemPedidosByPedidoId(pedidoId);
            return new APIMessage(HttpStatusCode.OK, _itens);
        }

        public APIMessage InsertNewPedido(InsertPedidoRequest pedido)
        {
            if(pedido.ClienteId <= 0) return new APIMessage(HttpStatusCode.BadRequest, pedido,"Informe o cliente");

            var itemPedido = new InsertItemPedidoRequest
            {
                Nome = pedido.ItemNome,
                ValorUnitario = pedido.ValorUnitario
            };

            int _pedidoId = _PedidoRepository.InsertPedido(pedido.ClienteId);
            itemPedido.PedidoId = _pedidoId;
            _ItemPedidoRepository.InsertItemPedido(itemPedido);
            return new APIMessage(HttpStatusCode.OK, _pedidoId);
        }


        public APIMessage GetAllOrders()
        {
            var pedidos = _PedidoRepository.GetAllOrders();
            return new APIMessage(HttpStatusCode.OK, pedidos);
        }
    }
}
