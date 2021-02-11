using Business.Concrete;
using DataAccess.Concrete.EntityFreamwork;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var car in carManager.GetCarsByBrandId(1))
            {
                Console.WriteLine(car.ModelYear +" " + car.Description);
            }

            Car car1 = new Car()
            {
                CarId=5,
                BrandId=1,
                ColorId=1,
                DailyPrice=125,
                Description="Mercedes C180",
                ModelYear="2021"
            };
            carManager.Add(car1);
            Console.WriteLine("Araç kaydı eklendi.");
        }
    }
}
