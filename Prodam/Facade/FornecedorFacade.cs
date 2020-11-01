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
            ValidarFornecedorMenorIdade validar = new ValidarFornecedorMenorIdade();
            var confirmacao = validar.Processar(entidadeDominio);

            if (confirmacao != null)
            {
                throw new Exception(confirmacao);
            }
            else
            {
                FornecedorDAL fd = new FornecedorDAL(dalContext);
                fd.Cadastrar(entidadeDominio);
            }
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

        public List<Fornecedor> ConsultarFiltro(Fornecedor forn)
        {
            return null;
        }

        public Fornecedor ConsultarFornecedor(int id)
        {
            FornecedorDAL fd = new FornecedorDAL(dalContext);
            var result = fd.ConsultarFornecedor(id);
            return result;
        }


    }
}
