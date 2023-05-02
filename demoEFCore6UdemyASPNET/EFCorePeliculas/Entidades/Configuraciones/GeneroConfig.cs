using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace EFCorePeliculas.Entidades.Configuraciones
{
    public class GeneroConfig : IEntityTypeConfiguration<Genero>
    {
        public void Configure(EntityTypeBuilder<Genero> builder)
        {
            //Genero
            builder.HasKey(prop => prop.Identificador); // configurar PK
            builder.Property(prop => prop.Nombre)
                // .HasColumnName("NombreGenero") //Cambiar el nombre de la columna
                .HasMaxLength(150) //Longitud máxima
                .IsRequired() //Campo requerido, no null
                ;
            //modelBuilder.Entity<Genero>().ToTable(name: "TablaGeneros", schema: "Peliculas"); //Cambiar el nombre de la tabla 
        }
    }
}
