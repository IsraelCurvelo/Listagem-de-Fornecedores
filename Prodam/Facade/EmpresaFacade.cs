using Prodam.DAL;
using Prodam.Data;
using Prodam.Models.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prodam.Facade
{
    public class EmpresaFacade : IFacade
    {
        private readonly DALContext dalContext;

        public EmpresaFacade(DALContext dalContext)
        {
            this.dalContext = dalContext;
        }

        public void Cadastrar(EntidadeDominio entidadeDominio)
        {
            EmpresaDAL dal = new EmpresaDAL(dalContext);
            dal.Cadastrar(entidadeDominio);           
        }

        public void Alterar(EntidadeDominio entidadeDominio)
        {

        }

        public void Excluir(EntidadeDominio entidadeDominio)
        {

        }

        public List<EntidadeDominio> Consultar(EntidadeDominio entidadeDominio)
        {
            EmpresaDAL ed = new EmpresaDAL(dalContext);

            List<EntidadeDominio> list = new List<EntidadeDominio>();
            list = ed.Consultar(entidadeDominio);
            return list;
        }
    }
}
