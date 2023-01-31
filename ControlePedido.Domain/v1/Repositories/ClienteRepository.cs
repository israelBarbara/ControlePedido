﻿
using ControlePedido.Domain.v1.DTOs.Request;
using ControlePedido.Domain.v1.Interfaces.Repositories;
using ControlePedido.Infrastructure;

namespace ControlePedido.Domain.v1.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly ControlePedidoContext _context;

        public ClienteRepository(ControlePedidoContext context) 
        {
            _context = context;
        }

        public Cliente FindCliente(int id)
        {
            var _cliente = _context.Cliente.Find(id);
            if (_cliente == null) return null;
            return _cliente;
        }

        public IEnumerable<Cliente> FindAllClientes()
        {
            return _context.Cliente.ToList();  
        }

        public void InsertCliente(InsertClienteRequest cliente)
        {
            var _cliente = new Cliente
            {
                Nome = cliente.Nome,
                Email = cliente.Email
            };
            _context.Cliente.Add(_cliente);
            _context.SaveChanges();
        }

        public Cliente UpdateCliente(UpdateClienteRequest cliente)
        {
            var _cliente = _context.Cliente.Find(cliente.Id);
            if(_cliente == null) return null;

            _cliente.Nome = cliente.Nome;
            _cliente.Email = cliente.Email;        
            _context.SaveChanges();
            return _cliente;
        }

        public bool RemoveCliente(int id)
        {
            var _cliente = _context.Cliente.Find(id);
            if (_cliente == null) return false;

            _context.Remove(_cliente);
            _context.SaveChanges();
            return true;
        }



    }
}
