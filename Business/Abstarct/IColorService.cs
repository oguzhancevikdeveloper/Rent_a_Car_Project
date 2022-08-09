using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstarct
{
  public interface IColorService
  {
    List<Color> GetAll();
    void AddCar(Color color);
    void Delete(Color color);
    void Update(Color color);
  }
}
