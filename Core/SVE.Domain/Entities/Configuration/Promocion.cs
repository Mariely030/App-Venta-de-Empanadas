namespace SVE.Domain.Base
{

    public class Promocion : BaseEntity

    {

        public string Descripcion { get; set; }
        public decimal Descuento { get; set; }
        public bool Activa { get; set; }
    }
}