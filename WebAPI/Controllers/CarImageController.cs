using Business.Abstarct;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class CarImageController : ControllerBase
  {
    ICarImageService _carImageService;

    public CarImageController(ICarImageService carImageService)
    {
      _carImageService = carImageService;
    }

    [HttpPost("addCarImage")]
    public IActionResult AddCarImage(CarImage carImage)
    {
     
      var result = _carImageService.Add(carImage);
      if (result.Success)
      {
        return Ok(result);
      }
      return BadRequest(result);
    }

    [HttpGet("getCarImage")]
    public IActionResult GetCarIamge()
    {
      var result = _carImageService.GetAll();
      if (result.Success)
      {
        return Ok(result);
      }
      return BadRequest(result);
    }  
  }
}

