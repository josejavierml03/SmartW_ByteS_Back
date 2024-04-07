namespace WebApplicationBS.Models
{
    public class Operativo
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Rol { get; set; }
        public Mision MisionAsignada { get; set;}
    }
}
