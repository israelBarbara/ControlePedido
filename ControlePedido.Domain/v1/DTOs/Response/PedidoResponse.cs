using System;

namespace ControlePedido.Domain.v1.DTOs.Response
{
    public class PedidoResponse
    {
        public int Id { get; set; }
        public string DataCriacao { get; set; }
        public string nomeCliente { get; set; } 

    }
}
