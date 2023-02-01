using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlePedido.Domain.v1.DTOs.Response
{
    public class TotalValueItemGroupedResponse
    {
        public decimal valorTotalPedido { get; set; }   
        public IEnumerable<ItensGroupedResponse> items { get; set; }    
    }
}
