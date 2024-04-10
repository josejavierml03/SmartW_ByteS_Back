using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationBS.Models
{
    public class MisionDTO
    {
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        public string NombreOperativo { get; set; }

    }
}
