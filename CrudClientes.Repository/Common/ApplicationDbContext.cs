using CrudClientes.Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace CrudClientes.Repository
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);

            modelBuilder.Entity<Estado>().HasData(
                new Estado() { Id = Guid.Parse("F5FCBC8C-FEF6-4912-BDF7-207CC38A1165"), Sigla = "AC", DataInclusao = DateTime.Now, Ativo = true, Nome = "Acre" },
                    new Estado() { Id = Guid.Parse("D3736560-3965-4386-A861-27D855079100"), Sigla = "DF", DataInclusao = DateTime.Now, Ativo = true, Nome = "Distrito Federal"},
                    new Estado() { Id = Guid.Parse("556A4ECB-EE84-43F7-A77D-2A83172C86E5"), Sigla = "GO", DataInclusao = DateTime.Now, Ativo = true, Nome = "Goiás"},
                    new Estado() { Id = Guid.Parse("83048E48-C250-4B64-A9C3-2AECB9849EF8"), Sigla = "MG", DataInclusao = DateTime.Now, Ativo = true, Nome = "Minas Gerais" },
                    new Estado() { Id = Guid.Parse("274C5939-23B6-45B4-8D8B-2AEF839D3413"), Sigla = "RR", DataInclusao = DateTime.Now, Ativo = true, Nome = "Roraima" },
                    new Estado() { Id = Guid.Parse("8AD5F994-2DA3-49CC-B8B4-2B609BE7D0E0"), Sigla = "MA", DataInclusao = DateTime.Now, Ativo = true, Nome = "Maranhão" },
                    new Estado() { Id = Guid.Parse("5820FE67-FDB7-407D-B5CB-3108DC612A95"), Sigla = "CE", DataInclusao = DateTime.Now, Ativo = true, Nome = "Ceará" },
                    new Estado() { Id = Guid.Parse("16546247-B363-4FCD-B957-315DB92ED63C"), Sigla = "PI", DataInclusao = DateTime.Now, Ativo = true, Nome = "Piauí" },
                    new Estado() { Id = Guid.Parse("FB184864-8DD7-47F0-ABF7-34476B6C27B1"), Sigla = "RO", DataInclusao = DateTime.Now, Ativo = true, Nome = "Rondônia" },
                    new Estado() { Id = Guid.Parse("2C3C50A5-89B9-452A-B46A-38CD86896700"), Sigla = "RJ", DataInclusao = DateTime.Now, Ativo = true, Nome = "Rio de Janeiro" },
                    new Estado() { Id = Guid.Parse("3891825C-A021-47FD-80B9-41F6F0AA65AF"), Sigla = "PR", DataInclusao = DateTime.Now, Ativo = true, Nome = "Paraná" },
                    new Estado() { Id = Guid.Parse("92B220E9-C472-481F-A943-444AC5DC00B8"), Sigla = "MT", DataInclusao = DateTime.Now, Ativo = true, Nome = "Mato Grosso" },
                    new Estado() { Id = Guid.Parse("EC896B88-084F-4B18-8F07-736CFE6E337D"), Sigla = "SP", DataInclusao = DateTime.Now, Ativo = true, Nome = "São Paulo" },
                    new Estado() { Id = Guid.Parse("4DC9F47E-E560-4CB6-9D0C-862DBECAF89B"), Sigla = "PB", DataInclusao = DateTime.Now, Ativo = true, Nome = "Paraíba" },
                    new Estado() { Id = Guid.Parse("52E3277B-E0E2-49EC-8976-A6D84F13741C"), Sigla = "PA", DataInclusao = DateTime.Now, Ativo = true, Nome = "Pará" },
                    new Estado() { Id = Guid.Parse("FDA8BC5C-5FDB-4451-841C-A746705E620C"), Sigla = "RS", DataInclusao = DateTime.Now, Ativo = true, Nome = "Rio Grande do Sul" },
                    new Estado() { Id = Guid.Parse("424DF1B9-38A8-485B-A241-AB9ED231D54C"), Sigla = "PE", DataInclusao = DateTime.Now, Ativo = true, Nome = "Pernambuco" },
                    new Estado() { Id = Guid.Parse("F32443A4-F172-42E9-84FC-B05E1F12FC31"), Sigla = "SC", DataInclusao = DateTime.Now, Ativo = true, Nome = "Santa Catarina" },
                    new Estado() { Id = Guid.Parse("A21B30FE-2F2C-4670-8A45-B24C56A82E9B"), Sigla = "AL", DataInclusao = DateTime.Now, Ativo = true, Nome = "Alagoas" },
                    new Estado() { Id = Guid.Parse("573BE76F-428C-4CDE-9400-C7B402F16FC9"), Sigla = "MS", DataInclusao = DateTime.Now, Ativo = true, Nome = "Mato Grosso do Sul" },
                    new Estado() { Id = Guid.Parse("EDE334EB-BDF3-4CB3-8819-CBC6A9265F5A"), Sigla = "RN", DataInclusao = DateTime.Now, Ativo = true, Nome = "Rio Grande do Norte" },
                    new Estado() { Id = Guid.Parse("BF3AC31F-A12A-4F43-AC4C-E835444661E8"), Sigla = "AP", DataInclusao = DateTime.Now, Ativo = true, Nome = "Amapá" },
                    new Estado() { Id = Guid.Parse("81F4C793-C448-4BAA-ACC8-EF1F8B634785"), Sigla = "BA", DataInclusao = DateTime.Now, Ativo = true, Nome = "Bahia" },
                    new Estado() { Id = Guid.Parse("37B29AA5-7BF0-4304-AB8B-F09A9E40686A"), Sigla = "ES", DataInclusao = DateTime.Now, Ativo = true, Nome = "Espírito Santo" },
                    new Estado() { Id = Guid.Parse("DEF11262-9538-43D4-8FF1-F57F3593AD36"), Sigla = "AM", DataInclusao = DateTime.Now, Ativo = true, Nome = "Amazonas" },
                    new Estado() { Id = Guid.Parse("82146413-7CF2-41D8-8EAA-FCDCAD37D863"), Sigla = "SE", DataInclusao = DateTime.Now, Ativo = true, Nome = "Sergipe" },
                    new Estado() { Id = Guid.Parse("8B3ABE67-33C1-4FDA-B719-FEC4FF740C23"), Sigla = "TO", DataInclusao = DateTime.Now, Ativo = true, Nome = "Tocantins" },
                    new Estado() { Id = Guid.Parse("DD4D2CA7-A30A-4660-88D3-9D132916832E"), Sigla = "EX", DataInclusao = DateTime.Now, Ativo = true, Nome = "Exterior" }
                );
        }

        public ApplicationDbContext()
        {
            ChangeTracker.AutoDetectChangesEnabled = false;
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            ChangeTracker.AutoDetectChangesEnabled = false;
        }
    }
}
