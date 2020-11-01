using Microsoft.EntityFrameworkCore;
using Prodam.Data;
using Prodam.Models.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public Fornecedor ConsultarFiltro(int id)
        {
            try
            {
                var fornecedor = dalContext.Fornecedor
                    .Include(obj => obj.Empresa)
                    .Include(obj => obj.DadosPessoaFisica)
                    .FirstOrDefault(x => x.Id == id);

                var res = dalContext.PessoaFisica.FirstOrDefault(x => x.FornecedorId == id);

                fornecedor.DadosPessoaFisica = res;

                if (fornecedor == null)
                {
                    return null;
                }
                TelefoneDAL dal = new TelefoneDAL(dalContext);
                var telefone = dal.ConsultarFornecedor(id);
                fornecedor.Telefones = telefone;

                return fornecedor;
            }
            catch (ApplicationException e)
            {
                throw new ApplicationException(e.Message);
            }
        }

        public ICollection<Fornecedor> ConsultarFiltro(Fornecedor fornecedor)
        {
            HashSet<Fornecedor> consulta = new HashSet<Fornecedor>();


            if (fornecedor.Nome != null)
            {
                var resultado = dalContext.Fornecedor.Where(x => x.Nome == fornecedor.Nome).ToList();
                foreach (Fornecedor item in resultado)
                {
                    var prod = ConsultarFiltro(item.Id);
                    consulta.Add(prod);
                }
            }

            if (fornecedor.CpfCnpj != null)
            {
                var resultado = dalContext.Fornecedor.Where(x => x.CpfCnpj == fornecedor.CpfCnpj).ToList();
                foreach (Fornecedor item in resultado)
                {
                    var prod = ConsultarFiltro(item.Id);
                    consulta.Add(prod);
                }
            }

            if (fornecedor.MomentoCadastro != null)
            {
                var resultado = dalContext.Fornecedor.Where(x => x.MomentoCadastro == fornecedor.MomentoCadastro).ToList();
                foreach (Fornecedor item in resultado)
                {
                    var prod = ConsultarFiltro(item.Id);
                    consulta.Add(prod);
                }
            }

            return consulta;
        }
    }
}
