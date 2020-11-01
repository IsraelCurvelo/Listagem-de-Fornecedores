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
        [RegularExpression("^(?!0+$)(\\+\\d{1,3}[- ]?)?(?!0+$)\\d{10,15}$", ErrorMessage = "Digite um numero de telefone válido")]
        public String Numero { get; set; }

        public int FornecedorId { get; set; }

        public Telefone()
        {
        }

        public Telefone(int id, String numero, int fornecedor): base(id)
        {
            Numero = numero;
            FornecedorId = fornecedor;
        }
    }
        
}
