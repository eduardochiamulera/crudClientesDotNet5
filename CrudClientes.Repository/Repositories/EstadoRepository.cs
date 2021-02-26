using CrudClientes.Domain;
using CrudClientes.Interface;
using System.Collections.Generic;
using System.Linq;

namespace CrudClientes.Repository
{
    public class EstadoRepository : BaseRepository<Estado>, IEstadoRepository
    {
        public EstadoRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        IQueryable<EstadoDTO> IEstadoRepository.All => base.All
            .Select(x => new EstadoDTO
            {
                    Id = x.Id,
                    Sigla = x.Sigla,
                    Nome = x.Nome,
            });
    }
}
