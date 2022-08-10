using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace OnlineBookStore.Helpers
{
    public class ImagesUploaderHelper
    {

        public async Task<string> UploadImage(IFormFile file, string path) {


            if (file.Length > 0 || file != null)
            {
                string ImageName = Guid.NewGuid().ToString() + ".jpg";
                var filepath = Path.Combine(Directory.GetCurrentDirectory(), path, ImageName);

                using (var stream = System.IO.File.Create(filepath))
                {
                    await file.CopyToAsync(stream);
                }

                return ImageName;
            }
            else
                return "";
            }

        public void DeleteImage(string path, string fileName)
        {
            File.Delete(Path.Combine(path, fileName));

        }


    }
}
