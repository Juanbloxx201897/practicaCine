namespace SistemaCine.Models
{
    public class Cine
    {
        public int Id { get; set; }

        public string Pelicula { get; set; } = string.Empty;

        public string Sala { get; set; } = string.Empty;

        public DateTime FechaFuncion { get; set; }

        public bool Disponible { get; set; }
    }
}