using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prodam.Models.Dominio
{
    public abstract class Fornecedor : EntidadeDominio
    {
        public String Nome { get; set; }
        public DateTime MomentoCadastro { get; set; }
        public List<int> Telefone { get; set; }

        public Empresa Empresa { get; set; }

        public TipoPessoa TipoPessoa { get; set; }

    }
}
