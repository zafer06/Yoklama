using Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfBaseRepository<TEntity, TContext> : IRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public async Task<TEntity> AddAsync(TEntity entity)
        {
            using TContext context = new();
            await context.Set<TEntity>().AddAsync(entity);
            await context.SaveChangesAsync();
            return entity;
        }

        public async Task<IEnumerable<TEntity>> AddRangeAsync(IEnumerable<TEntity> entities)
        {
            using TContext context = new();
            await context.Set<IEnumerable<TEntity>>().AddRangeAsync(entities);
            await context.SaveChangesAsync();
            return entities;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            using TContext context = new();
            var dEntity = await GetByIdAsync(id);
            context.Set<TEntity>().Remove(dEntity);
            var result = await context.SaveChangesAsync();
            return result > 0;
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter)
        {
            using TContext context = new();
            return await context.Set<TEntity>().FirstOrDefaultAsync(filter);
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            using TContext context = new();
            return await context.Set<TEntity>().FindAsync(id);
        }

        public async Task<IEnumerable<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> filter = null)
        {
            using TContext context = new();
            return filter == null ? await context.Set<TEntity>().ToListAsync() : await context.Set<TEntity>().Where(filter).ToListAsync();
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            using TContext context = new();
            context.Set<TEntity>().Update(entity);
            await context.SaveChangesAsync();
            return entity;
        }
    }
}
