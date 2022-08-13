using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstarct
{
  public interface IUserDal : IEntityRepository<User>
  {
  }
}
