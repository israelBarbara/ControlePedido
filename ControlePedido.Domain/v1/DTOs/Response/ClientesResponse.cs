using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlePedido.Domain.v1.DTOs.Response
{
    public class ClientesResponse
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

    }
}
