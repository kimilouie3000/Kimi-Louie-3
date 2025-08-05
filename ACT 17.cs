using System;
class Program
{
    static void Main()
    {
        // This program collects sentences drom the user.
        List<string> words = new List<string>();

        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Enter sentence #{i}: ");
            string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            foreach (string w in parts)
            {
                string word = w.ToLower();
                if (!words.Contains(word)) words.Add(word);
            }
        }

        words.Sort();
        Console.WriteLine($"\nTotal unique words: {words.Count}");
        Console.WriteLine("Words: " + string.Join(", ", words));
    }
}

