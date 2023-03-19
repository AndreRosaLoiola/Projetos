using Mapeamento.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mapeamento.Map
{
    public class ContaMap : IEntityTypeConfiguration<Conta>
    {
        public void Configure(EntityTypeBuilder<Conta> builder)
        {
            builder.ToTable("TB_CONTA");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("Id").UseIdentityColumn();
            builder.Property(x => x.IdPessoa).HasColumnName("PessoaId");
            builder.Property(x => x.TipoConta).HasColumnName("TipoContaId");
            builder.Property(x => x.DatadeCadastro).HasColumnName("DataCadastro");
            builder.Property(x => x.Saldo).HasColumnName("Saldo");

            builder.HasOne(x => x.Pessoa).WithMany(x => x.Conta);
            builder.HasOne(x => x.TipoConta).WithMany(x => x.Conta);
            
            
               
        }
    }
}
