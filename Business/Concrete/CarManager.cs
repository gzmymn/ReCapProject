using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService 
                                          
    {
        //Bir iş sınıfı başka sınıfları new'lemez!!! Bunun için ne yapar?? -Injection-
        ICarDal _carDal;  //Ne soyut, ne EntityFramework ne de InMemory ismi geçecek.
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.CarName.Length>2 && car.DailyPrice>0) //Eklenecek arabanın adı 2 kelimeden az olamaz ve günlük fiyatı 0'dan fazla olmalı
            {
                _carDal.Add(car);
                Console.WriteLine(car.CarName + " " + "isimli araç eklendi.");
            }
            else
            {
                Console.WriteLine("Ekleme başarısız!!! Araba ismi 2 kelimeden oluşmalı ya da günlük fiyat 0'dan farklı olmalı. ");
            }
            
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
            Console.WriteLine(car.CarName + " " + "isimli araç silindi.");
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

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(c => c.BrandId == id); //BrandId'ye göre listeler
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(c => c.ColorId == id); //ColorId'ye göre listeler
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
            Console.WriteLine(car.CarName + " " + "isimli araç güncellendi.");
        }
    }
}
