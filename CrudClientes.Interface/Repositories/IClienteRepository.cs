using CrudClientes.Domain;
using System;
using System.Linq;

namespace CrudClientes.Interface
{
    public interface IClienteRepository
    {
        IQueryable<ClienteDTO> All { get; }

        Cliente Detail(Guid id);

        Cliente Insert(Cliente entity);

        Cliente Update(Guid id, Cliente entity);

        void Delete(Guid id);

        void AttachForUpdate(Cliente entityToUpdate);

        void DetachEntity(Cliente entityToDetach);

        void ValidaModel(Cliente entityToValidade);
    }
}
