using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Helpers
{
  public interface IFileHelper
  {
    string Add(IFormFile formFile, string root);
    string Update(IFormFile formFile, string filePath, string root);
    void Delete(string filePath);
  }
}
