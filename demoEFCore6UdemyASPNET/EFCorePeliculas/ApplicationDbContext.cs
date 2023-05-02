using EFCorePeliculas.Entidades;
using Microsoft.EntityFrameworkCore;

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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //FluentAPI
            //Genero
            modelBuilder.Entity<Genero>().HasKey(prop => prop.Identificador); // configurar PK
            modelBuilder.Entity<Genero>().Property(prop => prop.Nombre)
                // .HasColumnName("NombreGenero") //Cambiar el nombre de la columna
                .HasMaxLength(150) //Longitud máxima
                .IsRequired() //Campo requerido, no null
                ;
            //modelBuilder.Entity<Genero>().ToTable(name: "TablaGeneros", schema: "Peliculas"); //Cambiar el nombre de la tabla 

            //Actor
            modelBuilder.Entity<Actor>().Property(prop => prop.nombre)
                .HasMaxLength(150)
                .IsRequired();
            modelBuilder.Entity<Actor>().Property(prop => prop.FechaNacimiento)
                .HasColumnType("date");

            //Cine
            modelBuilder.Entity<Cine>().Property(prop => prop.Nombre)
                .HasMaxLength(150)
                .IsRequired();

            //Pelicula
            modelBuilder.Entity<Pelicula>().Property(prop => prop.Titulo)
                .HasMaxLength(250)
                .IsRequired();
            modelBuilder.Entity<Pelicula>().Property(prop => prop.FechaEstreno)
                .HasColumnType("date");
            modelBuilder.Entity<Pelicula>().Property(prop => prop.PosterURL)
                .HasMaxLength(500)
                .IsUnicode(false); //Ahorramos espacio porque no vamos a guardar carácteres árabes, emojis, ñ...

            //CineOferta
            modelBuilder.Entity<CineOferta>().Property(prop => prop.PorcentajeDescuento)
                .HasPrecision(precision: 5, scale: 2);
            modelBuilder.Entity<CineOferta>().Property(prop => prop.FechaInicio)
                .HasColumnType("date");
            modelBuilder.Entity<CineOferta>().Property(prop => prop.FechaFin)
                .HasColumnType("date");

            //SalaDeCine
            modelBuilder.Entity<SalaDeCine>().Property(prop => prop.Precio)
                .HasPrecision(precision: 9, scale: 2);
        }

    }
}
