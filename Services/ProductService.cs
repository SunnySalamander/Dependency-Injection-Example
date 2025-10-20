using DI_Example.Interfaces;
using DI_Example.Models;

namespace DI_Example.Services
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product { Name = "Snakes", ImageUrl = "https://placehold.co/100x100/green/white?text=Snake" },
                new Product { Name = "Beetles", ImageUrl = "https://placehold.co/100x100/purple/white?text=Beetle" },
                new Product { Name = "Lizards", ImageUrl = "https://placehold.co/100x100/orange/white?text=Lizard" }
            };
        }
    }
}
