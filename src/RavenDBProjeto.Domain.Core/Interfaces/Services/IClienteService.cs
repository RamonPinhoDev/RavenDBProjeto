using RavenDBProjeto.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RavenDBProjeto.Domain.Core.Interfaces.Services
{
    public interface IClienteService
    {

        void Add(Cliente cliente);

        void Update(Cliente cliente);

        void Delete(string id);

        IEnumerable<Cliente> GetAll();

        Cliente GetById(string id);
    }
}
