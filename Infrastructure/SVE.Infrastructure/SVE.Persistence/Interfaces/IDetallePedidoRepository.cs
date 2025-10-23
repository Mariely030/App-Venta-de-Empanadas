using SVE.Domain.Repository;
using SVE.Domain.Entities.Configuration;
using SVE.Domain.Base;

namespace SVE.Infrastructure.SVE.Persistence.Interfaces
{

    public interface IDetallePedidoRepository : IBaseRepository<DetallePedido>
    {

        OperationResult GetDetallePedidoByPedidoId(int PedidoId);
        OperationResult GetDetallePedidoByProductoId(int PrductoId);
        OperationResult GetDetallePedidoByCantidad(int Cantidad);
        OperationResult GetDetallePedidoByPrecioUnitario(decimal PrecioUnitario);
    }
    
}