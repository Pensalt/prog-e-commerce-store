using System;
using System.Collections.Generic;

#nullable disable

namespace _19010230_e_commerce_store.Models
{
    public partial class OrderInfo
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public DateTime OrderDate { get; set; }

        public virtual Product Product { get; set; }
        public virtual UserInfo User { get; set; }
    }
}
