using System;
class Program
{
    static void Main()
    {
        // The program collects product names and their stock counts from the user.
        List<string> products = new List<string>();
        List<int> stocks = new List<int>();

        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"\nEnter product #{i}: ");
            products.Add(Console.ReadLine());

            Console.Write("Enter stock count: ");
            int stock = int.Parse(Console.ReadLine());

            if (stock < 10)
            {
                stock += 20;
                Console.WriteLine("Restocked by 20!");
            }

            stocks.Add(stock);
        }

        Console.WriteLine("\nFinal Stock Levels:");
        for (int i = 0; i < 10; i++)
            Console.WriteLine($"{products[i]} - {stocks[i]}");
    }
}

