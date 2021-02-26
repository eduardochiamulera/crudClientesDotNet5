using CrudClientes.Domain;
using System;
using System.Linq;

namespace CrudClientes.Interface
{
    public interface ICidadeRepository
    {
        IQueryable<CidadeDTO> GetCidade(Guid estadoId);
    }
}
