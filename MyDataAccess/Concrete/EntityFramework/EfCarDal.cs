using Core.DataAccess.EntityFramework;
using Microsoft.EntityFrameworkCore;
using MyDataAccess.Abstract;
using MyEntities.Concrete;
using MyEntities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyDataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, MyDbContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (MyDbContext context = new MyDbContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             join co in context.Colors
                             on c.ColorId equals co.Id
                             select new CarDetailDto
                             { Id = c.Id, BrandName = b.BrandName, ColorName = co.ColorName, DailyPrice = c.DailyPrice, ModelYear = c.ModelYear };
                return result.ToList();
            }
        }
    }
}
