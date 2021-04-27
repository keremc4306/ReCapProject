using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        readonly List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id = 1004, BrandId = 1, ColorId = 1, DailyPrice = 600, ModelYear = 2015, Description = "Sedan / 4 Kapı / Otomatik  / Dizel / 190 hp"},
                new Car{Id = 1006, BrandId = 2, ColorId = 5, DailyPrice = 360, ModelYear = 2015, Description = "Hatchback / 3 Kapı / Otomatik / Benzinli / 136 hp"},
                new Car{Id = 1007, BrandId = 3, ColorId = 3, DailyPrice = 500, ModelYear = 2014, Description = "Sedan / 4 Kapı / Dizel / Manuel / 120 hp"},
                new Car{Id = 1008, BrandId = 4, ColorId = 4, DailyPrice = 176, ModelYear = 2012, Description = "Hatchback / 4 Kapı / Benzinli / Otomatik / 125 hp"},
                new Car{Id = 1009, BrandId = 5, ColorId = 1002, DailyPrice = 250, ModelYear = 2014, Description = "Sedan / 4 Kapı / Dizel / Yarı Otomatik / 105 hp"},
            };
        }

        public Car GetById(int carId)
        {
            return _cars.SingleOrDefault(c => c.Id == carId);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);

            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);

            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public CarDetailDto GetCarDetail(Expression<Func<CarDetailDto, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}