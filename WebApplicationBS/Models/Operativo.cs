using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationBS.Models
{
    public class Operativo
    {
        public Operativo()
        {
            this.Misiones = new HashSet<Mision>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Nombre { get; set; }
        public string Rol { get; set; }
        public virtual ICollection<Mision> Misiones { get; set; }
    }
}
