using Core.DataAccess.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstarct
{
  public interface ICarImageService
  {
    IResult Add(IFormFile formFile, CarImage carImage);
    IDataResult<List<CarImage>> GetAll();
    IDataResult<List<CarImage>> GetByCarId(int carId);
    IDataResult<List<CarImage>> GetByImageId(int imageId);
    IResult Delete(CarImage carImage);
    IResult Update(IFormFile formFile, CarImage carImage);
  }
}
