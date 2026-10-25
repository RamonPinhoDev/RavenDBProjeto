

namespace RavenDBProjeto.Domain.Model;

public class Endereco
{
    public string Id { get; set; }
    public string Logradouro { get; set; }
    public int Numero { get; set; }

    public string Complemento { get; set; }

    public string Cidade { get; set; }

    public string Estado { get; set; }
    public string Cep { get; set; }

    public bool  Ativo { get; set; }



}
