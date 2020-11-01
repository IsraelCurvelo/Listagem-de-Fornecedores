using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prodam.Models.Dominio
{
    public class Telefone : EntidadeDominio
    {
        public int Numero { get; set; }

        public Fornecedor Fornecedor { get; set; }

        public Telefone()
        {
        }

        public Telefone(int id, int numero, Fornecedor fornecedor): base(id)
        {
            Numero = numero;
            Fornecedor = fornecedor;
        }
    }
        
}
