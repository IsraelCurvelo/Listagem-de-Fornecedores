using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prodam.Models.Dominio
{
    public class Telefone : EntidadeDominio
    {
        public int Numero { get; set; }

        public int FornecedorId { get; set; }

        public Telefone()
        {
        }

        public Telefone(int id, int numero, int fornecedor): base(id)
        {
            Numero = numero;
            FornecedorId = fornecedor;
        }
    }
        
}
