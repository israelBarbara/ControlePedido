using ControlePedido.Domain.v1.DTOs.Request;
using ControlePedido.Infrastructure;

namespace ControlePedido.Domain.v1.Interfaces.Repositories
{
    public interface IClienteRepository
    {
        public void InsertCliente(InsertClienteRequest cliente);
        public Cliente FindCliente(int id);
        public IEnumerable<Cliente> FindAllClientes();
        public Cliente UpdateCliente(UpdateClienteRequest cliente);
        public bool RemoveCliente(int id);

    }
}
