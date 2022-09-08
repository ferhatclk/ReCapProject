using Core.Utilities.Results;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstracts
{
    public interface IColorService
    {
        IDataResult<List<Color>> GetAll();
        IDataResult<Color> GetById(int id);
        IResult Add(Color color);
        IResult Update(Color color);
        IResult Delete(Color color);
    }
}
