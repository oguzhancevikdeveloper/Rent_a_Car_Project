using Business.Abstarct;
using Business.Constant;
using Core.DataAccess.Utilities.Results;
using DataAccess.Abstarct;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
  public class RentalManager : IRentalService
  {
    IRentalDal _rentalDal;
    public RentalManager(IRentalDal rentalDal)
    {
      _rentalDal = rentalDal;
    }
    public IResult AddCar(Rental rental)
    {
      _rentalDal.Add(rental);
      return new SuccessResult(Messages.RentalAdded);
    }
    public IResult Delete(Rental rental)
    {
      _rentalDal.Delete(rental);
      return new SuccessResult(Messages.RentalDeleted);
    }
    public IDataResult<List<Rental>> GetAll()
    {
      return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
    }
    public IResult Update(Rental rental)
    {
      _rentalDal.Update(rental);
      return new SuccessResult(Messages.RentalUpdated);
    }
  }
}
