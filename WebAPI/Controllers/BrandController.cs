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
  public class BrandController : ControllerBase
  {
    IBrandService _bradService;

    public BrandController(IBrandService bradService)
    {
      _bradService = bradService;
    }

    [HttpGet("getallBrand")]
    public IActionResult Get()
    {
      var result = _bradService.GetAll();
      if (result.Success)
      {
        return Ok(result);
      }
      return BadRequest(result);
    }

    [HttpPost("addBrand")]
    public IActionResult Add(Brand brand)
    {
      var result = _bradService.Add(brand);
      if (result.Success)
      {
        return Ok(result.Message);
      }
      return BadRequest(result.Message);

    }

    [HttpPut("updateBrand")]
    public IActionResult Update(Brand brand)
    {
      var result = _bradService.Update(brand);
      if (result.Success)
      {
        return Ok(result);
      }
      return BadRequest(result);
    }

    [HttpDelete("deleteBrand")]
    public IActionResult Delete(Brand brand)
    {
      var result = _bradService.Delete(brand);
      if (result.Success)
      {
        return Ok(result);
      }
      return BadRequest(result);
    }
  }
}
