namespace EFCorePeliculas.Entidades
{
    public class SalaDeCine
    {
        public int Id { get; set; }
        public decimal Precio { get; set; }
        public TipoSalaDeCine TiposalaDeCine { get; set; }

        //FK
        public int CineId { get; set; }
        //Propiedades de navegación
        public Cine Cine { get; set; }
    }
}
