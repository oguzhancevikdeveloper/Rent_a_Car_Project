using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstarct
{
  public interface IBrandService
  {
    List<Brand> GetAll();
    void AddCar(Brand brand);
    void Delete(Brand brand);
    void Update(Brand brand);
  }
}
