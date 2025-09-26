using SVE.Domain.Base;
using System.Linq.Expressions;

namespace SVE.Domain.Repository
{

    public interface IBaseRepository<TEntity> where TEntity : class
    {

        Task<OperationResult> Save(TEntity entity);
        Task<OperationResult> Update(TEntity entity);
        Task<OperationResult> Remove(TEntity entity);
        Task<OperationResult> GetAll();
        Task<OperationResult> GetAll(Expression<Func<TEntity, bool>> filter);
        Task<OperationResult> GetEntityBy(int Id);
        Task<bool> Exists(Expression<Func<TEntity, bool>> filter);
    }
}