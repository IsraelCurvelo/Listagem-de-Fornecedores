using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Prodam.Models.Dominio
{
    public class Fornecedor : EntidadeDominio
    {
        [Required(ErrorMessage = "{0} obrigatório")]
        [Display(Name = "Nome")]
        public String Nome { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]      
        [DataType(DataType.Date)]        
        [Display(Name = "Data de Cadastro")]
        public DateTime MomentoCadastro { get; set; }

        
        [Display(Name = "Pessoa Fisíca?")]
        public bool TipoPessoa { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]     
        [StringLength(11, MinimumLength = 11, ErrorMessage = "O {0} deve conter {1}caracteres")]
        [Display(Name = "CPF/CNPJ")]
        public String CpfCnpj { get; set; }


        public PessoaFisica DadosPessoaFisica { get; set; }

        public Empresa Empresa { get; set; }

        [NotMapped]
        public ICollection<Telefone> Telefones { get; set; } = new List<Telefone>();

        [Display(Name = "Selecione a empresa")]
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
