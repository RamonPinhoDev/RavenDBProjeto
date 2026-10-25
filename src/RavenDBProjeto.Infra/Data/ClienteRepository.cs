using Raven.Client.Documents.Session;
using RavenDBProjeto.Domain.Core.Interfaces.Repositories;
using RavenDBProjeto.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RavenDBProjeto.Infra.Data
{
    internal class ClienteRepository : IClienteRepository
    {
        private  readonly IDocumentStore _documentStore;

        public ClienteRepository(IDocumentStore documentStore)
        {
            _documentStore = documentStore;
        }
        public void Add(Cliente cliente)
        {
            using IDocumentSession session = _documentStore.OpenSession();

            session.Store(cliente);
            session.SaveChanges();
        }

        public void Delete(string id)
        {
            using IDocumentSession session = _documentStore.OpenSession();
            var cliente = session.Load<Cliente>(id);
            if (cliente != null)
            {
                session.Delete(cliente);
                session.SaveChanges();
            }
        }

        public IEnumerable<Cliente> GetAll()
        {
            using IDocumentSession session = _documentStore.OpenSession();
            var clientes = session.Query<Cliente>().ToList();
            return clientes;
        }

        public Cliente GetById(string id)
        {
            using IDocumentSession session = _documentStore.OpenSession();
            var cliente = session.Load<Cliente>(id);
            return cliente;
        }

        public void Update(Cliente cliente)
        {
            using IDocumentSession session = _documentStore.OpenSession();
            var clienteExistente = session.Query<Cliente>().FirstOrDefault(c => c.Id ==cliente.Id);


            if (clienteExistente != null)
            {
                clienteExistente.Cpf = cliente.Cpf;
                clienteExistente.Nome = cliente.Nome;
                clienteExistente.Email = cliente.Email;
                clienteExistente.DataNascimento = cliente.DataNascimento;
                clienteExistente.Endereco = cliente.Endereco;

                session.Store(clienteExistente);
                session.SaveChanges();
            }
        }
        }
    }
