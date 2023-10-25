using MyDataAccess.Abstract;
using MyEntities.Concrete;
using MyEntities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyDataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {

        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>()
            {
                new Car { Id = 1, BrandId = 1, ColorId = 2, DailyPrice = 500, ModelYear = 2003, Description = "2 Gün Kiralık" },
                new Car { Id = 2, BrandId = 2, ColorId = 1, DailyPrice = 1500, ModelYear = 2003, Description = "1 Gün Kiralık"},
                new Car { Id = 3, BrandId = 3, ColorId = 3, DailyPrice = 200, ModelYear = 2003, Description = "4 Gün Kiralık"},
                new Car { Id = 4, BrandId = 1, ColorId = 2, DailyPrice = 300, ModelYear = 2003, Description = "5 Gün Kiralık"},
                new Car { Id = 5, BrandId = 2, ColorId = 1, DailyPrice = 400, ModelYear = 2003, Description = "6 Gün Kiralık"},

            };

        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            /*
                Car carToDelete = null;
                foreach (var item in _cars)
                {
                    if (item.Id == car.Id)
                    {
                        carToDelete = item;
                    }
                }
                _cars.Remove(carToDelete);
            */


            Car carToDelete = _cars.SingleOrDefault(p=> p.Id == car.Id);
            _cars.Remove(carToDelete);


        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int id)
        {
           return _cars.Where(p=> p.Id == id).ToList();
        }

        public List<Car> GetById(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p=>p.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
            carToUpdate.DailyPrice = car.DailyPrice;





        }

        Car IEntityRepository<Car>.GetById(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
