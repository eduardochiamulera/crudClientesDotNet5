using CrudClientes.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace CrudClientes.Repository
{
    public class CidadeMap : BaseDomainMap<Cidade>
    {
        public CidadeMap() : base("tb_cidade"){}

        public override void Configure(EntityTypeBuilder<Cidade> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Nome).HasColumnName("nome").HasMaxLength(100).IsRequired();

            builder.Property(x => x.EstadoId).HasColumnName("id_estado").IsRequired();
            builder.HasOne(x => x.Estado).WithMany(x => x.Cidades).HasForeignKey(x => x.EstadoId);
            
        }
    }
}
