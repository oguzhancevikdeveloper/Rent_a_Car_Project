using System;
using System.Collections.Generic;
using System.Text;

namespace Core.DataAccess.Utilities.Results
{
  public class SuccessResult : Result
  {
    public SuccessResult(string message):base(true)
    {

    }
    public SuccessResult():base(true)
    {

    }
  }
}
