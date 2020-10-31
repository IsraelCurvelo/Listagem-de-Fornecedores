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

        public String Cadastrar(EntidadeDominio entidadeDominio)
        {
            return null;
        }

        public void Alterar(EntidadeDominio entidadeDominio)
        {

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
