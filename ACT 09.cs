using System;

class Program
{
    static void Main()
    {
        // Th program prompts the user to enter full names and formats them
        List<string> formattedNames = new List<string>();

        for (int i = 1; i <= 6; i++)
        {
            Console.Write($"Enter full name #{i}: ");
            string[] parts = Console.ReadLine().Split(' ');
            for (int j = 0; j < parts.Length; j++)
                if (parts[j].Length > 0)
                    parts[j] = parts[j].Substring(0,1).ToUpper() + parts[j].Substring(1).ToLower();

            formattedNames.Add(string.Join(" ", parts));
        }

        Console.WriteLine("\nFormatted Names:");
        foreach (string name in formattedNames) Console.WriteLine(name);
    }
}

