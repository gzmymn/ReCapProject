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
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1, BrandId=1, ColorId=1, ModelYear="2015", DailyPrice=200, Description="Binek Volkswagen Passat 2015 model Siyah - 200 TL"},
                new Car{CarId=2, BrandId=2, ColorId=2, ModelYear="2016", DailyPrice=400, Description="Binek BMW 5.20 2016 model Beyaz - 400 TL"},
                new Car{CarId=3, BrandId=1, ColorId=2, ModelYear="2017", DailyPrice=210, Description="Binek Volkswagen Jetta 2017 model Beyaz - 210 TL  "},
                new Car{CarId=4, BrandId=3, ColorId=2, ModelYear="2017", DailyPrice=300, Description="Binek Audi A6  2017 model Beyaz - 300 TL"},
                new Car{CarId=5, BrandId=1, ColorId=3, ModelYear="2018", DailyPrice=220, Description="Ticari Volkswagen Caddy 2018 model Gri - 220 TL"},
                new Car{CarId=6, BrandId=4, ColorId=4, ModelYear="2018", DailyPrice=220, Description="Ticari Fiat Doblo 2018 model Kırmızı - 220 TL"},
                new Car{CarId=7, BrandId=5, ColorId=1, ModelYear="2019", DailyPrice=230, Description="Ticari Renault Kangoo  2019 model Siyah - 230 TL"},
                
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.CarId == carId).ToList();
        }

        public void Update(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);            
            carToDelete.BrandId = car.BrandId;
            carToDelete.ColorId = car.ColorId;
            carToDelete.ModelYear = car.ModelYear;
            carToDelete.DailyPrice = car.DailyPrice;
            carToDelete.Description = car.Description;
        }
    }
}
