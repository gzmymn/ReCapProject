using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarDBContext>, IRentalDal
    {
        public List<CarRentalDetailDto> GetCarRentalDetails(Expression<Func<Rental, bool>> filter = null)
        {
            using (CarDBContext context = new CarDBContext())
            {
                var result = from r in filter is null ? context.Rentals : context.Rentals.Where(filter)
                             join car in context.Cars on r.CarId equals car.CarId
                             join color in context.Colors on car.ColorId equals color.ColorId
                             join b in context.Brands on car.BrandId equals b.BrandId
                             join customer in context.Customers on r.CustomerId equals customer.CustomerId
                             join u in context.Users on customer.UserId equals u.UserId
                             select new CarRentalDetailDto()
                             {
                                 RentalId = r.RentalId,
                                 CustomerName = u.FirstName,
                                 CustomerLastName = u.LastName,
                                 CustomerCompanyName = customer.CompanyName,
                                 CarName = car.CarName,
                                 BrandName = b.BrandName,
                                 ColorName = color.ColorName,
                                 DailyPrice = car.DailyPrice,
                                 TotalPrice = Convert.ToDecimal(r.ReturnDate.Value.Day - r.RentDate.Day) * car.DailyPrice,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate

                             };
                return result.ToList();
            }
        }
    }
}
