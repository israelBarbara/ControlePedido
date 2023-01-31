using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlePedido.Domain.v1.DTOs.Response
{
    public class ItensGroupedResponse
    {
        public decimal TotalAmount { get; set; }
        public string Nome { get; set; }    
        public int Quantity { get; set; }
    }
}
