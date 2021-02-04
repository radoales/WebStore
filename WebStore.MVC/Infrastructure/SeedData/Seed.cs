//namespace WebStore.MVC.Infrastructure.SeedData
//{
//    using System.Collections.Generic;
//    using System.IO;
//    using System.Text.Json;
//    using WebStore.MVC.Data.Models;

//    public static class Seed
//    {
//        public static void Products()
//        {
//            var employeesList = new List<Product>();

//            using (StreamReader file = File.OpenText(@"Infrastructre\Data\employees.json"))
//            {
//                JsonSerializer serializer = new JsonSerializer();
//                employeesList = (List<Product>)serializer.Deserialize(file, typeof(List<Product>));
//            }


//        }
//    }
//}
