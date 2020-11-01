using Prodam.Data;
using Prodam.Models.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            dalContext.Add(entidadeDominio);
            dalContext.SaveChanges();
        }

        public void Alterar(EntidadeDominio entidadeDominio)
        {

        }

        public void Excluir(EntidadeDominio entidadeDominio)
        {

        }

        public List<EntidadeDominio> Consultar(EntidadeDominio entidadeDominio)
        {
            var list = dalContext.Empresa.ToList();
            List<EntidadeDominio> resultado = new List<EntidadeDominio>();
            foreach (EntidadeDominio x in list)
            {
                resultado.Add(x);
            }

            return resultado;
        }

        public Empresa ConsultarId(int id)
        {
            var res= dalContext.Empresa.FirstOrDefault(x => x.Id == id);
            return res;
        }



    }
}
