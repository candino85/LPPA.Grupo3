using System.Collections.Generic;

namespace Marketplace.Entities.Models
{
    public class Category : IdentityBase
    {
        public string Name { get; set; }
        public virtual ICollection<Product> Products{ get; set; }
    }
}