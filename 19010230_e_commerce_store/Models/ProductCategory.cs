using System;
using System.Collections.Generic;

#nullable disable

namespace _19010230_e_commerce_store.Models
{
    public partial class ProductCategory
    {
        public ProductCategory()
        {
            Products = new HashSet<Product>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int TotalOrders { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
