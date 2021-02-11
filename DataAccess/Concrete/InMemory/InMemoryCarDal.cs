using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1,BrandId=1,ColorId=1,DailyPrice=500,ModelYear="2020",Description="Günlük kiralanabilen bir araçtır."},
                new Car{CarId=1,BrandId=2,ColorId=1,DailyPrice=500,ModelYear="2021",Description="Günlük kiralanabilen bir araçtır."},
                new Car{CarId=2,BrandId=2,ColorId=3,DailyPrice=700,ModelYear="2019",Description="Günlük kiralanabilen bir araçtır."},
                new Car{CarId=2,BrandId=3,ColorId=3,DailyPrice=700,ModelYear="2018",Description="Günlük kiralanabilen bir araçtır."},
                new Car{CarId=3,BrandId=3,ColorId=2,DailyPrice=600,ModelYear="2018",Description="Günlük kiralanabilen bir araçtır."},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(x => x.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car GetById(int carId)
        {
            return _cars.FirstOrDefault(x => x.CarId == carId);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(x => x.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
