using System.ComponentModel.DataAnnotations;

namespace ISNP097024ISNP153224_Bloque3.Models
{
    public class Pelicula
    {
        [Key]
        public int IdPelicula { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Sipnosis { get; set; }
        public string Duracion { get; set; }
        public string Clasificacion { get; set; }
    }
}
