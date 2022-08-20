﻿using Business.Abstarct;
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
  public class ColorController : ControllerBase
  {
    IColorService _colorService;

    public ColorController(IColorService colorService)
    {
      _colorService = colorService;
    }

    [HttpGet("getallColor")]
    public IActionResult Get()
    {
      var result = _colorService.GetAll();

      if (result.Success)
      {
        return Ok(result);
      }
      return BadRequest(result);
    }

    [HttpPost("addColor")]
    public IActionResult Add(Color color)
    {
      var result = _colorService.Add(color);
      if (result.Success)
      {
        return Ok(result);
      }
      return BadRequest(result);
    }

    [HttpPut("updateColor")]
    public IActionResult Update(Color color)
    {
      var result = _colorService.Update(color);
      if (result.Success)
      {
        return Ok(result);
      }
      return BadRequest(result);
    }

    [HttpDelete("deleteColor")]
    public IActionResult Delete(Color color)
    {
      var result = _colorService.Delete(color);
      if (result.Success)
      {
        return Ok(result);
      }
      return BadRequest(result);
    }
  }
}
