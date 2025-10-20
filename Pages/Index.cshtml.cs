using DI_Example.Interfaces;
using DI_Example.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DI_Example.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        //create a private field of type IProductService 
        //this holds the injected service <-----------------
        private readonly IProductService _productService;
        
        public List<Product> Products { get; set; } = new List<Product>();
        public IndexModel(ILogger<IndexModel> logger, IProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }
        
        public void OnGet()
        {
            Products = _productService.GetProducts();

        }
    }
}
