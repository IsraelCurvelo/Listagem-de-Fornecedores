using Prodam.Models.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prodam.Facade
{
    public interface IFacade
    {        
            void Cadastrar(EntidadeDominio entidadeDominio);
            void Alterar(EntidadeDominio entidadeDominio);
            void Excluir(EntidadeDominio entidadeDominio);
            List<EntidadeDominio> Consultar(EntidadeDominio entidadeDominio);       
    }
}
