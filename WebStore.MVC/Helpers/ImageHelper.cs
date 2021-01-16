namespace WebStore.MVC.Helpers
{
    using Microsoft.AspNetCore.Http;
    using System;
    using System.Drawing;
    using System.IO;

    public static class ImageHelper
    {
        //public static Image GetReducedImage(int width, int height, Stream resourceImage)
        //{
        //    try
        //    {
        //        Image image = Image.FromStream(resourceImage);
        //        Image thumb = image.GetThumbnailImage(width, height, () => false, IntPtr.Zero);

        //        return thumb;
        //    }
        //    catch (Exception e)
        //    {
        //        return null;
        //    }
        //}

        public static byte[] FileToArray(IFormFile image)
        {
            var imageArray = new byte[] { };
            using (var ms = new MemoryStream())
            {
                image.CopyTo(ms);
                imageArray = ms.ToArray();
                //Image image = GetReducedImage(33, 33, ms);
            }

            return imageArray;
        }

        public static IFormFile ArrayToFormFile(byte[] arr, string name)
        {
            using (var ms = new MemoryStream(arr))
            {
                IFormFile formFile = new FormFile(ms, 0, ms.Length, name, name);

                return formFile;
            }
        }
    }
}
