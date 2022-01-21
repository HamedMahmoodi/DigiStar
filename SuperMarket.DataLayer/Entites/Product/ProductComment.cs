using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket.DataLayer.Entites.Product
{
    public class ProductComment
    {
        [Key]
        public int CommentId { get; set; }

        [Required]
        public int ProductId { get; set; }

        [Required]
        public int UserId { get; set; }

        [Display(Name = "متن نظر")]
        [Required(ErrorMessage = "لطفا {0}  را وارد کنید")]
        [MaxLength(700, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد.")]
        public string Comment { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsDelete { get; set; }
        public bool IsAdminRead { get; set; }


        #region Relations

        public Product Product { get; set; }
        public User.User User { get; set; }

        #endregion
    }
}
