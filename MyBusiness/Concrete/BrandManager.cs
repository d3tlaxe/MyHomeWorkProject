using Core.Utilities.Results;
using MyBusiness.Abstract;
using MyBusiness.Constants;
using MyDataAccess.Abstract;
using MyDataAccess.Concrete.EntityFramework;
using MyEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBusiness.Concrete
{
 
    public class BrandManager : IBrandService
    {

        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
           _brandDal = brandDal;
        }



        public IResult Add(Brand brand)
        {

            if (brand.BrandName.Length > 2)
            {
                _brandDal.Add(brand);
                return new SuccessResult(Messages.BrandAdded);
            }
            else
            {
                Console.WriteLine("Lütfen marka adını 2 karakterden daha uzun yazınız.");
                return new SuccessResult(Messages.BrandNameInvalid);
            }
           
        }

        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return new SuccessResult();
        }

        public IDataResult<List<Brand>> GetAll()
        {
            if (DateTime.Now.Hour == 21)
            {
                return new ErrorDataResult<List<Brand>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(), Messages.BrandListed);
        }

        public IDataResult<Brand> GetById(int id)
        {
            return new SuccessDataResult<Brand>(_brandDal.GetById(p => p.Id == id));
        }


        public IResult Update(Brand brand)
        {
            _brandDal.Update(brand);
            return new SuccessResult();
        }






    }
}
