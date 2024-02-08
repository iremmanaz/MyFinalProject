using Core.DataAccess.EntityFramework;
using DataAccess1.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess1.Concrete.EntityFramework
{
    public class EfOrderDal:EfEntityRepositoryBase<Order, NorthWindContex>, IOrderDalcs
    {
    }
}
