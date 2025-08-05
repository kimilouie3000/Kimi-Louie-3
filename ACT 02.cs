using System;
class Program
{
    static void Main()
    {
        // The program collects item prices from the user.
        List<decimal> prices = new List<decimal>();
        decimal price;

        Console.WriteLine("Enter item prices (-1 to stop):");
        while (true)
        {
            price = decimal.Parse(Console.ReadLine());
            if (price == -1) break;
            if (price >= 0) prices.Add(price);
        }

        Console.WriteLine($"\nTotal Items: {prices.Count}");
        Console.WriteLine($"Average Price: {prices.Average():F2}");
        Console.WriteLine($"Highest Price: {prices.Max():F2}");
        Console.WriteLine($"Lowest Price: {prices.Min():F2}");
    }
}

