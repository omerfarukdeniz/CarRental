using DataAccess.Concrete.EntityFramework;
using Business.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace ConcoleUI.Tests
{
    public static class ColorTest
    {

        public static void AddColor(string colorName)
        {
            ColorManager ColorManager = new ColorManager(new EfColorDal());
            Color addedColor = new Color
            {
                ColorName = colorName
            };
            ColorManager.Add(addedColor);
            Console.WriteLine("Yeni Renk eklendi");
        }
        public static void UpdateColor(int colorId, string colorName)
        {
            ColorManager ColorManager = new ColorManager(new EfColorDal());
            Color updatedColor = new Color
            {
                ID = colorId,
                ColorName = colorName
            };
            ColorManager.Update(updatedColor);
            Console.WriteLine("Renk Güncellendi");
        }
        public static void DeleteColor(int colorID)
        {
            ColorManager ColorManager = new ColorManager(new EfColorDal());
            ColorManager.Delete(colorID);
            Console.WriteLine("Renk Silindi");
        }
        public static void GetAllColor()
        {
            ColorManager ColorManager = new ColorManager(new EfColorDal());
            var result = ColorManager.GetAll();
            if (result != null)
            {
                foreach (var color in result.Data)
                {
                    Console.WriteLine("Renk : {0}", color.ColorName);
                }
            }
            else
            {
                Console.WriteLine("Renklar Getirilemedi !");
            }

        }
        public static void GetColorById(int colorID)
        {
            ColorManager ColorManager = new ColorManager(new EfColorDal());
            var result = ColorManager.GetById(colorID);

            if (result != null)
            {
                Console.WriteLine("Renk : {0}",result.Data);
            }
            else
            {
                Console.WriteLine("Uygun  Renk Bulunamadı !");
            }
        }
    }
}
