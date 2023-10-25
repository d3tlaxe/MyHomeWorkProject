using MyEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDataAccess.Abstract
{
    public interface IColorDal : IEntityRepository<Color>
    {
    }
}
