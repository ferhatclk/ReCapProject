using Business.Abstracts;
using Business.Constants.Messages;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using Entities.Concretes;
using Entities.Dtos;
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

        public IResult Add(Car car)
        {
            CheckIfCarNameLength(car);
            CheckIfCarDailyPrice(car);
            _carDal.Add(car);

            return new SuccessResult(Messages.CarAdded);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);

            return new SuccessResult(Messages.CarDeleted);
        }

        public IDataResult<List<Car>> GetAll()
        {
            var result = _carDal.GetAll();
            
            return new SuccessDataResult<List<Car>>(result, Messages.CarListed);
        }

        public IDataResult<Car> GetById(int id)
        {
            var result = _carDal.Get(c=>c.CarId==id);

            return new SuccessDataResult<Car>(result, Messages.CarListed);
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {
            var result = _carDal.GetAll(c => c.BrandId == id);

            return new SuccessDataResult<List<Car>>(result, Messages.CarListed);
        }

        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            var result = _carDal.GetAll(c => c.ColorId == id);

            return new SuccessDataResult<List<Car>>(result, Messages.CarListed);
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            var result = _carDal.GetCarDetails();

            return new SuccessDataResult<List<CarDetailDto>>(result, Messages.CarListed);
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);

            return new SuccessResult(Messages.CarUpdated);
        }

        private void CheckIfCarNameLength(Car car)
        {
            if (car.CarName.Length < 2)
                throw new Exception(Messages.CarNameInvalid);
        }

        private void CheckIfCarDailyPrice(Car car)
        {
            if (car.DailyPrice <= 0)
                throw new Exception(Messages.DailyPriceInvalid);
        }
    }
}
