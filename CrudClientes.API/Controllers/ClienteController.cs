using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.Extensions.DependencyInjection;
using CrudClientes.Domain;
using CrudClientes.Interface;
using System.Linq;
using Microsoft.AspNetCore.Cors;

namespace CrudClientes.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : AppBaseController
    {
        public ClienteController(IServiceProvider serviceProvider) : base(serviceProvider) { }

        [HttpGet]
        public IQueryable<ClienteDTO>  Get()
        {
            return GetService<IClienteRepository>().All;
        }

        [HttpGet]
        [Route("detail")]
        public IActionResult Get(Guid id)
        {
            try
            {
                var cliente = GetService<IClienteRepository>().Detail(id);

                return Ok(new ClienteDTO
                {
                    Nome = cliente.Nome,
                    TipoDocumento = cliente.TipoDocumento,
                    Bairro = cliente.Bairro,
                    Celular = cliente.Celular,
                    CEP = cliente.CEP,
                    Complemento = cliente.Complemento,
                    CPFCNPJ = cliente.CPFCNPJ,
                    Email = cliente.Email,
                    Numero = cliente.Numero,
                    Telefone = cliente.Telefone,
                    CidadeId = cliente.CidadeId,
                    EstadoId = cliente.EstadoId,
                    Id = cliente.Id
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
           
        }

        [HttpPost]
        public IActionResult Post(ClienteDTO entity)
        {
            if (entity == null)
                return BadRequest(ModelState);

            try
            {
                var cliente = RetornaCliente(entity);

                cliente = GetService<IClienteRepository>().Insert(cliente);

                return Ok(new ClienteDTO
                {
                    Nome = cliente.Nome,
                    TipoDocumento = cliente.TipoDocumento,
                    Bairro = cliente.Bairro,
                    Celular = cliente.Celular,
                    CEP = cliente.CEP,
                    Complemento = cliente.Complemento,
                    CPFCNPJ = cliente.CPFCNPJ,
                    Email = cliente.Email,
                    Numero = cliente.Numero,
                    Telefone = cliente.Telefone,
                    CidadeId = cliente.CidadeId,
                    EstadoId = cliente.EstadoId,
                    Id = cliente.Id
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult Put([FromQuery] Guid id, [FromBody] ClienteDTO entity)
        {
            if (entity == null || id == default(Guid))
                return BadRequest(ModelState);

            try
            {
                var cliente = RetornaCliente(entity);

                cliente = GetService<IClienteRepository>().Update(id, cliente);

                return Ok(new ClienteDTO
                {
                    Nome = cliente.Nome,
                    TipoDocumento = cliente.TipoDocumento,
                    Bairro = cliente.Bairro,
                    Celular = cliente.Celular,
                    CEP = cliente.CEP,
                    Complemento = cliente.Complemento,
                    CPFCNPJ = cliente.CPFCNPJ,
                    Email = cliente.Email,
                    Numero = cliente.Numero,
                    Telefone = cliente.Telefone,
                    CidadeId = cliente.CidadeId,
                    EstadoId = cliente.EstadoId,
                    Id = cliente.Id

                });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        public IActionResult Delete([FromQuery] Guid id)
        {
            if (id == default(Guid))
                return BadRequest(ModelState);

            try
            {
                GetService<IClienteRepository>().Delete(id);

                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        private static Cliente RetornaCliente(ClienteDTO entity)
        {
            return new Cliente
            {
                Nome = entity.Nome,
                TipoDocumento = entity.TipoDocumento,
                Bairro = entity.Bairro,
                Celular = entity.Celular,
                CEP = entity.CEP,
                Complemento = entity.Complemento,
                CPFCNPJ = entity.CPFCNPJ,
                Email = entity.Email,
                Numero = entity.Numero,
                Telefone = entity.Telefone,
                CidadeId = entity.CidadeId,
                EstadoId = entity.EstadoId
            };
        }

    }
}
