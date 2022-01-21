using SuperMarket.DataLayer.Entites.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMarket.Core.DTO
{
   public class ProductForAdminViewModel
    {
        public List<Product> Products { get; set; }
        public int CurrentPage { get; set; }
        public int PageCount { get; set; }
    }

    public class InformationProductViewModel
    {
        public string ProductImageName { get; set; }
        public string ProductTitle { get; set; }
        public int ProductPrice { get; set; }
        public DateTime CreateDate { get; set; }
    }

    public class InformationProductGroupViewModel
    {
        public string GroupTitle { get; set; }
    }
}
