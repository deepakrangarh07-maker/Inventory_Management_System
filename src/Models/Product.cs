class Program
{
    static void Main(string[] args)
    {
      Console.WriteLine("Enter Product ID : ");
      int productId = Convert.ToInt16(Console.ReadLine());
        try
        {
            FindProduct(productId);
        }
        catch(ProductNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }

    }

    static void FindProduct(int productId)
    {
        if (productId == 1)
        {
            Console.WriteLine("Product found: Keyboard");
        }
        else if (productId == 2)
        {
            Console.WriteLine("Product found: Mouse");
        }
        else if (productId == 3)
        {
            Console.WriteLine("Product found: Monitor");
        }
        else
        {
            throw new ProductNotFoundException("Product not found.");
        }
    }
}