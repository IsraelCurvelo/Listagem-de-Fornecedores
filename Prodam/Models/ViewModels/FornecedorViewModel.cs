using Prodam.Models.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prodam.Models.ViewModels
{
    public class FornecedorViewModel : EntidadeDominio
    {
        public Fornecedor Fornecedor { get; set; }
        public ICollection<Empresa> Empresas { get; set; }
    }
}
