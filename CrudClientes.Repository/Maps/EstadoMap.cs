using CrudClientes.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace CrudClientes.Repository
{
    public class EstadoMap : BaseDomainMap<Estado>
    {
        public EstadoMap() : base("tb_estado") { }

        public override void Configure(EntityTypeBuilder<Estado> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Nome).HasColumnName("nome").HasMaxLength(100).IsRequired();
            builder.Property(x => x.Sigla).HasColumnName("sigla").HasMaxLength(2).IsRequired();
        }
    }
}
