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
  public class RentalController : ControllerBase
  {
    IRentalService _rentalService;

    public RentalController(IRentalService rentalService)
    {
      _rentalService = rentalService;
    }

    [HttpGet("getallRental")]
    public IActionResult Get()
    {
      var result = _rentalService.GetAll();
      if (result.Success)
      {
        return Ok(result);
      }
      return BadRequest(result);
    }

    [HttpPost("addRental")]
    public IActionResult Add(Rental rental)
    {
      var result = _rentalService.Add(rental);
      if (result.Success)
      {
        return Ok(result);
      }
      return BadRequest(result);
    }

    [HttpPut("updateRental")]
    public IActionResult Update(Rental rental)
    {
      var result = _rentalService.Update(rental);
      if (result.Success)
      {
        return Ok(result);
      }
      return BadRequest(result);
    }

    [HttpDelete("deleteRental")]
    public IActionResult Delete(Rental rental)
    {
      var result = _rentalService.Delete(rental);
      if (result.Success)
      {
        return Ok(result);
      }
      return BadRequest(result);
    }

  }
}
