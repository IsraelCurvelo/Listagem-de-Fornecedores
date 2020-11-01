using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Prodam.Models.Dominio;

namespace Prodam.Data
{
    public class DALContext : DbContext
    {
        public DALContext (DbContextOptions<DALContext> options)
            : base(options)
        {
        }

        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<Fornecedor> Fornecedor { get; set; }
        public DbSet<Telefone> Telefone { get; set; }
        public DbSet<PessoaFisica> PessoaFisica { get; set; }
    }
}
