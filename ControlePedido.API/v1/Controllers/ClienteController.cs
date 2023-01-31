using Cinema.Domain.Utils;
using ControlePedido.Domain.v1.DTOs.Request;
using ControlePedido.Domain.v1.Interfaces.Services;
using ControlePedido.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace ControlePedido.API.v1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {

        private readonly IClienteServices _services;

        public ClienteController(IClienteServices services)
        {
            _services = services;
        }
        [HttpPost("insert")]
        public IActionResult InsertCliente(InsertClienteRequest cliente)
        {
            APIMessage result = _services.InsertCliente(cliente);
            return StatusCode((int)result.StatusCode, result.Content);
        }


    }
}
