namespace Core.DataAccess.Utilities.Results
{
  public class ErrorResult : Result
  {
    public ErrorResult(string message) : base(false,message)
    {
    }
    public ErrorResult() : base(false)
    {
    }
  }
}
