using System.Collections;
using System.Collections.Generic;

namespace CrudClientes.Domain
{
    public class Estado : BaseDomain
    {
        public string Sigla { get; set; }

        public string Nome { get; set; }

        public ICollection<Cidade> Cidades { get; set; }
    }
}
