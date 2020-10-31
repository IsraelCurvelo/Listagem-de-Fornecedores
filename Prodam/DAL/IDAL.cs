using Prodam.Models.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prodam.DAL
{
    public interface IDAL
    {

        void Cadastrar(EntidadeDominio entidadeDominio);

        void Alterar(EntidadeDominio entidadeDominio);

        void Excluir(EntidadeDominio entidadeDominio);

        List<EntidadeDominio> Consultar(EntidadeDominio entidadeDominio);

    }
}
