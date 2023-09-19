using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistemaOficinaNT.Models;

namespace SistemaOficinaNT.Data
{
    public class SistemaOficinaNTContext : DbContext
    {
        public SistemaOficinaNTContext (DbContextOptions<SistemaOficinaNTContext> options)
            : base(options)
        {
        }

        public DbSet<SistemaOficinaNT.Models.Request> Request { get; set; } = default!;

        public DbSet<SistemaOficinaNT.Models.Compra> Compra { get; set; } = default!;
    }
}
