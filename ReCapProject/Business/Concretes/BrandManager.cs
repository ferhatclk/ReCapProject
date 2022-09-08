using Business.Abstracts;
using Business.Constants.Messages;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concretes
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IResult Add(Brand brand)
        {
            _brandDal.Add(brand);

            return new SuccessResult(Messages.BrandAdded);
        }

        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);

            return new SuccessResult(Messages.BrandDeleted);
        }

        public IDataResult<List<Brand>> GetAll()
        {
            var result = _brandDal.GetAll();

            return new SuccessDataResult<List<Brand>>(result, Messages.BrandListed);
        }

        public IDataResult<Brand> GetById(int id)
        {
            var result = _brandDal.Get(b=>b.BrandId==id);

            return new SuccessDataResult<Brand>(result, Messages.BrandListed);
        }

        public IResult Update(Brand brand)
        {
            _brandDal.Update(brand);

            return new SuccessResult(Messages.BrandUpdated);
        }
    }
}
