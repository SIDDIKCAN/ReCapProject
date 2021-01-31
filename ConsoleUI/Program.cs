using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Araç Id : " + car.CarId + " " + "Marka Id : " + car.BrandId+ " " + "Renk Id : " + car.ColorId + " " + "Günlük Araç Fiyatı :" +  car.DailyPrice + " " + "Açıklama : " + car.Description + " " + "Model : " + car.ModelYear );
            }
        }
    }
}
