namespace SVE.Domain.Base
{
    public class DetallePedido : BaseEntity
    {
        public int PedidoId { get; set; }
        public Pedido Pedido { get; set; }
        public int ProductoId { get; set; }
        public Producto Producto { get; set; }
        public Promocion Promocion { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
    } 
}