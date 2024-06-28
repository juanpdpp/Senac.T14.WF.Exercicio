using Microsoft.EntityFrameworkCore;

namespace WinFormsApp
{
    public class AppDbContext : DbContext
    {
        public DbSet<Usuarios> Usuarios { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            
            optionsBuilder.UseSqlite("Data Source=comandas.db");
        }
    }

}