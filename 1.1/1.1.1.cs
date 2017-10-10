using System;
using System.Threading;

namespace test2
{
    class Program1
    {

        public static void ThreadMethod()
        {
            for(int i = 0; i < 10; i++){
                Console.WriteLine("threadProc: {0}", i);
                Thread.Sleep(0);
            }
        }

        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(ThreadMethod));
            t.Start();

            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine("Main thread: Do some work.");
                Thread.Sleep(0);

            }

            t.Join();

        }
    }
}
