﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFreamwork
{
    public class EfCustomerDal: EfEntityRepositoryBase<Customer,ReCapContext>,ICustomerDal
    {
    }
}
