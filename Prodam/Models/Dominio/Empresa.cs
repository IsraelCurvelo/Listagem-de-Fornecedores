using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prodam.Models.Dominio
{
    public class Empresa : EntidadeDominio
    {
        public String Uf { get; set; }
        public String Nome { get; set; }

        public String Cnpj { get; set; }
    }
}
