using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.EntityFramework
{
    //generic constraint -  jenerik kısıt
    //TEntity : bir varlık tipi (Car-Brand-Color)
    //TContext : bir veritabanı tipi (EntityFramework, Northwind vs.)
    //class : referans tip olabilir
    //IEntity : ya IEntity olabilir ya da IEntity implemente eden bir nesne olabilir
    //DbContext : EntityFramework elemanı(veri tabanı)
    //new() : new'lenebilir olmalı (IEntity yazdığımızda kızması için)

    public class EfEntityRepositoryBase<TEntity, TContext>:IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            using (TContext context = new TContext()) //Garbage Collector'e using bittiği an beni bellekten at diyor.
            {
                var addedEntity = context.Entry(entity); //addedEntity=değişken - veri kaynağına gönderdiğimi ekle
                addedEntity.State = EntityState.Added; //eklenecek bir nesne olduğu belirtildi
                context.SaveChanges(); //ve şimdi ekle
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity); //deletedEntity=değişken - veri kaynağından gönderdiğimi sil
                deletedEntity.State = EntityState.Deleted; //silinecek bir nesne olduğu belirtildi
                context.SaveChanges(); //ve şimdi sil
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter); //SingleOrDefault foreach görevi gören bir Linq operatörü
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null
                    ? context.Set<TEntity>().ToList() //filter=null ise hepsini listele
                    : context.Set<TEntity>().Where(filter).ToList(); //filter=null değilse filtreye göre listele (lambda ile verilenler filtre)
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity); //deletedEntity=değişken - veri kaynağından gönderdiğimi güncelle
                updatedEntity.State = EntityState.Modified; //güncellenecek bir nesne olduğu belirtildi
                context.SaveChanges(); //ve şimdi güncelle
            }
        }
    }
}
