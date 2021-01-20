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
            var width = 0;
            var height = 0;
            using (var image = Image.Load(file.OpenReadStream()))
            {
                width = image.Width;
                height = image.Height;
            }
            var resized = Image.Load(file.OpenReadStream());
            resized.Mutate(x => x.Resize(width / 4, height / 4));         

            var imageArray = new byte[] { };
            using (var ms = new MemoryStream())
            {
                resized.SaveAsJpeg(ms);
                imageArray = ms.ToArray();
            }

            return imageArray;
        }

        public static IFormFile ArrayToFormFile(byte[] arr, string name)
        {
            using (var ms = new MemoryStream(arr))
            {
                System.Net.Mime.ContentDisposition cd = new System.Net.Mime.ContentDisposition
                {
                    FileName = name
                    
                };
                IFormFile formFile = new FormFile(ms, 0, ms.Length, name, name);
                formFile.Headers.Add("Content-Disposition", cd.ToString());
                formFile.Headers.Add("Content-Type", "image/jpeg");
                return formFile;
            }
        }
    }
}
