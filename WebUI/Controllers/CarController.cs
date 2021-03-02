using Business.Abstract;
using Core.Utulities.Results;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class CarController : Controller
    {
        ICarService _carService;
        public CarController(ICarService carService)
        {
            _carService = carService;
        }

        public IActionResult Index()
        {
            IDataResult<List<CarDetailDto>> carDetailDtos = _carService.GetCarDetails();
            //var cars= _carService.GetAll();
            //CarListViewModel model = new CarListViewModel
            //{
            //    Cars = cars
            //};
            return View(carDetailDtos.Data);
        }
    }
}
