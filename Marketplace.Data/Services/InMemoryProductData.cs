using System;
using System.Collections.Generic;
using System.Linq;
using Marketplace.Data.Models;

namespace Marketplace.Data.Services
{
    public class InMemoryProductData : IProductData
    {
        readonly List<Product> _products;

        public InMemoryProductData()
        {
            _products = new List<Product>()
            {
                new Product {Id = 1,Name = "Pan", Description = "Panificado", LastUpdted = DateTime.Now, Category = CategoryType.Panadería},
                new Product {Id = 2,Name = "Leche", Description = "Lácteo", LastUpdted = DateTime.Now, Category = CategoryType.Lácteos},
                new Product {Id = 3,Name = "Yogurth", Description = "Lácteo", LastUpdted = DateTime.Now, Category = CategoryType.Lácteos},
            };

        }

        public IEnumerable<Product> GetAll()
        {
            return _products.OrderBy(p => p.Name);
        }
    }
}

