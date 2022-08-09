﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstarct
{
  public interface ICarService
  {
    List<Car> GetAll();
    List<Car> GetCarsByBrandId(int brandId);
    List<Car> GetCarsByColorId(int colorId);
    void AddCar(Car car);
    void Delete(Car car);
    void Update(Car car);

  }
}
