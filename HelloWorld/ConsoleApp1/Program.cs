using System;
using System.Threading;
namespace Helloworld
{
    class Program
    {
       /* public static void Main(string[] args)
            
        {
            Console.WriteLine("Hello World!");
            //Console.Write("Press any key to continue . . . ");
            

            
        }
        System.Threading.Timer timer = new System.Threading.Timer(timerA, null,5000, 5000 );
        private void timerA(object state)
        {
            Environment.Exit(0);
        }*/
        static void Main(string[] args)
        {
            Play();
        }

        static void Play()
        {
            Console.WriteLine("Announce Program");
            Console.WriteLine("Close Program Announcement");
            Thread.Sleep(1000);
            Environment.Exit(2000);
        }
    }
}