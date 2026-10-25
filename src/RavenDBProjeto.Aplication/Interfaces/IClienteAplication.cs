using RavenDBProjeto.Aplication.DTOS;
using System;
using System.Collections.Generic;
using System.Text;

namespace RavenDBProjeto.Aplication.Interfaces
{
    public interface IClienteAplication
    {
        void Add(ClienteDTO cliente);

        void Update(ClienteDTO cliente);

        void Delete(string id);

        IEnumerable<ClienteDTO> GetAll();

        ClienteDTO GetById(string id);
    }
}
