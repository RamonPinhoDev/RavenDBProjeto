using AutoMapper;
using RavenDBProjeto.Aplication.DTOS;
using RavenDBProjeto.Aplication.Interfaces;
using RavenDBProjeto.Domain.Core.Interfaces.Services;
using RavenDBProjeto.Domain.Model;
using RavenDBProjeto.Domain.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace RavenDBProjeto.Aplication
{
    public class ClienteAplication : IClienteAplication
    {
        private readonly IClienteService _clienteRepository;
        private readonly IMapper _mapper;


        public ClienteAplication(IClienteService clienteRepository, IMapper mapper)
        {
            _clienteRepository = clienteRepository;
            _mapper = mapper;
        }
        public void Add(ClienteDTO cliente)
        {
            var dto = _mapper.Map<Cliente>(cliente);
            dto.Endereco = _mapper.Map<Endereco>(cliente.Enderecos);

            _clienteRepository.Add(dto);
        }

        public void Delete(string id)
        {
            _clienteRepository.Delete(id);
        }

        public IEnumerable<ClienteDTO> GetAll()
        {
            var clientes = _clienteRepository.GetAll();

           var  clinteDTO = _mapper.Map<IEnumerable<ClienteDTO>>(clientes);
            return clinteDTO;
        }

        public ClienteDTO GetById(string id)
        {
            var cliente = _clienteRepository.GetById(id);
            var clienteDTO = _mapper.Map<ClienteDTO>(cliente);
            return clienteDTO;
        }

        public void Update(ClienteDTO cliente)
        {
            var dto = _mapper.Map<Cliente>(cliente);
            _clienteRepository.Update(dto);
        }
    }
}
