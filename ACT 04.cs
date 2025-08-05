using System;

class Program
{
    static void Main()
    {
        // The program collects birth year from the user.
        int currentYear = DateTime.Now.Year;
        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Enter birth year #{i}: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int year))
            {
                int age = currentYear - year;
                string status = age < 18 ? "Minor" : age < 60 ? "Adult" : "Senior";
                Console.WriteLine($"Age: {age} - {status}\n");
            }
            else Console.WriteLine("Invalid input! Numbers only.\n");
        }
    }
}
