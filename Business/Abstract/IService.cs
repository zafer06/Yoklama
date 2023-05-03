using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IService<TEnTity>
    {
        Task<TEnTity> GetByIdAsync(int id);
        Task<IEnumerable<TEnTity>> GetListAsync(Expression<Func<TEnTity, bool>> filter = null);
        Task<TEnTity> GetAsync(Expression<Func<TEnTity, bool>> filter);
        Task<TEnTity> AddAsync(TEnTity entity);
        Task<IEnumerable<TEnTity>> AddRangeAsync(IEnumerable<TEnTity> entities);
        Task<TEnTity> UpdateAsync(TEnTity entity);
        Task<bool> DeleteAsync(int id);
    }
}
