using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using GestaoDeLoja.Data.Entities;

namespace GestaoDeLoja.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Categorias> Categorias { get; set; }

        public DbSet<Produtos> Produtos { get; set; }

        public DbSet<ModoEntrega> ModoEntrega { get; set; }
    }
}
