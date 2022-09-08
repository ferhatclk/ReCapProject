﻿using Core.Utilities.Results;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstracts
{
    public interface IBrandService
    {
        IDataResult<List<Brand>> GetAll();
        IDataResult<Brand> GetById(int id);
        IResult Add(Brand brand);
        IResult Update(Brand brand);
        IResult Delete(Brand brand);
    }
}
