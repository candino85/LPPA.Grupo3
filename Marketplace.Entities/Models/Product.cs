using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Marketplace.Entities.Models
{
    public class Product : IdentityBase
    {
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string Description { get; set; }
        public double Price { get; set; }
        public DateTime LastUpdated { get; set; }
        public int CategoryId  { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<OrderedProduct> OrderedProducts { get; set; }

    }
}