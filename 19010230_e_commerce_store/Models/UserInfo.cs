using System;
using System.Collections.Generic;

#nullable disable

namespace _19010230_e_commerce_store.Models
{
    public partial class UserInfo
    {
        public UserInfo()
        {
            OrderInfos = new HashSet<OrderInfo>();
        }

        public int UserId { get; set; }
        public int UserType { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }

        public virtual ICollection<OrderInfo> OrderInfos { get; set; }
    }
}
