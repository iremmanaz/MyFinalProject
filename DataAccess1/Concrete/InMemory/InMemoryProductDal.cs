using DataAccess1.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess1.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product>()
            { 
                new Product() {ProductID=1, CategoryId=1, ProductName="Bardak", UnitsInStock=15, UnitPrice=15},
                new Product() {ProductID=2, CategoryId=1, ProductName="Kamera", UnitsInStock=3, UnitPrice=500},
                new Product() {ProductID=3, CategoryId=2, ProductName="Telefon", UnitsInStock=2, UnitPrice=1500},
                new Product() {ProductID=4, CategoryId=2, ProductName="Klavye", UnitsInStock=65, UnitPrice=150},
                new Product() {ProductID=5, CategoryId=2, ProductName="Fare", UnitsInStock=1, UnitPrice=85},
            };
        }
        public void Add(Product product) 
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {

            /* Product productToDelete= null;
             foreach(var p in _products)
             {
                 if(product.ProductID == p.ProductID)
                 {
                     productToDelete = p;
                 }

             }
             _products.Remove(productToDelete);*/

            //LINQ- Language Integrated Query
            Product productToDelete = _products.SingleOrDefault(p => p.ProductID == product.ProductID);
            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }


        public void Update(Product product)
        {
            //Gönderdiğim ürün idsine sahip olan listedeki ürünü bul 
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductID == product.ProductID);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
        public List<Product> GetAllByCategory(int categoryId)
        {
           return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }
    }
}
