using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlePedido.Domain.v1.DTOs.Request
{
    public class UpdateClienteRequest
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Por favor informe um {0}")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Por favor informe um {0}")]
        public string Email { get; set; }

    }
}
