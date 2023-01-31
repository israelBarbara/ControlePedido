using Cinema.Domain.Utils;
using ControlePedido.Domain.v1.DTOs.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlePedido.Domain.v1.Interfaces.Services
{
    public interface IClienteServices
    {
        public APIMessage InsertCliente(InsertClienteRequest cliente);
        public APIMessage GetClientes();
    }
}
