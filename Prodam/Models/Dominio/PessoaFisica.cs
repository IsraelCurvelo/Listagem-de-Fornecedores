using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prodam.Models.Dominio
{
    public class PessoaFisica : EntidadeDominio
    {
        public String Rg { get; set; }
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
