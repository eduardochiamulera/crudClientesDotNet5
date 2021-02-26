using System;
using System.ComponentModel.DataAnnotations;

namespace CrudClientes.Domain
{
    public class Cidade : BaseDomain
    {
        [Required]
        [StringLength(35)]
        public string Nome { get; set; }

        [Required]
        [Display(Name = "Estado")]
        public Guid EstadoId { get; set; }

        public virtual Estado Estado { get; set; }
    }
}
