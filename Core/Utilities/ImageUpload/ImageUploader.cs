using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Core.Utilities.ImageUpload
{
    public static class ImageUploader
    {
        public static string UploadImage(string serverPath, IFormFile file)
        {
            if (file != null || file.Length < 0)
            {
                Guid uniqueName = Guid.NewGuid();
                serverPath = serverPath.Replace("~", string.Empty);
                string extension = Path.GetExtension(file.FileName);
                string fileName = $"{uniqueName}{extension}";
                if (extension.ToLower() == ".jpeg" || extension.ToLower() == ".jpg" || extension.ToLower() == ".png" || extension.ToLower() == "gif")
                {
                    if (Directory.Exists(serverPath + fileName))
                    {
                        return "Aynı isimde dosya mevcut!";
                    }
                    else
                    {
                        var stream = new FileStream(Path.Combine(serverPath, fileName), FileMode.Create);
                        file.CopyTo(stream);
                        return serverPath + fileName;
                    }
                }
                else
                {
                    return "Seçmiş olduğunuz dosya resim formatında değil !";
                }
            }
            else
            {
                return "Dosya Seçili Değil !";
            }
        }
    }
}