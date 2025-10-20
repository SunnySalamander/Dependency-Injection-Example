using DI_Example.Interfaces;
using DI_Example.Models;

namespace DI_Example.Services
{
    public class NewCoolerProductService : IProductService
    {
        public List<Product> GetProducts() //<--- completes the contract for you
        {
            //Write your own implementation :)
            return new List<Product>
            {
                new Product { Name = "Plushies", ImageUrl = "https://i.pinimg.com/736x/8d/4f/43/8d4f4305da0063e7fa59355036168f2c.jpg" },
                new Product { Name = "Video Games", ImageUrl = "https://play-lh.googleusercontent.com/iP2i_f23Z6I-5hoL2okPS4SxOGhj0q61Iyb0Y1m4xdTsbnaCmrjs7xKRnL6o5R4h-Yg=w240-h480" },
                new Product { Name = "Animes", ImageUrl = "https://www.pngkit.com/png/full/832-8323973_view-suzumiya-haruhi-no-yuuutsu-the-melancholy-of.png" }
            };
        }
    }
}
