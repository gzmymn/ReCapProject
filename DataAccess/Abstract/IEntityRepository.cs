using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //T : bir tip (Car-Brand-Color)
    //Generic constraint -  jenerik kısıt
    //class : referans tip olabilir
    //IEntity : ya IEntity olabilir ya da IEntity implemente eden bir nesne olabilir
    //new() : new'lenebilir olmalı (IEntity soyut bir sınıf onu eklediğimizde hata vermesi için)

    public interface IEntityRepository<T> where T:class, IEntity, new() 
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
