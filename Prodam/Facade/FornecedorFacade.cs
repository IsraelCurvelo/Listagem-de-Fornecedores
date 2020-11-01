using CadastroProduto.Data.Exception;
using Microsoft.AspNetCore.Rewrite.Internal.UrlActions;
using Prodam.DAL;
using Prodam.Data;
using Prodam.Models.Dominio;
using Prodam.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prodam.Facade
{
    public class FornecedorFacade : IFacade
    {
        private readonly DALContext dalContext;

        public FornecedorFacade(DALContext dalContext)
        {
            this.dalContext = dalContext;
        }

        public void Cadastrar(EntidadeDominio entidadeDominio)
        {

            FornecedorDAL fd = new FornecedorDAL(dalContext);
            fd.Cadastrar(entidadeDominio);
        }

        public void Alterar(EntidadeDominio entidadeDominio)
        {
            FornecedorDAL fd = new FornecedorDAL(dalContext);
            fd.Alterar(entidadeDominio);
        }

        public void Excluir(EntidadeDominio entidadeDominio)
        {

        }

        public List<EntidadeDominio> Consultar(EntidadeDominio entidadeDominio)
        {
            return null;
        }
      

        public Fornecedor ConsultarFornecedor(int id)
        {
            FornecedorDAL fd = new FornecedorDAL(dalContext);
            var result = fd.ConsultarFornecedor(id);
            return result;
        }

        public ICollection<Fornecedor> ConsultarFiltro(Fornecedor fornecedor)
        {
            FornecedorDAL dal = new FornecedorDAL(dalContext);
            var consulta = dal.ConsultarFiltro(fornecedor);
            return consulta;
        }

        public String CadastrarFornecedor(EntidadeDominio entidadeDominio)
        {
            var forne = (Fornecedor)entidadeDominio;
            EmpresaDAL dal = new EmpresaDAL(dalContext);
            var empresa = dal.ConsultarId(forne.EmpresaId);

            ValidarFornecedorMenorIdade validar = new ValidarFornecedorMenorIdade();
            var confirmacao = validar.Processar(forne, empresa);

            if (confirmacao != null)
            {
                return confirmacao;
            }
            else
            {
                FornecedorDAL fd = new FornecedorDAL(dalContext);
                fd.Cadastrar(entidadeDominio);
                return null;
            }
        }

    }
}
