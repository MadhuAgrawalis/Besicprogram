using System;
class First
{
    static void Main()
    {
        int a = 75, b = 84, t;
        t = a;
        a = b;
        b = t;
        Console.WriteLine("Values after swapping:");
        Console.WriteLine("a is :" + a);
        Console.WriteLine("b is :" + b);
    }
}




