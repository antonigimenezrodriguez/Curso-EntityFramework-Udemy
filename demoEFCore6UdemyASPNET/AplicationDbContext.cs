using EFCore6udemyMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCore6udemyMVC
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Persona> Personas { get; set; }
    }
}
