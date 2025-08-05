using System;
class Program
{
    static void Main()
    {
        // The program reads the number of employees adn their names and salaries.
        List<string> names = new List<string>();
        List<float> salaries = new List<float>();

        Console.Write("How many employees? ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"\nEnter name #{i}: ");
            names.Add(Console.ReadLine());

            Console.Write("Enter salary: ");
            float sal = float.Parse(Console.ReadLine());

            if (sal < 15000) sal *= 1.05f;
            else if (sal <= 30000) sal *= 1.03f;

            salaries.Add(sal);
        }

        Console.WriteLine("\nEmployees earning above 25,000 after adjustment:");
        for (int i = 0; i < n; i++)
            if (salaries[i] > 25000)
                Console.WriteLine($"{names[i]} - {salaries[i]:F2}");
    }
}
