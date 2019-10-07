using ItemsAPI.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItemsAPI.DAL
{
    public class ItemsAPIContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Database=DBItensApi;Trusted_Connection=true;");
        }

        public ItemsAPIContext() : base()
        {
        }

        public DbSet<Pais> Pais { get; set; }
        public DbSet<Estado> Estado { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

    }
}
