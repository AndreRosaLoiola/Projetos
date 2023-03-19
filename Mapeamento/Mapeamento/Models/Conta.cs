using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Mapeamento.Models
{
    public class Conta
    {
        public int Id { get; set; }
        
        public DateTime? DatadeCadastro { get; set; }

        public double? Saldo     { get; set; }

        [ForeignKey("PessoaId")]
        [IgnoreDataMember]
        public int  IdPessoa { get; set; }

        [ForeignKey("IdTipoConta")]
        [IgnoreDataMember]
        public int  IdTipoConta { get; set; }
        
        public Pessoa Pessoa { get; set; }  

        public TipoConta TipoConta { get; set; }

        
    }
}

