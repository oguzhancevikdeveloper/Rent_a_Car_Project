using Core.DataAccess.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstarct
{
  public interface IUserService
  {
    IDataResult<List<User>> GetAll();
    IResult Add(User user);
    IResult Delete(User user);
    IResult Update(User user);
  }
}
