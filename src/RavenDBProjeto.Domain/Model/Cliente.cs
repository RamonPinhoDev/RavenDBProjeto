

namespace RavenDBProjeto.Domain.Model
{
    public class Cliente
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public Endereco Endereco { get; set; }
        public bool Ativo { get; set; }
    }
}
