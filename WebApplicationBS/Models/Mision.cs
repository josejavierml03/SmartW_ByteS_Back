namespace WebApplicationBS.Models
{
    public class Mision
    {
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        public Operativo OpAsignado { get; set; }
    }
}
