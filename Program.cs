using System.ComponentModel.Design;
using LabInventorySystem.Models;
using LabInventorySystem.Services;

ProductService service = new ProductService();

Product product = new Product
{
    Id = 1,
    Name = "CBC Reagent",
    Stock = 20
};

service.AddProduct(product);

List<Product> products = service.GetAllProduct();

foreach (Product productItem in products)
{
    Console.WriteLine(productItem.Name);
    Console.WriteLine(productItem.Stock);
}

Console.WriteLine("Product added successfully");