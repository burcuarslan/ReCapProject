using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;
        public InMemoryCarDal()
        {
            _car = new List<Car>
            {
                new Car{Id=1,ColorId=1,BrandId=1,DailyPrice=500,ModelYear=2006,Description="Volkswagen Passat -> Dizel araç"},
                new Car{Id=2,ColorId=2,BrandId=1,DailyPrice=700,ModelYear=2016,Description="BMW 3 Serisi 320i ED M Plus -> Benzinli araç"},
                new Car{Id=3,ColorId=2,BrandId=1,DailyPrice=300,ModelYear=1996,Description="Opel Astra -> LPGli araç"},
                new Car{Id=4,ColorId=1,BrandId=1,DailyPrice=1000,ModelYear=2020,Description="Volkswagen e-Golf -> Elektrikli araç"}

            };
        }
        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _car.SingleOrDefault(c => c.Id==car.Id);
            _car.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetByld(int Id)
        {
            return _car.Where(c => c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }
    }
}
