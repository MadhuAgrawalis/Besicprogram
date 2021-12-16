using System;
namespace FactorialExample
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the number: ");
            int a = int.Parse(Console.ReadLine());
            int fact = 1;
            for (int x = 1; x <= a; x++)
            {
                fact *= x;
            }
            Console.WriteLine(fact);
            Console.ReadLine();
        }
    }
}







