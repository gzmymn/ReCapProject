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
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, CarDBContext>, ICustomerDal
    {
        public List<CarCustomerDetailDto> GetCustomerDetails(Expression<Func<Customer, bool>> filter = null)
        {
            using (CarDBContext context = new CarDBContext())
            {
                var result = from c in filter is null? context.Customers : context.Customers.Where(filter)
                            join u in context.Users 
                            on c.UserId equals u.UserId
                            select new CarCustomerDetailDto()
                            {
                                CustomerId = c.CustomerId,
                                UserId = u.UserId,
                                UserName = u.FirstName,
                                UserLastName = u.LastName,
                                CompanyName = c.CompanyName,
                                Email = u.Email
                            };
                return result.ToList();
            }
        }

        //public bool DeleteCustomerIfNotReturnDateNull(Customer customer)
        //{
        //    using (CarDBContext context = new CarDBContext())
        //    {
        //        var find = context.Rentals.Any(i => i.CustomerId == customer.CustomerId && i.ReturnDate == null);
        //        if (!find)
        //        {
        //            context.Remove(customer);
        //            context.SaveChanges();
        //            return true;
        //        }
        //    }
        //    return false;
        //}
    }
}
