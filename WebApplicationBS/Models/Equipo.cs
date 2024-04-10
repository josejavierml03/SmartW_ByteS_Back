using System.ComponentModel.DataAnnotations;

namespace WebApplicationBS.Models
{
    public class Equipo
    {
        [Key]
        public int ID { get; set; }
        public string Tipo { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
    }
}
