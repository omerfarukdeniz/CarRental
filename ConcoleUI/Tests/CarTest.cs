using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConcoleUI.Tests
{
    public static class CarTest
    {

        public static void AddCar(string carName, decimal dailyPrice, int brandId, int colorId)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Car addedCar = new Car
            {
                CarName = carName,
                DailyPrice = dailyPrice,
                BrandID = brandId,
                ColorID = colorId
            };
            carManager.Add(addedCar);
            Console.WriteLine("Yeni Araba eklendi");
        }
        public static void UpdateCar(int carId, string carName, decimal dailyPrice, int brandId, int colorId)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Car updatedCar = new Car
            {
                ID = carId,
                CarName = carName,
                DailyPrice = dailyPrice,
                BrandID = brandId,
                ColorID = colorId
            };
            carManager.Add(updatedCar);
            Console.WriteLine("Araba Güncellendi");
        }
        public static void DeleteCar(int carID)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Delete(carID);
            Console.WriteLine("Araba Silindi");
        }
        public static void GetAllCar()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetAll();
            if (result != null)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine("Araç : {0} - Günlük Fiyat : {1}", car.CarName, car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine("Araçlar Getirilemedi !");
            }
            
        }
        public static void GetCarById(int carId)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Car car = new Car();
            var result = carManager.GetById(carId);
            if (result!= null)
            {
                Console.WriteLine("Araç : {0} - Günlük Fiyat : {1}", car.CarName, car.DailyPrice);
            }
            else
            {
                Console.WriteLine("Uygun  Araç Bulunamadı !");
            }
        }
        public static void GetCarDetails()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result != null)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine("Araç : {0} - Günlük Fiyat : {1} - Renk : {2} - Marka : {3}", car.CarName, car.DailyPrice, car.ColorName, car.BrandName);
                }
            }
            else
            {
                Console.WriteLine("Araçlar Getirilemedi !");
            }
        }
    }
}
