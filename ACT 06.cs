using System;

class Program
{
    static void Main()
    {
        // The program will read city names from the user, store them in a list.
        List<string> cities = new List<string>();
        string city;

        Console.WriteLine("Enter city names (type 'exit' to finish):");
        while (true)
        {
            city = Console.ReadLine();
            if (city.ToLower() == "exit") break;
            cities.Add(city);
        }

        var uniqueCities = cities.Distinct().ToList();
        uniqueCities.Sort();

        Console.WriteLine("\nCities in alphabetical order:");
        foreach (string c in uniqueCities) Console.WriteLine(c);
    }
}

