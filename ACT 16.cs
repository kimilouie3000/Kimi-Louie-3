
using System;
class Program
{
    static void Main()
    {
        // This program simulates a simple shopping cart system
        List<string> cart = new List<string>();
        int choice;

        do
        {
            Console.WriteLine("\n1.Add  2.Remove  3.View  4.Clear  5.Exit");
            Console.Write("Choose: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter product to add: ");
                    cart.Add(Console.ReadLine());
                    break;
                case 2:
                    Console.Write("Enter product to remove: ");
                    cart.Remove(Console.ReadLine());
                    break;
                case 3:
                    Console.WriteLine("Cart: " + (cart.Count > 0 ? string.Join(", ", cart) : "Empty"));
                    break;
                case 4:
                    cart.Clear();
                    Console.WriteLine("Cart cleared!");
                    break;
            }
        } while (choice != 5);
    }
}
