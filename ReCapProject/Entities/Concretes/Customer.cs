using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concretes
{
    public class Customer : User, IEntity
    {
        public int UserId { get; set; }
        public string CustomerNo { get; set; }
    }
}
