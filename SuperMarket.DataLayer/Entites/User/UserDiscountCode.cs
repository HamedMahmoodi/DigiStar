using SuperMarket.DataLayer.Entites.Order;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SuperMarket.DataLayer.Entites.User
{
   public class UserDiscountCode
    {
        [Key]
        public int UD_Id { get; set; }
        public int UserId { get; set; }
        public int DiscountId { get; set; }


        #region Relation

        public User User { get; set; }
        public Discount Type { get; set; }

        #endregion
    }
}
