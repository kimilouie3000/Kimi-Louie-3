using System;
class Program
{
    static void Main()
    {
        // The program prompts the user to enter 8 product names.
        List<string> products = new List<string>();
        for (int i = 1; i <= 8; i++)
        {
            Console.Write($"Enter product #{i}: ");
            products.Add(Console.ReadLine());
        }

        Console.Write("\nEnter search keyword: ");
        string keyword = Console.ReadLine().ToLower();
        List<string> results = new List<string>();

        foreach (string p in products)
            if (p.ToLower().Contains(keyword)) results.Add(p);

        if (results.Count > 0)
        {
            Console.WriteLine("\nMatching products:");
            foreach (string r in results) Console.WriteLine(r);
        }
        else Console.WriteLine("\nNo products found.");
    }
}

