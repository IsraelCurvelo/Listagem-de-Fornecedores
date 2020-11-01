using Prodam.Models.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prodam.Strategy
{
    public class ValidarFornecedorMenorIdade : IStrategy
    {
        public String Processar(EntidadeDominio entidadeDominio)
        {
            /*
          var obj = (Fornecedor)entidadeDominio;
          if (obj.TipoPessoa == false)
          {
              return null;
          }


          if(obj.Empresa.Uf == "SP")
          {

              DateTime agora = DateTime.Now;
              TimeSpan diferenca = agora.Subtract(obj.MomentoCadastro);

              if(diferenca.TotalDays < 6570)
              {
                  return "Fornecedor menor";
              }
              else
              {
                  return null;
              }

          }
         */
            return null;
        }
    }
}
