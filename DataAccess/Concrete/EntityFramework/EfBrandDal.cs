using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : IBrandDal
    {
        public void Add(Brand entity)
        {
            
        }

        public void Delete(Brand entity)
        {
            
        }

        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            return null;
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            return null;
        }

        public void Update(Brand entity)
        {
            
        }
    }

}
