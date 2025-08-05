using System;
class Program
{
    static void Main()
    {
        // The program collects words from the user and replaces vowels with '*'.
        List<string> original = new List<string>(), modified = new List<string>();

        Console.Write("How many words? ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"Enter word #{i}: ");
            string word = Console.ReadLine();
            original.Add(word);

            string newWord = "";
            foreach (char c in word)
                newWord += "aeiouAEIOU".Contains(c) ? '*' : c;

            modified.Add(newWord);
        }

        Console.WriteLine("\nOriginal -> Modified");
        for (int i = 0; i < n; i++)
            Console.WriteLine($"{original[i]} -> {modified[i]}");
    }
}
