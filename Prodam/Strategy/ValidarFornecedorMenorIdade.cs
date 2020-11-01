using Prodam.DAL;
using Prodam.Models.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prodam.Strategy
{
    public class ValidarFornecedorMenorIdade : IStrategy
    {
        public String Processar(Fornecedor fornecedor, Empresa empresa)
        {
            String estado = "SP";

            if (fornecedor.TipoPessoa == false)
            {
                return null;
            }



            if (empresa.Uf == estado)
            {
                int AnoBase = DateTime.Today.Year - 18;

                if (fornecedor.DadosPessoaFisica.DataNascimento.Year > AnoBase)
                {
                    return "Fornecedor menor de idade";
                }

                if (AnoBase == fornecedor.DadosPessoaFisica.DataNascimento.Year)
                {
                    if (fornecedor.DadosPessoaFisica.DataNascimento.Month < DateTime.Now.Month)
                    {
                        return "Fornecedor menor de idade";
                    }
                    if (fornecedor.DadosPessoaFisica.DataNascimento.Month == DateTime.Now.Month)
                    {
                        if (fornecedor.DadosPessoaFisica.DataNascimento.Day <= DateTime.Now.Day)
                        {
                            return "Fornecedor menor de idade";
                        }
                    }
                }
                return null;
            }

            return null;
        }
    }
}
