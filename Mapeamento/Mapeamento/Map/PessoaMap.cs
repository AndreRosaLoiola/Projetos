using Mapeamento.Data;
using Mapeamento.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mapeamento.Map
{
    public class PessoaMap : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.ToTable("TB_PESSOA");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd();
            builder.Property(x=> x.Id).HasColumnName("Id");
            builder.Property(x => x.Nome).HasColumnName("Nome");
            builder.Property(x => x.SobreNome).HasColumnName("SobreNome");
            builder.Property(x => x.Sexo).HasColumnName("Sexo");
            builder.Property(x => x.DataNascimento).HasColumnName("DataNascimento");
            
            builder.HasMany(x=>x.Conta).WithOne(x=>x.Pessoa).HasForeignKey(x=>x.IdPessoa);
          
        }
    }
}
