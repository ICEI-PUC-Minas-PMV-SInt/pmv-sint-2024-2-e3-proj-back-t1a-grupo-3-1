using Microsoft.EntityFrameworkCore;

namespace Projeto_1._0_eixo3_2024.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Cachorro> Cachorros { get; set; }

        public DbSet<Alimentacao> Alimentacoes { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
