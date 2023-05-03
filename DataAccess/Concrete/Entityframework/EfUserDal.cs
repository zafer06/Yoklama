using DataAccess.Abstract;
using DataAccess.Concrete.Contexts;
using Entities.Concrete;

namespace DataAccess.Concrete.Entityframework
{
    public class EfUserDal : EfBaseRepository<User, WebAPIContext>, IUserDal
    {
    }
}
