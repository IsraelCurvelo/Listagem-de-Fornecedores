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

        public DbSet<Prodam.Models.Dominio.Empresa> Empresa { get; set; }
    }
}
