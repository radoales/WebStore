using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.MVC.Helpers;

namespace WebStore.MVC.ViewModels.Products 
{
    public class ProductIndexViewModel
    {
        public PaginatedList<ListProductRequestModel> Products { get; set; }
        public int SortBy { get; set; }

        public int? ProductTypeId { get; set; }
        public SelectList SortList { get; set; }
    }
}
