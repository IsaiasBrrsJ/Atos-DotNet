using AtosEntityCodeFirst.DataModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtosEntityCodeFirst
{
    class Contexto : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Email> Emails { get; set; }

        public Contexto() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string configBanco = @"Data Source=localhost;initial Catalog=AtosEntity2;User ID=AtosEntity2;password=admin123;language=Portuguese;Trusted_Connection=True;TrustServerCertificate=True;";

            optionsBuilder.UseSqlServer(configBanco);

            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Email>()
                .HasOne(e => e.pessoa)
                .WithMany(e => e.Emails)
                .OnDelete(DeleteBehavior.Cascade);
        }

    }
}
