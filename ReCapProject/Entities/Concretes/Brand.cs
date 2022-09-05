﻿using Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concretes
{
    public class Brand : IEntity
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }
    }
}
