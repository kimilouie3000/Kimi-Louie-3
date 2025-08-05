using System;

class Program
{
    static void Main()
    {
        // The program prompts the user to enter 10 numbers
        List<int> numbers = new List<int>();
        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"Enter number #{i}: ");
            numbers.Add(int.Parse(Console.ReadLine()));
        }

        List<int> filtered = numbers.Where(n => n > 50).ToList();

        Console.WriteLine($"\nOriginal count: {numbers.Count}");
        Console.WriteLine($"Filtered (>50) count: {filtered.Count}");
    }
}

