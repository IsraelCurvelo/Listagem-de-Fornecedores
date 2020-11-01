using Prodam.Data;
using Prodam.Models.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prodam.DAL
{
    public class TelefoneDAL : IDAL
    {
        private readonly DALContext dalContext;
        public TelefoneDAL(DALContext dalContext)
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
            var list = dalContext.Telefone.ToList();
            List<EntidadeDominio> resultado = new List<EntidadeDominio>();
            foreach (EntidadeDominio x in list)
            {
                resultado.Add(x);
            }

            return resultado;
        }

        public List<Telefone> ConsultarFornecedor(int id)
        {
           // var list = dalContext.Telefone.Where(x => x.FornecedorId == id).ToList();
            return null;
        }
    }
}
