class ListExample
{
    static void Main()
    {
        List<string> products = new List<string>();

        products.Add("CBC");
        products.Add("EDTA");
        products.Add("Gloves");
        products.Insert(3, "Needle");

        bool check = products.Contains("Gloves");
        products.Remove("CBC");


    // Find All Sentex
        List<string> result = products.FindAll(static product => product.StartsWith("S"));

        Console.WriteLine(result);
        Console.WriteLine(check);

        foreach (string product in products)
        {
            Console.WriteLine(product);
        }
        Console.WriteLine("KK");
    }
}
