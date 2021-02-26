using System;

namespace CrudClientes.Domain
{
    public class ClienteDTO : BaseDomainDTO
    {
        public string Nome { get; set; }

        public string TipoDocumento { get; set; }

        public string CPFCNPJ { get; set; }

        public string CEP { get; set; }

        public string Endereco { get; set; }

        public string Numero { get; set; }

        public string Complemento { get; set; }

        public string Bairro { get; set; }

        public Guid? CidadeId { get; set; }

        public Guid? EstadoId { get; set; }

        public string Telefone { get; set; }

        public string Celular { get; set; }

        public string Email { get; set; }

        public virtual CidadeDTO Cidade { get; set; }
        public virtual EstadoDTO Estado { get; set; }

    }
}
