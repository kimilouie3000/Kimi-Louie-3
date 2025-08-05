using System;
class Program
{
    static void Main()
    {
        // The program propmts the user to enter 12 numbers
        List<int> numbers = new List<int>(), evenList = new List<int>(), oddList = new List<int>();

        for (int i = 1; i <= 12; i++)
        {
            Console.Write($"Enter number #{i}: ");
            int num = int.Parse(Console.ReadLine());
            numbers.Add(num);
            if (num % 2 == 0) evenList.Add(num); else oddList.Add(num);
        }

        Console.WriteLine("\nEven numbers: " + string.Join(", ", evenList));
        Console.WriteLine("Odd numbers: " + string.Join(", ", oddList));
    }
}
