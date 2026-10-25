using RavenDBProjeto.Domain.Core.Interfaces.Repositories;
using RavenDBProjeto.Domain.Core.Interfaces.Services;
using RavenDBProjeto.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RavenDBProjeto.Domain.Service
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;


        

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }



        public void Add(Cliente cliente)
        {
            cliente.Ativo = true;
            _clienteRepository.Add(cliente);
        }

        public void Delete(string id)
        {
            _clienteRepository.Delete(id);
        }

        public IEnumerable<Cliente> GetAll()
        {
            return _clienteRepository.GetAll();
        }

        public Cliente GetById(string id)
        {
            return _clienteRepository.GetById(id);
        }

        public void Update(Cliente cliente)
        {
            _clienteRepository.Update(cliente);
        }
    }
}
