using Microsoft.EntityFrameworkCore;
using APIMoedas.Models;

namespace APIMoedas.Data
{
    public class MoedasContext : DbContext
    {
        public DbSet<Cotacao> Cotacoes { get; set; }

        public MoedasContext(DbContextOptions<MoedasContext> options) :
            base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cotacao>()
                .HasKey(c => c.Sigla);
        }
    }
}