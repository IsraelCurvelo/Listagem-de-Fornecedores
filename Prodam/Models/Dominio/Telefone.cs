using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prodam.Models.Dominio
{
    public class Telefone : EntidadeDominio
    {
       
        [Display(Name = "Telefone")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "O {0} deve conter {1}caracteres")]
        public int Numero { get; set; }

        public int FornecedorId { get; set; }

        public Telefone()
        {
        }

        public Telefone(int id, int numero, int fornecedor): base(id)
        {
            Numero = numero;
            FornecedorId = fornecedor;
        }
    }
        
}
