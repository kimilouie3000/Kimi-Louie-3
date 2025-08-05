using System;

class Program
{
    static void Main()
    {
        // The program searches for specific characters in usernames.
        List<string> users = new List<string> { "Kimi", "Kath", "Martin", "Edrei", "Eugene" };

        Console.Write("Enter a character to search: ");
        char ch = char.ToLower(Console.ReadKey().KeyChar);
        Console.WriteLine("\n\nUsernames containing that character:");

        foreach (string u in users)
            if (u.ToLower().Contains(ch)) Console.WriteLine(u);
    }
}

