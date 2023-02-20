using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Server.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<CartaoPonto> CartaoPonto { get; set; }
    }
}
