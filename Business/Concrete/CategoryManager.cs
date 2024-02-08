using Business.Abstract;
using Core.Utilities.Results;
using DataAccess1.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICtegoryDal _categoryDal;

        public CategoryManager(ICtegoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IDataResult<List<Category>> GetAll()
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll());
            
        }
        //Select*from categories where categoryid = 3
        public IDataResult<Category> GetById(int categoryId)
        {
            return new SuccessDataResult<Category> (_categoryDal.Get(c=>c.CategoryId == categoryId));
        }
    }
}
