using Core.DataAccess.EntityFramework;
using DataAccess1.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess1.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthWindContex>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetails()
        {
            using (NorthWindContex contex = new NorthWindContex())
            {
                //ürünlerle kategorileri join yap ve 3.satırdakine göre yap.
                var result = from p in contex.Products
                             join c in contex.Categories
                             on p.CategoryId equals c.CategoryId
                             select new ProductDetailDto { ProductId = p.ProductID, ProductName = p.ProductName, 
                                 CategoryName = c.CategoryName, UnitInStock = p.UnitsInStock };
                return result.ToList();
            }
        }
    }
}
