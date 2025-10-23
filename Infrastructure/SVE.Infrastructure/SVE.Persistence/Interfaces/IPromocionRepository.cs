using SVE.Domain.Repository;
using SVE.Domain.Entities.Configuration;
using SVE.Domain.Base;

namespace SVE.Infrastructure.SVE.Persistence.Interfaces
{

    public interface IPromocionRepository : IBaseRepository<Promocion>
    {

        OperationResult GetPromocionByDescripcion(string Descripcion);
        OperationResult GetPromocionByDescuento(decimal Descuento);
        OperationResult GetPromocionByActiva(bool Activa);
    }
}