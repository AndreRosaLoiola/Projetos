using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Mapeamento.Models
{
    public class Conta
    {
        public int Id { get; set; }
        
        public DateTime? DataCadastro { get; set; }

        public decimal? Saldo    { get; set; }

      
        
        public int?  PessoaId { get; set; }

        
        public int?  TipoContaId { get; set; }
        
        public Pessoa? Pessoa { get; set; }  

        public TipoConta? TipoConta { get; set; }

        
    }
}

