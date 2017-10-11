using System;
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

    //             token.ThrowIfCancellationRequested();

    //         }, token).ContinueWith((t) => {
    //             t.Exception.Handle((e) => true);
    //             Console.WriteLine("You have canceled the task");
    //         }, TaskContinuationOptions.OnlyOnCanceled);
    //     }
    // }
}