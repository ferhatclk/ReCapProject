﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfCorporateCustomerDal : EfEntityRepositoryBase<CorporateCustomer, ReCapDbContext>, ICorporateCustomerDal
    {
    }
}
