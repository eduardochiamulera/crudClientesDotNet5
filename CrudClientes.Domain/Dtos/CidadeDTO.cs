using System;

namespace CrudClientes.Domain
{
    public class CidadeDTO : BaseDomainDTO
    {
        public string Nome { get; set; }
        public Guid EstadoId { get; set; }
        public virtual EstadoDTO Estado { get; set; }
    }
}
