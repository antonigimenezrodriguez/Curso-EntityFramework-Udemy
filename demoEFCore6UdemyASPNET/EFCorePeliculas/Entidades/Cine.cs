using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;

namespace EFCorePeliculas.Entidades
{
    public class Cine
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        //[Precision(precision: 9, scale: 2)] //Definir la precisión de los decimales, cuanta más precisión, más espacio utiliza. también en FluentApi
        public decimal Precio { get; set; }
        public Point Ubicacion { get; set; }
    }
}
