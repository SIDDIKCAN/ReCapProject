using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Hosting;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarImagesController : ControllerBase
    {
        private ICarImageService _carImageService;

        public CarImagesController(ICarImageService carImageService)
        {
            _carImageService = carImageService;

        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _carImageService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getcarsbyimageid")]
        public IActionResult GetCarsByImageId(int id)
        {
            var result = _carImageService.GetImagesByCarId(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("get")]
        public IActionResult Get(int id)
        {
            var result = _carImageService.Get(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add([FromForm(Name = ("Image"))] IFormFile file, [FromForm] CarImage carImage)
        {
            var result = _carImageService.Add(carImage,file);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete([FromForm(Name = ("Id"))] int id)
        {
            var carImage = _carImageService.Get(id).Data;

            var result = _carImageService.Delete(carImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut("update")]
        public IActionResult Update([FromForm(Name = ("Image"))] IFormFile file, [FromForm(Name = ("Id"))] int id)
        {
            var carImage = _carImageService.Get(id).Data;
            var result = _carImageService.Update(carImage, file);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


    }
}
