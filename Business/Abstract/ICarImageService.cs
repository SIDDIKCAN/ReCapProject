using System;
using System.Collections.Generic;
using System.Text;
using Core.Utulities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IDataResult<List<CarImage>> GetAll();
        IDataResult<CarImage> Get(int id);
        IDataResult<List<CarImage>> GetImagesByCarId(int id);
        IResult Add(CarImage carImage,IFormFile file);
        IResult Delete(CarImage carImage);
        IResult Update(CarImage carImage, IFormFile file);
    }
}
