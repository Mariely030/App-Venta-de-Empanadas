namespace SVE.Domain.Base
{
    public class Pedido : BaseEntity
    {

        public int UsuarioId { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; }
        public decimal Total { get; set; }
    }
}