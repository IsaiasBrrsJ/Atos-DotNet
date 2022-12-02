using Microsoft.EntityFrameworkCore;
using PrimeiraAulaAPI.DataModel;

namespace PrimeiraAulaAPI
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string configBanco = @"Data Source=localhost;initial Catalog=primeiraAulaApi;User ID=AtosEntity2;password=sed-09lim;language=Portuguese;Trusted_Connection=True;TrustServerCertificate=True;";

            optionsBuilder.UseSqlServer(configBanco);


        }

        public DbSet<Pessoa> Pessoas { get; set; }
    }
}
