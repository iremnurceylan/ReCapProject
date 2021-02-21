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
        List <Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car{CarId=1 , BrandId=1 , ColorId=1, DailyPrice=400000 , Description="BMW" , ModelYear="2015 model" },
                new Car{CarId=2 , BrandId=2 , ColorId=1, DailyPrice=250000 , Description="MiniCooper" , ModelYear="2020 model" },
                new Car{CarId=3 , BrandId=3 , ColorId=1, DailyPrice=750000 , Description="Mercedes" , ModelYear="2021 model" },
                new Car{CarId=4 , BrandId=1 , ColorId=1, DailyPrice=45000 , Description="Ford" , ModelYear="2013 model" },

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = null;
            carToDelete = _cars.SingleOrDefault(c=>c.CarId==car.CarId);
            _cars.Remove(carToDelete);
        }


        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllById(int CarId)
        {
           return _cars.Where(c => c.CarId == CarId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = null;
            carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;

        }
    }
}
