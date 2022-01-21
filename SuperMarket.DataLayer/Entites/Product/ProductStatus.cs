using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SuperMarket.DataLayer.Entites.Product
{
    public class ProductStatus
    {
        [Key]
        public int StatusId { get; set; }

        [Required]
        [MaxLength(150)]
        public string StatusTitle { get; set; }


        #region Relations

        public List<Product> Products { get; set; }

        #endregion

    }
}
