using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace EFCorePeliculas.Entidades.Configuraciones
{
    public class SalaDeCineConfig : IEntityTypeConfiguration<SalaDeCine>
    {
        public void Configure(EntityTypeBuilder<SalaDeCine> builder)
        {
            //SalaDeCine
            builder.Property(prop => prop.Precio)
                .HasPrecision(precision: 9, scale: 2);
            builder.Property(prop => prop.TiposalaDeCine)
                //.HasDefaultValueSql("GETDATE()") // De esta forma se pueden usar expresiones SQL para el valor por defecto, en este caso se obtendria la hora actual desde SQL
                .HasDefaultValue(TipoSalaDeCine.DosDimensiones); //Especificamos el valor por defecto
        }
    }
}
