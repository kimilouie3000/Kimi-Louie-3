using System;

class Program
{
    static void Main()
    {
        // The program will read student names from the console.
        List<string> students = new List<string>();
        string name;

        Console.WriteLine("Enter student names (type 'done' to finish):");
        while (true)
        {
            name = Console.ReadLine();
            if (name.ToLower() == "done") break;
            students.Add(name.ToUpper());
        }

        Console.WriteLine("\nStudents Present:");
        foreach (string s in students) Console.WriteLine(s);

        int countA = 0;
        foreach (string s in students)
            if (s.StartsWith("A")) countA++;

        Console.WriteLine($"\nNames starting with 'A': {countA}");
    }
}

