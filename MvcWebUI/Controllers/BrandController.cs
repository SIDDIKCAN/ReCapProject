using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Utulities.Results;
using Entities.Concrete;

namespace MvcWebUI.Controllers
{
    public class BrandController : Controller
    {
        private IBrandService _brandService;

        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        public IActionResult Index()
        {
             IDataResult<List<Brand>> brands = _brandService.GetAll();
            return View(brands);
        }
    }
}
