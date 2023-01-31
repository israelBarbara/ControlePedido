using ControlePedido.Domain.v1.DTOs.Response;
using ControlePedido.Domain.v1.Interfaces.Repositories;
using ControlePedido.Infrastructure;
using ControlePedido.Infrastructure.EntityModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlePedido.Domain.v1.Repositories
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly ControlePedidoContext _context;

        public PedidoRepository(ControlePedidoContext context)
        {
            _context = context;
        }
        public int InsertPedido(int idCliente)
        {
            var _pedido = new Pedido
            {
                DataCriacao = DateTime.Now,
                ClienteId = idCliente,
            };

            _context.Pedido.Add(_pedido);
            _context.SaveChanges();
            _pedido.NumPedido = _pedido.Id;
            _context.SaveChanges();

            return _pedido.Id;

            //Nao entendi a necessidade do Num Pedido, tendo em vista que a primary key do Pedido ja é no numero do pedido em si.
        }

        public bool RemovePedido(int idPedido)
        {
            var _pedido = _context.Pedido.Find(idPedido);
            if(_pedido == null) return false;
            _context.Pedido.Remove(_pedido);
            _context.SaveChanges();
            return true;
        }

        public IEnumerable<ItemPedido> GetAllItemsFromPedido(int PedidoId)
        {
            return _context.ItemPedido.Where(x=>x.PedidoId == PedidoId).ToList();
        }

        public IEnumerable<PedidoResponse> GetAllOrders()
        {
            return (from p in _context.Pedido
                    join cli in _context.Cliente on p.ClienteId equals cli.Id
                    select new PedidoResponse
                    {
                        Id = p.Id,
                        DataCriacao = p.DataCriacao.ToString("dd/MM/yyyy hh:mm:ss"),
                        nomeCliente = cli.Nome
                    }).ToList();
        }

        public IEnumerable<ItensGroupedResponse> GetItemPedidosByPedidoId(int pedidoId)
        {

            return (from IP in _context.ItemPedido.Where(x => x.PedidoId == pedidoId)
                    group IP by IP.Nome into K
                    select new ItensGroupedResponse
                    {
                        Quantidade = K.Count(),
                        ValorTotal = K.Sum(x => x.ValorUnitario),
                        Nome = K.Key
                    }).ToList();

        }

    }
}
