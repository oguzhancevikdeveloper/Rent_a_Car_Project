﻿using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstarct
{
  public interface ICarDal : IEntityRepository<Car>
  {
    List<Car> GetCarsByBrandId(int brandId);
    List<Car> GetCarsByColorId(int colorId);
    List<CarDetailDto> GetCarsDetail(int carId);
  }
}
