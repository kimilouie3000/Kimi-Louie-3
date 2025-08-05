using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // The program collects grades from the user.
        List<int> grades = new List<int>();
        int[] counts = new int[5]; // A,B,C,D,F

        for (int i = 1; i <= 7; i++)
        {
            Console.Write($"Enter grade #{i} (0-100): ");
            if (int.TryParse(Console.ReadLine(), out int g) && g >= 0 && g <= 100)
            {
                grades.Add(g);
                switch (g / 10)
                {
                    case 10:
                    case 9: counts[0]++; break; // A
                    case 8: counts[1]++; break; // B
                    case 7: counts[2]++; break; // C
                    case 6: counts[3]++; break; // D
                    default: counts[4]++; break; // F
                }
            }
            else { Console.WriteLine("Invalid! Try again."); i--; }
        }

        Console.WriteLine($"\nA:{counts[0]}  B:{counts[1]}  C:{counts[2]}  D:{counts[3]}  F:{counts[4]}");
    }
}
