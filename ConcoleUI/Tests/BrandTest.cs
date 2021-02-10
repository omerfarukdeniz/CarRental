using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConcoleUI.Tests
{
    public static class BrandTest
    {

        public static void AddBrand(string brandName)
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            Brand addedBrand = new Brand
            {
                BrandName = brandName
            };
            brandManager.Add(addedBrand);
            Console.WriteLine("Yeni Marka eklendi");
        }
        public static void UpdateBrand(int brandId, string brandName)
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            Brand updatedBrand = new Brand
            {
                ID = brandId,
                BrandName = brandName
            };
            brandManager.Update(updatedBrand);
            Console.WriteLine("Marka Güncellendi");
        }
        public static void DeleteBrand(int brandID)
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Delete(brandID);
            Console.WriteLine("Marka Silindi");
        }
        public static void GetAllBrand()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result = brandManager.GetAll();
            if (result != null)
            {
                foreach (var brand in result)
                {
                    Console.WriteLine("Marka : {0}", brand.BrandName);
                }
            }
            else
            {
                Console.WriteLine("Markalar Getirilemedi !");
            }

        }
        public static void GetBrandById(int brandID)
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result = brandManager.GetById(brandID);
            if (result != null)
            {
                Console.WriteLine("Marka : {0}",result.BrandName);
            }
            else
            {
                Console.WriteLine("Uygun  Marka Bulunamadı !");
            }
        }
    }
}
