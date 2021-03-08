using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            using (CarDBContext context = new CarDBContext()) //Garbage Collector'e using bittiği an beni bellekten at diyor.
            {
                var addedEntity = context.Entry(entity); //addedEntity=değişken - veri kaynağına gönderdiğimi ekle
                addedEntity.State = EntityState.Added; //eklenecek bir nesne olduğu belirtildi
                context.SaveChanges(); //ve şimdi ekle
            }
        }

        public void Delete(Car entity)
        {
            using (CarDBContext context = new CarDBContext())
            {
                var deletedEntity = context.Entry(entity); //deletedEntity=değişken - veri kaynağından gönderdiğimi sil
                deletedEntity.State = EntityState.Deleted; //silinecek bir nesne olduğu belirtildi
                context.SaveChanges(); //ve şimdi sil
            } 
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (CarDBContext context = new CarDBContext())
            {
                return context.Set<Car>().SingleOrDefault(filter); //SingleOrDefault foreach görevi gören bir Linq operatörü
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (CarDBContext context = new CarDBContext())
            {
                return filter == null 
                    ? context.Set<Car>().ToList() //filter=null ise hepsini listele
                    : context.Set<Car>().Where(filter).ToList(); //filter=null değilse filtreye göre listele (lambda ile verilenler filtre)
            }
        }

        public void Update(Car entity)
        {
            using (CarDBContext context = new CarDBContext())
            {
                var updatedEntity = context.Entry(entity); //deletedEntity=değişken - veri kaynağından gönderdiğimi güncelle
                updatedEntity.State = EntityState.Modified; //güncellenecek bir nesne olduğu belirtildi
                context.SaveChanges(); //ve şimdi güncelle
            }
        }
    }

}
