using System;

namespace CrudClientes.Domain
{
    public class EstadoDTO : BaseDomainDTO
    {
        public string Nome { get; set; }
        public string Sigla { get; set; }
    }
}
