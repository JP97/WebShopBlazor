using System;
using System.Linq;
using System.Threading.Tasks;

namespace WebShopBlazor.Data
{
    public class ProductService
    {
        private static readonly string[] Categories = new[]
        {
            "Dress", "T-Shirt", "Jeans", "Sweater", "Sweatpants"
        };


        public Task<Product[]> GetProductAsync()
        {
            var rng = new Random();
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new Product
            {
                Price = rng.Next(10, 99),
                Category = Categories[rng.Next(Categories.Length)],
                Name = "name"
            }).ToArray());
        }
    }
}
