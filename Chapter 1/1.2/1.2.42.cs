﻿using System;
using System.Threading;
using System.Threading.Tasks;


namespace test2
{
    // public static class Program
    // {    
    //     static int value = 1;

    //     public static void Main()
    //     {
    //         CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
    //         CancellationToken token = cancellationTokenSource.Token;

    //         Task task = Task.Run(() =>
    //         {
    //             while(!token.IsCancellationRequested)
    //             {
    //                 Console.Write("*");
    //                 Thread.Sleep(1000);
    //             }
    //         }, token);

    //         Console.WriteLine("Press enter to stop the task");
    //         Console.ReadLine();
    //         cancellationTokenSource.Cancel();
    //         Console.WriteLine("Press enter to end the application");
    //         Console.ReadLine();

    //     }
    // }
}