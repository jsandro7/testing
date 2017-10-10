using System;
using System.Threading;

namespace test2
{
    class Program2
    {        
            
        static void Main()
        {
            ThreadPool.QueueUserWorkItem((s) =>
            {
               Console.WriteLine("Working on a thread from threadpool");
            });
        }
    }
}
