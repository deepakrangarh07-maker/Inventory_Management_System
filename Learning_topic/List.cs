using System;
using System.Collections.Generic;

class ListPractice
{
    public void Test()
    {
        List<string> products = new List<string>();

        products.Add("CBC");
        products.Add("EDTA Tube");
        products.Add("EDTA");

        foreach (string product in products)
        {
            Console.WriteLine(product);
        }
    }
}