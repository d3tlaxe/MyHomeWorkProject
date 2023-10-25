using Core.DataAccess.EntityFramework;
using Microsoft.EntityFrameworkCore;
using MyDataAccess.Abstract;
using MyEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyDataAccess.Concrete.EntityFramework
{
    public class EfColorDal : EfEntityRepositoryBase<Color, MyDbContext>, IColorDal
    {
        

    
    }
}
