using DI_Example.Models;

namespace DI_Example.Interfaces

{
    /*---
    First, we create an interface that defines what a product service 
    should be able to do, without specifying how.
     ---*/
    public interface IProductService
    {
        /*---
        In C#, members of an interface are implicitly public by definition. 
        You're not allowed to add an access modifier like 
        public because it's redundant
        ---*/
        List<Product> GetProducts();  
    }
}
