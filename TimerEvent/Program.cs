using System;
using System.Timers;

namespace TimerEvent
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Timer mytimer = new Timer(2000);

            mytimer.Elapsed += MyTimer_Elapsed;
            mytimer.Elapsed += MyTimer_Elapsed2;

            mytimer.Start();

            Console.WriteLine("Press enteder to stop the red event!");
            Console.ReadLine();

            mytimer.Elapsed -= MyTimer_Elapsed2;

            Console.ReadLine();
        }

        private static void MyTimer_Elapsed(object sender, ElapsedEventArgs e){
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Elapsed: {0:hh:mm:ss:fff}", e.SignalTime);
        }

        private static void MyTimer_Elapsed2(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Elapsed: {0:hh:mm:ss:fff}", e.SignalTime);
        }
    }
}
