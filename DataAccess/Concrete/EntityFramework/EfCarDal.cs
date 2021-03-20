using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarDBContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails(Expression<Func<Car, bool>> filter = null)
        {
            using (CarDBContext context = new CarDBContext())
            {
                var result = from car in filter == null ? context.Cars : context.Cars.Where(filter)
                             join brand in context.Brands on car.BrandId equals brand.BrandId  //tabloları join edelim
                             join color in context.Colors on car.ColorId equals color.ColorId
                             //join image in context.CarImages on car.CarId equals image.CarId
                             select new CarDetailDto()
                             {
                                 CarId = car.CarId,
                                 CarName = car.CarName,
                                 BrandName = brand.BrandName,
                                 ColorName = color.ColorName,
                                 DailyPrice = car.DailyPrice,
                                 Description = car.Description,
                                 ImagePath = (from i in context.CarImages where i.CarId==car.CarId select i.ImagePath).ToList()
                             };
                return result.ToList(); //ToList() yapmamızın sebebi dönen sonucun IQueryable bir döngü olması
            }
        }

        public bool DeleteCarIfNotReturnDateNull(Car car)
        {
            using (CarDBContext context = new CarDBContext())
            {
                var find = context.Rentals.Any(i => i.CarId == car.CarId && i.ReturnDate == null);
                if (!find)
                {
                    context.Remove(car);
                    context.SaveChanges();
                    return true;
                }

                return false;
            }
        }
    }

}
