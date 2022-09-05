using Business.Abstracts;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concretes
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            this._carDal = carDal;
        }

        public void Add(Car car)
        {
            CheckIfCarDescriptionLength(car);
            CheckIfCarDailyPrice(car);
            _carDal.Add(car);
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public Car GetById(int id)
        {
            return _carDal.Get(c=>c.CarId==id);
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(c => c.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(c => c.ColorId == id);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }

        private void CheckIfCarDescriptionLength(Car car)
        {
            if (car.Description.Length < 2)
                throw new Exception("Description is not the requested length");
        }

        private void CheckIfCarDailyPrice(Car car)
        {
            if (car.DailyPrice <= 0)
                throw new Exception("Daily price entered incorrectly");
        }
    }
}
