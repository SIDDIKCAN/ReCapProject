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
            //CarTest();
            //ColorTest();
            //BrandTest();

            //Car car1 = new Car()
            //{
            //    CarId = 5,
            //    BrandId = 1,
            //    ColorId = 1,
            //    DailyPrice = 125,
            //    Description = "Mercedes C180",
            //    ModelYear = "2021"
            //};
            //carManager.Add(car1);
            //Console.WriteLine("Araç kaydı eklendi.");
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            Customer customer1 = new Customer()
            {
                Id = 4,
                UserId = 2,
                CompanyName = "ABC"
            };
            customerManager.Add(customer1);
            Console.WriteLine("Kullanıcı eklendi.");

            //CustomerTest();


        }

        private static void CustomerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            var result = customerManager.GetAll();
            foreach (var customer in result.Data)
            {
                Console.WriteLine(customer.Id + " " + customer.UserId + " " + customer.CompanyName);
            }
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var result = colorManager.GetAll();
            foreach (var color in result.Data)
            {
                Console.WriteLine("{0}  {1}", color.Id, color.Name);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            foreach (var car in result.Data)
            {
                Console.WriteLine(car.ModelYear + " " + car.Description);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result = brandManager.GetAll();
            foreach (var brand in result.Data)
            {
                Console.WriteLine(brand.Name);
            }
        }
    }
}
