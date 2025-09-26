namespace SVE.Domain.Base
{

    public class Usuario : BaseEntity
    {

        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Rol { get; set; }
    }
}