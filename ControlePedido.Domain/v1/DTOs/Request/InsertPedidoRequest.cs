using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlePedido.Domain.v1.DTOs.Request
{
    public class InsertPedidoRequest
    {
        [Required(ErrorMessage = "Por favor informe um {0}")]
        public int ClienteId { get; set; }

        [Required(ErrorMessage = "Por favor informe um {0}")]
        public string ItemNome { get; set; }

        [Required(ErrorMessage = "Por favor informe um {0}")]
        public decimal ValorUnitario { get; set; }

    }
}
