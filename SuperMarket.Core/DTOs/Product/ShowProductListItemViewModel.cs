using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMarket.Core.DTOs.Product
{
    public class ShowProductListItemViewModel
    {
        public int ProductId { get; set; }
        public int StatusId { get; set; }
        public string Title { get; set; }
        public string ImageName { get; set; }
        public int Price { get; set; }

    }
}
