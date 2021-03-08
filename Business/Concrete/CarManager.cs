using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.CarName.Length>2 && car.DailyPrice>0) //Eklenecek arabanın adı 2 kelimeden az olamaz ve günlük fiyatı 0'dan az olamaz
            {
                _carDal.Add(car);
            }
            
        }

       
        public List<Car> GetAll()
        {
            return _carDal.GetAll(); //tüm arabaları listeler
        }

        public List<Car> GetByDailyPrice(decimal min, decimal max)
        {
            return _carDal.GetAll(c => c.DailyPrice >= min && c.DailyPrice <= max); //girilen değer aralığına göre arabaları listeler
        }

        public List<Car> GetById(int id)
        {
            return _carDal.GetAll(c => c.CarId == id); //CarId'ye göre arabayı getirir
        } 

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(c => c.BrandId == id); //BrandId'ye göre listeler
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(c => c.ColorId == id); //ColorId'ye göre listeler
        }

       
    }
}
