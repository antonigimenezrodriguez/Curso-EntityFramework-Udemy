using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;

namespace EFCorePeliculas.Entidades
{
    public class Cine
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        //[Precision(precision: 9, scale: 2)] //Definir la precisión de los decimales, cuanta más precisión, más espacio utiliza. también en FluentApi
        public Point Ubicacion { get; set; }

        //Propiedad de navegación
        public CineOferta CineOferta { get; set; }
        public HashSet<SalaDeCine> SalasDeCine { get; set; } //HashSet es más rápido que ICollection o IList, pero no permite ordenaciones... etc
    }
}
