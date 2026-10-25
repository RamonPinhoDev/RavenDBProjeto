using AutoMapper;
using RavenDBProjeto.Aplication.DTOS;
using RavenDBProjeto.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RavenDBProjeto.Aplication.Mappers
{
    public class DtoToModelMapping : Profile
    {
        public DtoToModelMapping()
        {
            CreateMap<ClienteDTO, Cliente>().ForMember(c => c.Id, opt => opt.Ignore()).ReverseMap()
            .ForMember(c => c.Cpf, opt => opt.MapFrom(dto => dto.Cpf))
            .ForMember(c => c.Nome, opt => opt.MapFrom(dto => dto.Nome))
            .ForMember(c => c.Email, opt => opt.MapFrom(dto => dto.Email))
            .ForMember(c => c.DataNascimento, opt => opt.MapFrom(dto => dto.DataNascimento));

            CreateMap<EnderecoDTO, Endereco >().ForMember(e => e.Id, opt => opt.Ignore()).ReverseMap()
            .ForMember(e => e.Logradouro, opt => opt.MapFrom(dto => dto.Logradouro))
            .ForMember(e => e.Numero, opt => opt.MapFrom(dto => dto.Numero))
            .ForMember(e => e.Complemento, opt => opt.MapFrom(dto => dto.Complemento))
            .ForMember(e => e.Cidade, opt => opt.MapFrom(dto => dto.Cidade))
            .ForMember(e => e.Estado, opt => opt.MapFrom(dto => dto.Estado))
            .ForMember(e => e.Cep, opt => opt.MapFrom(dto => dto.Cep));


        }
    }
}
