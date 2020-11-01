using Prodam.Models.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prodam.Strategy
{
    public interface IStrategy
    {
        String Processar(EntidadeDominio entidadeDominio);
    }
}
