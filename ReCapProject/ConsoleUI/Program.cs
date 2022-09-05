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
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            //brandManager.Add(new Brand { BrandName = "Volvo" });
            //brandManager.Add(new Brand { BrandName = "Toyota" });
            //brandManager.Add(new Brand { BrandName = "Ford" });
            //brandManager.Add(new Brand { BrandName = "Fiat" });
            //brandManager.Add(new Brand { BrandName = "Dodge" });

            ColorManager colorManager = new ColorManager(new EfColorDal());
            //colorManager.Add(new Color { ColorName = "Kırmızı" });
            //colorManager.Add(new Color { ColorName = "Mavi" });
            //colorManager.Add(new Color { ColorName = "Siyah" });
            //colorManager.Add(new Color { ColorName = "Sarı" });

            CarManager carManager = new CarManager(new EfCarDal());
            //carManager.Add(new Car { BrandId = 1, ColorId = 1, DailyPrice = 650, ModelYear = 2020, Description = "Kırmızı Volvo SUV" });
            //carManager.Add(new Car { BrandId = 2, ColorId = 2, DailyPrice = 550, ModelYear = 2020, Description = "Mavi Toyota " });
            //carManager.Add(new Car { BrandId = 3, ColorId = 2, DailyPrice = 550, ModelYear = 2022, Description = "Mavi Ford" });
            //carManager.Add(new Car { BrandId = 4, ColorId = 3, DailyPrice = 450, ModelYear = 2022, Description = "Siyah  Fiat" });
            //carManager.Add(new Car { BrandId = 5, ColorId = 4, DailyPrice = 1750, ModelYear = 2022, Description = "Sarı Dodge " });
            carManager.Add(new Car { BrandId = 5, ColorId = 4, DailyPrice = 0, ModelYear = 2022, Description = "SLX" });
            carManager.Add(new Car { BrandId = 4, ColorId = 3, DailyPrice = 350, ModelYear = 2002, Description = "S" });

            foreach (var car in carManager.GetCarsByColorId(2))
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}
