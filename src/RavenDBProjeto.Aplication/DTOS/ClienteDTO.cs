using System;
using System.Collections.Generic;
using System.Text;

namespace RavenDBProjeto.Aplication.DTOS
{
    public class ClienteDTO
    {
       // public string Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }

        public EnderecoDTO Enderecos { get; set; }
    }
}
