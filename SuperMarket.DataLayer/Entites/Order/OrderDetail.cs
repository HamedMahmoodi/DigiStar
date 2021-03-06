using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SuperMarket.DataLayer.Entites.Order
{
    public class OrderDetail
    {
        [Key]
        public int DetailId { get; set; }

        [Required]
        public int OrderId { get; set; }

        [Required]
        public int ProductId { get; set; }

        [Required]
        public int Count { get; set; }

        [Required]
        public int Price { get; set; }


        #region Relation

        public virtual Order Order { get; set; }
        public virtual Product.Product Product { get; set; }

        #endregion
    }
}
