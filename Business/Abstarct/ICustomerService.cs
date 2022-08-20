using Core.DataAccess.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstarct
{
  public interface ICustomerService
  {
    IDataResult<List<Customer>> GetAll();
    IResult Add(Customer customer);
    IResult Delete(Customer customer);
    IResult Update(Customer customer);
  }
}
