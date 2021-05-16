using System;

namespace Marketplace.Entities.Models
{
    public class Cart : IdentityBase
    {
        public string CardId { get; set; }
        public int ProductId { get; set; }
        public int Count { get; set; }
        public DateTime DateCreated { get; set; }
        public virtual Product Product { get; set; }
    }
}