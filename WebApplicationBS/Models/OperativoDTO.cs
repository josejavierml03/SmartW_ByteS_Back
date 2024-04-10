namespace WebApplicationBS.Models
{
    public class OperativoDTO
    {
        public OperativoDTO()
        {
            this.Misiones = new HashSet<MisionDTO>();
        }
        public OperativoDTO( Operativo op): this() 
        {
            Nombre = op.Nombre;
            Rol = op.Rol;
            foreach (Mision mision in op.Misiones)
            {
                Misiones.Add( new MisionDTO{
                    Codigo = mision.Codigo, Descripcion = mision.Descripcion, 
                Estado = mision.Estado, NombreOperativo = mision.NombreOperativo});
            }
        }
        public string Nombre { get; set; }
        public string Rol { get; set; }
        public virtual ICollection<MisionDTO> Misiones { get; set; }
    }
}
