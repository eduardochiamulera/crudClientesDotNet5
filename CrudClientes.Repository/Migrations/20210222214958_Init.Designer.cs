﻿// <auto-generated />
using System;
using CrudClientes.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace CrudClientes.Repository.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210222214958_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("CrudClientes.Domain.Cidade", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<bool>("Ativo")
                        .HasColumnType("boolean")
                        .HasColumnName("ativo");

                    b.Property<DateTime?>("DataAlteracao")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("data_alteracao");

                    b.Property<DateTime?>("DataExclusao")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("data_exclusao");

                    b.Property<DateTime>("DataInclusao")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("data_inclusao");

                    b.Property<Guid>("EstadoId")
                        .HasColumnType("uuid")
                        .HasColumnName("id_estado");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("nome");

                    b.HasKey("Id");

                    b.HasIndex("EstadoId");

                    b.ToTable("tb_cidade");
                });

            modelBuilder.Entity("CrudClientes.Domain.Cliente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<bool>("Ativo")
                        .HasColumnType("boolean")
                        .HasColumnName("ativo");

                    b.Property<string>("Bairro")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("bairro");

                    b.Property<string>("CEP")
                        .HasMaxLength(8)
                        .HasColumnType("character varying(8)")
                        .HasColumnName("cep");

                    b.Property<string>("CPFCNPJ")
                        .HasMaxLength(14)
                        .HasColumnType("character varying(14)")
                        .HasColumnName("cpfcnpj");

                    b.Property<string>("Celular")
                        .HasMaxLength(11)
                        .HasColumnType("character varying(11)")
                        .HasColumnName("celular");

                    b.Property<Guid?>("CidadeId")
                        .HasMaxLength(36)
                        .HasColumnType("uuid")
                        .HasColumnName("cidade_id");

                    b.Property<string>("Complemento")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("complemento");

                    b.Property<DateTime?>("DataAlteracao")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("data_alteracao");

                    b.Property<DateTime?>("DataExclusao")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("data_exclusao");

                    b.Property<DateTime>("DataInclusao")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("data_inclusao");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("email");

                    b.Property<string>("Endereco")
                        .HasMaxLength(60)
                        .HasColumnType("character varying(60)")
                        .HasColumnName("endereco");

                    b.Property<Guid?>("EstadoId")
                        .HasMaxLength(36)
                        .HasColumnType("uuid")
                        .HasColumnName("estado_id");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("nome");

                    b.Property<string>("Numero")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("numero");

                    b.Property<string>("Telefone")
                        .HasMaxLength(11)
                        .HasColumnType("character varying(11)")
                        .HasColumnName("telefone");

                    b.Property<string>("TipoDocumento")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("character varying(1)")
                        .HasColumnName("tipo_documento");

                    b.HasKey("Id");

                    b.HasIndex("CidadeId");

                    b.HasIndex("EstadoId");

                    b.ToTable("tb_cliente");
                });

            modelBuilder.Entity("CrudClientes.Domain.Estado", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<bool>("Ativo")
                        .HasColumnType("boolean")
                        .HasColumnName("ativo");

                    b.Property<DateTime?>("DataAlteracao")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("data_alteracao");

                    b.Property<DateTime?>("DataExclusao")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("data_exclusao");

                    b.Property<DateTime>("DataInclusao")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("data_inclusao");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("nome");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("character varying(2)")
                        .HasColumnName("sigla");

                    b.HasKey("Id");

                    b.ToTable("tb_estado");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f5fcbc8c-fef6-4912-bdf7-207cc38a1165"),
                            Ativo = true,
                            DataInclusao = new DateTime(2021, 2, 22, 18, 49, 57, 822, DateTimeKind.Local).AddTicks(5328),
                            Nome = "Acre",
                            Sigla = "AC"
                        },
                        new
                        {
                            Id = new Guid("d3736560-3965-4386-a861-27d855079100"),
                            Ativo = true,
                            DataInclusao = new DateTime(2021, 2, 22, 18, 49, 57, 827, DateTimeKind.Local).AddTicks(888),
                            Nome = "Distrito Federal",
                            Sigla = "DF"
                        },
                        new
                        {
                            Id = new Guid("556a4ecb-ee84-43f7-a77d-2a83172c86e5"),
                            Ativo = true,
                            DataInclusao = new DateTime(2021, 2, 22, 18, 49, 57, 827, DateTimeKind.Local).AddTicks(918),
                            Nome = "Goiás",
                            Sigla = "GO"
                        },
                        new
                        {
                            Id = new Guid("83048e48-c250-4b64-a9c3-2aecb9849ef8"),
                            Ativo = true,
                            DataInclusao = new DateTime(2021, 2, 22, 18, 49, 57, 827, DateTimeKind.Local).AddTicks(923),
                            Nome = "Minas Gerais",
                            Sigla = "MG"
                        },
                        new
                        {
                            Id = new Guid("274c5939-23b6-45b4-8d8b-2aef839d3413"),
                            Ativo = true,
                            DataInclusao = new DateTime(2021, 2, 22, 18, 49, 57, 827, DateTimeKind.Local).AddTicks(926),
                            Nome = "Roraima",
                            Sigla = "RR"
                        },
                        new
                        {
                            Id = new Guid("8ad5f994-2da3-49cc-b8b4-2b609be7d0e0"),
                            Ativo = true,
                            DataInclusao = new DateTime(2021, 2, 22, 18, 49, 57, 827, DateTimeKind.Local).AddTicks(932),
                            Nome = "Maranhão",
                            Sigla = "MA"
                        },
                        new
                        {
                            Id = new Guid("5820fe67-fdb7-407d-b5cb-3108dc612a95"),
                            Ativo = true,
                            DataInclusao = new DateTime(2021, 2, 22, 18, 49, 57, 827, DateTimeKind.Local).AddTicks(935),
                            Nome = "Ceará",
                            Sigla = "CE"
                        },
                        new
                        {
                            Id = new Guid("16546247-b363-4fcd-b957-315db92ed63c"),
                            Ativo = true,
                            DataInclusao = new DateTime(2021, 2, 22, 18, 49, 57, 827, DateTimeKind.Local).AddTicks(938),
                            Nome = "Piauí",
                            Sigla = "PI"
                        },
                        new
                        {
                            Id = new Guid("fb184864-8dd7-47f0-abf7-34476b6c27b1"),
                            Ativo = true,
                            DataInclusao = new DateTime(2021, 2, 22, 18, 49, 57, 827, DateTimeKind.Local).AddTicks(941),
                            Nome = "Rondônia",
                            Sigla = "RO"
                        },
                        new
                        {
                            Id = new Guid("2c3c50a5-89b9-452a-b46a-38cd86896700"),
                            Ativo = true,
                            DataInclusao = new DateTime(2021, 2, 22, 18, 49, 57, 827, DateTimeKind.Local).AddTicks(944),
                            Nome = "Rio de Janeiro",
                            Sigla = "RJ"
                        },
                        new
                        {
                            Id = new Guid("3891825c-a021-47fd-80b9-41f6f0aa65af"),
                            Ativo = true,
                            DataInclusao = new DateTime(2021, 2, 22, 18, 49, 57, 827, DateTimeKind.Local).AddTicks(948),
                            Nome = "Paraná",
                            Sigla = "PR"
                        },
                        new
                        {
                            Id = new Guid("92b220e9-c472-481f-a943-444ac5dc00b8"),
                            Ativo = true,
                            DataInclusao = new DateTime(2021, 2, 22, 18, 49, 57, 827, DateTimeKind.Local).AddTicks(952),
                            Nome = "Mato Grosso",
                            Sigla = "MT"
                        },
                        new
                        {
                            Id = new Guid("ec896b88-084f-4b18-8f07-736cfe6e337d"),
                            Ativo = true,
                            DataInclusao = new DateTime(2021, 2, 22, 18, 49, 57, 827, DateTimeKind.Local).AddTicks(955),
                            Nome = "São Paulo",
                            Sigla = "SP"
                        },
                        new
                        {
                            Id = new Guid("4dc9f47e-e560-4cb6-9d0c-862dbecaf89b"),
                            Ativo = true,
                            DataInclusao = new DateTime(2021, 2, 22, 18, 49, 57, 827, DateTimeKind.Local).AddTicks(959),
                            Nome = "Paraíba",
                            Sigla = "PB"
                        },
                        new
                        {
                            Id = new Guid("52e3277b-e0e2-49ec-8976-a6d84f13741c"),
                            Ativo = true,
                            DataInclusao = new DateTime(2021, 2, 22, 18, 49, 57, 827, DateTimeKind.Local).AddTicks(1035),
                            Nome = "Pará",
                            Sigla = "PA"
                        },
                        new
                        {
                            Id = new Guid("fda8bc5c-5fdb-4451-841c-a746705e620c"),
                            Ativo = true,
                            DataInclusao = new DateTime(2021, 2, 22, 18, 49, 57, 827, DateTimeKind.Local).AddTicks(1040),
                            Nome = "Rio Grande do Sul",
                            Sigla = "RS"
                        },
                        new
                        {
                            Id = new Guid("424df1b9-38a8-485b-a241-ab9ed231d54c"),
                            Ativo = true,
                            DataInclusao = new DateTime(2021, 2, 22, 18, 49, 57, 827, DateTimeKind.Local).AddTicks(1043),
                            Nome = "Pernambuco",
                            Sigla = "PE"
                        },
                        new
                        {
                            Id = new Guid("f32443a4-f172-42e9-84fc-b05e1f12fc31"),
                            Ativo = true,
                            DataInclusao = new DateTime(2021, 2, 22, 18, 49, 57, 827, DateTimeKind.Local).AddTicks(1047),
                            Nome = "Santa Catarina",
                            Sigla = "SC"
                        },
                        new
                        {
                            Id = new Guid("a21b30fe-2f2c-4670-8a45-b24c56a82e9b"),
                            Ativo = true,
                            DataInclusao = new DateTime(2021, 2, 22, 18, 49, 57, 827, DateTimeKind.Local).AddTicks(1050),
                            Nome = "Alagoas",
                            Sigla = "AL"
                        },
                        new
                        {
                            Id = new Guid("573be76f-428c-4cde-9400-c7b402f16fc9"),
                            Ativo = true,
                            DataInclusao = new DateTime(2021, 2, 22, 18, 49, 57, 827, DateTimeKind.Local).AddTicks(1053),
                            Nome = "Mato Grosso do Sul",
                            Sigla = "MS"
                        },
                        new
                        {
                            Id = new Guid("ede334eb-bdf3-4cb3-8819-cbc6a9265f5a"),
                            Ativo = true,
                            DataInclusao = new DateTime(2021, 2, 22, 18, 49, 57, 827, DateTimeKind.Local).AddTicks(1057),
                            Nome = "Rio Grande do Norte",
                            Sigla = "RN"
                        },
                        new
                        {
                            Id = new Guid("bf3ac31f-a12a-4f43-ac4c-e835444661e8"),
                            Ativo = true,
                            DataInclusao = new DateTime(2021, 2, 22, 18, 49, 57, 827, DateTimeKind.Local).AddTicks(1060),
                            Nome = "Amapá",
                            Sigla = "AP"
                        },
                        new
                        {
                            Id = new Guid("81f4c793-c448-4baa-acc8-ef1f8b634785"),
                            Ativo = true,
                            DataInclusao = new DateTime(2021, 2, 22, 18, 49, 57, 827, DateTimeKind.Local).AddTicks(1063),
                            Nome = "Bahia",
                            Sigla = "BA"
                        },
                        new
                        {
                            Id = new Guid("37b29aa5-7bf0-4304-ab8b-f09a9e40686a"),
                            Ativo = true,
                            DataInclusao = new DateTime(2021, 2, 22, 18, 49, 57, 827, DateTimeKind.Local).AddTicks(1066),
                            Nome = "Espírito Santo",
                            Sigla = "ES"
                        },
                        new
                        {
                            Id = new Guid("def11262-9538-43d4-8ff1-f57f3593ad36"),
                            Ativo = true,
                            DataInclusao = new DateTime(2021, 2, 22, 18, 49, 57, 827, DateTimeKind.Local).AddTicks(1072),
                            Nome = "Amazonas",
                            Sigla = "AM"
                        },
                        new
                        {
                            Id = new Guid("82146413-7cf2-41d8-8eaa-fcdcad37d863"),
                            Ativo = true,
                            DataInclusao = new DateTime(2021, 2, 22, 18, 49, 57, 827, DateTimeKind.Local).AddTicks(1075),
                            Nome = "Sergipe",
                            Sigla = "SE"
                        },
                        new
                        {
                            Id = new Guid("8b3abe67-33c1-4fda-b719-fec4ff740c23"),
                            Ativo = true,
                            DataInclusao = new DateTime(2021, 2, 22, 18, 49, 57, 827, DateTimeKind.Local).AddTicks(1079),
                            Nome = "Tocantins",
                            Sigla = "TO"
                        },
                        new
                        {
                            Id = new Guid("dd4d2ca7-a30a-4660-88d3-9d132916832e"),
                            Ativo = true,
                            DataInclusao = new DateTime(2021, 2, 22, 18, 49, 57, 827, DateTimeKind.Local).AddTicks(1084),
                            Nome = "Exterior",
                            Sigla = "EX"
                        });
                });

            modelBuilder.Entity("CrudClientes.Domain.Cidade", b =>
                {
                    b.HasOne("CrudClientes.Domain.Estado", "Estado")
                        .WithMany("Cidades")
                        .HasForeignKey("EstadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Estado");
                });

            modelBuilder.Entity("CrudClientes.Domain.Cliente", b =>
                {
                    b.HasOne("CrudClientes.Domain.Cidade", "Cidade")
                        .WithMany()
                        .HasForeignKey("CidadeId");

                    b.HasOne("CrudClientes.Domain.Estado", "Estado")
                        .WithMany()
                        .HasForeignKey("EstadoId");

                    b.Navigation("Cidade");

                    b.Navigation("Estado");
                });

            modelBuilder.Entity("CrudClientes.Domain.Estado", b =>
                {
                    b.Navigation("Cidades");
                });
#pragma warning restore 612, 618
        }
    }
}
