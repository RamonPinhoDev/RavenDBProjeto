using RavenDBProjeto.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RavenDBProjeto.Domain.Core.Interfaces.Repositories
{
    public interface IEnderecoRepository
    {
        void Add(Endereco endereco);

        void Update(Endereco endereco);

        void Delete(string id);

        IEnumerable<Endereco> GetAll();

        Endereco GetById(string id);
    }
}
