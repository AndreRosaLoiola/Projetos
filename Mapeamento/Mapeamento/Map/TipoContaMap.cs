using Mapeamento.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mapeamento.Map
{
    public class TipoContaMap : IEntityTypeConfiguration<TipoConta>
    {
        public void Configure(EntityTypeBuilder<TipoConta> builder)
        {
            builder.ToTable("TB_TIPO_CONTA");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("Id").UseIdentityColumn();
            builder.Property(x => x.Descricao).HasColumnName("Descricao");


            builder.HasMany(x => x.Conta).WithOne(x => x.TipoConta).HasForeignKey(x => x.IdTipoConta);
              
        }

       
            
    }
}
