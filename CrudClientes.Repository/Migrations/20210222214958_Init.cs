using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CrudClientes.Repository.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_estado",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    sigla = table.Column<string>(type: "character varying(2)", maxLength: 2, nullable: false),
                    nome = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    data_inclusao = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    data_alteracao = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    data_exclusao = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ativo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_estado", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tb_cidade",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    nome = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    id_estado = table.Column<Guid>(type: "uuid", nullable: false),
                    data_inclusao = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    data_alteracao = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    data_exclusao = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ativo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_cidade", x => x.id);
                    table.ForeignKey(
                        name: "FK_tb_cidade_tb_estado_id_estado",
                        column: x => x.id_estado,
                        principalTable: "tb_estado",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_cliente",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    nome = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    tipo_documento = table.Column<string>(type: "character varying(1)", maxLength: 1, nullable: false),
                    cpfcnpj = table.Column<string>(type: "character varying(14)", maxLength: 14, nullable: true),
                    cep = table.Column<string>(type: "character varying(8)", maxLength: 8, nullable: true),
                    endereco = table.Column<string>(type: "character varying(60)", maxLength: 60, nullable: true),
                    numero = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    complemento = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    bairro = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    cidade_id = table.Column<Guid>(type: "uuid", maxLength: 36, nullable: true),
                    estado_id = table.Column<Guid>(type: "uuid", maxLength: 36, nullable: true),
                    telefone = table.Column<string>(type: "character varying(11)", maxLength: 11, nullable: true),
                    celular = table.Column<string>(type: "character varying(11)", maxLength: 11, nullable: true),
                    email = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    data_inclusao = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    data_alteracao = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    data_exclusao = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ativo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_cliente", x => x.id);
                    table.ForeignKey(
                        name: "FK_tb_cliente_tb_cidade_cidade_id",
                        column: x => x.cidade_id,
                        principalTable: "tb_cidade",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tb_cliente_tb_estado_estado_id",
                        column: x => x.estado_id,
                        principalTable: "tb_estado",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "tb_estado",
                columns: new[] { "id", "ativo", "data_alteracao", "data_exclusao", "data_inclusao", "nome", "sigla" },
                values: new object[,]
                {
                    { new Guid("f5fcbc8c-fef6-4912-bdf7-207cc38a1165"), true, null, null, new DateTime(2021, 2, 22, 18, 49, 57, 822, DateTimeKind.Local).AddTicks(5328), "Acre", "AC" },
                    { new Guid("82146413-7cf2-41d8-8eaa-fcdcad37d863"), true, null, null, new DateTime(2021, 2, 22, 18, 49, 57, 827, DateTimeKind.Local).AddTicks(1075), "Sergipe", "SE" },
                    { new Guid("def11262-9538-43d4-8ff1-f57f3593ad36"), true, null, null, new DateTime(2021, 2, 22, 18, 49, 57, 827, DateTimeKind.Local).AddTicks(1072), "Amazonas", "AM" },
                    { new Guid("37b29aa5-7bf0-4304-ab8b-f09a9e40686a"), true, null, null, new DateTime(2021, 2, 22, 18, 49, 57, 827, DateTimeKind.Local).AddTicks(1066), "Espírito Santo", "ES" },
                    { new Guid("81f4c793-c448-4baa-acc8-ef1f8b634785"), true, null, null, new DateTime(2021, 2, 22, 18, 49, 57, 827, DateTimeKind.Local).AddTicks(1063), "Bahia", "BA" },
                    { new Guid("bf3ac31f-a12a-4f43-ac4c-e835444661e8"), true, null, null, new DateTime(2021, 2, 22, 18, 49, 57, 827, DateTimeKind.Local).AddTicks(1060), "Amapá", "AP" },
                    { new Guid("ede334eb-bdf3-4cb3-8819-cbc6a9265f5a"), true, null, null, new DateTime(2021, 2, 22, 18, 49, 57, 827, DateTimeKind.Local).AddTicks(1057), "Rio Grande do Norte", "RN" },
                    { new Guid("573be76f-428c-4cde-9400-c7b402f16fc9"), true, null, null, new DateTime(2021, 2, 22, 18, 49, 57, 827, DateTimeKind.Local).AddTicks(1053), "Mato Grosso do Sul", "MS" },
                    { new Guid("a21b30fe-2f2c-4670-8a45-b24c56a82e9b"), true, null, null, new DateTime(2021, 2, 22, 18, 49, 57, 827, DateTimeKind.Local).AddTicks(1050), "Alagoas", "AL" },
                    { new Guid("f32443a4-f172-42e9-84fc-b05e1f12fc31"), true, null, null, new DateTime(2021, 2, 22, 18, 49, 57, 827, DateTimeKind.Local).AddTicks(1047), "Santa Catarina", "SC" },
                    { new Guid("424df1b9-38a8-485b-a241-ab9ed231d54c"), true, null, null, new DateTime(2021, 2, 22, 18, 49, 57, 827, DateTimeKind.Local).AddTicks(1043), "Pernambuco", "PE" },
                    { new Guid("fda8bc5c-5fdb-4451-841c-a746705e620c"), true, null, null, new DateTime(2021, 2, 22, 18, 49, 57, 827, DateTimeKind.Local).AddTicks(1040), "Rio Grande do Sul", "RS" },
                    { new Guid("52e3277b-e0e2-49ec-8976-a6d84f13741c"), true, null, null, new DateTime(2021, 2, 22, 18, 49, 57, 827, DateTimeKind.Local).AddTicks(1035), "Pará", "PA" },
                    { new Guid("4dc9f47e-e560-4cb6-9d0c-862dbecaf89b"), true, null, null, new DateTime(2021, 2, 22, 18, 49, 57, 827, DateTimeKind.Local).AddTicks(959), "Paraíba", "PB" },
                    { new Guid("ec896b88-084f-4b18-8f07-736cfe6e337d"), true, null, null, new DateTime(2021, 2, 22, 18, 49, 57, 827, DateTimeKind.Local).AddTicks(955), "São Paulo", "SP" },
                    { new Guid("92b220e9-c472-481f-a943-444ac5dc00b8"), true, null, null, new DateTime(2021, 2, 22, 18, 49, 57, 827, DateTimeKind.Local).AddTicks(952), "Mato Grosso", "MT" },
                    { new Guid("3891825c-a021-47fd-80b9-41f6f0aa65af"), true, null, null, new DateTime(2021, 2, 22, 18, 49, 57, 827, DateTimeKind.Local).AddTicks(948), "Paraná", "PR" },
                    { new Guid("2c3c50a5-89b9-452a-b46a-38cd86896700"), true, null, null, new DateTime(2021, 2, 22, 18, 49, 57, 827, DateTimeKind.Local).AddTicks(944), "Rio de Janeiro", "RJ" },
                    { new Guid("fb184864-8dd7-47f0-abf7-34476b6c27b1"), true, null, null, new DateTime(2021, 2, 22, 18, 49, 57, 827, DateTimeKind.Local).AddTicks(941), "Rondônia", "RO" },
                    { new Guid("16546247-b363-4fcd-b957-315db92ed63c"), true, null, null, new DateTime(2021, 2, 22, 18, 49, 57, 827, DateTimeKind.Local).AddTicks(938), "Piauí", "PI" },
                    { new Guid("5820fe67-fdb7-407d-b5cb-3108dc612a95"), true, null, null, new DateTime(2021, 2, 22, 18, 49, 57, 827, DateTimeKind.Local).AddTicks(935), "Ceará", "CE" },
                    { new Guid("8ad5f994-2da3-49cc-b8b4-2b609be7d0e0"), true, null, null, new DateTime(2021, 2, 22, 18, 49, 57, 827, DateTimeKind.Local).AddTicks(932), "Maranhão", "MA" },
                    { new Guid("274c5939-23b6-45b4-8d8b-2aef839d3413"), true, null, null, new DateTime(2021, 2, 22, 18, 49, 57, 827, DateTimeKind.Local).AddTicks(926), "Roraima", "RR" },
                    { new Guid("83048e48-c250-4b64-a9c3-2aecb9849ef8"), true, null, null, new DateTime(2021, 2, 22, 18, 49, 57, 827, DateTimeKind.Local).AddTicks(923), "Minas Gerais", "MG" },
                    { new Guid("556a4ecb-ee84-43f7-a77d-2a83172c86e5"), true, null, null, new DateTime(2021, 2, 22, 18, 49, 57, 827, DateTimeKind.Local).AddTicks(918), "Goiás", "GO" },
                    { new Guid("d3736560-3965-4386-a861-27d855079100"), true, null, null, new DateTime(2021, 2, 22, 18, 49, 57, 827, DateTimeKind.Local).AddTicks(888), "Distrito Federal", "DF" },
                    { new Guid("8b3abe67-33c1-4fda-b719-fec4ff740c23"), true, null, null, new DateTime(2021, 2, 22, 18, 49, 57, 827, DateTimeKind.Local).AddTicks(1079), "Tocantins", "TO" },
                    { new Guid("dd4d2ca7-a30a-4660-88d3-9d132916832e"), true, null, null, new DateTime(2021, 2, 22, 18, 49, 57, 827, DateTimeKind.Local).AddTicks(1084), "Exterior", "EX" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_cidade_id_estado",
                table: "tb_cidade",
                column: "id_estado");

            migrationBuilder.CreateIndex(
                name: "IX_tb_cliente_cidade_id",
                table: "tb_cliente",
                column: "cidade_id");

            migrationBuilder.CreateIndex(
                name: "IX_tb_cliente_estado_id",
                table: "tb_cliente",
                column: "estado_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_cliente");

            migrationBuilder.DropTable(
                name: "tb_cidade");

            migrationBuilder.DropTable(
                name: "tb_estado");
        }
    }
}
