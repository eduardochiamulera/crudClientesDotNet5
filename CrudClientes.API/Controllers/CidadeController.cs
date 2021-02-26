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
    public class CidadeController : AppBaseController
    {
        public CidadeController(IServiceProvider serviceProvider) : base(serviceProvider) { }

        [HttpGet]
        public IActionResult Get(Guid estadoId)
        {
            try
            {
                return Ok(GetService<ICidadeRepository>().GetCidade(estadoId));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
           
        }

    }
}
