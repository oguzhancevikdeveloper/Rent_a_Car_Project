using Business.Abstarct;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
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

    [HttpPost("addCar")]
    public IActionResult AddCarImage([FromForm] IFormFile formFile, [FromForm] CarImage carImage)
    {
     
      var result = _carImageService.Add(formFile,carImage);
      if (result.Success)
      {
        return Ok(result);
      }
      return BadRequest(result);
    }

    [HttpGet("getAll")]
    public IActionResult GetCarIamge()
    {
      var result = _carImageService.GetAll();
      if (result.Success)
      {
        return Ok(result);
      }
      return BadRequest(result);
    }
    
    [HttpGet("getByImageId")]
    public IActionResult GetByImageId(int carId)
    {
      var result = _carImageService.GetByImageId(carId);
      if (result.Success)
      {
        return Ok(result);
      }
      return BadRequest(result);
    }
    
    [HttpGet("getBuyCarId")]
    public IActionResult GetByCarId(int carId)
    {
      var result = _carImageService.GetByCarId(carId);
      if (result.Success)
      {
        return Ok(result);
      }
      return BadRequest(result);
    }

    [HttpPut("updateCar")]
    public IActionResult Update([FromForm] IFormFile formFile, [FromForm] CarImage carImage)
    {
      var result = _carImageService.Update(formFile, carImage);
      if (result.Success)
      {
        return Ok(result);
      }
      return BadRequest(result);
    }

    [HttpPost("delete")]
    public IActionResult Delete([FromForm] CarImage carImage)
    {
      var result = _carImageService.Delete(carImage);
      if (result.Success)
      {
        return Ok(result);
      }
      return BadRequest(result);
    }
  }
}

