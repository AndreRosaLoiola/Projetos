namespace Mapeamento.Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string? Nome { get; set; }   
        public string? SobreNome { get; set; }   

        public string? Sexo { get; set; }    
        public DateTime? DataNascimento { get; set; }

        public ICollection<Conta>? Conta { get; set; }
    }
}
