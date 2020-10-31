using Prodam.Data;
using Prodam.Models.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prodam.DAL
{
    public class EmpresaDAL : IDAL
    {
        private readonly DALContext dalContext;
        public EmpresaDAL(DALContext dalContext)
        {
            this.dalContext = dalContext;
        }


        public void Cadastrar(EntidadeDominio entidadeDominio)
        {

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
