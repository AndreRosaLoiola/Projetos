using System.Collections.ObjectModel;

namespace Mapeamento.Models
{
    public class TipoConta
    {
        public int Id { get; set; }
        public string? Descricao { get; set; }

        public Collection<Conta>? Conta { get; set; }
    }
}
