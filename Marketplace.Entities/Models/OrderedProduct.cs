using System.ComponentModel.DataAnnotations;

namespace Marketplace.Entities.Models
{
    public class OrderedProduct : IdentityBase
    {
        public int Quantity { get; set; }
        
        [Required]        
        public virtual Product Product { get; set; }

        [Required]
        public virtual CustomerOrder CustomerOrder { get; set; }
    }
}