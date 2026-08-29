using System.Collections.Generic;

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
        Console.WriteLine(check);
        foreach (string product in products)
        {
            Console.WriteLine(product);
        }
    }

}