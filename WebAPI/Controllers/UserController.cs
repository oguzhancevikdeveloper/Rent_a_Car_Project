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
  public class UserController : ControllerBase
  {
    IUserService _userService;

    public UserController(IUserService userService)
    {
      _userService = userService;
    }

    [HttpGet("getallUser")]
    public IActionResult Get()
    {
      var result = _userService.GetAll();
      if (result.Success)
      {
        return Ok(result);
      }
      return BadRequest(result.Message);
    }

    [HttpPost("addUser")]
    public IActionResult Add(User user)
    {
      var result = _userService.Add(user);
      if (result.Success)
      {
        return Ok(result);
      }
      return BadRequest(result.Message);

    }

    [HttpPut("updateUser")]
    public IActionResult Update(User user)
    {
      var result = _userService.Update(user);
      if (result.Success)
      {
        return Ok(result);
      }
      return BadRequest(result);
    }

    [HttpDelete("deleteUser")]
    public IActionResult Delete(User user)
    {
      var result = _userService.Delete(user);
      if (result.Success)
      {
        return Ok(result);
      }
      return BadRequest(result);
    }
  }
}
