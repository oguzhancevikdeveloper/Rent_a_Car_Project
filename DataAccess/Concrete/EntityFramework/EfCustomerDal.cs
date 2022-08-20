using Core.DataAccess.EtityFramework;
using DataAccess.Abstarct;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
  public class EfCustomerDal : EfEntityRepositoryBase<Customer ,ReCapContext> ,ICustomerDal
  {
  }
}
