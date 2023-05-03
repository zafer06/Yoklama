using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserService : IUserService
    {
        private readonly IUserDal _dal;

        public UserService(IUserDal dal)
        {
            this._dal = dal;
        }

        public async Task<User> AddAsync(User entity)
        {
            return await _dal.AddAsync(entity);
        }

        public async Task<IEnumerable<User>> AddRangeAsync(IEnumerable<User> entities)
        {
            return await _dal.AddRangeAsync(entities);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await _dal.DeleteAsync(id);
        }

        public async Task<User> GetAsync(Expression<Func<User, bool>> filter)
        {
            return await _dal.GetAsync(filter);
        }

        public async Task<User> GetByIdAsync(int id)
        {
            return await _dal.GetByIdAsync(id);
        }

        public async Task<IEnumerable<User>> GetListAsync(Expression<Func<User, bool>> filter = null)
        {
            return await _dal.GetListAsync(filter);
        }

        public async Task<User> UpdateAsync(User entity)
        {
            return await _dal.UpdateAsync(entity);
        }
    }
}
