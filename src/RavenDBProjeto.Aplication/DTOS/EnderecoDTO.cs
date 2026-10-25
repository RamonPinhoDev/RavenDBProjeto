using System;
using System.Collections.Generic;
using System.Text;

namespace RavenDBProjeto.Aplication.DTOS
{
    public class EnderecoDTO
    {
       // public string Id { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }

        public string Complemento { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }
        public string Cep { get; set; }


    }
}
