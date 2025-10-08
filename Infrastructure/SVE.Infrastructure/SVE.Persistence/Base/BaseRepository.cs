using Microsoft.EntityFrameworkCore;
using SVE.Domain.Repository;
using SVE.Persistence.Context;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SVE.Persistence.Base
{

    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {

        protected readonly SVEContext _context;
        protected readonly DbSet<TEntity> _dbSet;

        public BaseRepository(SVEContext context)
        {

            _context = context;
            _dbSet = _context.Set<TEntity>();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {

            return await _dbSet.FindAsync(id);
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {

            return await _dbSet.ToListAsync();
        }

        public async Task Addsync(TEntity entity)
        {

            await _dbSet.AddAsync(entity);
        }

        public void Update(TEntity entity)
        {

            _dbSet.Update(entity);
        }

        public void Delete(TEntity entity)
        {

            _dbSet.Remove(entity);
        }

    }

}