using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prodam.Models.Dominio
{
    public class FornecedorPessoaJuridica : Fornecedor
    {
        public String Cnpj { get; set; }
    }
}
