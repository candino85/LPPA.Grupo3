using System.Collections.Generic;
using Marketplace.Data.Models;

namespace Marketplace.Data.Services
{
    public interface IProductData
    {
        IEnumerable<Product> GetAll();
    }
}

