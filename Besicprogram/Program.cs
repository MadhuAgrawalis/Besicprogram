using System;
namespace Besicprogram

{
    class Program

    {
        static bool isPowerOfTwo(int n)
        {
            if (n == 0)
                return false;

            while (n != 1)
            {
                if (n % 2 != 0)
                    return false;

                n = n / 2;
            }
            return true;
        }

        
        public static void Main()
        {
            Console.WriteLine(isPowerOfTwo(64) ? "Yes" : "No");
            Console.WriteLine(isPowerOfTwo(37) ? "Yes" : "No");

        }
    }
}






