using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prodam.Models.Dominio
{
    public class FornecedorPessoaFisica : Fornecedor
    {
        public String Cpf { get; set; }
        public String Rg { get; set; }

        public DateTime DataNascimento { get; set; }
    }
}
