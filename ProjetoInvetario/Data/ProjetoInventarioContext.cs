using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoInventario.Models;

namespace ProjetoInventario.Data
{
    public class ProjetoInventarioContext : DbContext
    {
        public ProjetoInventarioContext (DbContextOptions<ProjetoInventarioContext> options)
            : base(options)
        {
        }

        public DbSet<ProjetoInventario.Models.Produtos> Produtos { get; set; }
    }
}
