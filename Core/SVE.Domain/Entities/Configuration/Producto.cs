namespace SVE.Domain.Base
{

    public class Producto : BaseEntity
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public string Categoria { get; set; }
    }
}