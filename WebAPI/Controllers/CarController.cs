using Business.Abstarct;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class CarController : ControllerBase
  {
    ICarService _carService;

    public CarController(ICarService carService)
    {
      _carService = carService;
    }

    [HttpGet("getAllCar")]
    public IActionResult GetCar()
    {
      var result = _carService.GetAll();
      if (result.Success)
      {
        return Ok(result);
      }
      return BadRequest(result);
    }

    [HttpPost("addCar")]
    public IActionResult AddCar(Car car)
    {
      var result = _carService.AddCar(car);
      if (result.Success)
      {
        return Ok(result.Message);
      }
      return BadRequest(result.Message);
    }

    [HttpDelete("deleteCar")]
    public IActionResult DeleteCar(Car car)
    {
      var result = _carService.Delete(car);
      if (result.Success)
      {
        return Ok(result.Message);
      }
      return BadRequest(result.Message);
    }

    [HttpPut("updateCar")]
    public IActionResult Update(Car car)
    {
      var result = _carService.Update(car);
      if (result.Success)
      {
        return Ok(result.Success);
      }
      return BadRequest(result.Message);
    }


  }
}
