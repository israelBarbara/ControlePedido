using Cinema.Domain.Utils;
using ControlePedido.Domain.v1.DTOs.Request;
using ControlePedido.Domain.v1.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace ControlePedido.API.v1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PedidoController : ControllerBase
    {
        private readonly IPedidoServices _services;

        public PedidoController(IPedidoServices services)
        {
            _services = services;
        }

        [HttpGet("grouped-itens/{id}")]
        public IActionResult GetItensPedido(int idPedido)
        {
            APIMessage result = _services.GetItensPedidoByPedido(idPedido);
            return StatusCode((int)result.StatusCode, result.Content);
        }

        [HttpPost("insert")]
        public IActionResult Pedido(InsertPedidoRequest pedido)
        {
            APIMessage result = _services.InsertNewPedido(pedido);
            return StatusCode((int)result.StatusCode, result.Content);
        }

        [HttpPost("all-orders")]
        public IActionResult AllOrders()
        {
            APIMessage result = _services.GetAllOrders();
            return StatusCode((int)result.StatusCode, result.Content);
        }

       

    }
}
