using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PaymentComputeApp.DataAccess.Repositories
{
    public class Repository<TEntity>:IRepository<TEntity> where TEntity:class
    {
        protected readonly ApplicationDbContext _context;
        private DbSet<TEntity> _dbSet;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }

        public virtual async Task<IEnumerable<TEntity>> GetAsync(
           Expression<Func<TEntity, bool>> filter = null,
           Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
           string includeProperties = "")
        {
            IQueryable<TEntity> query = _dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            return (orderBy != null) ? await orderBy(query).ToListAsync() : await query.ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(int id)
            => await _context.Set<TEntity>().FindAsync(id);

        public async Task<IEnumerable<TEntity>> GetAllAsync()
            => await _context.Set<TEntity>().ToListAsync();

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
            => _context.Set<TEntity>().Where(predicate);

        public async Task AddAsync(TEntity entity)
            => await _context.Set<TEntity>().AddAsync(entity);

        public async Task AddRangeAsync(IEnumerable<TEntity> entities)
            => await _context.Set<TEntity>().AddRangeAsync(entities);

        public void Remove(TEntity entity)
            => _context.Set<TEntity>().Remove(entity);

        public void RemoveRange(IEnumerable<TEntity> entities)
            => _context.Set<TEntity>().RemoveRange(entities);

        public void Update(TEntity entityToUpdate)
            => _context.Set<TEntity>().Update(entityToUpdate);

        public void Remove(int id)
            => _context.Set<TEntity>().Remove(_context.Set<TEntity>().Find(id));

        public TEntity GetById(int id)
            => _context.Set<TEntity>().Find(id);
    } 
}
