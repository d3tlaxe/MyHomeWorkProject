using Core.DataAccess.EntityFramework;
using MyDataAccess.Abstract;
using MyEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, MyDbContext>, IRentalDal
    {
    }
}
