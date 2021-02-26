using CrudClientes.Domain;
using CrudClientes.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CrudClientes.Repository
{
    public class CidadeRepository : BaseRepository<Cidade>, ICidadeRepository
    {
        public CidadeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public IQueryable<CidadeDTO> GetCidade(Guid estadoId)
        {
            return All.Where(x => x.EstadoId == estadoId).Select(x => new CidadeDTO 
            { 
                Id = x.Id,
                Nome = x.Nome
            });

        }
    }
}
