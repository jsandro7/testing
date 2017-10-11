using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Http;

namespace test2
{
    // public static class Program
    // {       
    //     public static void Main()
    //     {
    //         SleepAsyncA(1000);
    //         SleepAsyncB(1000);
    //     }

    //    public static Task SleepAsyncA(int millisecondsTimeout)
    //     {
    //         return Task.Run(() => Thread.Sleep(millisecondsTimeout));
    //     }
    //     public static Task SleepAsyncB(int millisecondsTimeout)
    //     {
    //         TaskCompletionSource<bool> tcs = null;
    //         var t = new Timer(delegate { tcs.TrySetResult(true); }, null, -1, -1);
    //         tcs = new TaskCompletionSource<bool>(t);
    //         t.Change(millisecondsTimeout, -1);
    //         return tcs.Task;
    //     }
        
    // }
}
