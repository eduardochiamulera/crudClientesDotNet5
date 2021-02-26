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
    public class EstadoController : AppBaseController
    {
        public EstadoController(IServiceProvider serviceProvider) : base(serviceProvider) { }

        [HttpGet]
        public IQueryable<EstadoDTO>  Get()
        {
            return GetService<IEstadoRepository>().All;
        }

    }
}
