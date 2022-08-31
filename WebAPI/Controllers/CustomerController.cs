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
  public class CustomerController : ControllerBase
  {
    ICustomerService _customerService;

    public CustomerController(ICustomerService customerService)
    {
      _customerService = customerService;
    }


    [HttpGet("getallCustomer")]
    public IActionResult Get()
    {
      var result = _customerService.GetAll();
      if (result.Success)
      {
        return Ok(result);
      }
      return BadRequest(result);
    }

    [HttpPost("addCustomer")]
    public IActionResult Add(Customer customer)
    {
      var result = _customerService.Add(customer);
      if (result.Success)
      {
        return Ok(result);
      }
      return BadRequest(result);
    }

    [HttpPut("updateCustomer")]
    public IActionResult  Update(Customer customer)
    {
      var result = _customerService.Update(customer);

      if (result.Success)
      {
        return Ok(result);
      }
      return BadRequest(result);
    }

    [HttpDelete("deleteCustomer")]
    public IActionResult Delete(Customer customer)
    {
      var result = _customerService.Delete(customer);
      if (result.Success)
      {
        return Ok(result);
      }
      return BadRequest(result);

    }
  }
}
