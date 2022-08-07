using System;
using Entities.Concrete;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Core.DataAccess;

namespace DataAccess.Abstarct
{
  public interface IColorDal : IEntityRepository<Entities.Concrete.Color>
  {

  }
}
