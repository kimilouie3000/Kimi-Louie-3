using System;
class Program
{
    static void Main()
    {
        // Prompt user for 10 Student names and quiz scores
        List<string> names = new List<string>();
        List<int> scores = new List<int>();

        for (int i = 1; i <= 10; i++)
        {
            Console.Write("\nEnter student name: ");
            names.Add(Console.ReadLine());

            Console.Write("Enter quiz score: ");
            scores.Add(int.Parse(Console.ReadLine()));
        }

        // Create combined list of name-score pairs
        List<(string Name, int Score)> students = new List<(string, int)>();
        for (int i = 0; i < 10; i++) students.Add((names[i], scores[i]));

        // Sort by score descending
        students.Sort((a, b) => b.Score.CompareTo(a.Score));

        Console.WriteLine("\nTop 3 Performers:");
        for (int i = 0; i < 3; i++)
            Console.WriteLine($"{students[i].Name} - {students[i].Score}");
    }
}

