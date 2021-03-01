using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapContext>, IRentalDal
    {

        //Bu kodu incele

        public List<RentalDetailDto> GetRentalDetails(Expression<Func<Rental, bool>> filter = null)
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from r in filter is null ? context.Rentals : context.Rentals.Where(filter)
                    join cu in context.Customers
                        on r.CustomerId equals cu.Id
                    join c in context.Cars
                        on r.CarId equals c.Id
                    join u in context.Users
                        on cu.UserId equals u.Id
                    select new RentalDetailDto
                    {
                        Id = r.Id,
                        CarName = c.Name,
                        FirstName = u.FirstName,
                        LastName = u.LastName,
                        CompanyName = cu.CompanyName,
                        RentDate = r.RentDate,
                        ReturnDate = r.ReturnDate
                    };
                return result.ToList();
            }
        }
    }
}
