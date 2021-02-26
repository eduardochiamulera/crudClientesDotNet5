using CrudClientes.Domain;
using CrudClientes.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace CrudClientes.Repository
{
    public class ClienteRepository : BaseRepository<Cliente>, IClienteRepository
    {
        public static Error FormatoDocumentoInvalido = new Error("Formato de documento inválido.", "cpfcnpj");

        IQueryable<ClienteDTO> IClienteRepository.All => base.All
            .Include(x => x.Cidade)
            .Include(x => x.Estado)
            .Select(x => new ClienteDTO
            {
                Nome = x.Nome,
                TipoDocumento = x.TipoDocumento,
                Bairro = x.Bairro,
                Celular = x.Celular,
                CEP = x.CEP,
                Complemento = x.Complemento,
                CPFCNPJ = x.CPFCNPJ,
                Email = x.Email,
                Numero = x.Numero,
                Telefone = x.Telefone,
                Id = x.Id,
                Cidade = new CidadeDTO
                {
                    Id = x.Cidade != null ? x.Cidade.Id : Guid.Empty,
                    Nome = x.Cidade != null ? x.Cidade.Nome : string.Empty
                },
                Estado = new EstadoDTO
                {
                    Id = x.Estado != null ? x.Estado.Id : Guid.Empty,
                    Sigla = x.Estado != null ? x.Estado.Sigla : string.Empty
                },
            });

        public ClienteRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public new Cliente Insert(Cliente entity)
        {
            ValidaModel(entity);

            base.Insert(entity);

            return entity;
        }

        public Cliente Update(Guid id, Cliente model)
        {
            var entity = All.Where(x => x.Id == id).FirstOrDefault();

            if (entity == null || !entity.Ativo)
                throw new Exception("Registro não encontrado ou já excluído");

            entity.Nome = model.Nome;
            entity.TipoDocumento = model.TipoDocumento;
            entity.CPFCNPJ = model.CPFCNPJ;
            entity.CEP = model.CEP;
            entity.Endereco = model.Endereco;
            entity.Numero = model.Numero;
            entity.Complemento = model.Complemento;
            entity.Bairro = model.Bairro;
            entity.CidadeId = model.CidadeId;
            entity.EstadoId = model.EstadoId;
            entity.Telefone = model.Telefone;
            entity.Celular = model.Celular;
            entity.Email = model.Email;

            base.Update(entity);

            return entity;
        }

        public Cliente Detail(Guid id)
        {
            if (!All.Any(x => x.Id == id))
            {
                throw new Exception("Registro não encontrado ou já excluído");
            }
            else
            {
                var entity = All.Where(x => x.Id == id).First();
                return entity;
            }
        }

        protected void ValidaFormatoDocumento(Cliente entity)
        {
            if (!string.IsNullOrWhiteSpace(entity.CPFCNPJ.ToString()) && !string.IsNullOrEmpty(entity.CPFCNPJ.ToString()))
            {
                switch (entity.TipoDocumento)
                {
                    case "F":
                        entity.Fail(!CPF.ValidaNumero(entity.CPFCNPJ), FormatoDocumentoInvalido);
                        break;
                    case "J":
                        entity.Fail(!CNPJ.ValidaNumero(entity.CPFCNPJ), FormatoDocumentoInvalido);
                        break;
                    default:
                        entity.Fail(true, FormatoDocumentoInvalido);
                        break;
                }
            }

        }

        public override void ValidaModel(Cliente entity)
        {
            entity.Fail(string.IsNullOrEmpty(entity.Nome) || (!string.IsNullOrWhiteSpace(entity.Nome) &&
                (entity.Nome.Length == 0 || entity.Nome.Length > 100)), new Error("O campo nome deve possuir entre 1 e 100 caracteres.", "nome"));
            entity.Fail(!string.IsNullOrWhiteSpace(entity.Bairro) && entity.Bairro != null && entity.Bairro.Length > 100, new Error("O campo Bairro deve possuir entre 1 e 100 caracteres.", "bairro"));
            entity.Fail(!string.IsNullOrWhiteSpace(entity.Celular) && entity.Celular.Length > 11, new Error("O campo Celular deve possuir entre 1 e 100 caracteres.", "celular"));
            entity.Fail(!string.IsNullOrWhiteSpace(entity.Telefone) && entity.Telefone.Length > 11, new Error("O campo Telefone deve possuir entre 1 e 100 caracteres.", "telefone"));
            entity.Fail(!string.IsNullOrWhiteSpace(entity.CEP) && entity.CEP.Length > 8, new Error("O campo CEP deve possuir entre 1 e 100 caracteres.", "cep"));
            entity.Fail(!string.IsNullOrWhiteSpace(entity.TipoDocumento) && entity.TipoDocumento.Length > 1, new Error("O campo TipoDocumento deve possuir entre 1 e 100 caracteres.", "tipoDocumento"));
            entity.Fail(!string.IsNullOrWhiteSpace(entity.CPFCNPJ) && entity.CPFCNPJ.Length > 14, new Error("O campo CPFCNPJ deve possuir entre 1 e 100 caracteres.", "cpfcnpj"));
            entity.Fail(!string.IsNullOrWhiteSpace(entity.Endereco) && entity.Endereco.Length > 60, new Error("O campo Endereco deve possuir entre 1 e 100 caracteres.", "endereco"));
            entity.Fail(!string.IsNullOrWhiteSpace(entity.Numero) && entity.Numero.Length > 50, new Error("O campo Numero deve possuir entre 1 e 100 caracteres.", "numero"));
            entity.Fail(!string.IsNullOrWhiteSpace(entity.Complemento) && entity.Complemento.Length > 100, new Error("O campo Complemento deve possuir entre 1 e 100 caracteres.", "complemento"));
            entity.Fail(!string.IsNullOrWhiteSpace(entity.Email) && entity.Email.Length > 100, new Error("O campo Email deve possuir entre 1 e 100 caracteres.", "email"));
            ValidaCPFCNPJ(entity);

            base.ValidaModel(entity);
        }

        private void ValidaCPFCNPJ(Cliente entity)
        {
            if (!string.IsNullOrEmpty(entity.CPFCNPJ))
            {
                var cliente = All.AsNoTracking().FirstOrDefault(x => x.CPFCNPJ.Trim().ToUpper() == entity.CPFCNPJ.Trim().ToUpper() && x.Id != entity.Id);

                entity.Fail(cliente != null, new Error($"O CPF/CNPJ informado já foi utilizado em outro cadastro. ({entity.CPFCNPJ})", "cpfcnpj", cliente?.Id.ToString()));
            }
        }

        public void Delete(Guid id)
        {
            var entity = All.Where(x => x.Id == id).FirstOrDefault();

            if (entity == null || !entity.Ativo)
                throw new Exception("Registro não encontrado ou já excluído");

            entity.Ativo = false;
            Update(entity);
        }
    }
}
