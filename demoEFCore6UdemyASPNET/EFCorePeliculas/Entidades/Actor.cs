using System.ComponentModel.DataAnnotations.Schema;

namespace EFCorePeliculas.Entidades
{
    public class Actor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Biografia { get; set; }
        //[Column(TypeName = "Date")] //Para definir el tipo de datos, también en el ApiFluent
        public DateTime? FechaNacimiento { get; set; }

        //FK
        public HashSet<PeliculaActor> PeliculasActores { get; set; }
    }
}
