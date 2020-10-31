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
        public List<int> Telefone { get; set; } = new List<int>();

        public List<Empresa> Empresas { get; set; } = new List<Empresa>();

        public TipoPessoa TipoPessoa { get; set; }

        protected Fornecedor()
        {
        }

        protected Fornecedor(int id, string nome, DateTime momentoCadastro, TipoPessoa tipoPessoa): base(id)
        {
            Nome = nome;
            MomentoCadastro = momentoCadastro;
            TipoPessoa = tipoPessoa;
        }
    }
}
