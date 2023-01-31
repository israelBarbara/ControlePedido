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
    public class ClienteServices : IClienteServices
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteServices(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }


        public APIMessage InsertCliente(InsertClienteRequest cliente)
        {
            if(cliente == null) return new APIMessage(HttpStatusCode.BadRequest, cliente);
            if(cliente.Nome.Length > 100 || cliente.Email.Length > 100) return new APIMessage(HttpStatusCode.BadRequest, cliente,"Nome e email devem ter no maximo 100 caracteres");

            _clienteRepository.InsertCliente(cliente);
            return new APIMessage(HttpStatusCode.OK, cliente);
        }

    }
}
