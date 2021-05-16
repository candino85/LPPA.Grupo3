using System;
using System.Collections.Generic;

namespace Marketplace.Entities.Models
{
    public class Product : IdentityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public DateTime LastUpdated { get; set; }
        public int CategoryId  { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<OrderedProduct> OrderedProducts { get; set; }

    }
}