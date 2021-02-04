namespace WebStore.MVC.Helpers
{
    using Microsoft.AspNetCore.Http;
    using SixLabors.ImageSharp;
    using SixLabors.ImageSharp.Processing;
    using System;
    using System.IO;

    public static class ImageHelper
    {
        public static byte[] FileToArray(IFormFile file)
        {
            var resized = ReduceImage(file, 400, 300);
                  
            var imageArray = new byte[] { };
            using (var ms = new MemoryStream())
            {
                resized.SaveAsJpeg(ms);
                imageArray = ms.ToArray();
            }

            return imageArray;
        }

        public static byte[] FileThumbnailToArray(IFormFile file)
        {
            var resized = ReduceImage(file, 200, 200);

            var imageArray = new byte[] { };
            using (var ms = new MemoryStream())
            {
                resized.SaveAsJpeg(ms);
                imageArray = ms.ToArray();
            }

            return imageArray;
        }

        public static Image ReduceImage(IFormFile file, int width, int height)
        {
            
            var resized = Image.Load(file.OpenReadStream());

                resized.Mutate(x => x.Resize(width, height));

            return resized;
        }

       
    }
}
