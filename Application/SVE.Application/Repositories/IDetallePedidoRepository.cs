using SVE.Domain.Repository;
using SVE.Domain.Entitines.Configuration;

namespace SVE.Application.Repositories
{

    public interface IDetallePedidoRepository : IBaseRepository<DetallePedido>
    {

        List<DetallePedido> GetDetallePedidoByPedidoId(int PedidoId);
        List<DetallePedido> GetDetallePedidoByProductoId(int PrductoId);
        List<DetallePedido> GetDetallePedidoByCantidad(int Cantidad);
        List<DetallePedido> GetDetallePedidoByPrecioUnitario(decimal PrecioUnitario);
    }
}