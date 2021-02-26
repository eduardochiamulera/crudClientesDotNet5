using CrudClientes.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace CrudClientes.Repository
{
    public class ClienteMap : BaseDomainMap<Cliente>
    {
        public ClienteMap() : base("tb_cliente") { }

        public override void Configure(EntityTypeBuilder<Cliente> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Nome).HasColumnName("nome").HasMaxLength(100).IsRequired();
            builder.Property(x => x.Bairro).HasColumnName("bairro").HasMaxLength(100);
            builder.Property(x => x.Celular).HasColumnName("celular").HasMaxLength(11);
            builder.Property(x => x.Telefone).HasColumnName("telefone").HasMaxLength(11);
            builder.Property(x => x.CEP).HasColumnName("cep").HasMaxLength(8);
            builder.Property(x => x.TipoDocumento).HasColumnName("tipo_documento").HasMaxLength(1).IsRequired();
            builder.Property(x => x.CPFCNPJ).HasColumnName("cpfcnpj").HasMaxLength(14);
            builder.Property(x => x.Endereco).HasColumnName("endereco").HasMaxLength(60);
            builder.Property(x => x.Numero).HasColumnName("numero").HasMaxLength(50);
            builder.Property(x => x.Complemento).HasColumnName("complemento").HasMaxLength(100);
            builder.Property(x => x.Email).HasColumnName("email").HasMaxLength(100);
         
            builder.Property(x => x.CidadeId).HasColumnName("cidade_id").HasMaxLength(36);
            builder.HasOne(x => x.Cidade).WithMany().HasForeignKey(x => x.CidadeId);

            builder.Property(x => x.EstadoId).HasColumnName("estado_id").HasMaxLength(36);
            builder.HasOne(x => x.Estado).WithMany().HasForeignKey(x => x.EstadoId);
        }
    }
}
