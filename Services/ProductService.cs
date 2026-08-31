using System.Globalization;
using LabInventorySystem.Models;

namespace LabInventorySystem.Services;

public class ProductService
{
    private List<Product> products = new List<Product>();

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public Product ProductRemove (int Id)
    {
       Product product = products.Find(p => p.Id == Id);

       if(product != null)
        {
            products.Remove(product);
            return product;
        }
        return null;
    }

    public Product updateProduct(int Id, string name, int stock)
    {
        Product product = products.Find(p => p.Id == Id);

        if(product != null)
        {
            product.Name = name;
            product.Stock = stock;
            return product;
        }
        return null;
        }
     
    public Product FindProduct(int Id)
    {
        return products.Find(p=>p.Id == Id);
    }

    public List<Product> GetAllProduct()
    {
        return products;
    }

    // internal List<Product> GetAllProducts()
    // {
    //     throw new NotImplementedException();
    // }
}