using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfColorDal : IColorDal
    {
        public void Add(Color entity)
        {
            
        }

        public void Delete(Color entity)
        {
            
        }

        public Color Get(Expression<Func<Color, bool>> filter)
        {
            return null;
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            return null;
        }

        public void Update(Color entity)
        {
            
        }
    }

}
