using SuperMarket.DataLayer.Entites.Order;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SuperMarket.DataLayer.Entites.Product
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        public int GroupId { get; set; }

        public int? SubGroup { get; set; }

        [Required]
        public int StatusId { get; set; }

        [Display(Name = "عنوان محصول")]
        [Required(ErrorMessage = "لطفا {0}  را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد.")]
        public string ProductTitle { get; set; }

        [Display(Name = "توضیحات محصول")]
        public string ProductDescription { get; set; }

        [Display(Name = "قیمت محصول")]
        [Required(ErrorMessage = "لطفا {0}  را وارد کنید")]
        public int ProductPrice { get; set; }

        [MaxLength(50)]
        public string ProductImageName { get; set; }

        public DateTime CreateDate { get; set; }

        public bool IsDelete { get; set; }



        #region Relations

        [ForeignKey("GroupId")]
        public ProductGroup ProductGroup { get; set; }

        [ForeignKey("SubGroup")]
        public ProductGroup Group { get; set; }

        [ForeignKey("StatusId")]
        public ProductStatus ProductStatus { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        public List<UserProduct> UserProducts { get; set; }
        public List<ProductComment> ProductComments { get; set; }

        #endregion
    }
}
