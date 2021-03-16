using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarGetAllTest();
            //CarAddTest();
            //BrandGetByIdTest();
            //CarDetailsTest();
            //ColorGetByIdTest();
            //CarDeleteTest();
            //CarDetailTest();
            //BrandGetAllTest();

            //UserAddTest();

            //BrandAddTest();

            RentalAddTest();

        }

        private static void RentalAddTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            rentalManager.Add(new Rental { CarId = 1, CustomerId = 1, RentDate = DateTime.Now, ReturnDate = DateTime.Now.AddDays(3) });
            rentalManager.Add(new Rental { CarId = 2, CustomerId = 1, RentDate = DateTime.Now, ReturnDate = DateTime.Now.AddDays(4) });
            rentalManager.Add(new Rental { CarId = 3, CustomerId = 2, RentDate = DateTime.Now, ReturnDate = DateTime.Now.AddDays(7) });
            rentalManager.Add(new Rental { CarId = 4, CustomerId = 2, RentDate = DateTime.Now, ReturnDate = DateTime.Now.AddDays(2) });
            rentalManager.Add(new Rental { CarId = 5, CustomerId = 2, RentDate = DateTime.Now });
        }

        private static void BrandAddTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Brand { BrandName = "Fiat" });
            brandManager.Add(new Brand { BrandName = "Renault" });
        }

        private static void UserAddTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            userManager.Add(new User { FirstName = "Gizem", LastName = "Yaman", Email = "gizem@gmail.com", Password = "12345" });
            userManager.Add(new User { FirstName = "Kerem", LastName = "Yaman", Email = "kerem@gmail.com", Password = "12345" });
            userManager.Add(new User { FirstName = "Alparslan", LastName = "Tekkanat", Email = "alp@gmail.com", Password = "12345" });
        }

        private static void BrandGetAllTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result = brandManager.GetAll();
            if (result.Success == true)
            {
                foreach (var brand in result.Data)
                {
                    Console.WriteLine(brand.BrandId + "--" + brand.BrandName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CarDetailTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.BrandName + "|" + car.ColorName + "|" + car.DailyPrice + "|" + car.Description);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CarDeleteTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Delete(new Car { CarId = 4 });
        }

        private static void ColorGetByIdTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            Color color = colorManager.GetById(1).Data;
            Console.WriteLine(color.ColorName);
        }

        private static void CarDetailsTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine("{0}--{1}--{2}--{3}--{4}", car.CarId, car.CarName, car.BrandName, car.ColorName, car.DailyPrice);
                }
            }
        }

        private static void CarAddTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
              

            carManager.Add(new Car {CarName = "Volkswagen Caddy", BrandId = 1, ColorId = 3, ModelYear = "2018", DailyPrice = 220, Description = "Ticari Volkswagen Caddy 2018 model Gri - 220 TL" });
            carManager.Add(new Car {CarName = "Fiat Doblo", BrandId = 4, ColorId = 4, ModelYear = "2018", DailyPrice = 220, Description = "Ticari Fiat Doblo 2018 model Kırmızı - 220 TL" });
            carManager.Add(new Car {CarName = "Renault Kangoo", BrandId = 5, ColorId = 1, ModelYear = "2019", DailyPrice = 230, Description = "Ticari Renault Kangoo  2019 model Siyah - 230 TL" });


            }

        private static void BrandGetByIdTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            Brand brand = brandManager.GetById(1).Data;
            Console.WriteLine(brand.BrandName);
        }

        private static void CarGetAllTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetAll();
            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine("{0}--{1}--{2}", car.CarName, car.ModelYear, car.DailyPrice + "TL");
                }
            }
        }
    }
}
