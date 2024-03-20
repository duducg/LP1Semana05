using System;
using System.Diagnostics;
using System.Threading;

namespace Chronos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare 2 instances of class Stopwatch
            Stopwatch crono1 = new Stopwatch();
            Stopwatch crono2 = new Stopwatch();

            //start timer on "crono1"
            crono1.Start();

            //pause system thread for 0.6s (600 ms)
            Thread.Sleep(600);

            //start timer on "crono2"
            crono2.Start();

            //pause system thread for 0.2s (200 ms)
            Thread.Sleep(200);

            //stop both timers
            crono1.Stop();
            crono2.Stop();

            //Get milliseconds
            long elapsed_mil_cron1 = crono1.ElapsedMilliseconds;
            long elapsed_mil_cron2 = crono2.ElapsedMilliseconds;
            
            //Convert to float
            float cron1_secf = Convert.ToSingle(elapsed_mil_cron1) ;
            float cron2_secf = Convert.ToSingle(elapsed_mil_cron2) ;

            //divide by 1000;
            float cron1_sec = cron1_secf / 1000f; 
            float cron2_sec = cron2_secf / 1000f;             

            //Print seconds in 3 decimal format            
            Console.WriteLine($"{cron1_sec:f3}");
            Console.WriteLine($"{cron2_sec:f3}");
            
            





        }
    }
}
