using Microsoft.EntityFrameworkCore;
using zyra.Model;

namespace zyra.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tema>().ToTable("tb_tema");
        }

        public DbSet<Tema> Tema { get; set; } = null!;
    }
}
