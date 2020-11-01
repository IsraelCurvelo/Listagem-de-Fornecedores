using Prodam.DAL;
using Prodam.Data;
using Prodam.Models.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prodam.Facade
{
    public class TelefoneFacade : IFacade
    {
        private readonly DALContext dalContext;

        public TelefoneFacade(DALContext dalContext)
        {
            this.dalContext = dalContext;
        }

        public void Cadastrar(EntidadeDominio entidadeDominio)
        {
            TelefoneDAL fd = new TelefoneDAL(dalContext);
            fd.Cadastrar(entidadeDominio);
        }

        public void Alterar(EntidadeDominio entidadeDominio)
        {
            TelefoneDAL fd = new TelefoneDAL(dalContext);
            fd.Alterar(entidadeDominio);
        }

        public void Excluir(EntidadeDominio entidadeDominio)
        {

        }

        public List<EntidadeDominio> Consultar(EntidadeDominio entidadeDominio)
        {
            return null;
        }
    }
}
