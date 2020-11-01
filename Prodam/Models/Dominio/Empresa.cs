using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prodam.Models.Dominio
{
    public class Empresa : EntidadeDominio
    {
        [Required(ErrorMessage = "{0} obrigatório")]
        [Display(Name = "Estado")]
        [StringLength(2, MinimumLength = 2, ErrorMessage = "O {0} tem que ter {2} digitos")]
        public String Uf { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        [Display(Name = "Nome Fantasia")]
        public String Nome { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "O {0} deve conter {1}caracteres")]
        [Display(Name = "CNPJ")]
        public String Cnpj { get; set; }

        public Empresa()
        {
        }

        public Empresa(int id, string uf, string nome, string cnpj) : base(id)
        {
            Uf = uf;
            Nome = nome;
            Cnpj = cnpj;
        }
    }
}
