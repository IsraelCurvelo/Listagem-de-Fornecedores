using Microsoft.EntityFrameworkCore;
using Prodam.Data;
using Prodam.Models.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prodam.DAL
{
    public class FornecedorDAL : IDAL
    {
        private readonly DALContext dalContext;
        public FornecedorDAL(DALContext dalContext)
        {
            this.dalContext = dalContext;
        }


        public void Cadastrar(EntidadeDominio entidadeDominio)
        {
            dalContext.Add(entidadeDominio);
            dalContext.SaveChanges();
        }

        public void Alterar(EntidadeDominio entidadeDominio)
        {
            if (!dalContext.Fornecedor.Any(x => x.Id == entidadeDominio.Id))
            {
                throw new ApplicationException("Fornecedor não encontrada");
            }

            try
            {
                dalContext.Update(entidadeDominio);
                dalContext.SaveChanges();
            }
            catch (ApplicationException e)
            {
                throw new ApplicationException(e.Message);
            }
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
            var result = dalContext.Fornecedor.FirstOrDefault(x => x.Id == id);
            return result;

        }
    }
}
