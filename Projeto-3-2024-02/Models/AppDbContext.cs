using Microsoft.EntityFrameworkCore;

namespace Projeto_3_2024_02.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
