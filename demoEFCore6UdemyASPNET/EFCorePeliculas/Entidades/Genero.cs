using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCorePeliculas.Entidades
{
   // [Table("TablaGeneros", Schema = "peliculas")] //Para cambiar el nombre de la tabla en la base de datos también con ApiFluent
    public class Genero
    {
        //Convenciones: Id o NombreClaseId se marcará como PK
        //[Key] -> Para cuando no sean convenciones o configurando en el DbContext con ApiFluent
        public int Identificador { get; set; }
        // [StringLength(150)] // Definir longitud, también se puede: [MaxLength(150)] también con ApiFluent
        // [Required] // Campo requerido, no puede ser null también con ApiFluent
        //[Column("NombreGenero")] //Para cambiar el nombre de la columna en la base de datos, también con ApiFluent
        public string Nombre { get; set; }

        //FK
        public HashSet<Pelicula> Peliculas { get; set; }
    }
}
