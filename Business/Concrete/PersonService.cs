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
    public class PersonService : IPersonService
    {
        private readonly IPersonDal _dal;
        public PersonService(IPersonDal dal)
        {
            _dal = dal;
        }
        public async Task<Person> AddAsync(Person entity)
        {
            return await _dal.AddAsync(entity);
        }

        public async Task<IEnumerable<Person>> AddRangeAsync(IEnumerable<Person> entities)
        {
            return await _dal.AddRangeAsync(entities);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await _dal.DeleteAsync(id);
        }

        public async Task<Person> GetAsync(Expression<Func<Person, bool>> filter)
        {
            return await _dal.GetAsync(filter);
        }

        public async Task<Person> GetByIdAsync(int id)
        {
            return await _dal.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Person>> GetListAsync(Expression<Func<Person, bool>> filter = null)
        {
            return await _dal.GetListAsync(filter);
        }

        public async Task<Person> UpdateAsync(Person entity)
        {
            return await _dal.UpdateAsync(entity);
        }
    }
}
