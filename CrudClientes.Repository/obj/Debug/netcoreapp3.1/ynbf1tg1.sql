CREATE TABLE IF NOT EXISTS "__EFMigrationsHistory" (
    "MigrationId" character varying(150) NOT NULL,
    "ProductVersion" character varying(32) NOT NULL,
    CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY ("MigrationId")
);

START TRANSACTION;

CREATE TABLE tb_estado (
    id uuid NOT NULL,
    sigla character varying(2) NOT NULL,
    nome character varying(100) NOT NULL,
    data_inclusao Date NOT NULL,
    data_alteracao Date NULL,
    data_exclusao Date NULL,
    ativo boolean NOT NULL,
    CONSTRAINT "PK_tb_estado" PRIMARY KEY (id)
);

CREATE TABLE tb_cidade (
    id uuid NOT NULL,
    nome character varying(100) NOT NULL,
    id_estado uuid NOT NULL,
    data_inclusao Date NOT NULL,
    data_alteracao Date NULL,
    data_exclusao Date NULL,
    ativo boolean NOT NULL,
    CONSTRAINT "PK_tb_cidade" PRIMARY KEY (id),
    CONSTRAINT "FK_tb_cidade_tb_estado_id_estado" FOREIGN KEY (id_estado) REFERENCES tb_estado (id) ON DELETE CASCADE
);

CREATE TABLE tb_cliente (
    id uuid NOT NULL,
    nome character varying(100) NOT NULL,
    tipo_documento character varying(1) NOT NULL,
    cpfcnpj character varying(14) NULL,
    cep character varying(8) NULL,
    endereco character varying(60) NULL,
    numero character varying(50) NULL,
    complemento character varying(100) NULL,
    bairro character varying(100) NULL,
    cidade_id uuid NULL,
    estado_id uuid NULL,
    telefone character varying(11) NULL,
    celular character varying(11) NULL,
    email character varying(100) NULL,
    data_inclusao Date NOT NULL,
    data_alteracao Date NULL,
    data_exclusao Date NULL,
    ativo boolean NOT NULL,
    CONSTRAINT "PK_tb_cliente" PRIMARY KEY (id),
    CONSTRAINT "FK_tb_cliente_tb_cidade_cidade_id" FOREIGN KEY (cidade_id) REFERENCES tb_cidade (id) ON DELETE RESTRICT,
    CONSTRAINT "FK_tb_cliente_tb_estado_estado_id" FOREIGN KEY (estado_id) REFERENCES tb_estado (id) ON DELETE RESTRICT
);

INSERT INTO tb_estado (id, ativo, data_alteracao, data_exclusao, data_inclusao, nome, sigla)
VALUES ('f5fcbc8c-fef6-4912-bdf7-207cc38a1165', TRUE, NULL, NULL, DATE '2021-02-22', 'Acre', 'AC');
INSERT INTO tb_estado (id, ativo, data_alteracao, data_exclusao, data_inclusao, nome, sigla)
VALUES ('82146413-7cf2-41d8-8eaa-fcdcad37d863', TRUE, NULL, NULL, DATE '2021-02-22', 'Sergipe', 'SE');
INSERT INTO tb_estado (id, ativo, data_alteracao, data_exclusao, data_inclusao, nome, sigla)
VALUES ('def11262-9538-43d4-8ff1-f57f3593ad36', TRUE, NULL, NULL, DATE '2021-02-22', 'Amazonas', 'AM');
INSERT INTO tb_estado (id, ativo, data_alteracao, data_exclusao, data_inclusao, nome, sigla)
VALUES ('37b29aa5-7bf0-4304-ab8b-f09a9e40686a', TRUE, NULL, NULL, DATE '2021-02-22', 'Espírito Santo', 'ES');
INSERT INTO tb_estado (id, ativo, data_alteracao, data_exclusao, data_inclusao, nome, sigla)
VALUES ('81f4c793-c448-4baa-acc8-ef1f8b634785', TRUE, NULL, NULL, DATE '2021-02-22', 'Bahia', 'BA');
INSERT INTO tb_estado (id, ativo, data_alteracao, data_exclusao, data_inclusao, nome, sigla)
VALUES ('bf3ac31f-a12a-4f43-ac4c-e835444661e8', TRUE, NULL, NULL, DATE '2021-02-22', 'Amapá', 'AP');
INSERT INTO tb_estado (id, ativo, data_alteracao, data_exclusao, data_inclusao, nome, sigla)
VALUES ('ede334eb-bdf3-4cb3-8819-cbc6a9265f5a', TRUE, NULL, NULL, DATE '2021-02-22', 'Rio Grande do Norte', 'RN');
INSERT INTO tb_estado (id, ativo, data_alteracao, data_exclusao, data_inclusao, nome, sigla)
VALUES ('573be76f-428c-4cde-9400-c7b402f16fc9', TRUE, NULL, NULL, DATE '2021-02-22', 'Mato Grosso do Sul', 'MS');
INSERT INTO tb_estado (id, ativo, data_alteracao, data_exclusao, data_inclusao, nome, sigla)
VALUES ('a21b30fe-2f2c-4670-8a45-b24c56a82e9b', TRUE, NULL, NULL, DATE '2021-02-22', 'Alagoas', 'AL');
INSERT INTO tb_estado (id, ativo, data_alteracao, data_exclusao, data_inclusao, nome, sigla)
VALUES ('f32443a4-f172-42e9-84fc-b05e1f12fc31', TRUE, NULL, NULL, DATE '2021-02-22', 'Santa Catarina', 'SC');
INSERT INTO tb_estado (id, ativo, data_alteracao, data_exclusao, data_inclusao, nome, sigla)
VALUES ('424df1b9-38a8-485b-a241-ab9ed231d54c', TRUE, NULL, NULL, DATE '2021-02-22', 'Pernambuco', 'PE');
INSERT INTO tb_estado (id, ativo, data_alteracao, data_exclusao, data_inclusao, nome, sigla)
VALUES ('fda8bc5c-5fdb-4451-841c-a746705e620c', TRUE, NULL, NULL, DATE '2021-02-22', 'Rio Grande do Sul', 'RS');
INSERT INTO tb_estado (id, ativo, data_alteracao, data_exclusao, data_inclusao, nome, sigla)
VALUES ('52e3277b-e0e2-49ec-8976-a6d84f13741c', TRUE, NULL, NULL, DATE '2021-02-22', 'Pará', 'PA');
INSERT INTO tb_estado (id, ativo, data_alteracao, data_exclusao, data_inclusao, nome, sigla)
VALUES ('4dc9f47e-e560-4cb6-9d0c-862dbecaf89b', TRUE, NULL, NULL, DATE '2021-02-22', 'Paraíba', 'PB');
INSERT INTO tb_estado (id, ativo, data_alteracao, data_exclusao, data_inclusao, nome, sigla)
VALUES ('ec896b88-084f-4b18-8f07-736cfe6e337d', TRUE, NULL, NULL, DATE '2021-02-22', 'São Paulo', 'SP');
INSERT INTO tb_estado (id, ativo, data_alteracao, data_exclusao, data_inclusao, nome, sigla)
VALUES ('92b220e9-c472-481f-a943-444ac5dc00b8', TRUE, NULL, NULL, DATE '2021-02-22', 'Mato Grosso', 'MT');
INSERT INTO tb_estado (id, ativo, data_alteracao, data_exclusao, data_inclusao, nome, sigla)
VALUES ('3891825c-a021-47fd-80b9-41f6f0aa65af', TRUE, NULL, NULL, DATE '2021-02-22', 'Paraná', 'PR');
INSERT INTO tb_estado (id, ativo, data_alteracao, data_exclusao, data_inclusao, nome, sigla)
VALUES ('2c3c50a5-89b9-452a-b46a-38cd86896700', TRUE, NULL, NULL, DATE '2021-02-22', 'Rio de Janeiro', 'RJ');
INSERT INTO tb_estado (id, ativo, data_alteracao, data_exclusao, data_inclusao, nome, sigla)
VALUES ('fb184864-8dd7-47f0-abf7-34476b6c27b1', TRUE, NULL, NULL, DATE '2021-02-22', 'Rondônia', 'RO');
INSERT INTO tb_estado (id, ativo, data_alteracao, data_exclusao, data_inclusao, nome, sigla)
VALUES ('16546247-b363-4fcd-b957-315db92ed63c', TRUE, NULL, NULL, DATE '2021-02-22', 'Piauí', 'PI');
INSERT INTO tb_estado (id, ativo, data_alteracao, data_exclusao, data_inclusao, nome, sigla)
VALUES ('5820fe67-fdb7-407d-b5cb-3108dc612a95', TRUE, NULL, NULL, DATE '2021-02-22', 'Ceará', 'CE');
INSERT INTO tb_estado (id, ativo, data_alteracao, data_exclusao, data_inclusao, nome, sigla)
VALUES ('8ad5f994-2da3-49cc-b8b4-2b609be7d0e0', TRUE, NULL, NULL, DATE '2021-02-22', 'Maranhão', 'MA');
INSERT INTO tb_estado (id, ativo, data_alteracao, data_exclusao, data_inclusao, nome, sigla)
VALUES ('274c5939-23b6-45b4-8d8b-2aef839d3413', TRUE, NULL, NULL, DATE '2021-02-22', 'Roraima', 'RR');
INSERT INTO tb_estado (id, ativo, data_alteracao, data_exclusao, data_inclusao, nome, sigla)
VALUES ('83048e48-c250-4b64-a9c3-2aecb9849ef8', TRUE, NULL, NULL, DATE '2021-02-22', 'Minas Gerais', 'MG');
INSERT INTO tb_estado (id, ativo, data_alteracao, data_exclusao, data_inclusao, nome, sigla)
VALUES ('556a4ecb-ee84-43f7-a77d-2a83172c86e5', TRUE, NULL, NULL, DATE '2021-02-22', 'Goiás', 'GO');
INSERT INTO tb_estado (id, ativo, data_alteracao, data_exclusao, data_inclusao, nome, sigla)
VALUES ('d3736560-3965-4386-a861-27d855079100', TRUE, NULL, NULL, DATE '2021-02-22', 'Distrito Federal', 'DF');
INSERT INTO tb_estado (id, ativo, data_alteracao, data_exclusao, data_inclusao, nome, sigla)
VALUES ('8b3abe67-33c1-4fda-b719-fec4ff740c23', TRUE, NULL, NULL, DATE '2021-02-22', 'Tocantins', 'TO');
INSERT INTO tb_estado (id, ativo, data_alteracao, data_exclusao, data_inclusao, nome, sigla)
VALUES ('dd4d2ca7-a30a-4660-88d3-9d132916832e', TRUE, NULL, NULL, DATE '2021-02-22', 'Exterior', 'EX');

CREATE UNIQUE INDEX "IX_tb_cidade_id_estado" ON tb_cidade (id_estado);

CREATE UNIQUE INDEX "IX_tb_cliente_cidade_id" ON tb_cliente (cidade_id);

CREATE UNIQUE INDEX "IX_tb_cliente_estado_id" ON tb_cliente (estado_id);

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20210222204222_Init', '5.0.3');

COMMIT;

