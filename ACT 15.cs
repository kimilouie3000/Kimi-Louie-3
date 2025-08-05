using System;
class Program
{
    static void Main()
    {
        // This program registers 6 courses with unque 5-character codes.
        List<string> courses = new List<string>();

        for (int i = 1; i <= 6; i++)
        {
            Console.Write($"Enter course code #{i}: ");
            string code = Console.ReadLine().ToUpper();

            if (code.Length != 5)
                Console.WriteLine("Error: Code must be 5 characters.\n");
            else if (courses.Contains(code))
                Console.WriteLine("Error: Duplicate code.\n");
            else
            {
                courses.Add(code);
                Console.WriteLine("Course registered.\n");
            }
        }

        Console.WriteLine("\nRegistered Courses:");
        foreach (string c in courses) Console.WriteLine(c);
    }
}
