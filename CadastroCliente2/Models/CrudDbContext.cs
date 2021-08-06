using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Data.SQLite;

namespace CadastroCliente2.Models
{
    public class CrudDbContext : DbContext
    {
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Situacoes> Situacoes { get; set; }

        public CrudDbContext(DbContextOptions<CrudDbContext> options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            //            base.OnConfiguring(optionsBuilder);

            //optionsBuilder.UseSqlite($"Data Source={"crudnetcoremvc.db"};");
            //optionsBuilder.EnableSensitiveDataLogging();

            if (!optionsBuilder.IsConfigured)
            {
                _ = optionsBuilder.UseSqlite("DataSource=crudnetcoremvc.db");
            }
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
            .Entity<Clientes>()
            .HasOne(p => p.Situacao);

            base.OnModelCreating(modelBuilder);
        }
    }
}
