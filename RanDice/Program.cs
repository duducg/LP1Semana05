using System;

namespace RanDice
{
    class Program
    {
        static void Main(string[] args)
        {
            //get user input from console and parse into variables

            //dice number
            int n = int.Parse(args[0]);
            //seed
            int s = int.Parse(args[1]);
            

            //random
            int total = 0;
            Random r1 = new Random(s);
            for(int i = 0; i < n; i++)
            {
                                
                total += r1.Next(1,7); // maxvalue -1
            }

            //print total
            Console.WriteLine(total);
            
            
        }
    }
}
