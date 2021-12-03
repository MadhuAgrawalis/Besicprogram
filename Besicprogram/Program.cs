using System;
namespace Besicprogram

{
    class Program

    {
         static void Main(string[] args)

         {
            Console.WriteLine("Let's flip a coin 10000 times");

            Coinflip();

         }
          public static int Coinflip()

         {
            Random Rand = new Random();

            int heads = 0;

            int tails = 0;

            int result = 0;

            for (int i = 0; i< 10000; i++)

            {

                result = Rand.Next(0, 2);
            if (result == 1)

                {
                    heads++;
                    }
                else
                    
                {
                   tails++;
                    
                }
            }
            Console.WriteLine("heads was flipped {0} times", heads);
            Console.WriteLine("tails was flipped {0} times", tails);
            
            return result;
            
          }

    }

}




