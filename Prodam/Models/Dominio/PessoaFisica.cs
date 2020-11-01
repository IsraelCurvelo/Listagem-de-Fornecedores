using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prodam.Models.Dominio
{
    public class PessoaFisica : EntidadeDominio
    {
        [Required(ErrorMessage = "{0} obrigatório")]
        [StringLength(9, MinimumLength = 9, ErrorMessage = "O {0} deve conter {1}caracteres")]
        [Display(Name = "RG")]
        public String Rg { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "{0} obrigatório")]
        [Display(Name = "Data de Nascimento")]
        public DateTime DataNascimento { get; set; }

        public int FornecedorId { get; set; }

        public PessoaFisica()
        {
        }

        public PessoaFisica(int id, string rg, DateTime dataNascimento, int fornId): base(id)
        {
            Rg = rg;
            DataNascimento = dataNascimento;
            FornecedorId = fornId;
        }
    }
}
