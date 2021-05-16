using System;
namespace Marketplace.Data.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public DateTime LastUpdted { get; set; }
        public Enum Category { get; set; }

    }
}
