using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Prodam.Models.Dominio
{
    public class Fornecedor : EntidadeDominio
    {
        public String Nome { get; set; }
        public DateTime MomentoCadastro { get; set; }

        public bool TipoPessoa { get; set; }        

        public String CpfCnpj { get; set; }


        public PessoaFisica DadosPessoaFisica { get; set; }

        public Empresa Empresa { get; set; }

        [NotMapped]
        public ICollection<Telefone> Telefones { get; set; } = new List<Telefone>();

        public int EmpresaId { get; set; }

       

        public Fornecedor()
        {
        }

        public Fornecedor(int id, string nome, bool tipoPessoa, String cpfCnpj, Empresa empresa) : base(id)
        {
            Nome = nome;            
            TipoPessoa = tipoPessoa;
            CpfCnpj = cpfCnpj;
            Empresa = empresa;

        }
    }
}
