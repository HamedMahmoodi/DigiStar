using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SuperMarket.DataLayer.Entites.Product
{
   public class UserProduct
    {
        [Key]
        public int UP_Id { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }


        #region Relation

        public Product Product { get; set; }
        public User.User User { get; set; }

        #endregion
    }
}
