using EFCorePeliculas.Entidades;
using EFCorePeliculas.Entidades.Configuraciones;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace EFCorePeliculas
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Actor> Actores { get; set; }
        public DbSet<Cine> Cines { get; set; }
        public DbSet<CineOferta> CinesOfertas { get; set; }
        public DbSet<SalaDeCine> SalasDeCine { get; set; }
        public DbSet<Pelicula> Peliculas { get; set; }
        public DbSet<PeliculaActor> PeliculasActores { get; set; }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<DateTime>().HaveColumnType("date"); // Sobreescribimos las convenciones (comportamiento por defecto). En este caso, todos los DateTime se pasaran a SQL como date
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //FluentAPI
            //modelBuilder.ApplyConfiguration(new GeneroConfig()); // Si queremos hacer uno por uno
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); // Coge todas IEntityConfigurations del assembly
        }
    }
}
