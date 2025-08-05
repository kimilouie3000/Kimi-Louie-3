using System;

class Program
{
    static void Main()
    {
        // The program prompts the user to enter 10 grades.
        List<int> grades = new List<int>();
        int a=0,b=0,c=0,d=0,f=0;

        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"Enter grade #{i}: ");
            int g = int.Parse(Console.ReadLine());
            grades.Add(g);

            switch (g / 10)
            {
                case 10:
                case 9: a++; break;
                case 8: b++; break;
                case 7: c++; break;
                case 6: d++; break;
                default: f++; break;
            }
        }

        Console.WriteLine($"\nA:{a}  B:{b}  C:{c}  D:{d}  F:{f}");
    }
}

