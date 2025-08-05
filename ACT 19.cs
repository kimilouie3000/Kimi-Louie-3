using System;

class Program
{
    static void Main()
    {
        // The program collects student names and ensures no duplicates.
        List<string> attendees = new List<string>();
        string name;

        Console.WriteLine("Enter student names (type 'end' to finish):");
        while (true)
        {
            name = Console.ReadLine();
            if (name.ToLower() == "end") break;

            if (!attendees.Contains(name))
                attendees.Add(name);
        }

        attendees.Sort();
        Console.WriteLine($"\nTotal unique attendees: {attendees.Count}");
        Console.WriteLine("Attendees:");
        foreach (string n in attendees) Console.WriteLine(n);
    }
}
