using Business.Concretes;
using DataAccess.InMemory.Concretes;
using Entities.Concretes;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            carManager.Add(new Car { Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 450, ModelYear = 2020, Description = "Toyota SUV" });
            carManager.Add(new Car { Id = 2, BrandId = 2, ColorId = 2, DailyPrice = 550, ModelYear = 2020, Description = "Ford SUV" });
            carManager.Add(new Car { Id = 3, BrandId = 3, ColorId = 2, DailyPrice = 750, ModelYear = 2022, Description = "Volvo SUV" });

            foreach(var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}
