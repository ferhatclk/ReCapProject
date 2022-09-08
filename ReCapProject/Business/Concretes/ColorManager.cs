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
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IResult Add(Color color)
        {
            _colorDal.Add(color);

            return new SuccessResult(Messages.ColorAdded);
        }

        public IResult Delete(Color color)
        {
            _colorDal.Delete(color);

            return new SuccessResult(Messages.ColorDeleted);
        }

        public IDataResult<List<Color>> GetAll()
        {
            var result = _colorDal.GetAll();

            return new SuccessDataResult<List<Color>>(result, Messages.ColorListed);
        }

        public IDataResult<Color> GetById(int id)
        {
            var result = _colorDal.Get(c=>c.ColorId==id);

            return new SuccessDataResult<Color>(result, Messages.ColorListed);
        }

        public IResult Update(Color color)
        {
            _colorDal.Update(color);

            return new SuccessResult(Messages.ColorUpdated);
        }
    }
}
