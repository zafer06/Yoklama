using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class TeacherService: ITeacherService
    {
        private readonly ITeacherDal _dal;

        public TeacherService(ITeacherDal dal)
        {
            this._dal = dal;
        }

        public async Task<Teacher> AddAsync(Teacher entity)
        {
            return await _dal.AddAsync(entity);
        }

        public async Task<IEnumerable<Teacher>> AddRangeAsync(IEnumerable<Teacher> entities)
        {
            return await _dal.AddRangeAsync(entities);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await _dal.DeleteAsync(id);
        }

        public async Task<Teacher> GetAsync(Expression<Func<Teacher, bool>> filter)
        {
            return await _dal.GetAsync(filter);
        }

        public async Task<Teacher> GetByIdAsync(int id)
        {
            return await _dal.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Teacher>> GetListAsync(Expression<Func<Teacher, bool>> filter = null)
        {
            return await _dal.GetListAsync(filter);
        }

        public async Task<Teacher> UpdateAsync(Teacher entity)
        {
            return await _dal.UpdateAsync(entity);
        }
    }
}
