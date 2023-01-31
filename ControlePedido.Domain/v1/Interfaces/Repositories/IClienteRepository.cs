using ControlePedido.Domain.v1.DTOs.Request;
using ControlePedido.Domain.v1.DTOs.Response;
using ControlePedido.Infrastructure;

namespace ControlePedido.Domain.v1.Interfaces.Repositories
{
    public interface IClienteRepository
    {
        public void InsertCliente(InsertClienteRequest cliente);
        public Cliente FindCliente(int id);
        public IEnumerable<ClientesResponse> FindAllClientes();
        public Cliente UpdateCliente(UpdateClienteRequest cliente);
        public bool RemoveCliente(int id);

    }
}
