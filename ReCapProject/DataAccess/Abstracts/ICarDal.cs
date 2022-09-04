﻿using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.InMemory.Abstracts
{
    public interface ICarDal
    {
        Car GetById(int id);
        List<Car> GetAll();
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);

    }
}
