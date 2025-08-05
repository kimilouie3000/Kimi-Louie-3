using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> countries = new List<string> { "Philippines", "Japan","Cambodia"};
        List<string> capitals  = new List<string> { "Manila", "Tokyo", "Phnom Phen" };

        Console.Write("Enter a country: ");
        string input = Console.ReadLine().ToLower();
        bool found = false;

        for (int i = 0; i < countries.Count; i++)
        {
            if (countries[i].ToLower() == input)
            {
                Console.WriteLine($"Capital: {capitals[i]}");
                found = true;
                break;
            }
        }

        if (!found) Console.WriteLine("Country not found.");
    }
}

