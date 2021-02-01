namespace WebStore.MVC.Helpers
{
    using Microsoft.AspNetCore.Http;
    using SixLabors.ImageSharp;
    using SixLabors.ImageSharp.Processing;
    using System;
    using System.Drawing;
    using System.IO;

    public static class ImageHelper
    {
        public static byte[] FileToArray(IFormFile file)
        {
            var resized = ReduceImage(file, 8);
                  
            var imageArray = new byte[] { };
            using (var ms = new MemoryStream())
            {
                resized.SaveAsJpeg(ms);
                imageArray = ms.ToArray();
            }

            return imageArray;
        }

        public static Image ReduceImage(IFormFile file, int n)
        {
            var width = 0;
            var height = 0;
            using (var image = Image.Load(file.OpenReadStream()))
            {
                width = image.Width;
                height = image.Height;
            }
            var resized = Image.Load(file.OpenReadStream());
            if (width > 300 || height > 300)
            {
                resized.Mutate(x => x.Resize(width / n, height / n));
            }

            return resized;
        }
    }
}
