# Dependency Injection in ASP.NET

This project is for understanding dependency injection in ASP.NET specifically, but also explains dependency injection as a fundamental programming concept.

Dependency injection allows for inversion of control which is a fancy term for 'your classes do not create their own dependencies', they simply request them instead.

Why is it better that they request and depend on the asp.net dependency injection container to pass them what they need? 

It's better because this allows you to decouple your code, meaning the class that needs a service (IndexModel) only depends on the abstract interface (IProductService), 

not on the concrete class (NewCoolerProductService) that does the work (is the implementation).

