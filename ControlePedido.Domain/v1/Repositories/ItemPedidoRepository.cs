using ControlePedido.Domain.v1.DTOs.Request;
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
    public class ItemPedidoRepository : IItemPedidoRepository
    {
        private readonly ControlePedidoContext _context;

        public ItemPedidoRepository(ControlePedidoContext context)
        {
            _context = context;
        }

        public void InsertItemPedido(InsertItemPedidoRequest ItemPedido)
        {
            var _itemPedido = new ItemPedido
            {
                Nome = ItemPedido.Nome,
                ValorUnitario = ItemPedido.ValorUnitario,
                PedidoId = ItemPedido.PedidoId,
            };

            _context.ItemPedido.Add(_itemPedido);
            _context.SaveChanges();

        }

        public int RemoveItemPedido(int itemPedidoId)
        {
            var itemPedido = _context.ItemPedido.Find(itemPedidoId);
            if (itemPedido == null) return 0;
          
            _context.ItemPedido.Remove(itemPedido);
            _context.SaveChanges();
            return itemPedido.PedidoId;
        }




    }
}
