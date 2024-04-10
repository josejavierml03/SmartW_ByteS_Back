using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationBS.Models
{
    public class Mision
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        public string NombreOperativo { get; set;}
        [ForeignKey("NombreOperativo")]
        public virtual Operativo Operativo { get; set; }
    }
}
