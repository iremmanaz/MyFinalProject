﻿using Core.DataAccess;
using Core.Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess1.Abstract
{
    public interface IOrderDalcs: IEntityRepository<Order>
    {
    }
}
