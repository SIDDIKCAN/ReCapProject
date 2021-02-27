using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Concrete;
using Core.Utulities.Results;
using DataAccess.Concrete.EntityFreamwork;
using Entities.Concrete;
using Entities.DTOs;

namespace MvcWebUI.Controllers
{
    public class CarController : Controller
    {
        private ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }

        public IActionResult Index()
        {
            IDataResult<List<CarDetailDto>> carDetailDtos = _carService.GetCarDetails();
             //IDataResult<List<Car>> cars=_carService.GetAll();

            // CarListViewModel model = new CarListViewModel
            //{
            //    Cars=cars
            //};

            return View(carDetailDtos.Data);
        }
    }
}
