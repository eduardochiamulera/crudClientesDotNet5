using CrudClientes.Domain;
using System;
using System.Linq;

namespace CrudClientes.Interface
{
    public interface IEstadoRepository
    {
        IQueryable<EstadoDTO> All { get; }

    }
}
