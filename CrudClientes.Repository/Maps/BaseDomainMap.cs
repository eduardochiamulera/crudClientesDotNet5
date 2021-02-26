using CrudClientes.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace CrudClientes.Repository
{
    public class BaseDomainMap<TDomain> : IEntityTypeConfiguration<TDomain> where TDomain : BaseDomain
    {
        private readonly string _tableName;

        public BaseDomainMap(string tableName = "")
        {
            _tableName = tableName;
        }
        public virtual void Configure(EntityTypeBuilder<TDomain> builder)
        {
            if (!string.IsNullOrEmpty(_tableName))
            {
                builder.ToTable(_tableName);
            }

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id");
            builder.Property(x => x.DataInclusao).HasColumnName("data_inclusao").IsRequired();
            builder.Property(x => x.DataAlteracao).HasColumnName("data_alteracao");
            builder.Property(x => x.DataExclusao).HasColumnName("data_exclusao");
            builder.Property(x => x.Ativo).HasColumnName("ativo").IsRequired();

        }
    }
}
