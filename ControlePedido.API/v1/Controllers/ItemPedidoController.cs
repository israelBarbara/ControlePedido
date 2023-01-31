using Cinema.Domain.Utils;
using ControlePedido.Domain.v1.DTOs.Request;
using ControlePedido.Domain.v1.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace ControlePedido.API.v1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemPedidoController : ControllerBase
    {
        private readonly IItemPedidoServices _services;

        public ItemPedidoController(IItemPedidoServices services)
        {
            _services = services;
        }

        [HttpPost("insert")]
        public IActionResult ItemPedido(InsertItemPedidoRequest pedido)
        {
            APIMessage result = _services.InsertItemPedido(pedido);
            return StatusCode((int)result.StatusCode, result.Content);
        }
      
        [HttpDelete("Remove/{id}")]
        public IActionResult ItemPedido(int id)
        {
            APIMessage result = _services.RemoveItemPedido(id);
            return StatusCode((int)result.StatusCode, result.Content);
        }

    }
}
