using Business.Abstract;
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
    public class CarsController : ControllerBase
    {
        readonly ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _carService.GetAll();

            if (!result.Success)
                return BadRequest(result);

            return Ok();
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _carService.GetById(id);

            if (!result.Success)
                return BadRequest(result);

            return Ok();
        }

        [HttpGet("getcardetails")]
        public IActionResult GetCarDetails()
        {
            var result = _carService.GetCarDetails();

            if (!result.Success)
                return BadRequest(result);

            return Ok();
        }

        [HttpGet]
        public IActionResult Add(Car car)
        {
            var result = _carService.Add(car);

            if (!result.Success)
                return BadRequest(result);

            return Ok();
        }

        [HttpGet]
        public IActionResult Update(Car car)
        {
            var result = _carService.Update(car);

            if (!result.Success)
                return BadRequest(result);

            return Ok();
        }

        [HttpGet]
        public IActionResult Delete(Car car)
        {
            var result = _carService.Delete(car);

            if (!result.Success)
                return BadRequest(result);

            return Ok(result);
        }
    }
}
