using Microsoft.EntityFrameworkCore;
using WebApplicationBS.Models;

namespace WebApplicationBS.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            
        }

        public DbSet<Equipo> Equipos { get; set; }
        public DbSet<Mision> Misiones { get; set; }
        public DbSet<Operativo> Operativos { get; set; }
    }
}
