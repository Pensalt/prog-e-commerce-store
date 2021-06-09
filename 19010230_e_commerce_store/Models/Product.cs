using System;
using System.Collections.Generic;

#nullable disable

namespace _19010230_e_commerce_store.Models
{
    public partial class Product
    {
        public Product()
        {
            OrderInfos = new HashSet<OrderInfo>();
        }

        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductImage { get; set; }

        public virtual ProductCategory Category { get; set; }
        public virtual ICollection<OrderInfo> OrderInfos { get; set; }
    }
}
