using Tienda.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tienda.DataAccess
{
    public class TiendaDBContext : DbContext
    {
        public DbSet<Registro> Registros { get; set; }

        public TiendaDBContext(DbContextOptions<TiendaDBContext> options) : base(options)
        {

        }

        public TiendaDBContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=registro.db");
        }
    }
}
