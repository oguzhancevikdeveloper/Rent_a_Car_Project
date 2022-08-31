using Core.DataAccess.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstarct
{
  public interface ICarImageService
  {
    IResult Add(CarImage carImage);
    IDataResult<List<CarImage>> GetAll();
  }
}
