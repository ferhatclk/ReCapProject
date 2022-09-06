using Business.Concretes;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //BrandTest();
            
            //ColorTest();
            
            //CarTest();
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { BrandId = 1, ColorId = 1, DailyPrice = 650, CarName = "Volvo", ModelYear = 2020, Description = "Kırmızı XC90 SUV" });
            carManager.Add(new Car { BrandId = 3, ColorId = 4, DailyPrice = 650, CarName = "Volkswagen", ModelYear = 2016, Description = "Mavi Tiguan" });
            carManager.Add(new Car { BrandId = 4, ColorId = 5, DailyPrice = 650, CarName = "Toyota", ModelYear = 2015, Description = "Siyah Carolla" });
            carManager.Add(new Car { BrandId = 3, ColorId = 4, DailyPrice = 650, CarName = "Volkswagen", ModelYear = 2019, Description = "Mavi Passat" });
            carManager.Add(new Car { BrandId = 6, ColorId = 6, DailyPrice = 650, CarName = "Fiat", ModelYear = 2018, Description = "Sarı 500L" });
            
            carManager.Delete(new Car { CarId = 2 });
            carManager.Update(new Car { CarId = 6, BrandId = 5, ColorId = 4, DailyPrice = 2550, CarName = "Ford", ModelYear = 2022, Description = "Mavi Mustang" });

            carManager.GetById(4);

            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine("{0} / {1} / {2} / {3}",car.CarName,car.BrandName,car.ColorName,car.DailyPrice);
            }
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(new Color { ColorName = "Kırmızı" });
            colorManager.Delete(new Color { ColorId  = 2 });
            colorManager.Update(new Color { ColorId  = 6, ColorName = "Yeşil" });

            colorManager.GetById(1);
            
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorName);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Brand { BrandName = "Volvo" });
            brandManager.Delete(new Brand { BrandId = 2});
            brandManager.Update(new Brand { BrandId = 3, BrandName = "Volkswagen" });
            
            brandManager.GetById(3);

            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }
        }
    }
}
